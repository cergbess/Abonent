using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MondoDBtest
{
    public partial class FormMoreInfo : Form
    {
        private ModelClient _selectedClient;
        public FormMoreInfo(ModelClient selectedClient)
        {
            _selectedClient = selectedClient;
            InitializeComponent();
        }

        private void FormMoreInfo_Load(object sender, EventArgs e)
        {
            label2.Text = _selectedClient.lSHET.ToString();
            label3.Text = _selectedClient.adress.ToString();    
            label4.Text = _selectedClient.PeopleLive.ToString() + "  чел.";
            label5.Text = _selectedClient.Sqmetr.ToString() + "  Кв.М";
            label6.Text = _selectedClient.AllDebt.ToString("N2") + "  Руб.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
