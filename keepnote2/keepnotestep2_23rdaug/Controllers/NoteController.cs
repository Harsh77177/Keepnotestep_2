using KeepNote_Step2.IRepo;
using KeepNote_Step2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KeepNote_Step2.Controllers
{
    public class NoteController : Controller
    {
        private INoteRepository _repo;
        public NoteController(INoteRepository repo)
        {
            _repo = repo;
        }

        // GET: NoteController
        public ActionResult Index()
        {
            List<Note> notes = _repo.GetNotes();
            // in mvc , when ypou want to send some value from controlle
            // to view we use viewbag , viewdata 

            return View(notes);
        }

        // GET: NoteController/Details/5
        public ActionResult Details(int id)
        {
            return View(_repo.GetNoteById(id));
        }

        // GET: NoteController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NoteController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Note note)
        {
            try
            {
                _repo.AddNote(note);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: NoteController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_repo.GetNoteById(id));
        }

        // POST: NoteController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: NoteController/Delete/5
        public ActionResult Delete(int id)
        {

            return View(_repo.GetNoteById(id));
        }

        // POST: NoteController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Note note)
        {
            try
            {
                _repo.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}