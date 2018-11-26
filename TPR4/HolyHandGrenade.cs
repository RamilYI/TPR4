using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPR4
{
    public static class HolyHandGrenade
    {
        internal static void borderdata(DataGridView dataGridView1)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Height = (dataGridView1.ClientRectangle.Height - dataGridView1.ColumnHeadersHeight) / dataGridView1.Rows.Count;
            }

            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                col.Width = (dataGridView1.ClientRectangle.Width - dataGridView1.ColumnHeadersHeight) /
                            dataGridView1.Columns.Count;
            }
        }

        public static Func<decimal, decimal>[] methods =
        {
                n => func1(n),
                n => func2(n),
                n => func3(n)
        };

        internal static decimal func1(decimal elem)
        {
            if (elem < 5) return 0;
            else return 1;
        }

        internal static decimal func2(decimal elem)
        {
            if (elem <= 1) return 0;
            else if (elem > 1 && elem <= 3) return elem / 3;
            else return 1;
        }

        internal static decimal func3(decimal elem)
        {
            if (elem <= 1) return 0M;
            else if (elem > 1 && elem <= 5) return 0.5M;
            else return 1M;
        }

    }
}
