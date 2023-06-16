using System.ComponentModel.DataAnnotations;

namespace Langwish.Models
{
    public class LangwishWordInFile
    {
        public long LangwishWordId { get; set; }
        public LangwishWord LangwishWord { get; set; }

        public long FileWatcherId { get; set; }
        public FileWatcher FileWatcher { get; set; }
    }
}