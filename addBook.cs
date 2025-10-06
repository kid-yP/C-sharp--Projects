using System;
using System.IO;
using System.Windows.Forms;

namespace librarys
{
    public partial class addBook : Form
    {
        private Form previousForm;

        public addBook(Form previous)
        {
            InitializeComponent();
            previousForm = previous; // Store reference to the previous form
        }

        public addBook()
        {
            InitializeComponent();
        }

        private void addBook_Load(object sender, EventArgs e)
        {
            // Optional initialization code
        }

        private void button2_Click(object sender, EventArgs e)
        {
            previousForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Gather book information from text boxes
            string bookName = textBox1.Text.Trim();
            string isbn = textBox2.Text.Trim();
            string author = textBox3.Text.Trim();
            string publishedDate = dateTimePicker1.Value.ToString("yyyy-MM-dd"); // Format date
            string edition = textBox5.Text.Trim();
            string description = richTextBox1.Text.Trim();

            // Validate input
            if (string.IsNullOrWhiteSpace(bookName) || string.IsNullOrWhiteSpace(isbn))
            {
                MessageBox.Show("Book name and ISBN are required.");
                return;
            }

            // Create a book entry
            string bookEntry = $"{bookName},{isbn},{author},{publishedDate},{edition},{description}";

            // Save to text file
            SaveBookToFile(bookEntry);
        }

        private void SaveBookToFile(string bookEntry)
        {
            // Path to the books file
            string filePath = "C:\\Users\\MIKIMARE\\source\\repos\\librarys\\librarys\\books.txt";

            try
            {
                // Append the book entry to the file
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine(bookEntry);
                }
                MessageBox.Show("Book added successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving book: {ex.Message}");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
