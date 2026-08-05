using System;

namespace SHRS_Inspector.Validation
{
    public class ValidationResult
    {
        public string RuleId { get; set; }
        public bool Passed { get; set; }
        public string Message { get; set; }
        public string Severity { get; set; } // Low, Medium, High, Critical
        public string Category { get; set; }
        public TimeSpan Duration { get; set; }
        public string Source { get; set; } // File path or Component
    }
}
