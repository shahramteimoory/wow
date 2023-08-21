using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fury
{
    public class FileLogger
    {
        public static void Log(string content)
        {
            string directoryPath = Application.StartupPath;
            string filePath = Path.Combine(directoryPath, "ErrorLog.txt");

            try
            {
                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }
                File.WriteAllText(filePath, content);
            }
            catch (Exception ex)
            {
                // در صورت بروز خطا، می‌توانید اقدامات لازم را انجام دهید، مانند نمایش پیام خطا
                FileLogger.Log(ex.ToString());
            }
        }
    }
}
