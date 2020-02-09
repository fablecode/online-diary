using System;

namespace onlinediary.core.Models.Db
{
    public partial class DiaryEntry
    {
        public long Id { get; set; }
        public long DiaryId { get; set; }
        public DateTime EntryDate { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime DateChanged { get; set; }

        public virtual Diary Diary { get; set; }
    }
}
