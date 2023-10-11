using KeepNote_Step2.Context;
using KeepNote_Step2.IRepo;
using KeepNote_Step2.Models;

namespace KeepNote_Step2.Repo
{
    public class NoteRepository : INoteRepository
    {
        private NoteDBContext _context;
        public NoteRepository(NoteDBContext context)
        {

            _context = context;

        }
        public int AddNote(Note note)
        {
            _context.Notes.Add(note);
            _context.SaveChanges();
            return 1;

        }

        public int Delete(int id)
        {
            var note = _context.Notes.FirstOrDefault(x => x.NoteId == id);
            if (note != null)
            {
                _context.Notes.Remove(note);
                _context.SaveChanges();
                return 1;
            }
            return 0;
        }

        public List<Note> GetNotes()
        {
            return _context.Notes.ToList();
        }

        public Note GetNoteById(int id)
        {
            return _context.Notes.FirstOrDefault(x => x.NoteId == id);

        }

        public int EditNote(int id, Note note)
        {
            return 1;
        }


    }
}