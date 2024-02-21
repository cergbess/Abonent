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

namespace MondoDBtest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += async (sender, args) => await InitializeMongoDBAsync();
        }
        private async Task InitializeMongoDBAsync()
        {
            string connectionString = "mongodb://localhost:27017";
            string dbName = "simple_db";
            string collectionName = "users";
            var clientDB = new MongoClient(connectionString);
            var db = clientDB.GetDatabase(dbName);
            var collection = db.GetCollection<ModelClient>(collectionName);
           // добавление записи
            Random rnd = new Random();
            decimal clientSQ = Math.Round(15 + (decimal)rnd.NextDouble() * (260 - 15), 2);

            var newClient = new ModelClient
            {
                adress = $"Улица Камышовая , дом {rnd.Next(1, 60)}, квартира {rnd.Next(1, 200)}",
                lSHET = 1037943999,
                PeopleLive = rnd.Next(1, 7),
                Sqmetr = clientSQ,
                Services = new List<ModelService>
                {
                    new ModelService(clientSQ)
                    {
                        ServiceName = "Поддержание жилищного фонда",
                        DebtPast = Math.Round((decimal)rnd.NextDouble() * 5000, 2),
                        UnitOfMeasurement = "кв. м",
                        BenefitsAndSubsidies = Math.Round(-400 + (decimal)rnd.NextDouble() * 400, 2),
                        TotalRecalculations = Math.Round(-400 + (decimal)rnd.NextDouble() * 400, 2),
                        tariff = Math.Round(1.12m + (decimal)rnd.NextDouble() * (16.3m - 1.12m), 2),
                        Paid = Math.Round((decimal)rnd.NextDouble() * 1000, 2)
                    },
                    new ModelService(clientSQ)
                    {
                        ServiceName = "Кап. Ремонт",
                        DebtPast = Math.Round((decimal)rnd.NextDouble() * 5000, 2),
                        UnitOfMeasurement = "кв. м",
                        BenefitsAndSubsidies = Math.Round(-400 + (decimal)rnd.NextDouble() * 400, 2),
                       TotalRecalculations = Math.Round(-400 + (decimal)rnd.NextDouble() * 400, 2),
                       tariff = Math.Round(1.12m + (decimal)rnd.NextDouble() * (16.3m - 1.12m), 2),
                        Paid = Math.Round((decimal)rnd.NextDouble() * 1000, 2)
                    },
                    new ModelService()
                    {
                        ServiceName = "Горячая вода",
                        DebtPast = Math.Round((decimal)rnd.NextDouble() * 5000, 2),
                        UnitOfMeasurement = "куб. м",
                        IndividualUsageVolume = Math.Round((decimal)rnd.NextDouble() * 220, 2),
                       BenefitsAndSubsidies = Math.Round(-400 + (decimal)rnd.NextDouble() * 400, 2),
                        TotalRecalculations = Math.Round(-400 + (decimal)rnd.NextDouble() * 400, 2),
                        tariff = Math.Round(1.12m + (decimal)rnd.NextDouble() * (16.3m - 1.12m), 2),
                        Paid = Math.Round((decimal)rnd.NextDouble() * 1000, 2)
                    },
                    new ModelService()
                    {
                        ServiceName = "Холодная вода",
                        DebtPast = Math.Round((decimal)rnd.NextDouble() * 5000, 2),
                       UnitOfMeasurement = "куб. м",
                       IndividualUsageVolume = Math.Round((decimal)rnd.NextDouble() * 220, 2),
                        BenefitsAndSubsidies = Math.Round(-400 + (decimal)rnd.NextDouble() * 400, 2),
                        TotalRecalculations = Math.Round(-400 + (decimal)rnd.NextDouble() * 400, 2),
                        tariff = Math.Round(1.12m + (decimal)rnd.NextDouble() * (16.3m - 1.12m), 2),
                        Paid = Math.Round((decimal)rnd.NextDouble() * 1000, 2)
                    },
                     new ModelService()
                    {
                        ServiceName = "Электроэнергия",
                        DebtPast = Math.Round((decimal)rnd.NextDouble() * 5000, 2),
                        UnitOfMeasurement = "квт.ч",
                        IndividualUsageVolume = Math.Round((decimal)rnd.NextDouble() * 220, 2),
                        BenefitsAndSubsidies = Math.Round(-400 + (decimal)rnd.NextDouble() * 400, 2),
                       TotalRecalculations = Math.Round(-400 + (decimal)rnd.NextDouble() * 400, 2),
                        tariff = Math.Round(1.12m + (decimal)rnd.NextDouble() * (16.3m - 1.12m), 2),
                      Paid = Math.Round((decimal)rnd.NextDouble() * 1000, 2)
                    },
                      new ModelService()
                   {
                       ServiceName = "Электроэнергия (ночь)",
                        DebtPast = Math.Round((decimal)rnd.NextDouble() * 5000, 2),
                        UnitOfMeasurement = "квт.ч",
                        IndividualUsageVolume = Math.Round((decimal)rnd.NextDouble() * 220, 2),
                        BenefitsAndSubsidies = Math.Round(-400 + (decimal)rnd.NextDouble() * 400, 2),
                        TotalRecalculations = Math.Round(-400 + (decimal)rnd.NextDouble() * 400, 2),
                        tariff = Math.Round(1.12m + (decimal)rnd.NextDouble() * (16.3m - 1.12m), 2),
                        Paid = Math.Round((decimal)rnd.NextDouble() * 1000, 2)
                    }
                }
            };
            await collection.InsertOneAsync(newClient);
          //  добавление записи
          
            var results = await collection.FindAsync(_ => true);
            dataGridView1.DataSource = results.ToList();
 //сюда конец
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.DataBoundItem is ModelClient selectedClient)
            {
                FormPayment fp = new FormPayment(selectedClient);
                fp.ShowDialog();
            }
        }
      /*  private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBox1.Text;
            dataGridView1.ClearSelection();
            if (searchText != "")
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value.ToString().Contains(searchText))
                        {
                            row.Selected = true;
                            dataGridView1.CurrentCell = row.Cells[0];
                            break;
                        }
                    }
                }
            }
        }*/

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.DataBoundItem is ModelClient selectedClient)
            {
                FormMoreInfo mf = new FormMoreInfo(selectedClient);
                mf.ShowDialog();
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) 
            {
                int index = dataGridView1.SelectedRows[0].Index;
                string value = dataGridView1[0, index].Value.ToString();
                label2.Text = value;
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
