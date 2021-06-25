using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MikroZaim
{
    public partial class MikroZaim : Form
    {
        public object Masage { get; private set; }

        public MikroZaim()
        {
            InitializeComponent();
        }

        private void day_TextChanged(object sender, EventArgs e)
        {

        }

        private void prot_TextChanged(object sender, EventArgs e)
        {

        }

        private void money_TextChanged(object sender, EventArgs e)
        {
            if (money > 500000)
            {
                Masage.box("Ошибка");
            }

        }

        private void sum_Click(object sender, EventArgs e)
        {
            int days = Convert.ToInt32(day.Text);
            string Prot = Convert.ToString(prot);
            double Money = Convert.ToDouble(money.Text)


            double[] sum_prot = prot.Text.Split(' ').Select(x => double.Parse(x).ToString);
            var SumProt = prot.Where(x=>char.IsDigit(x)).Sum(x => char.GetNumericValue(x));
            SumProt = SumProt / 10 / days;
        }
    }
}
