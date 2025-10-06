using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace librarys
{
    public partial class UpdateBookForm : Form
    {
        private Form previousForm;

        public UpdateBookForm(Form previous)
        {
            InitializeComponent();
            previousForm = previous;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            previousForm.Show();
            this.Hide();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string isbn = textBoxISBN.Text.Trim();
            string bookName = textBoxBookName.Text.Trim();
            string author = textBoxAuthor.Text.Trim();
            string edition = textBoxEdition.Text.Trim();
            string publishedDate = dateTimePickerPublishedDate.Value.ToString("yyyy-MM-dd");
            string description = richTextBoxDescription.Text.Trim();

            if (string.IsNullOrWhiteSpace(isbn) || string.IsNullOrWhiteSpace(bookName))
            {
                MessageBox.Show("ISBN and Book Name are required.");
                return;
            }

            UpdateBookInLibrary(bookName, isbn, author, publishedDate, edition, description);
            MessageBox.Show("Book updated successfully!");
        }

        private void UpdateBookInLibrary(string bookName, string isbn, string author, string publishedDate, string edition, string description)
        {
            string filePath = "C:\\Users\\MIKIMARE\\source\\repos\\librarys\\librarys\\books.txt";
            var lines = File.ReadAllLines(filePath).ToList();

            var bookEntryIndex = lines.FindIndex(line =>
            {
                var fields = line.Split(',');
                return fields.Length > 1 && fields[0].Equals(bookName, StringComparison.OrdinalIgnoreCase) && fields[1].Equals(isbn, StringComparison.OrdinalIgnoreCase);
            });

            if (bookEntryIndex != -1)
            {
                lines[bookEntryIndex] = $"{bookName},{isbn},{author},{publishedDate},{edition},{description}";
                File.WriteAllLines(filePath, lines);
            }
        }
    }
}
