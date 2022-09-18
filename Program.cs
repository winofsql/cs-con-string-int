using System.Diagnostics;

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

        }

        private static void print(int v)
        {
            System.Console.WriteLine(v);
            Debug.WriteLine(v);
        }

        private static void print(string v)
        {
            System.Console.WriteLine(v);
            Debug.WriteLine(v);
        }
    }
}
