using CRUDdtLogic;
using CRUDdtLogic.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeUI
{
    public partial class Form2 : Form
    {
        public Form2(List<EmployeeDt> data)
        {
            InitializeComponent();
 
            dataGridView1.DataSource = data;
        }

        private void Filter_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string gender = textBox2.Text;
            string city = textBox3.Text;
            string addressType = textBox4.Text;

            List<EmployeeDetails> filteredData = EmployeeDataLogic.GetFilteredEmployeeDetails(name, gender, city, addressType);

            dataGridView1.DataSource = filteredData;
        }
    }
}
