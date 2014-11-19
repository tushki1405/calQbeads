using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Drawing;

namespace Controller
{
    public static class Validations
    {
        private static string invalidCharacters = @"([\\/\.\'\[\]\=\-\(\)\&\^\%\$\~\`\{\}\:\;\<\>\,])";
        private static string startWithChar = @"^[\w]+";
        private static string onlyNumber = @"^[\d]+$";

        //Check for values entered in text field
        //Return false if value entered is not in required format
        public static bool ProperText(TextBox tb)
        {
            Match match = Regex.Match(tb.Text, invalidCharacters, RegexOptions.IgnoreCase);
            if(match.Success)
            {
                return false;
            }
            match = Regex.Match(tb.Text, startWithChar, RegexOptions.IgnoreCase);
            if (!match.Success)
            {
                return false;
            }
            return true;
        }

        //Check for values entered in text field
        //Return false if value entered contains invalid characters
        public static bool NoInvalidCharacters(TextBox tb)
        {
            Match match = Regex.Match(tb.Text, invalidCharacters, RegexOptions.IgnoreCase);
            if (match.Success)
            {
                return false;
            }
            return true;
        }

        //Check for values entered in text field
        //Return false if value entered is not number
        public static bool IsProperNumber(TextBox tb)
        {
            Match match = Regex.Match(tb.Text, onlyNumber, RegexOptions.IgnoreCase);
            if (match.Success)
            {
                return true;
            }
            return false;
        }

        //Event functions to embed
        public static void Suppress(object sender, KeyEventArgs args)
        {
            if (args.KeyCode != Keys.Down && args.KeyCode != Keys.Up)
                args.SuppressKeyPress = true;
        }
    }
}
