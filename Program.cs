﻿using System.Diagnostics;

namespace cs_con_string_int
{
    class Program
    {
        static void Main(string[] args)
        {

            // ****************************
            // 文字列を整数に変換
            // ****************************
            var su = "123";
            var result = int.Parse(su);
            result++;
            result += 2;
            result = result + 2;
            print(result);

            // ****************************
            // 整数を文字列に変換
            // ****************************
            var text = string.Format("{0}", result);
            print(text);

            text = $"{result}";
            print(text);

            // 簡易的な方法
            text = result + "";
            print(text);

            text = result.ToString();
            print(text);

            text = result.ToString("0000");
            print(text);

            text = (result+100000).ToString("###,##0");
            print(text);
            text = (result+100000).ToString("00-00-00");
            print(text);

            text = string.Format("/{0:###,###}/ /{0:###,##0}/ /{2:#円}/ /{1:0円}/", 0, 0, 0);
            print(text);

            text = $"/{1234:###,###}/ /{1234:###,##0}/";
            print(text);

            text = $"        {result+100000:#,0}";
            int len = text.Length;
            text = text.Substring(len-8,8);
            print($"/{text}/");

            text = $"        {0:#,0}";
            len = text.Length;
            text = text.Substring(len-8,8);
            print($"/{text}/");

            text = $"{new string(' ', 8)}{1234:#,0}";
            len = text.Length;
            text = text.Substring(len-8,8);
            print($"/{text}/");

        }

        private static void print(int v)
        {
            System.Console.WriteLine(v);
            Debug.WriteLine($"DBG:{v}");
        }

        private static void print(string v)
        {
            System.Console.WriteLine(v);
            Debug.WriteLine($"DBG:{v}");
        }
    }
}
