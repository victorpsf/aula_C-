using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Aula.Source
{
    public class Util
    {
        public static string CompleteString(int length, string message) {
            for(int x = message.Length; x < length; x++)
                message += " ";
            return message;
        }

        public static int ReadIntTerminal() {
            string readed = Console.ReadLine() ?? "";
            
            if (Regex.Match(readed, "^[0-9]+$").Success)
                return Convert.ToInt32(readed);
            else throw new Exception("Invalid input number");
        }
    }
}