using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace librarys
{
    public partial class BorrowBook : Form
    {
        private Form previousForm;

        public BorrowBook(Form previous)
        {
            InitializeComponent();
            previousForm = previous; // Store reference to the previous form
        }

        private void ButtonBorrow_Click(object sender, EventArgs e)
        {
            string bookID = textBoxBookID.Text.Trim();
            string bookTitle = textBoxBookTitle.Text.Trim();

            // Check if the book is available in the books.txt file
            if (!IsBookAvailable(bookID, bookTitle))
            {
                MessageBox.Show("Book is not available for borrowing or details do not match.");
                return;
            }

            // Set the due date to one week from today
            dateTimePickerDueDate.Value = DateTime.Now.AddDays(7);

            // Move the book to the borrowed_books.txt file
            MoveBookToBorrowedFile(bookID, bookTitle);

            MessageBox.Show($"Book borrowed successfully!\n" +
                            $"Borrow Date: {DateTime.Now.ToShortDateString()}\n" +
                            $"Due Date: {dateTimePickerDueDate.Value.ToShortDateString()}");
        }

        private bool IsBookAvailable(string bookID, string bookTitle)
        {
            string filePath = "C:\\Users\\MIKIMARE\\source\\repos\\librarys\\librarys\\books.txt";

            // Check if the file exists
            if (!File.Exists(filePath))
            {
                MessageBox.Show("Books file not found.");
                return false;
            }

            // Read the file and check for the book ID and title
            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines)
            {
                var fields = line.Split(',');
                if (fields.Length > 2 && fields[1].Equals(bookID, StringComparison.OrdinalIgnoreCase) && fields[0].Equals(bookTitle, StringComparison.OrdinalIgnoreCase))
                {
                    return true; // Book found with matching ID and title
                }
            }

            return false; // Book not found
        }

        private void MoveBookToBorrowedFile(string bookID, string bookTitle)
        {
            string booksFilePath = "C:\\Users\\MIKIMARE\\source\\repos\\librarys\\librarys\\books.txt";
            string borrowedFilePath = "C:\\Users\\MIKIMARE\\source\\repos\\librarys\\librarys\\borrowed_books.txt";

            // Check if the books file exists
            if (!File.Exists(booksFilePath))
            {
                MessageBox.Show("Books file not found.");
                return;
            }

            // Read all lines from the books file
            var lines = File.ReadAllLines(booksFilePath).ToList();

            // Find the book entry
            var bookEntry = lines.FirstOrDefault(line =>
            {
                var fields = line.Split(',');
                return fields.Length > 2 && fields[1].Equals(bookID, StringComparison.OrdinalIgnoreCase) && fields[0].Equals(bookTitle, StringComparison.OrdinalIgnoreCase);
            });

            if (bookEntry != null)
            {
                try
                {
                    // Append the book entry to the borrowed file
                    File.AppendAllText(borrowedFilePath, bookEntry + Environment.NewLine);

                    // Remove the book from the original list
                    lines.Remove(bookEntry);

                    // Write the remaining lines back to the books file
                    File.WriteAllLines(booksFilePath, lines);

                    MessageBox.Show("Book successfully borrowed and removed from available books.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error moving book: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Book entry not found in the list. Please check the details.");
            }
        }



        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            previousForm.Show();
            this.Hide();
        }
    }
}
