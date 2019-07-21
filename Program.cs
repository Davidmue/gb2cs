using System;

namespace gb2cs
{
    public class Program
    {
        public static void Main(string[] args)
        {
         
            // for each line ... 
            var gb3String = "Print \"truc\""; 
            string instructionTranslated = "";
            
            char[] separators = { ' ', ';' };

            string[] tokens = gb3String.Split(separators);

            foreach(string token in tokens) {
                string translation = "";
                switch(token) {
                    case "Print" : 
                        translation += "Console.WriteLine()";
                    break;
                    default:
                        translation += token;
                    break;
                }
                instructionTranslated += translation;
            }

            Console.WriteLine(gb3String);
            Console.WriteLine(instructionTranslated);
        }
    }
}
