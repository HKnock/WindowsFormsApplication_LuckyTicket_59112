using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication_LuckyTicket_59112
{
    public class Class_Evaluating
    {
        public const short DEF_LUCKY_TICKET = 1;
        public const short DEF_USUAL_TICKET = 0;
        public const short DEF_FAILED_TICKET = -1;
        public const short DEF_VARIANT_DEFAULT = 100;
        public const short DEF_VARIANT_TASK = 101;
        public static string GetMessageByLuckyValue(short sh_is_lucky)
        {
            switch (sh_is_lucky)
            {
                case DEF_LUCKY_TICKET:
                    return "Получен счастливый билет!)";
                case DEF_USUAL_TICKET:
                    return "Получен обычный билет!(";
                default:
                    return "Задан недопустимый номер билета";
            }
        }
        public static short IsHappyLucky(short[] arr, short sh_checked)
        {
            short sh_return = CheckInput(arr);
            if (sh_return == DEF_USUAL_TICKET)
            {
                switch (sh_checked)
                {
                    case DEF_VARIANT_DEFAULT:
                        sh_return = RevealLucky_Default(arr);
                        break;
                    case DEF_VARIANT_TASK:
                        sh_return = RevealLucky_Task(arr);
                        break;
                }
                return sh_return;
            }
            else
            {
                return sh_return;
            }
        }
        private static short CheckInput(short[] arr)
        {
            short iter = 0;
            for (; iter <= 5; iter++)
            {
                if (arr[iter] < 0 || arr[iter] > 9)
                {
                    return DEF_FAILED_TICKET;
                }
            }
            return DEF_USUAL_TICKET;
        }
        private static short RevealLucky_Default(short[] arr)
        {
            short iter = 1;
            for (; iter <= 5; iter++)
            {
                if (!
                    (
                       (arr[iter] % 2 == 0 ||
                        arr[iter] % 3 == 0)
                       &&
                       (arr[iter] == arr[0])
                    )
                  )
                {
                    return DEF_USUAL_TICKET;
                }
            }
            return DEF_LUCKY_TICKET;
        }
        private static short RevealLucky_Task(short[] arr)
        {
            short iter = 1;
            for (; iter <= 5; iter++)
            {
                if (!((arr[iter] % 2 == 0 || arr[iter] % 3 == 0) && (arr[iter] == arr[0])))
                {
                    return DEF_USUAL_TICKET;
                }
            }
            return DEF_LUCKY_TICKET;
        }
    }
}
