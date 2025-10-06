using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace librarys
{
    public partial class searchBooks : Form
    {
        private Form previousForm;

        public searchBooks(Form previous)
        {
            InitializeComponent();
            previousForm = previous; // Store reference to the previous form
        }

        private void comboBoxSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Optional: You can add logic here if you want to change the UI based on the selected search criteria.
        }

        private void searchBooks_Load(object sender, EventArgs e)
        {
            // Optional: Any initialization code can go here
        }

        private void buttonBack_Click_1(object sender, EventArgs e)
        {
            previousForm.Show();
            this.Hide(); // Optionally hide the current form instead of closing it
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string searchValue = textBoxSearchValue.Text.Trim();
            string searchBy = comboBoxSearchBy.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(searchValue) || string.IsNullOrWhiteSpace(searchBy))
            {
                MessageBox.Show("Please enter a search value and select a search criteria.");
                return;
            }

            listBoxResults.Items.Clear(); // Clear previous results

            string filePath = "C:\\Users\\MIKIMARE\\source\\repos\\librarys\\librarys\\books.txt";

            // Check if the books file exists
            if (!File.Exists(filePath))
            {
                MessageBox.Show("Books file not found.");
                return;
            }

            // Read all lines from the books file
            var lines = File.ReadAllLines(filePath);

            // Perform the search based on the selected criteria
            var results = lines.Where(line =>
            {
                var fields = line.Split(',');
                switch (searchBy)
                {
                    case "Book Name":
                        return fields[0].IndexOf(searchValue, StringComparison.OrdinalIgnoreCase) >= 0;
                    case "ISBN":
                        return fields[1].IndexOf(searchValue, StringComparison.OrdinalIgnoreCase) >= 0;
                    case "Author":
                        return fields[2].IndexOf(searchValue, StringComparison.OrdinalIgnoreCase) >= 0;
                    case "Published Date":
                        return fields[3].IndexOf(searchValue, StringComparison.OrdinalIgnoreCase) >= 0;
                    case "Edition":
                        return fields[4].IndexOf(searchValue, StringComparison.OrdinalIgnoreCase) >= 0;
                    case "Description":
                        return fields[5].IndexOf(searchValue, StringComparison.OrdinalIgnoreCase) >= 0;
                    default:
                        return false;
                }
            }).ToList();

            // Display results in the list box
            if (results.Any())
            {
                foreach (var result in results)
                {
                    var fields = result.Split(',');
                    listBoxResults.Items.Add($"{fields[0]} (ISBN: {fields[1]}, Author: {fields[2]}, Published: {fields[3]}, Edition: {fields[4]})"); // Customize display format as needed
                }
            }
            else
            {
                MessageBox.Show("No results found.");
            }
        }

    }
}
