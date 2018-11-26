using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TPR4
{
    public partial class Solution : Form
    {
        decimal[] Fplus;
        decimal[] Fminus, F;
        private string[] nameCrit, nameAlt;
        private DataGridView dataGridView;
        private decimal[,] step1array;
        decimal[] array;
        private decimal[,] Pi;
        private decimal[] W;
        List<decimal[,]> arraystep2 = new List<decimal[,]>();

        public Solution(string[] nameCrit, string[] nameAlt, DataGridView dataGridView, decimal[] W)
        {
            InitializeComponent();
            this.nameCrit = nameCrit;
            this.nameAlt = nameAlt;
            this.dataGridView = dataGridView;
            this.W = W;
        }
        

        private DataGridView datamake()
        {
            DataGridView data = new DataGridView();
            data.Dock = DockStyle.Fill;
            HolyHandGrenade.borderdata(data);
            return data;
        }


        public void fillTable()
        {
            TabControl tab1 = new TabControl(); //шаг1
            tab1.Dock = DockStyle.Fill;
            TabControl tab2 = new TabControl(); //шаг2
            tab2.Dock = DockStyle.Fill;
            

            for (int i = 0; i < nameCrit.Length; i++)
            {
                tab1.TabPages.Add(new TabPage($"{nameCrit[i]}"));
                tab2.TabPages.Add(new TabPage($"{nameCrit[i]}"));
                step1array = step1(i);
                DataGridView data1 = new DataGridView()
                {
                    RowCount = (int)(step1array.Length / Math.Sqrt(step1array.Length)),
                    ColumnCount = (int)(step1array.Length / Math.Sqrt(step1array.Length))
                };
                for (int m = 0; m < data1.RowCount; m++)
                    for (int j = 0; j < data1.ColumnCount; j++)
                        data1.Rows[m].Cells[j].Value = step1array[m,j];

                step1array = step2(i);
                DataGridView data2 = new DataGridView()
                {
                    RowCount = (int)(step1array.Length / Math.Sqrt(step1array.Length)),
                    ColumnCount = (int)(step1array.Length / Math.Sqrt(step1array.Length))
                };
                for (int m = 0; m < data2.RowCount; m++)
                    for (int j = 0; j < data2.ColumnCount; j++)
                        data2.Rows[m].Cells[j].Value = step1array[m, j];
                data1.Dock = DockStyle.Fill;
                data2.Dock = DockStyle.Fill;
                tab1.TabPages[i].Controls.Add(data1);
                tab2.TabPages[i].Controls.Add(data2);
            }
            tab1.Dock = DockStyle.Fill;
            tab2.Dock = DockStyle.Fill;
            tabPage1.Controls.Add(tab1);
            tabPage2.Controls.Add(tab2);
            dataGridView228.RowCount = array.Length+1;
            dataGridView228.ColumnCount = array.Length+1;
            HolyHandGrenade.borderdata(dataGridView228);
            Pi = step3();
            for (int i = 0; i < array.Length; i++)
                for (int j = 0; j < array.Length; j++)
                    dataGridView228.Rows[i].Cells[j].Value = Pi[i, j];
            string[] range = step4();
            dataGridView1488.RowCount = range.Length;
            dataGridView1488.ColumnCount = 1;
            HolyHandGrenade.borderdata(dataGridView1488);
            for (int i = 0; i < range.Length; i++)
                for (int j = 0; j < 1; j++)
                    dataGridView1488.Rows[i].Cells[j].Value = range[i];

            for (int i = 0; i < array.Length; i++) dataGridView228.Rows[array.Length].Cells[i].Value = Fminus[i];
            dataGridView228.Rows[array.Length].HeaderCell.Value = "F-";
            for (int i = 0; i < array.Length; i++) dataGridView228.Rows[i].Cells[array.Length].Value = Fplus[i];
            dataGridView228.Columns[array.Length].HeaderText = "F+";
            chartMake();
        }

        private void chartMake()
        {
            for (int i = 0; i < array.Length; i++)
            {
                chart1.Series["Рейтинг альтернатив"].Points.AddXY(nameAlt[i], -F[i]);
            }
        }

        private decimal[] datagridviewColumnToArray(int k)
        {
            return Array.ConvertAll(dataGridView.Rows.Cast<DataGridViewRow>()
    .Select(x => x.Cells[k].Value.ToString().Trim())
    .ToArray(), s => decimal.Parse(s));
        }

        private decimal[,] step1(int k)
        {
            array = datagridviewColumnToArray(k);
            step1array = new decimal[array.Length, array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    step1array[i, j] = array[i] - array[j];
                }
            }

            return step1array;
        }

        private decimal[,] step2(int k)
        {
            if (k > nameCrit.Length) k = k - nameCrit.Length;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    step1array[i, j] = HolyHandGrenade.methods[k](step1array[i, j]);
                }
            }
            arraystep2.Add(step1array);
            return step1array;
        }

        private decimal[,] step3()
        {
            Pi = new decimal[array.Length, array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    for (int k = 0; k < nameCrit.Length; k++)
                    {
                        Pi[i, j] += arraystep2[k][i, j] * W[k];
                    }
                }
            }

            return Pi;
        }

        private string[] step4()
        {
            decimal[,] res = Pi;
            Fplus = new decimal[array.Length];
            Fminus = new decimal[array.Length];
            F = new decimal[array.Length];
            decimal[] buf = new decimal[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    Fplus[i] += res[i, j];
                    Fminus[i] += res[j, i];
                }

                F[i] = Fplus[i] - Fminus[i];
            }
            int[] range = new int[array.Length];
            Array.Copy(F, buf, F.Length);
            Array.Sort(buf);
            //Array.Reverse(buf);
            for (int i = 0; i < range.Length; i++) range[i] = Array.IndexOf(F, buf[i]); //namealt
            string[] rangeAlt = new string[nameAlt.Length];
            for (int i = 0; i < nameAlt.Length; i++) rangeAlt[i] = nameAlt[range[i]];
            return rangeAlt;
        }

    }
}
