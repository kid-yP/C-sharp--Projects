using System.Windows.Forms;

namespace librarys
{
    partial class UpdateBookForm
    {
        private System.ComponentModel.IContainer components = null;

        private Label labelBookName;
        private TextBox textBoxBookName;
        private Label labelISBN;
        private TextBox textBoxISBN;
        private Label labelAuthor;
        private TextBox textBoxAuthor;
        private Label labelPublishedDate;
        private DateTimePicker dateTimePickerPublishedDate;
        private Label labelEdition;
        private TextBox textBoxEdition;
        private Label labelDescription;
        private RichTextBox richTextBoxDescription;
        private Button buttonUpdate;
        private Button buttonBack;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.labelBookName = new Label();
            this.textBoxBookName = new TextBox();
            this.labelISBN = new Label();
            this.textBoxISBN = new TextBox();
            this.labelAuthor = new Label();
            this.textBoxAuthor = new TextBox();
            this.labelPublishedDate = new Label();
            this.dateTimePickerPublishedDate = new DateTimePicker();
            this.labelEdition = new Label();
            this.textBoxEdition = new TextBox();
            this.labelDescription = new Label();
            this.richTextBoxDescription = new RichTextBox();
            this.buttonUpdate = new Button();
            this.buttonBack = new Button();
            this.SuspendLayout();

            // 
            // labelBookName
            // 
            this.labelBookName.AutoSize = true;
            this.labelBookName.Location = new System.Drawing.Point(20, 20);
            this.labelBookName.Name = "labelBookName";
            this.labelBookName.Size = new System.Drawing.Size(70, 13);
            this.labelBookName.TabIndex = 0;
            this.labelBookName.Text = "Book Name:";

            // 
            // textBoxBookName
            // 
            this.textBoxBookName.Location = new System.Drawing.Point(120, 20);
            this.textBoxBookName.Name = "textBoxBookName";
            this.textBoxBookName.Size = new System.Drawing.Size(200, 20);
            this.textBoxBookName.TabIndex = 1;

            // 
            // labelISBN
            // 
            this.labelISBN.AutoSize = true;
            this.labelISBN.Location = new System.Drawing.Point(20, 60);
            this.labelISBN.Name = "labelISBN";
            this.labelISBN.Size = new System.Drawing.Size(38, 13);
            this.labelISBN.TabIndex = 2;
            this.labelISBN.Text = "ISBN:";

            // 
            // textBoxISBN
            // 
            this.textBoxISBN.Location = new System.Drawing.Point(120, 60);
            this.textBoxISBN.Name = "textBoxISBN";
            this.textBoxISBN.Size = new System.Drawing.Size(200, 20);
            this.textBoxISBN.TabIndex = 3;

            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Location = new System.Drawing.Point(20, 100);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(43, 13);
            this.labelAuthor.TabIndex = 4;
            this.labelAuthor.Text = "Author:";

            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Location = new System.Drawing.Point(120, 100);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.Size = new System.Drawing.Size(200, 20);
            this.textBoxAuthor.TabIndex = 5;

            // 
            // labelPublishedDate
            // 
            this.labelPublishedDate.AutoSize = true;
            this.labelPublishedDate.Location = new System.Drawing.Point(20, 140);
            this.labelPublishedDate.Name = "labelPublishedDate";
            this.labelPublishedDate.Size = new System.Drawing.Size(90, 13);
            this.labelPublishedDate.TabIndex = 6;
            this.labelPublishedDate.Text = "Published Date:";

            // 
            // dateTimePickerPublishedDate
            // 
            this.dateTimePickerPublishedDate.Location = new System.Drawing.Point(120, 140);
            this.dateTimePickerPublishedDate.Name = "dateTimePickerPublishedDate";
            this.dateTimePickerPublishedDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerPublishedDate.TabIndex = 7;

            // 
            // labelEdition
            // 
            this.labelEdition.AutoSize = true;
            this.labelEdition.Location = new System.Drawing.Point(20, 180);
            this.labelEdition.Name = "labelEdition";
            this.labelEdition.Size = new System.Drawing.Size(47, 13);
            this.labelEdition.TabIndex = 8;
            this.labelEdition.Text = "Edition:";

            // 
            // textBoxEdition
            // 
            this.textBoxEdition.Location = new System.Drawing.Point(120, 180);
            this.textBoxEdition.Name = "textBoxEdition";
            this.textBoxEdition.Size = new System.Drawing.Size(200, 20);
            this.textBoxEdition.TabIndex = 9;

            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(20, 220);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(63, 13);
            this.labelDescription.TabIndex = 10;
            this.labelDescription.Text = "Description:";

            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.Location = new System.Drawing.Point(120, 220);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.Size = new System.Drawing.Size(200, 80);
            this.richTextBoxDescription.TabIndex = 11;
            this.richTextBoxDescription.Text = "";

            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(120, 320);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 12;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);

            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(245, 320);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 13;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);

            // 
            // UpdateBookForm
            // 
            this.ClientSize = new System.Drawing.Size(350, 370);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.richTextBoxDescription);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.textBoxEdition);
            this.Controls.Add(this.labelEdition);
            this.Controls.Add(this.dateTimePickerPublishedDate);
            this.Controls.Add(this.labelPublishedDate);
            this.Controls.Add(this.textBoxAuthor);
            this.Controls.Add(this.labelAuthor);
            this.Controls.Add(this.textBoxISBN);
            this.Controls.Add(this.labelISBN);
            this.Controls.Add(this.textBoxBookName);
            this.Controls.Add(this.labelBookName);
            this.Name = "UpdateBookForm";
            this.Text = "Update Book";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
