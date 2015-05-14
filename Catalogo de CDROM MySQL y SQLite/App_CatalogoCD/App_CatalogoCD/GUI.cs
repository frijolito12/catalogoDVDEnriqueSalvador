using System;
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
        static Catalogo c = new Catalogo();
        public GUI()
        {
            InitializeComponent();
        }
         void AnadirDVD()
        {
            string codigo =  string.Empty;
            codigo = textBox1.Text;
            c.AddEntrada(codigo);
        }
         void BorrarDVD()
        {
            string codigo = string.Empty;
            codigo = textBox1.Text;
            if (c.BorrarDVD(codigo) != 0)
               MessageBox.Show("Operación realizada");
            else
                MessageBox.Show("Registro no encontrado");
        }
         static void VolcarAFichero()
         {
             c.XmlAFichero();
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

        private void button2_Click(object sender, EventArgs e)
        {
            c.LeerDVD();
            MessageBox.Show(c.Xml);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            AnadirDVD();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void GUI_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            BorrarDVD();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            VolcarAFichero();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            c.FiltrarPorPais();
            MessageBox.Show(c.ToString());
        }
       
    }
}
