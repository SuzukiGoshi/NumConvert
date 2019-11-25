using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            string target = args[0];
            // 小数部の取得
            string dec = string.Empty;
            int point = target.IndexOf(".");
            if (point >= 0)
            {
                dec = "point ";
                for (int i = point + 1; i < target.Length; i++)
                {
                    dec += getIntegerString(target[i].ToString());
                }
                target = target.Substring(0, point);
            }
            // 整数部の取得
            // 百の位
            string numStr = target;
            if (numStr.Length > 3)
            {
                // 3桁以上は3桁のみ取得
                numStr = numStr.Substring(numStr.Length - 3, 3);
            }
            string hounStr = getHoundString(numStr);

            // 千の位
            numStr = target;
            String thou = string.Empty;
            if (target.Length > 4)
            {
                // 4桁以上の3桁のみ取得
                numStr = numStr.Remove(numStr.Length - 3, 3);
                if (numStr.Length > 3)
                {
                    numStr = numStr.Substring(numStr.Length - 3, 3);
                }
                thou = getHoundString(numStr) + "thousand ";
            }
            // 百万の位
            numStr = target;
            String mill = string.Empty;
            if (target.Length > 6)
            {
                // 6桁以上の3桁のみ取得
                numStr = numStr.Remove(numStr.Length - 6, 6);
                if (numStr.Length > 3)
                {
                    numStr = numStr.Substring(numStr.Length - 3, 3);
                }
                mill = getHoundString(numStr) + "million ";
            }
            // 億の位
            numStr = target;
            String bill = string.Empty;
            if (target.Length > 9)
            {
                // 9桁以上の3桁のみ取得
                numStr = numStr.Remove(numStr.Length - 9, 9);
                if (numStr.Length > 3)
                {
                    numStr = numStr.Substring(numStr.Length - 3, 3);
                }
                bill = getHoundString(numStr) + "billion ";
            }
            System.Console.WriteLine((mill + thou + hounStr + dec).TrimEnd());
        }


        private static string getIntegerString(string target)
        {
            string numStr = string.Empty;
            if (target.Equals("0"))
            {
                numStr = "zero ";
            }
            else if (target.Equals("1"))
            {
                numStr = "one ";
            }
            else if (target.Equals("2"))
            {
                numStr = "two ";
            }
            else if (target.Equals("3"))
            {
                numStr = "three ";
            }
            else if (target.Equals("4"))
            {
                numStr = "four ";
            }
            else if (target.Equals("5"))
            {
                numStr = "five ";
            }
            else if (target.Equals("6"))
            {
                numStr = "six ";
            }
            else if (target.Equals("7"))
            {
                numStr = "seven ";
            }
            else if (target.Equals("8"))
            {
                numStr = "eight ";
            }
            else if (target.Equals("9"))
            {
                numStr = "nine ";
            }

            return numStr;
        }
        private static string getHoundString(string target)
        {
            string numStr = string.Empty;
            int num = int.Parse(target);
            if (num > 100)
            {
                string houn = target[0].ToString();
                numStr += getIntegerString(houn) + "hundred ";
            }
            int ten = int.Parse(target) % 100;

            if (ten > 19)
            {
                string tenStr = ten.ToString()[0].ToString();
                if (tenStr.Equals("2"))
                {
                    numStr += "twenty ";
                }
                else if (tenStr.Equals("3"))
                {
                    numStr += "thirty ";
                }
                else if (tenStr.Equals("4"))
                {
                    numStr += "forty ";
                }
                else if (tenStr.Equals("5"))
                {
                    numStr += "fifty ";
                }
                else if (tenStr.Equals("6"))
                {
                    numStr += "sixty ";
                }
                else if (tenStr.Equals("7"))
                {
                    numStr += "seventy ";
                }
                else if (tenStr.Equals("8"))
                {
                    numStr += "eighty ";
                }
                else if (tenStr.Equals("9"))
                {
                    numStr += "ninety ";
                }
                string oneStr = ten.ToString()[1].ToString();
                if (int.Parse(oneStr) > 0)
                {
                    numStr += getIntegerString(oneStr);
                }
            }
            else
            {
                if (ten > 9)
                {
                    string tenStr = ten.ToString();
                    if (tenStr.Equals("10"))
                    {
                        numStr += "ten ";
                    }
                    else if (tenStr.Equals("11"))
                    {
                        numStr += "eleven ";
                    }
                    else if (tenStr.Equals("12"))
                    {
                        numStr += "twelve ";
                    }
                    else if (tenStr.Equals("13"))
                    {
                        numStr += "thirteen ";
                    }
                    else if (tenStr.Equals("14"))
                    {
                        numStr += "fourteen ";
                    }
                    else if (tenStr.Equals("15"))
                    {
                        numStr += "fifteen ";
                    }
                    else if (tenStr.Equals("16"))
                    {
                        numStr += "sixteen ";
                    }
                    else if (tenStr.Equals("17"))
                    {
                        numStr += "seventeen ";
                    }
                    else if (tenStr.Equals("18"))
                    {
                        numStr += "eighteen ";
                    }
                    else if (tenStr.Equals("19"))
                    {
                        numStr += "nineteen ";
                    }
                }
                else
                {
                    if (ten > 0)
                    {
                        numStr += getIntegerString(ten.ToString());
                    }
                }
            }

            return numStr;
        }
    }
}
