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

        // Lab Task 1: Floating point regex for numbers with length <= 6
        private void ApplyFloatingPointRegex(DataGridView dataGridView)
        {
            string pattern = @"^[-+]?\d{0,4}(\.\d{1,5})?$";
            Regex regex = new Regex(pattern);

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (regex.IsMatch(cell.Value?.ToString() ?? ""))
                    {
                        cell.Style.BackColor = System.Drawing.Color.Yellow; // Highlight cell
                    }
                }
            }
        }

        private void btnFloatingPoint_Click(object sender, EventArgs e)
        {
            ApplyFloatingPointRegex(dataGridView1); // Assuming dataGridView1 contains the data
        }
    }
}
