
using System.Text;

namespace FileOperations
{
    public class FileOperation
    {
        public static void WriteFile(string filePath, string value)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                byte[] valueToFile = Encoding.Default.GetBytes(value);
                fs.Write(valueToFile, 0, valueToFile.Length);
                if (fs.Length == 0) throw new Exception("File isn`t recorded!");  
            }
        }
        public static string ReadFile(string filePath)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                if (fs.Length == 0) throw new Exception("File is empty!");
                byte[] valueToRead = new byte[(int)fs.Length];
                fs.Read(valueToRead, 0, valueToRead.Length);
                return Encoding.Default.GetString(valueToRead);
            }
        }
    }
}
