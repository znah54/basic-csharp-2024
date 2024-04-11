using System.Numerics;

namespace ex06_properties
{
    class Kiturami
    {
        private int temperature; //온도

        private int Year;  // 제작년도
        public string Name{get; set;} // 자동 프로퍼티

        // Rosalyn VS 개발서포트
       public int Temperature
        {
            get 
            {   // 값을 리턴하니까 특별한 기능이 없음
                return temperature; 
            }
            set
            {   // 잘못된 값이 들어오면 안되기 때문에 여러 제약을 걸어줌
                if (value < 10)
                {
                    temperature = 20; // 10도 이하는 허용안함
                }
                else if (value > 20)
                {
                    temperature = 50; // 70도 초과는 허용안함
                }
                else temperature = value;
            }
        }

        public int Year { get => Year1; set => Year1 = value; }
        public int Year1 { get => Year2; set => Year2 = value; }
        public int Year2 { get => Year3; set => Year3 = value; }
        public int Year3 { get => Year; set => Year = value; }

        //public void SetTemperature(int temp)
        //{
        //    if (temp > 70)
        //    {
        //        Console.WriteLine("온도가 너무 높습니다. 50도로 조정합니다/");
        //        this.Temperature = 50;
        //    }
        //    else if(temp < 10)
        //    {
        //        Console.WriteLine("온도가 너무 낮습니다. 20도로 조정합니다/");
        //        this.Temperature = 20;
        //    }
        //    this.Temperature = temp;
        //}
        //public int GetTemperature()
        //{
        //    return this.Temperature;
        //}
        public void ON()
        {
            Console.WriteLine("보일러 On");
        }
        public void OFF()
        {
            Console.WriteLine("보일러 Off");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("보일러 시작");
            Kiturami boiler = new Kiturami();
            //boiler.temperature = 610; // 막아버림
            //Console.WriteLine($"보일로 온도는 {boiler.temperature}도"); //막아버림
            //boiler.SetTemperature(460);
            //Console.WriteLine($"보일로 온도는{boiler.GetTemperature()}도");
            boiler.Temperature = 400;
            Console.WriteLine($"보일로 온도는{boiler.Temperature()}도");
            boiler.ON();
        }
    }
}
