using System.ComponentModel.DataAnnotations;

namespace Langwish.Models
{
    public class FolderWatcher
    {

        [Key]
        public long Id { get; set; }

        [StringLength(1000)]
        public string FolderName { get; set; }

        public long FoundModulesCt { get; set; }
        public long FoundEntriesCt { get; set; }
        public long FoundEntriesUniqueCt { get; set; }

        [StringLength(800)]
        public string ProjectRootPath { get; set; }
    }
}