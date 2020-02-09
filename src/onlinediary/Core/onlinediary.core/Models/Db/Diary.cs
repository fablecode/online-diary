using System.Collections.Generic;

namespace onlinediary.core.Models.Db
{
    public partial class Diary
    {
        public Diary()
        {
            Contact = new HashSet<Contact>();
            DiaryEntry = new HashSet<DiaryEntry>();
            DiaryEvent = new HashSet<DiaryEvent>();
        }

        public long Id { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual ICollection<Contact> Contact { get; set; }
        public virtual ICollection<DiaryEntry> DiaryEntry { get; set; }
        public virtual ICollection<DiaryEvent> DiaryEvent { get; set; }
    }
}
