using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingOnDataType
{
    public class CatchingString
    {
        public char word = 'N';
        public string sentence = "This is a sentence";
        public string text = "This is Text with more word. Bla bla bla.";
        public string specialString = "This is a \"String\"";
        public char[] chars = { 'H', 'e', 'l', 'l', 'o' };
        public string using_string_keyword = "This is string keyword";
        public String using_String_keyword = "This is String keyword";

        public void PrintString()
        {
            Console.WriteLine($"Char : {word}");
            Console.WriteLine($"Sentence with string : {sentence}");
            Console.WriteLine($"Text with string : {text}");
            Console.WriteLine($"Special string : {specialString}");
            Console.WriteLine($"chars : {chars}");
            Console.WriteLine($"using_string_keyword : {using_string_keyword}");
            Console.WriteLine($"using_String_keyword : {using_String_keyword}");
        }
    }
}
