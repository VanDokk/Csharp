using System;


    class Program
    {
        static void Main(string[] args)
        {
        
        Console.WriteLine("Введите два вещественных числа: ");
        double num1 = 0, num2 = 0;

        bool flag = false;
        do
        {            
            try
            {
                num1 = Convert.ToDouble(Console.ReadLine());
                num2 = Convert.ToDouble(Console.ReadLine());
                flag = true;
            }
            catch
            {
                Console.WriteLine("Введите корректное значение(Возможно поменяйте . на ,)");
            }
            finally
            {
                double sum = num1 + num2;
                Console.Write($"{sum}");
            }
        } while (flag != true);


        
        }
    }

