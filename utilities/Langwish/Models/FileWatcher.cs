using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Langwish.Models
{
    public class FileWatcher
    {
        public FileWatcher(){
            this.LangwishWordInFiles = new HashSet<LangwishWordInFile>();
        }
        [Key]
        public long Id { get; set; }
        public long FolderWatcherId { get; set; }
        public FolderWatcher FolderWatcher { get; set; }
        public string FileName { get; set; }
        public string FileNameWithoutExtension { get; set; }
        public string FileNameWithFullPath { get; set; }

        public virtual ICollection<LangwishWordInFile> LangwishWordInFiles { get; set; }

    }
}