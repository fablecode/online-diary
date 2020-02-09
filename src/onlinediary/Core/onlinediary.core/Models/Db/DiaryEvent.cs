using System;

namespace onlinediary.core.Models.Db
{
    public partial class DiaryEvent
    {
        public long Id { get; set; }
        public long DiaryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime EventDate { get; set; }
        public int EventDuration { get; set; }

        public virtual Diary Diary { get; set; }
    }
}
