using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kartoteka
{
    // класс для ведения журнала-отчета (логов) работы программы
    static class Logs
    {
        static string path = @"C:\Kartoteka\Logs\" + DateTime.Now.ToString("dd.MM.yyyy") + ".txt";

        static async public void RegularLog(string message)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(path, true))
                {
                    await writer.WriteLineAsync(DateTime.Now.ToString("HH:mm:ss") + "\t" + message);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(
                    "Сбой при записи штатного лога: \n" + e.ToString(),
                    "Ошибка!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
            }
        }

        static async public void ErrorLog(string message)
        {
            try
            {
                path += DateTime.Now.ToString("dd.MM.yyyy") + ".txt";

                using (StreamWriter writer = new StreamWriter(path, true))
                {
                    await writer.WriteLineAsync("!!" + DateTime.Now.ToString("HH:mm:ss") + "\t" + message);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(
                    "Сбой при записи лога ошибки: \n" + e.ToString(),
                    "Ошибка!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
            }
        }

    }
}
