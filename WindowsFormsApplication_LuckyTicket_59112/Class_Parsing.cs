using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication_LuckyTicket_59112
{
    public class Class_Parsing
    {
        public static short StrToShortDef(string s, short @default)
        {
            short number;
            if (short.TryParse(s, out number))
                return number;
            return @default;
        }
        public static void ConvertLongToArray(long lg_value, ref short[] sh_array)
        {
            for (short sh_i = 0; sh_i < 6; sh_i++)
                sh_array[sh_i] = 0;
            string str = lg_value.ToString();
            long count = str.Count();
            for (long lg_i = count - 1; lg_i >= 0; lg_i--)
            {
                string str_digit = (string)str.ElementAt((int)lg_i).ToString();
                sh_array[lg_i] = StrToShortDef(str_digit, sh_array[lg_i]);
            }
        }
        public static string ConvertLongToString(long lg_value, short sh_num_of_digits)
        {
            string str_return = "";
            string str = lg_value.ToString();
            long count = str.Count();
            for (long lg_i = 0; lg_i < sh_num_of_digits - count; lg_i++)
            {
                str_return += "0";
            }
            for (long lg_i = 0; lg_i < count; lg_i++)
            {
                str_return += (string)str.ElementAt((int)lg_i).ToString();
            }
            return str_return;
        }
    }
}