using System;

namespace Zadacha_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            string text = 
                "І вам слава, сині гори," +
                "\r\nКригою окуті." +
                "\r\nІ вам, лицарі великі," +
                "\r\nБогом не забуті." +
                "\r\nБорітеся — поборете!" +
                "\r\nВам Бог помагає!" +
                "\r\nЗа вас правда, за вас слава" +
                "\r\nІ воля святая!";

            int count = 0;
            char letter = ' ' ; 

            for (char c = 'а'; c < 'я'; c++) 
            {
                int tmp = 0; 

                for (int i = 0; i < text.Length; i++) 
                {
                    if (text[i] == c) 
                    {
                        tmp++;
                    }
                }
                    
                if (tmp > count)
                {
                    count = tmp;
                    letter = c;
                }
            }
            
            Console.Write("Буква " + "'" +letter + "'" + " зустрічається " + count + " разів");
            Console.WriteLine();
        }
    }
}
