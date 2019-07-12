using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autofac;
using Contract;
namespace SampleWinformApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var scope = BootStrapper.AutoFacContainer.BeginLifetimeScope())
            {
                var mgr = scope.Resolve<ISalaryManager>();
                label1.Text = mgr.GetMonthlySalary(123).ToString();
            }
        }
    }
}
