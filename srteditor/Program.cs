using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace srteditor
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = File.ReadAllText("/users/ab/Downloads/subs.srt");
            var lines = text.Split("\n\n");
            var sb = new StringBuilder();
            int sub = 1;
            foreach(var line in lines)
            {
                if (line.Contains("[") || line.Contains("]")) continue;
                var subLines = line.Split("\n");
                var newLine = sub++.ToString();
                for (int i = 1; i < subLines.Length; i++)
                {
                    newLine += "\n" + subLines[i];
                }
                newLine += "\n";
                sb.AppendLine(newLine);
            }
            File.WriteAllText("/users/ab/downloads/subsnew.srt", sb.ToString());
        }
    }
}
