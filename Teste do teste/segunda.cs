﻿using System;
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
    public partial class segunda : Form
    {
        public segunda()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //testando o git 
            //agr saquei
            
            string sexo = "";
           
            if(radioButton1.Checked == true)
            {
                sexo = radioButton1.Text;
                MessageBox.Show(sexo);
            }
            else
            {
                sexo = radioButton2.Text;
                MessageBox.Show(sexo);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }
    }
}
