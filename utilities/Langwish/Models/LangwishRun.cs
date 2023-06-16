using System.ComponentModel.DataAnnotations;

namespace Langwish.Models
{
    public class LangwishRun
    {
        [Key]
        public long Id { get; set; }

        public string RunDuration { get; set; }
        public long FilesFoundCt { get; set; }
        public long FoldersFoundCt { get; set; }

        public long TranslatesFoundCt { get; set; }
        public long TranslatesFoundUniqueCt { get; set; }

    }
}