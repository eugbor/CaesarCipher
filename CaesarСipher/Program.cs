using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarСipher
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите слово,которое нужно зашифровать:");
            string s = Console.ReadLine();

            Console.WriteLine("Введите ключ:");
            var key = Convert.ToInt32(Console.ReadLine());

            string s1 = "";

            //string alf = "abcdefghijklmnopqrstuvwxyz";
            string alf = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";

            int m = alf.Length;

            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < alf.Length; j++)
                {
                    if (s[i] == alf[j])
                    {
                        int temp = j + key;

                        while (temp >= m)
                            temp -= m;

                        s1 += alf[temp];
                    }
                }
            }

            Console.WriteLine("Зашифрованное слово:" + s1);
            Console.ReadLine();
        }
    }
}
