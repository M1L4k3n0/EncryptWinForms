using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShifrLab1
{
     public class Cesar
    {
        public static string Encrypt(char[] input)
        {
            string output = "";
            for(int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'а') output = string.Format("{0}г", output);
                if (input[i] == 'б') output = string.Format("{0}д", output);
                if (input[i] == 'в') output = string.Format("{0}е", output);
                if (input[i] == 'г') output = string.Format("{0}ё", output);
                if (input[i] == 'д') output = string.Format("{0}ж", output);
                if (input[i] == 'е') output = string.Format("{0}з", output);
                if (input[i] == 'ё') output = string.Format("{0}и", output);
                if (input[i] == 'ж') output = string.Format("{0}й", output);
                if (input[i] == 'з') output = string.Format("{0}к", output);
                if (input[i] == 'и') output = string.Format("{0}л", output);
                if (input[i] == 'й') output = string.Format("{0}м", output);
                if (input[i] == 'к') output = string.Format("{0}н", output);
                if (input[i] == 'л') output = string.Format("{0}о", output);
                if (input[i] == 'м') output = string.Format("{0}п", output);
                if (input[i] == 'н') output = string.Format("{0}р", output);
                if (input[i] == 'о') output = string.Format("{0}с", output);
                if (input[i] == 'п') output = string.Format("{0}т", output);
                if (input[i] == 'р') output = string.Format("{0}у", output);
                if (input[i] == 'с') output = string.Format("{0}ф", output);
                if (input[i] == 'т') output = string.Format("{0}х", output);
                if (input[i] == 'у') output = string.Format("{0}ц", output);
                if (input[i] == 'ф') output = string.Format("{0}ч", output);
                if (input[i] == 'х') output = string.Format("{0}ш", output);
                if (input[i] == 'ц') output = string.Format("{0}щ", output);
                if (input[i] == 'ч') output = string.Format("{0}ъ", output);
                if (input[i] == 'ш') output = string.Format("{0}ы", output);
                if (input[i] == 'щ') output = string.Format("{0}ь", output);
                if (input[i] == 'ы') output = string.Format("{0}э", output);
                if (input[i] == 'ь') output = string.Format("{0}ю", output);
                if (input[i] == 'ъ') output = string.Format("{0}я", output);
                if (input[i] == 'э') output = string.Format("{0}а", output);
                if (input[i] == 'ю') output = string.Format("{0}б", output);
                if (input[i] == 'я') output = string.Format("{0}в", output);         
            }
            return output;
        }
    }
}
