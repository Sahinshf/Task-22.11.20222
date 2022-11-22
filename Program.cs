namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Divide7(Convert.ToInt32(Console.ReadLine()));
        }

        static void Divide7(int num1)
        {
            int i = 0;
            int k = 0;
            int num = num1;

            if (num1 % 7 == 0)
            {

                Console.WriteLine("number is divisible by seven");

            }

            else
            {
                while (num1 % 7 != 0)
                {
                    num1++;
                    i++;
                }

                while (num % 7 != 0)
                {
                    num--;
                    k++;
                }

                //Console.WriteLine(k);
                //Console.WriteLine(i);

                //Console.WriteLine(num1);
                //Console.WriteLine(num);

                if (k > i)
                {
                    Console.WriteLine(num1);
           
                }
                else
                {
                    Console.WriteLine(num);
                }

            }

        }



    }
}