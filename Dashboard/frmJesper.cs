using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard
{
    public partial class frmNotes : Form
    {
        DataTable notes = new DataTable();
        bool editing = false;
        public frmNotes()
        {
            InitializeComponent();
        }

        private void frmJesper_Load(object sender, EventArgs e)
        {
            notes.Columns.Add("Title");
            notes.Columns.Add("Note");

            PreviousNotes.DataSource= notes;

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if(editing)
            {
                notes.Rows[PreviousNotes.CurrentCell.RowIndex]["Title"] = TitleBox.Text;
                notes.Rows[PreviousNotes.CurrentCell.RowIndex]["Note"] = NotesBox.Text;
            }
            else
            {
                notes.Rows.Add(TitleBox.Text, NotesBox.Text);
                
            }
            TitleBox.Text = "";
            NotesBox.Text = "";
            editing = false;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            TitleBox.Text = notes.Rows[PreviousNotes.CurrentCell.RowIndex].ItemArray[0].ToString();
            NotesBox.Text = notes.Rows[PreviousNotes.CurrentCell.RowIndex].ItemArray[1].ToString();
            editing= true;
        }

        private void NewNoteButton_Click(object sender, EventArgs e)
        {
            TitleBox.Text = "";
            NotesBox.Text = "";
        }

        private void DeleteButton_Click(object sender, EventArgs a)
        {
            try
            {
                notes.Rows[PreviousNotes.CurrentCell.RowIndex].Delete();
            }
            catch(Exception e) { Console.WriteLine("Not a valid note");
            }
        }

        private void PreviousNotes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TitleBox.Text = notes.Rows[PreviousNotes.CurrentCell.RowIndex].ItemArray[0].ToString();
            NotesBox.Text = notes.Rows[PreviousNotes.CurrentCell.RowIndex].ItemArray[1].ToString();
            editing = true;
        }
    }
}
