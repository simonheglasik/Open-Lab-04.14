using System;

namespace Open_Lab_04._14
{
    public class FramePrinter
    {
        public void Print(string[] strings)
            {
            string stars = "";
            string longest = "";
            string word = "";
            for (int i = 0; i < strings.Length; i++)
            {
                if (strings[i].Length > longest.Length)
                {
                    longest = strings[i];
                }
            }
            for (int o = 0; o < longest.Length + 4; o++)
            {
                stars = stars + "*";
            }
            Console.WriteLine(stars);
            foreach (string s in strings)
            {
                word = s;
                for (int o = 0; o < (stars.Length - 4) - s.Length; o++)
                {
                    word = word + " ";
                }
                Console.WriteLine($"* {word} *");
            }
            Console.WriteLine(stars);
        }
    }
}