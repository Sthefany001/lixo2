using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste_do_teste
{
    public partial class Teste : Form
    {
        public Teste()
        {
            InitializeComponent();
            label1.Text = "";
        }

        private void bt_teste1_Click(object sender, EventArgs e)
        {
            segunda segunda = new segunda();
            segunda.ShowDialog();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(textBox1.Text); ;
                int b = Convert.ToInt32(textBox2.Text);

                int c = a / b;
                label1.Text = c.ToString();
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message);
            }
            finally
            {
                MessageBox.Show("Obrigado!");
            }
           

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
