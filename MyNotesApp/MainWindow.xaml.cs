using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


using MyNotesApp.Models;
using MyNotesApp.Services;

namespace MyNotesApp
{
    public partial class MainWindow : Window
    {
        private NoteService noteService = new NoteService();

        public MainWindow()
        {
            InitializeComponent();
            RefreshNotes();
        }

        private void AddNote_Click(object sender, RoutedEventArgs e)
        {
            var note = new Note
            {
                Title = TitleBox.Text,
                Content = ContentBox.Text
            };

            noteService.AddNote(note);
            RefreshNotes();

            TitleBox.Clear();
            ContentBox.Clear();
        }

        private void DeleteNote_Click(object sender, RoutedEventArgs e)
        {
            if (NotesList.SelectedItem != null)
            {
                var selectedNote = (Note)NotesList.SelectedItem;
                noteService.DeleteNote(selectedNote);
                RefreshNotes();
            }
        }

        private void RefreshNotes()
        {
            NotesList.ItemsSource = null;
            NotesList.ItemsSource = noteService.GetNotes();
        }
    }
}
