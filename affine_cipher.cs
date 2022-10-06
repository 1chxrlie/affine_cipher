using System;
using System.Collections;
using System.Collections.Generic;
class Program2
{
    static void Main(string[] args)
    {
        Console.WriteLine("Зашифровка исходной фразы HELLO WORLD!");
        Console.WriteLine(" ");
        Console.WriteLine("Буква откр.текста - x - (ax+b)mod(m) - Буква закр. текста");

        string[] open_text = new string[] { "H", "E", "L", "L", "O", " ", "W", "O", "R", "L", "D", "!"}; //открытый текст
        
        //создание алфавита
        string[] alphabet = new[] {"A", "B","C", "D", "E", "F","G", "H","I","J","K", "L", "M", "N", "O", "P", "Q", "R"
            ,"S", "T", "U", "V","W", "X", "Y", "Z","а", "б","в","г","д", "е", "ж", "з", "и", "й", "к", "л","м","н","о","п",
            "р", "с","т", "у","ф", "х","ц", "ч","ш", "щ","ъ","ы","ь","э","ю","я", " ", ",", ".",":","!","?" };

        int[] letter_code = new int[open_text.Length]; //массив для хранения кодов букв из открытого текста
        int a = 11, b = 50, m = 64; //объявление переменных
        int[] closed_code = new int[open_text.Length]; //массив для хранения кодов зашифрованных букв
        string[] closed_text = new string[open_text.Length]; //массив для хранения букв закрытого текста 

        //цикл для шифрования фразы
        for (int i = 0; i < open_text.Length; i++)
        {
            letter_code[i] = Array.IndexOf(alphabet, open_text[i]); //заполняем массив кодами букв из открытого текста
            int new_code = (a * letter_code[i] + b) % m; //индекс нового символа 
            closed_code[i] = new_code; //заполняем массив кодами зашифрованных букв
            closed_text[i] = alphabet[closed_code[i]]; //заполняем массив буквами закрытого текста
            //буква открытого текста, номер в алфавите, новый номер, буква закрытого текста
            Console.WriteLine("         " + open_text[i] + "          " + letter_code[i] + "          " + closed_code[i] + "         " + closed_text[i]); 
        }
        Console.WriteLine(" ");
        Console.WriteLine("Дешифровка полученной фразы ?дссMцкMусTв");
        Console.WriteLine(" ");
        Console.WriteLine("Буква закр.текста - x - ((a^(-1)(x - b))mod(m) - Буква откр. текста");
        //цикл для дешифрования фразы
        for (int i = 0; i < open_text.Length; i++)
        {
            int old_code = (35 * (closed_code[i] - b)) % 64; //индекс нового символа, 35 = a^(-1)
            Console.WriteLine("         " + closed_text[i] + "          " + closed_code[i] + "            " + letter_code[i] + "                 " + open_text[i]);
        }
    }
}