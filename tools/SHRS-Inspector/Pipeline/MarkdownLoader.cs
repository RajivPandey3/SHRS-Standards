using System;
using System.IO;
using SHRS_Inspector.Models;

namespace SHRS_Inspector.Pipeline
{
    public class MarkdownLoader
    {
        public DocumentInfo Load(string filePath)
        {
            var doc = new DocumentInfo { FilePath = filePath };
            
            if (!File.Exists(filePath))
                return doc;

            string[] lines = File.ReadAllLines(filePath);
            
            // Basic logic to extract Front Matter (between --- and ---)
            // CTO Rule: "MarkdownLoader should only read markdown and extract front matter. No validation."
            bool inFrontMatter = false;
            foreach (var line in lines)
            {
                if (line.Trim() == "---")
                {
                    inFrontMatter = !inFrontMatter;
                    continue;
                }

                if (inFrontMatter)
                {
                    var parts = line.Split(':', 2);
                    if (parts.Length == 2)
                    {
                        doc.FrontMatter[parts[0].Trim()] = parts[1].Trim();
                    }
                }
            }

            doc.Content = File.ReadAllText(filePath);
            return doc;
        }
    }
}
