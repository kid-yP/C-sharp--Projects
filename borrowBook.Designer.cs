using System.Windows.Forms;

namespace librarys
{
    partial class BorrowBook
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
            this.labelBookTitle = new System.Windows.Forms.Label();
            this.labelBorrowDate = new System.Windows.Forms.Label();
            this.labelDueDate = new System.Windows.Forms.Label();
            this.textBoxBookID = new System.Windows.Forms.TextBox();
            this.textBoxBookTitle = new System.Windows.Forms.TextBox();
            this.dateTimePickerBorrowDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDueDate = new System.Windows.Forms.DateTimePicker();
            this.buttonBorrow = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelBookID
            // 
            this.labelBookID.AutoSize = true;
            this.labelBookID.Location = new System.Drawing.Point(42, 61);
            this.labelBookID.Name = "labelBookID";
            this.labelBookID.Size = new System.Drawing.Size(63, 13);
            this.labelBookID.TabIndex = 4;
            this.labelBookID.Text = "Book ISBN:";
            // 
            // labelBookTitle
            // 
            this.labelBookTitle.AutoSize = true;
            this.labelBookTitle.Location = new System.Drawing.Point(42, 91);
            this.labelBookTitle.Name = "labelBookTitle";
            this.labelBookTitle.Size = new System.Drawing.Size(58, 13);
            this.labelBookTitle.TabIndex = 6;
            this.labelBookTitle.Text = "Book Title:";
            // 
            // labelBorrowDate
            // 
            this.labelBorrowDate.AutoSize = true;
            this.labelBorrowDate.Location = new System.Drawing.Point(42, 121);
            this.labelBorrowDate.Name = "labelBorrowDate";
            this.labelBorrowDate.Size = new System.Drawing.Size(69, 13);
            this.labelBorrowDate.TabIndex = 8;
            this.labelBorrowDate.Text = "Borrow Date:";
            // 
            // labelDueDate
            // 
            this.labelDueDate.AutoSize = true;
            this.labelDueDate.Location = new System.Drawing.Point(42, 151);
            this.labelDueDate.Name = "labelDueDate";
            this.labelDueDate.Size = new System.Drawing.Size(56, 13);
            this.labelDueDate.TabIndex = 10;
            this.labelDueDate.Text = "Due Date:";
            // 
            // textBoxBookID
            // 
            this.textBoxBookID.Location = new System.Drawing.Point(132, 61);
            this.textBoxBookID.Name = "textBoxBookID";
            this.textBoxBookID.Size = new System.Drawing.Size(100, 20);
            this.textBoxBookID.TabIndex = 5;
            // 
            // textBoxBookTitle
            // 
            this.textBoxBookTitle.Location = new System.Drawing.Point(132, 91);
            this.textBoxBookTitle.Name = "textBoxBookTitle";
            this.textBoxBookTitle.Size = new System.Drawing.Size(100, 20);
            this.textBoxBookTitle.TabIndex = 7;
            // 
            // dateTimePickerBorrowDate
            // 
            this.dateTimePickerBorrowDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerBorrowDate.Location = new System.Drawing.Point(132, 121);
            this.dateTimePickerBorrowDate.Name = "dateTimePickerBorrowDate";
            this.dateTimePickerBorrowDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerBorrowDate.TabIndex = 9;
            // 
            // dateTimePickerDueDate
            // 
            this.dateTimePickerDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDueDate.Location = new System.Drawing.Point(132, 151);
            this.dateTimePickerDueDate.Name = "dateTimePickerDueDate";
            this.dateTimePickerDueDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDueDate.TabIndex = 11;
            // 
            // buttonBorrow
            // 
            this.buttonBorrow.Location = new System.Drawing.Point(132, 191);
            this.buttonBorrow.Name = "buttonBorrow";
            this.buttonBorrow.Size = new System.Drawing.Size(75, 23);
            this.buttonBorrow.TabIndex = 12;
            this.buttonBorrow.Text = "Borrow";
            this.buttonBorrow.Click += new System.EventHandler(this.ButtonBorrow_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(257, 191);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 13;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // BorrowBook
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(400, 280);
            this.Controls.Add(this.labelBookID);
            this.Controls.Add(this.textBoxBookID);
            this.Controls.Add(this.labelBookTitle);
            this.Controls.Add(this.textBoxBookTitle);
            this.Controls.Add(this.labelBorrowDate);
            this.Controls.Add(this.dateTimePickerBorrowDate);
            this.Controls.Add(this.labelDueDate);
            this.Controls.Add(this.dateTimePickerDueDate);
            this.Controls.Add(this.buttonBorrow);
            this.Controls.Add(this.buttonCancel);
            this.Name = "BorrowBook";
            this.Text = "Borrow Book";
            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label labelBookID;
        private Label labelBookTitle;
        private Label labelBorrowDate;
        private Label labelDueDate;
        private TextBox textBoxBookID;
        private TextBox textBoxBookTitle;
        private DateTimePicker dateTimePickerBorrowDate;
        private DateTimePicker dateTimePickerDueDate;
        private Button buttonBorrow;
        private Button buttonCancel;
    }
}
