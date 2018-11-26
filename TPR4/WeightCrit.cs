using System;
using System.Globalization;
using System.Windows.Forms;

namespace TPR4
{
    public partial class WeightCrit : Form
    {
        private int n, m;
        private int[] crits, alts;
        public decimal[] weightCr;
        public string[] nameCrit, nameAlt;
        public WeightCrit(int n, int m)
        {
            InitializeComponent();
            dataAlt.AllowUserToAddRows = false;
            dataCrit.AllowUserToAddRows = false;
            this.n = n;
            this.m = m;
            crits  = new int[m];
            alts = new int[n];
            weightCr = new decimal[m];
            nameCrit = new string[m];
            nameAlt = new string[n];
            filltable();
            sequenceNum(dataCrit, crits);
            sequenceNum(dataAlt, alts);
        }

        private void filltable()
        {
            dataCrit.Rows.Clear();
            dataCrit.Columns.Clear();
            dataCrit.ColumnCount = 3;
            dataCrit.RowCount = m;
            dataCrit.Columns[0].HeaderText = "Номер критерия";
            dataCrit.Columns[1].HeaderText = "Вес критерия";
            dataCrit.Columns[2].HeaderText = "Название критерия";
            dataAlt.Columns.Clear();
            dataAlt.Rows.Clear();
            dataAlt.ColumnCount = 2;
            dataAlt.RowCount = n;
            dataAlt.Columns[0].HeaderText = "Номер альтернативы";
            dataAlt.Columns[1].HeaderText = "Название альтернативы";
            HolyHandGrenade.borderdata(dataCrit);
            HolyHandGrenade.borderdata(dataAlt);
        }

        
        private void sequenceNum(DataGridView data, int[] array)
        {
            for (int i = 0; i < array.Length; i++) array[i] = i + 1;
            foreach (DataGridViewRow col in data.Rows)
                data.Rows[col.Index].Cells[0].Value = array[col.Index];
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            datagridViewToStrArrays(dataAlt, nameAlt, 1);
            datagridViewToStrArrays(dataCrit, nameCrit, 2);
            datagridViewToDecimalArrays(dataCrit, weightCr, 1);
            this.Close();
        }

        private void datagridViewToStrArrays(DataGridView data, string[] array, int colNum)
        {
            foreach (DataGridViewRow col in data.Rows)
                array[col.Index] = data.Rows[col.Index].Cells[colNum].Value.ToString();
        }

        private void datagridViewToDecimalArrays(DataGridView data, decimal[] array, int colNum)
        {
            foreach (DataGridViewRow col in data.Rows)
                array[col.Index] = Decimal.Parse(data.Rows[col.Index].Cells[colNum].Value.ToString(), CultureInfo.InvariantCulture);
        }

    }
}
