using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RemoveEmptyFolder
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tmpDirs = Directory.GetDirectories("./", "*.*", SearchOption.AllDirectories);
            for (int i = 0; i < tmpDirs.Length; i++)
            {
                string tmpDir = tmpDirs[i];
                if(Directory.Exists(tmpDir))
                {
                    string[] tmpFilesInDir = Directory.GetFiles(tmpDir, "*.*", SearchOption.AllDirectories);
                    if (tmpFilesInDir.Length == 0)
                    {
                        Directory.Delete(tmpDir, true);

                        Console.WriteLine(tmpDir);
                    }
                }

            }

            Console.ReadKey();
        }
    }
}
