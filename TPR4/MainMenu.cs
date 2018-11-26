using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TPR4
{
    public partial class MainMenu : Form
    {
        private int n, m;
        private string[] nameCrit, nameAlt;
        private decimal[,] dataGridArray;
        private decimal[] W;
        public MainMenu()
        {
            InitializeComponent();
            dataGridView1.AllowUserToAddRows = false;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
        }

        private void createtable_Click(object sender, EventArgs e)
        {
            n = Int32.Parse(numalternative.Value.ToString());
            m = Int32.Parse(numcrit.Value.ToString());
            dataGridView1.RowCount = n;
            dataGridView1.ColumnCount = m;
            dataGridArray = new decimal[n,m];
            WeightCrit wc = new WeightCrit(n, m);
            W = new decimal[m];
            wc.ShowDialog();
            for (int i = 0; i < m; i++)
            {
                dataGridView1.Columns[i].HeaderText = wc.nameCrit[i];
                W[i] = wc.weightCr[i];
            }
            for (int i = 0; i < n; i++) dataGridView1.Rows[i].HeaderCell.Value = wc.nameAlt[i];

            HolyHandGrenade.borderdata(dataGridView1);
            nameCrit = new string[m];
            nameCrit = wc.nameCrit;
            nameAlt = new string[n];
            nameAlt = wc.nameAlt;
        }

        private void dataGridViewToArray (DataGridView data)
        {
            foreach (DataGridViewRow i in dataGridView1.Rows)
            {
                if (i.IsNewRow) continue;
                foreach (DataGridViewCell j in i.Cells)
                {
                    dataGridArray[j.RowIndex, j.ColumnIndex] = decimal.Parse(j.Value.ToString());
                }
            }
        }

        private void calcbutton_Click(object sender, EventArgs e)
        {
            Solution solution = new Solution(nameCrit, nameAlt, dataGridView1, W);
            solution.fillTable();
            solution.Show();
        }

    }
}
