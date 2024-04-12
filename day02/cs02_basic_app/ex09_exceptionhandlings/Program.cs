using System.Diagnostics;

namespace ex09_exceptionhandlings
{
    internal class Program
    {
        class Sorting { }

        static void Main(string[] args)
        {
            int[] array = { 3, 7, 10, 5, 4, 1, 9 };
            Sorting sorting = new Sorting;

            Console.WriteLine("오름차순 정렬");

            int[] array1 = new int[3] { 1, 2, 3 };
            try
            {
                for (int i = 0; i < 4; i++)
                {
                    Console.WriteLine($"{array[i]}");
                }
            }
            catch (IndexOutOfRangeException ex) // 모든 예외클래스의 조상이 Exception이므로
            {   // 어떤 예외클래스를 써야할지 모르면 무조건 Exception 클래스.
                Debug.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("프로그램 종료!");
            }
        }
    }
}
