using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIOPractice
{
    public class FileIO
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome in File IO");
            PracticeFile practiceFile = new PracticeFile();
            int input = 0;
            do
            {
                Console.WriteLine("1: File Exist");
                Console.WriteLine("2: Read All Text");
                Console.WriteLine("3: Read all line");
                Console.WriteLine("4: Read all bytes");
                Console.WriteLine("5: Read Write all text");
                Console.WriteLine("6: Read all lines");
                Console.WriteLine("7: Append all text");
                Console.WriteLine("8: Append All line");
                Console.WriteLine("9: Copy File");
                Console.WriteLine("10: Delete File");
                Console.WriteLine("11: file creation time");
                Console.WriteLine("12: Directory Name ");
                Console.WriteLine("13: Length of File");
                Console.WriteLine("14: CreateDirectory");
                Console.WriteLine("15: Deletes a Directory ");
                 input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                      practiceFile.FileExist();
                        break;
                    case 2:
                        practiceFile.ReadAllText();
                        break;
                    case 3:
                        practiceFile.ReadAllLine();
                        break;
                    case 4:
                        practiceFile.ReadAllBytes();
                        break;
                    case 5:
                        practiceFile.WriteAllText();
                        break;
                    case 6:
                        practiceFile.ReadAllLines();
                        break;
                    case 7:
                        practiceFile.AppendAllText();
                        break;
                    case 8:
                        practiceFile.AppendAllLine();
                        break;
                    case 9:
                        practiceFile.CopyFile();
                        break;
                    case 10:
                        practiceFile.DeleteFile();
                        break;
                    case 11:
                        practiceFile.GetCreationTime();
                        break;
                    case 12:
                        practiceFile.DirectoryName();
                            break;
                    case 13:
                        practiceFile.LengthOfFile();
                        break;
                     case 14:
                        practiceFile.CreateDirectory();
                        break;
                    case 15:
                        practiceFile.DeleteDirectory();
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
            }
            while (input != 0);
        }
    }
}