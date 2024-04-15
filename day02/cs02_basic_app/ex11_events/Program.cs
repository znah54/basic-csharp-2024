namespace ex11_events
{
    delegate int Caclulate(int a, int b);
    delegate void EventHandler(string message); // 이벤트핸들러 대리자
    class CustomNotifier
    {

        public event EventHandler SomethingHappend;

        public void Dosomething(int number)
        {
            int temp = number % 10; //
            if (temp != 0 && temp % 3 == 0)
            {   // 3,6,9 등의 상태가 되면 짝! 하는 이벤트를 발생시키겠다
                SomethingHappend($"{number}:짝!"); // 이벤트핸들러 발생, 자신의 메서드가 아닌 외부에서 만들어진 메서드를 대신 실행시켜주는 일을 함
            }
        }
    } // 우리가 구현하는 게 아니라, 원래부터 만들어져 있는 것
    internal class Program
    {
        public static void MyHandler(string message)
        {
            Console.WriteLine($"[{DateTime.Now.ToShortTimeString()}] : {message}");
        }

        static void Main(string[] args)
        {
            #region "익명 메서드"
            Caclulate calc; // 대리자
            // 매서드 이름이 존재x
            // 익명 메서드, 한번 사용이후 다시 호출할 필요가 없을 때 사용
            calc = delegate (int a, int b)
            {
                return a + b;
            };
            var result = calc(10, 4);
            #endregion  
            CustomNotifier notifier = new CustomNotifier();
            notifier.SomethingHappend += new EventHandler(MyHandler);

            for(int i = 0; i < 30; i++) 
            {
                notifier.Dosomething(i); // 내장된 클래스의 어떠한 메서드 호출 
            }
        }
    }
}
