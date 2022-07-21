using System;



namespace RefOutKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int number1=1;
            int number2 = 200;
            var result = Add(ref number1,number2);
            Console.WriteLine(result);
            Console.WriteLine(number1);      
        }
    
        static int Add(ref int number1, int number2)
        {

            number1 = 122;
            number1 = 11;
            return number1 + number2;
        
        
        }         
    

    }
}
