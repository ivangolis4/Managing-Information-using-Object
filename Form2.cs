using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        Info i = new Info();
        public Form2(Object Info)
        {
            InitializeComponent();
            this.i = (Info) Info;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        public void load()
        {
            label5.Text = i.getName();
            label6.Text = i.getAddress();
            label7.Text = Convert.ToString(i.getAge());
            label8.Text = i.getGender();
        }
    }
}
