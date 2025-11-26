using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp
{
    class FileProcessing
    {
        private static readonly string dir = @"C:\PROJECTS\skoleni\2025_komfi\BigFiles";
        public static Dictionary<string, int> StatsAllFile()
        {
            var files = Directory.GetFiles(dir);
            Dictionary<string, int> stats = new();

            foreach (var file in files)
            {
                var words = File.ReadLines(file);

                foreach (var word in words)
                {
                    if (stats.ContainsKey(word))
                        stats[word]++;
                    else
                        stats[word] = 1;
                }
            }
            
            var top10 = stats.OrderByDescending(kv => kv.Value).Take(10);

            return top10.ToDictionary();
        }
    }
}
