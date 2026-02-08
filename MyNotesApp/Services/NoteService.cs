using System;
using System.Collections.Generic;
using System.Text;

using MyNotesApp.Models;
using System.Collections.Generic;

namespace MyNotesApp.Services
{
    public class NoteService
    {
        private List<Note> notes = new List<Note>();

        public void AddNote(Note note)
        {
            notes.Add(note);
        }

        public List<Note> GetNotes()
        {
            return notes;
        }

        public void DeleteNote(Note note)
        {
            notes.Remove(note);
        }
    }
}
