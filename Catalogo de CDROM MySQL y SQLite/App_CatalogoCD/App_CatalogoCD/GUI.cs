﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_CatalogoCD
{
    public partial class GUI : Form
    {
        Catalogo c = new Catalogo();
        public GUI()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            c.LeerDVD();
            MessageBox.Show(c.ToString());
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
