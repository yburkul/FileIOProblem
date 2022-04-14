using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIOPractice
{
   public class PracticeFile
   {
        public void FileExist()
        {
            string InputFile = @"D:\Bridglabz\FileIOPractice\Sample.txt";
            if (File.Exists(InputFile))
            {
                Console.WriteLine("File Exist");
            }
            else
            {
                Console.WriteLine("File is not found");
            }
        }
        public void ReadAllText()
        {
            string filePath = @"D:\Bridglabz\FileIOPractice\Sample.txt";
            string read = File.ReadAllText(filePath);
            Console.WriteLine(read);
        }
        public void ReadAllLine()
        {
            string Path = @"D:\Bridglabz\FileIOPractice\Sample.txt";
            string[] readline = File.ReadAllLines(Path);
            foreach (string line in readline)
            {
                Console.WriteLine(line);
            }
        }
        public void ReadAllBytes()
        {
            string Path = @"D:\Bridglabz\FileIOPractice\Sample.txt";
            byte[] readBytes = File.ReadAllBytes(Path);
            foreach (byte b in readBytes)
            {
                Console.WriteLine(b);
            }
        }
        public void WriteAllText()
        {
            string filePath = @"D:\Bridglabz\FileIOPractice\Demo.txt";
            string data = "C# Corner MVP & Microsoft MVP;";
            File.WriteAllText(filePath, data);
        }
        public void ReadAllLines()
        {
            string filePath = @"D:\Bridglabz\FileIOPractice\Demo.txt";
            string[] data = { "MCT", "MCPD", "MCTS", "MCSD.NET", "MCAD.NET", "CSM" };
            File.WriteAllLines(filePath, data);
            foreach (string line in data)
            {
                Console.WriteLine(line);
            }
        }
        public void AppendAllText()
        {
            string filePath = @"D:\Bridglabz\FileIOPractice\Demo.txt";
            string data = "Also Certified from IIT Kharagpur";
            File.AppendAllText(filePath, data);
        }
        public void AppendAllLine()
        {
            string filePath = @"D:\Bridglabz\FileIOPractice\Demo.txt";
            string[] otherData = { "Worked with Microsoft", "Lived in USA" };
            File.AppendAllLines(filePath, otherData);
        }
        public void CopyFile()
        {
            string filePath = @"D:\Bridglabz\FileIOPractice\Demo.txt";
            string copyPath = @"D:\Bridglabz\FileIOPractice\DemoSample.txt";
            bool overWrite = true;
            File.Copy(filePath, copyPath, overWrite);
        }
        public void DeleteFile()
        {
            string filePath = @"D:\Bridglabz\FileIOPractice\DemoSample.txt";
            File.Delete(filePath);
        }
        public void GetCreationTime()
        {
            string sourceFilePath = @"D:\Bridglabz\FileIOPractice\Demo.txt";
            DateTime fileCreatedOn = File.GetCreationTime(sourceFilePath);
            Console.WriteLine(fileCreatedOn);
        }
        public void DirectoryName()
        {
            string sourceFilePath = @"D:\Bridglabz\FileIOPractice\Demo.txt";
            FileInfo fInfo = new FileInfo(sourceFilePath);
            string directoryPath = fInfo.DirectoryName;
            Console.WriteLine(directoryPath);
        }
        public void LengthOfFile()
        {
            string sourceFilePath = @"D:\Bridglabz\FileIOPractice\Demo.txt";
            FileInfo fInfo = new FileInfo(sourceFilePath);
            long length = fInfo.Length;
            Console.WriteLine(length);
        }
        public void CreateDirectory()
        {
            string sourceDirPath = @"D:\Bridglabz\FileIOPractice\Demo";
            Directory.CreateDirectory(sourceDirPath);
        }
        public void DeleteDirectory()
        {
            string sourceDirPath = @"D:\Bridglabz\FileIOPractice\Demo";
            Directory.Delete(sourceDirPath);
        }
   }
}
