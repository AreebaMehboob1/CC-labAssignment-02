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

        // Lab Task 3: Regex for words starting with 't' or 'm'
        private void ApplyWordsStartingWithTandMRegex(DataGridView dataGridView)
        {
            string pattern = @"\b[tT|mM]\w*\b";
            Regex regex = new Regex(pattern);

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (regex.IsMatch(cell.Value?.ToString() ?? ""))
                    {
                        cell.Style.BackColor = System.Drawing.Color.Blue; // Highlight cell
                    }
                }
            }
        }

        private void btnWordsWithTandM_Click(object sender, EventArgs e)
        {
            ApplyWordsStartingWithTandMRegex(dataGridView1); // Assuming dataGridView1 contains the data
        }
    }
}
