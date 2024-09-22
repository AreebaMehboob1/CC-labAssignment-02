using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RegexLabTasks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Lab Task 2: Regex for scientific notation numbers
        private void ApplyScientificNotationRegex(DataGridView dataGridView)
        {
            string pattern = @"^\d+e[-+]?\d+$";
            Regex regex = new Regex(pattern);

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (regex.IsMatch(cell.Value?.ToString() ?? ""))
                    {
                        cell.Style.BackColor = System.Drawing.Color.Green; // Highlight cell
                    }
                }
            }
        }

        private void btnScientificNotation_Click(object sender, EventArgs e)
        {
            ApplyScientificNotationRegex(dataGridView1); // Assuming dataGridView1 contains the data
        }
    }
}
