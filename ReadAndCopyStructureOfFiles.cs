using System.IO;
using System.IO.Compression;

namespace ReadFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string dirSrc = "C:\\source\\";
            string dirTrgt = "C:\\target\\";
            DirectoryInfo directoryInfo = new DirectoryInfo(dirSrc);
            DirectoryInfo[] dirs = directoryInfo.GetDirectories();
            FileInfo[] files = directoryInfo.GetFiles();
            if (dirs.Length != 0) ReadFromDir(dirs, dirTrgt);
            if (files.Length != 0) ReadFromSrc(files, dirTrgt);
            if (dirs.Length != 0 || files.Length != 0) ZipFile.CreateFromDirectory($"{dirTrgt}", "C:\\C#\\Engeniy\\myZip\\myZip.zip");
        }
        static void ReadFromDir(DirectoryInfo[] dirs, string dirTrgt)
        {
            foreach (var curDir in dirs)
            {
                DirectoryInfo[] dirsCurDir = curDir.GetDirectories();
                if (dirsCurDir.Length != 0) ReadFromDir(dirsCurDir, $"{dirTrgt}\\{curDir.Name}");
                foreach (var curFile in curDir.GetFiles())
                {
                    Directory.CreateDirectory($"{dirTrgt}\\{curDir.Name}");
                    File.Copy(curFile.FullName, $"{dirTrgt}\\{curDir.Name}\\{curFile.Name}", true);
                }
            }
        }
        static void ReadFromSrc(FileInfo[] files, string dirTrgt)
        {
            foreach (var curFile in files)
            {
                File.Copy(curFile.FullName, $"{dirTrgt}{curFile.Name}", true);
            }
        }
    }
}
