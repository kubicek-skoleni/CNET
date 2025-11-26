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
        public static Dictionary<string, int> StatsAllFile(IProgress<(string file, double percent)> progress = null)
        {
            var files = Directory.GetFiles(dir);
            Dictionary<string, int> stats = new();
            var cnt = 0;

            foreach (var file in files)
            {
                if (progress != null)
                {
                    var report = (file, (double)cnt++ / files.Length * 100);
                    progress.Report(report);
                }
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
