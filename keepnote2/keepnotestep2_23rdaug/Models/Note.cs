namespace KeepNote_Step2.Models
{
    public class Note
    {
        public int NoteId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public bool Status { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}
