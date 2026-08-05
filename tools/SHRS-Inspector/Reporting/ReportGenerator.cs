using System;
using System.Collections.Generic;
using SHRS_Inspector.Validation;

namespace SHRS_Inspector.Reporting
{
    public interface IReportWriter
    {
        void GenerateReport(IEnumerable<ValidationResult> results);
    }

    public class ConsoleReport : IReportWriter
    {
        public void GenerateReport(IEnumerable<ValidationResult> results)
        {
            Console.WriteLine("=== SHRS Inspector Report ===");
            foreach (var result in results)
            {
                string icon = result.Passed ? "✅" : "❌";
                Console.WriteLine($"{icon} [{result.RuleId}] {result.Category}: {result.Message} (Source: {result.Source})");
            }
        }
    }
}
