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
    }
}
