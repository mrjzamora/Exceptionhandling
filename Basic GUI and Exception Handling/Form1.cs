using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basic_GUI_and_Exception_Handling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int result;
            string str = textBox1.Text;
            if (int.TryParse(str,out result))
            {
                MessageBox.Show("this is a valid integer");
            }
            else
            {
                MessageBox.Show("invalid integer");
            }
            try
            {
                result = int.Parse(str);

            }
            catch
            {
                MessageBox.Show("Catch - not a valid integer");
            }
        }
    }
}
