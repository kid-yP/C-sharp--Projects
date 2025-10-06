using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace librarys
{
    public partial class ReturnBook : Form
    {
        private Label labelBookID;
        private Label labelBookTitle;
        private Label labelReturnDate;
        private TextBox textBoxBookID;
        private TextBox textBoxBookTitle;
        private DateTimePicker dateTimePickerReturnDate;
        private Button buttonReturn;
        private Button buttonCancel;

        private Form previousForm;

        public ReturnBook(Form previous)
        {
            InitializeComponent();
            previousForm = previous; // Store reference to the previous form
        }

        private void ButtonReturn_Click(object sender, EventArgs e)
        {
            string bookID = textBoxBookID.Text.Trim();
            string bookTitle = textBoxBookTitle.Text.Trim();

            if (string.IsNullOrWhiteSpace(bookID) || string.IsNullOrWhiteSpace(bookTitle))
            {
                MessageBox.Show("Book ID and Title are required.");
                return;
            }

            // Logic to return the book
            if (ReturnBookToLibrary(bookID, bookTitle))
            {
                MessageBox.Show("Book returned successfully!");
            }
            else
            {
                MessageBox.Show("Error: Book not found in borrowed list.");
            }
        }

        private bool ReturnBookToLibrary(string bookID, string bookTitle)
        {
            string borrowedFilePath = "C:\\Users\\MIKIMARE\\source\\repos\\librarys\\librarys\\borrowed_books.txt";
            string booksFilePath = "C:\\Users\\MIKIMARE\\source\\repos\\librarys\\librarys\\books.txt";

            // Check if the borrowed books file exists
            if (!File.Exists(borrowedFilePath))
            {
                MessageBox.Show("Borrowed books file not found.");
                return false;
            }

            // Read all lines from the borrowed books file
            var borrowedLines = File.ReadAllLines(borrowedFilePath).ToList();

            // Find the book entry to return
            var bookEntry = borrowedLines.FirstOrDefault(line =>
            {
                var fields = line.Split(',');
                return fields.Length > 2 && fields[1].Equals(bookID, StringComparison.OrdinalIgnoreCase) && fields[0].Equals(bookTitle, StringComparison.OrdinalIgnoreCase);
            });

            if (bookEntry != null)
            {
                // Append the book entry back to the books file
                using (StreamWriter writer = new StreamWriter(booksFilePath, true))
                {
                    writer.WriteLine(bookEntry);
                }

                // Remove the book from the borrowed list
                borrowedLines.Remove(bookEntry);

                // Write the remaining borrowed books back to the file
                File.WriteAllLines(borrowedFilePath, borrowedLines);

                return true; // Successfully returned the book
            }

            return false; // Book entry not found
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            previousForm.Show();
            this.Hide();
        }

        private void ReturnBook_Load(object sender, EventArgs e)
        {
            // Optional initialization code
        }
    }
}
