using System;
using System.Collections.Generic;

namespace Testing
{
    class Program
    {
        public static void Main()
        {
            string[] message = { "решИла нЕ Упрощать и зашифРОВАтЬ Все послаНИЕ",
                            "дАже не Старайся нИЧЕГО у тЕбя нЕ получится с расшифРОВкой",
                            "Сдавайся НЕ твоего ума Ты не споСОбЕн Но может быть",
                            "если особенно упорно подойдешь к делу",
                            "",
                            "будет Трудно конечнО",
                            "Код ведЬ не из простых",
                            "очень ХОРОШИЙ код",
                            "то у тебя все получится",
                            "и я буДу Писать тЕбЕ еще",
                            "",
                            "чао" };
            string result = DecodeMessage(message);
            Console.WriteLine(result);
        }

        private static string DecodeMessage(string[] lines)
        {
            List<string> messages = new List<string>();

            for (int i = lines.Length - 1; i >= 0; i--)
            {
				string[] arr = lines[i].Split(' ');

                for (int j = arr.Length - 1; j >= 0; j--)
                {
                    if (arr[j] != "" && Char.IsUpper(arr[j][0]) && arr[j].Length > 0)
                    {
                        messages.Add(arr[j]);
                    }
                }
            }
			string str = "";

            foreach (string msg in messages)
            {
                str += msg + " ";
			}

            return str.Substring(0, str.Length - 1);
        }
    }
}
