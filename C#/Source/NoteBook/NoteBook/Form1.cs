using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteBook
{
    public partial class Form1 : Form
    {
        private Book nb;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            nb = new Book();
            update();
        }

        private void addNoteButton_Click(object sender, EventArgs e)
        {
            nb.addNote();
            update();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            nb.updateSelectedNoteTitle(noteTitleTextBox.Text);
            update();
        }

        private void NoteTextBox_TextChanged(object sender, EventArgs e)
        {
            nb.updateSelectedNote(noteTextBox.Text);
            update(); 
        }

        private void update()
        {
            nb.update();
            createdLabel.Text = nb.getSelectedNoteCreated();
            modifiedLabel.Text = nb.getSelectedNoteModified();
            noteTitleTextBox.Text = nb.getSelectedNoteTitle();
            noteTextBox.Text = nb.getSelectedNote();
            notesListBox.Items.Clear();
            for (int i = 0; i < nb.getNumOfNotes(); i++)
            {
                notesListBox.Items.Add(nb.getTitleOfNoteX(i));
            }
        }

        private void notesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Clicked");
            nb.setSelectedNote(notesListBox.SelectedIndex);
            update();
        }
    }

    class Book
    {
        private Note[] nb;
        int selectedNote = -1;

        public Book()
        {
            nb = new Note[1000];
            try
            {
                string[] lines = System.IO.File.ReadAllLines("Save.txt");
                for (int i = 0; i < lines.Length; i++)
                {
                    if (i % 4 == 0)
                    {
                        int j = i / 4;
                        nb[j] = new Note();
                        nb[j].updateTitle(lines[i]);
                        nb[j].updateText(lines[i + 3].Replace("<newLine>", Environment.NewLine));
                        nb[j].setModified(DateTime.Parse(lines[i + 2]));
                        nb[j].setCreated(DateTime.Parse(lines[i + 1]));
                    }
                }
                selectedNote = 0;
            }
            catch {}
        }

        public void addNote()
        {
            for (int i = 0; i < nb.Length; i++)
            {
                if (nb[i] == null)
                {
                    nb[i] = new Note();
                    selectedNote = i;
                    update();
                    return;
                }
            }
        }

        public void update()
        {
            save();
        }

        public void save()
        {
            int nbSize = 0;
            for (int i = 0; i < nb.Length; i++)
            {
                if (nb[i] != null)
                {
                    nbSize++;
                }
            }
            string[] notes = new String[nbSize * 4];
            for (int i = 0; i < nbSize; i++)
            {
                notes[i * 4] = nb[i].getTitle();
                notes[(i * 4) + 1] = nb[i].getCreated().ToString();
                notes[(i * 4) + 2] = nb[i].getModified().ToString();
                notes[(i * 4) + 3] = nb[i].getText();
                notes[(i * 4) + 3] = notes[(i * 4) + 3].Replace(Environment.NewLine, "<newLine>");
            }
            System.IO.File.WriteAllLines("Save.txt", notes);
        }

        public string getSelectedNoteCreated()
        {
            return "Created: " + nb[selectedNote].getCreated();
        }

        public string getSelectedNoteModified()
        {
            return "Modified: " + nb[selectedNote].getModified();
        }

        public string getSelectedNoteTitle()
        {
            return nb[selectedNote].getTitle();
        }

        public int getNumOfNotes()
        {
            for (int i = 0; i < nb.Length; i++)
            {
                if (nb[i] == null)
                {
                    return i;
                }
            }
            return nb.Length;
        }

        public string getTitleOfNoteX(int x)
        {
            return nb[x].getTitle();
        }

        public void setSelectedNote(int index)
        {
            selectedNote = index;
        }

        public void updateSelectedNoteTitle(string title)
        {
            nb[selectedNote].updateTitle(title);
        }

        public void updateSelectedNote(string note)
        {
            nb[selectedNote].updateText(note);
        }

        public string getSelectedNote()
        {
            return nb[selectedNote].getText();
        }
    }

    class Note
    {
        private string title;
        private DateTime created;
        private DateTime modified;
        private string text;
        private bool deleted;

        public Note()
        {
            title = "New Note";
            created = DateTime.Now;
            modified = DateTime.Now;
            text = "";
            deleted = false;
        }

        public void updateTitle(string title)
        {
            this.title = title;
        }

        public void updateText(string text)
        {
            this.text = text;
            modified = DateTime.Now;
        }

        public void setCreated(DateTime created)
        {
            this.created = created;
        }

        public void setModified(DateTime modified)
        {
            this.modified = modified;
        }

        public DateTime getCreated()
        {
            return created;
        }

        public DateTime getModified()
        {
            return modified;
        }

        public string getTitle()
        {
            return title;
        }

        public string getText()
        {
            return text;
        }
        
    }
}
