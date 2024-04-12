namespace ex11_events
{
    internal class Program
    {
        delegate int Caclulate(int a, int b);

        // 모든 메서드 이름이 존재
        static void DoSomething(int a)
        {
            // ...
        }
        static void Main(string[] args)
        {
            Caclulate calc;
            
            calc = delegate(int a, int b) 
            {  
                return a + b;
            };
            calc(10, 4);
        }
    }
}
