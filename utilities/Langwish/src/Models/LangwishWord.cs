using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Langwish.Models
{
    public class LangwishWord
    {
        [Key]
        public long Id { get; set; }

        public string TranslateText { get; set; }

        public virtual ICollection<LangwishWordInFile> LangwishWordsInFiles { get; set; }
    }
}