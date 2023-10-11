using KeepNote_Step2.Models;
namespace KeepNote_Step2.IRepo
{
    public interface INoteRepository
    {
        List<Note> GetNotes();
        int AddNote(Note note);
        int Delete(int id);
        Note GetNoteById(int id);
        int EditNote(int id, Note note);
    }
}
