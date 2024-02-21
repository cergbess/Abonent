using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MongoDB.Driver.WriteConcern;

namespace MondoDBtest
{
    public partial class FormPayment : Form
    {
        private ModelClient _selectedClient;
        public FormPayment(ModelClient selectedClient)
        {
            _selectedClient = selectedClient;
            InitializeComponent();

        }

        private void FormPayment_Load(object sender, EventArgs e)
        {
            if (_selectedClient.Services != null && _selectedClient.Services.Count > 0)
            {
                dataGridView1.DataSource = _selectedClient.Services.ToList();
            }
            else
            {
                dataGridView1.DataSource = null;
                MessageBox.Show("Клиент еще не подключил ни одну услугу!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.DataBoundItem is ModelService selectedServ)
            {
                string value = selectedServ.ServiceName.ToString();
                string value2 = selectedServ.Debt.ToString("N2");
                label4.Text = value2 + "  Руб.";
                label3.Text = value;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridView1.ClearSelection();
                dataGridView1.Rows[e.RowIndex].Selected = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal input;
            if (decimal.TryParse(textBox1.Text, out input))
            {
                if (input >= 50m && input <= 1000000m)
                {
                    if (dataGridView1.CurrentRow.DataBoundItem is ModelService selectedServ)
                    {
                        selectedServ.Paid += input;
                        label4.Text = selectedServ.Debt.ToString("N2") + "  Руб.";
                    }
                    dataGridView1.Refresh();
                    MessageBox.Show("Сумма " + textBox1.Text + "  Руб. успешно внесена!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox1.Text = "";

                }
                else
                {
                    MessageBox.Show("Пожалуйста, введите число от 50 до 1млн.");
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите число с двумя знаками после запятой.");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
