using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modul1
{
    public partial class ZooForm : Form
    {
        public ZooForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void calculateButton_Click_1(object sender, EventArgs e)
        {
            List<IAnimal> animals = new List<IAnimal>
        {
            new Zebra(),
            new Hippo(),
            new Snake()
        };

            double totalArea = 0;

            dataGridView1.Rows.Clear();

            foreach (var animal in animals)
            {
                double requiredArea = animal.GetRequiredArea();
                double requiredTemperature = animal.GetRequiredTemperature();
                totalArea += requiredArea;

                dataGridView1.Rows.Add(animal.GetName(), requiredArea, requiredTemperature);
            }

            totalAreaLabel.Text = "Загальна площа вольєрів: " + totalArea + " кв. метрів";
        }

        private void totalAreaLabel_Click(object sender, EventArgs e)
        {

        }
    }
}