using System;
using System.IO;
using System.Linq;
using SHRS_Inspector.Models;
using SHRS_Inspector.Configuration;

namespace SHRS_Inspector.Pipeline
{
    public class RepositoryBuilder
    {
        private readonly InspectorConfiguration _config;
        private readonly MarkdownLoader _loader;

        public RepositoryBuilder(InspectorConfiguration config)
        {
            _config = config;
            _loader = new MarkdownLoader();
        }

        public RepositoryInfo Build(string rootPath)
        {
            var repo = new RepositoryInfo();

            if (!Directory.Exists(rootPath))
                return repo;

            // 1. Scan Directories
            repo.Directories = Directory.GetDirectories(rootPath, "*", SearchOption.AllDirectories).ToList();

            // 2. Scan Files
            var allFiles = Directory.GetFiles(rootPath, "*.*", SearchOption.AllDirectories);
            repo.Files = allFiles.ToList();

            // 3. Build Documents (Markdown only)
            foreach (var file in allFiles.Where(f => f.EndsWith(".md", StringComparison.OrdinalIgnoreCase)))
            {
                var doc = _loader.Load(file);
                repo.Documents.Add(doc);
            }

            return repo;
        }
    }
}
