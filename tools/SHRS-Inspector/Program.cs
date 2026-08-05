using System;
using System.Collections.Generic;
using SHRS_Inspector.Configuration;
using SHRS_Inspector.Pipeline;
using SHRS_Inspector.Validation;
using SHRS_Inspector.Reporting;

namespace SHRS_Inspector
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting SHRS-Inspector...");

            // 1. Load Configuration
            var config = InspectorConfiguration.LoadDefault();

            // 2. Build Repository Model (Scanner -> Builder -> Model)
            // Assuming the repo root is the current directory or passed via args
            string repoRoot = args.Length > 0 ? args[0] : Environment.CurrentDirectory;
            var builder = new RepositoryBuilder(config);
            var repositoryModel = builder.Build(repoRoot);

            Console.WriteLine($"Built Repository Model: {repositoryModel.Documents.Count} documents found.");

            // 3. Validation (Mock logic just to show the pipeline structure)
            var results = new List<ValidationResult>();
            
            // Example Rule: Required Directories check
            foreach (var reqDir in config.RequiredDirectories)
            {
                bool exists = repositoryModel.Directories.Exists(d => d.Replace("\\", "/").EndsWith(reqDir));
                results.Add(new ValidationResult 
                { 
                    RuleId = "DIR-001", 
                    Category = "Structure", 
                    Passed = exists, 
                    Message = $"Required directory '{reqDir}' was {(exists ? "found" : "missing")}.", 
                    Severity = "High",
                    Source = "Repository Structure"
                });
            }

            // 4. Report Generation (Strategy Pattern)
            IReportWriter reporter = new ConsoleReport();
            reporter.GenerateReport(results);

            Console.WriteLine("Inspection complete.");
        }
    }
}
