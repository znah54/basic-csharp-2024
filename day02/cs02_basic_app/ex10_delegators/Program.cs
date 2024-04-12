namespace ex10_delegators
{
    delegate int MyDelegate(int a, int b); // 대리자
    delegate int Compare(int a, int b); // 두 값을 비교하는 대리자
    // 어떠한 일이 발생하는지 시스템이 알려주는 것 - 이벤트
    delegate void Notify(string message); // Notify 대리자
    class Notifier
    {
        public Notify Event0ccured; // 이벤트 발생(이벤트 메서드 실행)
    }
    class EventListener // 이벤트가 발생하는 지 듣고있는 객체
    {
        private string name;
        //생성자
        public EventListener(string name) { this.name = name; }
        public void SomethingHappend(string message)
        {
            Console.WriteLine($"{name}.뭔일이 발생했다!!! : {message}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Notifier notifier = new Notifier();
            EventListener listener1 = new EventListener("리스너1");
            EventListener listener2 = new EventListener("리스너2");
            EventListener listener3 = new EventListener("리스너3");
            // 대리자 체인!!! notifier의 Event0ccured라는 대리자에 리스너 3개에 일어날 수 있는 메서드를 연결
            // 일반적인 함수 호출에서 한번에 여러개의 함수 실행이 가능하냐? 불가능!
            notifier.Event0ccured += listener1.SomethingHappend;
            notifier.Event0ccured += listener2.SomethingHappend;
            notifier.Event0ccured += listener3.SomethingHappend;
            notifier.Event0ccured("메일을 받았어요!");
            Console.WriteLine();

            notifier.Event0ccured -= listener2.SomethingHappend; //리스너 2번의 함수는 실행하지마
            notifier.Event0ccured("파일 다운로드 완료!");
            Console.WriteLine();

            notifier.Event0ccured = new Notify(listener2.SomethingHappend) + new Notify(listener3.SomethingHappend);
            notifier.Event0ccured("미사일 발사!");
            Console.WriteLine() ;

        }
    }
}
