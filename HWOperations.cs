
using System.Text.RegularExpressions;

namespace FileOperations
{
    public class HWOperations
    {
        public static string[] SearchByMask(string path, string mask)
        {
            //Regex regex = new Regex(@"^\*\.[a - z] {3, 4}");
            if (!Directory.Exists(path)) throw new FileNotFoundException("Directory isn`t exists!");
            else return Directory.GetFiles(path, mask, SearchOption.AllDirectories);
        }
        public static void DeleteFilesByMask(string path, string mask)
        {
            string[] files = SearchByMask(path, mask);
            foreach (var item in files)
                File.Delete(item);
        }
        public static void DeleteSubDirectories(string rootPath)
        {
            string[] subDirs = Directory.GetDirectories(rootPath, "*", SearchOption.TopDirectoryOnly);
            foreach (var item in subDirs)
                Directory.Delete(item, true);
        }
        public static string[] ShowAllByPath(string path)
        {
            if (!Directory.Exists(path)) throw new FileNotFoundException("Directory isn`t exists!");
            return Directory.GetFileSystemEntries(path);
        }
    }
}
