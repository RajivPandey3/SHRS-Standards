using System;
using System.Collections.Generic;

namespace SHRS_Inspector.Models
{
    public class RepositoryInfo
    {
        public List<string> Files { get; set; } = new List<string>();
        public List<string> Directories { get; set; } = new List<string>();
        public List<DocumentInfo> Documents { get; set; } = new List<DocumentInfo>();
    }

    public class DocumentInfo
    {
        public string FilePath { get; set; }
        public Dictionary<string, string> FrontMatter { get; set; } = new Dictionary<string, string>();
        public string Content { get; set; }
    }
}
