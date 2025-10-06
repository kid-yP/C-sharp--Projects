using System;
using System.Windows.Forms;

namespace librarys
{
    partial class ReturnBook
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.labelBookID = new System.Windows.Forms.Label();
            this.textBoxBookID = new System.Windows.Forms.TextBox();
            this.labelBookTitle = new System.Windows.Forms.Label();
            this.textBoxBookTitle = new System.Windows.Forms.TextBox();
            this.labelReturnDate = new System.Windows.Forms.Label();
            this.dateTimePickerReturnDate = new System.Windows.Forms.DateTimePicker();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelBookID
            // 
            this.labelBookID.AutoSize = true;
            this.labelBookID.Location = new System.Drawing.Point(43, 67);
            this.labelBookID.Name = "labelBookID";
            this.labelBookID.Size = new System.Drawing.Size(49, 13);
            this.labelBookID.TabIndex = 4;
            this.labelBookID.Text = "Book ID:";
            // 
            // textBoxBookID
            // 
            this.textBoxBookID.Location = new System.Drawing.Point(133, 64);
            this.textBoxBookID.Name = "textBoxBookID";
            this.textBoxBookID.Size = new System.Drawing.Size(200, 20);
            this.textBoxBookID.TabIndex = 5;
            // 
            // labelBookTitle
            // 
            this.labelBookTitle.AutoSize = true;
            this.labelBookTitle.Location = new System.Drawing.Point(43, 97);
            this.labelBookTitle.Name = "labelBookTitle";
            this.labelBookTitle.Size = new System.Drawing.Size(58, 13);
            this.labelBookTitle.TabIndex = 6;
            this.labelBookTitle.Text = "Book Title:";
            // 
            // textBoxBookTitle
            // 
            this.textBoxBookTitle.Location = new System.Drawing.Point(133, 94);
            this.textBoxBookTitle.Name = "textBoxBookTitle";
            this.textBoxBookTitle.Size = new System.Drawing.Size(200, 20);
            this.textBoxBookTitle.TabIndex = 7;
            // 
            // labelReturnDate
            // 
            this.labelReturnDate.AutoSize = true;
            this.labelReturnDate.Location = new System.Drawing.Point(43, 127);
            this.labelReturnDate.Name = "labelReturnDate";
            this.labelReturnDate.Size = new System.Drawing.Size(68, 13);
            this.labelReturnDate.TabIndex = 8;
            this.labelReturnDate.Text = "Return Date:";
            // 
            // dateTimePickerReturnDate
            // 
            this.dateTimePickerReturnDate.Location = new System.Drawing.Point(133, 124);
            this.dateTimePickerReturnDate.Name = "dateTimePickerReturnDate";
            this.dateTimePickerReturnDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerReturnDate.TabIndex = 9;
            this.dateTimePickerReturnDate.Value = new System.DateTime(2025, 1, 16, 13, 24, 30, 764);
            // 
            // buttonReturn
            // 
            this.buttonReturn.Location = new System.Drawing.Point(133, 177);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(75, 23);
            this.buttonReturn.TabIndex = 10;
            this.buttonReturn.Text = "Return";
            this.buttonReturn.Click += new System.EventHandler(this.ButtonReturn_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(258, 177);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "back";
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // ReturnBook
            // 
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(400, 250);
            this.Controls.Add(this.labelBookID);
            this.Controls.Add(this.textBoxBookID);
            this.Controls.Add(this.labelBookTitle);
            this.Controls.Add(this.textBoxBookTitle);
            this.Controls.Add(this.labelReturnDate);
            this.Controls.Add(this.dateTimePickerReturnDate);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.buttonCancel);
            this.Name = "ReturnBook";
            this.Text = "Return Book";
            this.Load += new System.EventHandler(this.ReturnBook_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
