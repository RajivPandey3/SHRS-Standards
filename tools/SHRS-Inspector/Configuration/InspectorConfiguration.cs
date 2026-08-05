using System.Collections.Generic;

namespace SHRS_Inspector.Configuration
{
    public class InspectorConfiguration
    {
        public List<string> RequiredDirectories { get; set; } = new List<string>();
        public List<string> RequiredFiles { get; set; } = new List<string>();
        public List<string> KnownStandards { get; set; } = new List<string>();
        
        // Metadata & Naming configs can be added here
        public Dictionary<string, string> NamingRules { get; set; } = new Dictionary<string, string>();
        
        public static InspectorConfiguration LoadDefault()
        {
            // In a real scenario, this would deserialize from a config.json file
            return new InspectorConfiguration
            {
                RequiredDirectories = new List<string> { "docs/standards/SAO", "docs/standards/SEG", "docs/standards/SGM", "docs/standards/KPM" },
                RequiredFiles = new List<string> { "CONSTITUTION.md", "README.md" },
                KnownStandards = new List<string> { "SAO", "SEG", "SGM", "KPM" }
            };
        }
    }
}
