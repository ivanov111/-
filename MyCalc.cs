using System;
using MyCalcLib;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;

namespace MyCalcLib
{
    public class MyCalc
    {
        public bool Sum(string x)
        {
            /*string[] mass = {"Чайковского", "Ленина", "Советская", "Гоголя"};*/

            using (FileStream fstream = File.OpenRead(@"F:\c# test\Ulica\ylic1.txt"))
            {
                // преобразуем строку в байты
                byte[] array = new byte[fstream.Length];
                // считываем данные
                fstream.Read(array, 0, array.Length);
                // декодируем байты в строку
                string tt = System.Text.Encoding.Default.GetString(array);
                string q = "'" + x + "'";
                if (tt.Contains(q))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
