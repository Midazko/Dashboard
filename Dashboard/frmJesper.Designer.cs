namespace Dashboard
{
    partial class frmNotes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TitleBox = new System.Windows.Forms.TextBox();
            this.NotesBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PreviousNotes = new System.Windows.Forms.DataGridView();
            this.EditButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.NewNoteButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PreviousNotes)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleBox
            // 
            this.TitleBox.Location = new System.Drawing.Point(745, 113);
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.Size = new System.Drawing.Size(496, 23);
            this.TitleBox.TabIndex = 0;
            // 
            // NotesBox
            // 
            this.NotesBox.Location = new System.Drawing.Point(745, 182);
            this.NotesBox.Multiline = true;
            this.NotesBox.Name = "NotesBox";
            this.NotesBox.Size = new System.Drawing.Size(496, 459);
            this.NotesBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.LightSalmon;
            this.label1.Location = new System.Drawing.Point(745, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(496, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Title:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.LightSalmon;
            this.label2.Location = new System.Drawing.Point(745, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(496, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Notes:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PreviousNotes
            // 
            this.PreviousNotes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PreviousNotes.BackgroundColor = System.Drawing.Color.White;
            this.PreviousNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PreviousNotes.Location = new System.Drawing.Point(12, 182);
            this.PreviousNotes.Name = "PreviousNotes";
            this.PreviousNotes.RowTemplate.Height = 25;
            this.PreviousNotes.Size = new System.Drawing.Size(463, 459);
            this.PreviousNotes.TabIndex = 4;
            this.PreviousNotes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PreviousNotes_CellDoubleClick);
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.Color.White;
            this.EditButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EditButton.ForeColor = System.Drawing.Color.LightSalmon;
            this.EditButton.Location = new System.Drawing.Point(481, 538);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(115, 46);
            this.EditButton.TabIndex = 5;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.White;
            this.DeleteButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeleteButton.ForeColor = System.Drawing.Color.LightSalmon;
            this.DeleteButton.Location = new System.Drawing.Point(602, 538);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(115, 46);
            this.DeleteButton.TabIndex = 6;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // NewNoteButton
            // 
            this.NewNoteButton.BackColor = System.Drawing.Color.White;
            this.NewNoteButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NewNoteButton.ForeColor = System.Drawing.Color.LightSalmon;
            this.NewNoteButton.Location = new System.Drawing.Point(602, 590);
            this.NewNoteButton.Name = "NewNoteButton";
            this.NewNoteButton.Size = new System.Drawing.Size(115, 46);
            this.NewNoteButton.TabIndex = 7;
            this.NewNoteButton.Text = "New Note";
            this.NewNoteButton.UseVisualStyleBackColor = false;
            this.NewNoteButton.Click += new System.EventHandler(this.NewNoteButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.White;
            this.SaveButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SaveButton.ForeColor = System.Drawing.Color.LightSalmon;
            this.SaveButton.Location = new System.Drawing.Point(481, 590);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(115, 46);
            this.SaveButton.TabIndex = 8;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // frmNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1253, 653);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.NewNoteButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.PreviousNotes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NotesBox);
            this.Controls.Add(this.TitleBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNotes";
            this.Text = "frmNotes";
            this.Load += new System.EventHandler(this.frmJesper_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PreviousNotes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TitleBox;
        private TextBox NotesBox;
        private Label label1;
        private Label label2;
        private DataGridView PreviousNotes;
        private Button EditButton;
        private Button DeleteButton;
        private Button NewNoteButton;
        private Button SaveButton;
    }
}