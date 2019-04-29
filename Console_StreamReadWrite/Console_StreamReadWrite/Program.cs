using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_StreamReadWrite
{
    class Program
    {
        static void Main(string[] args)
        {
            //Data Sample, add sum and avg
            //1,10,10,10 -> 1,10,10,10,30,10
            if (args.Length == 0)
            {
                Console.WriteLine("Please enter data file.");

                return;
            }

            string filePath = args[0];

            if (!File.Exists(filePath))
            {
                Console.WriteLine("Please check data file.");

                return;
            }

            PrintScore(filePath);
        }

        static void PrintScore(string filePath)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                using(StreamWriter writer = new StreamWriter(@"data.txt.out"))
                {
                    string line;

                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] temp = line.Split(',');
                        int sum = 0;
                        int avg = 0;
                        int count = 0;

                        for (int i = 1; i < temp.Length; i++)
                        {
                            sum += Convert.ToInt32(temp[i]);
                            count++;
                        }

                        avg = sum / count;

                        line = $",{sum},{avg}";

                        writer.WriteLine(line);
                    }
                }
            }
        }
    }
}
