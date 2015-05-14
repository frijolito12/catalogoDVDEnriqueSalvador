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
    public struct dvdLocal
    {
        public string codigo;
        public string titulo;
        public string artista;
        public string pais;
        public string compania;
        public string precio;
        public string anio;
    }
    
    
    public partial class frm_gui2 : Form
    {
        static Catalogo c;


            
        public frm_gui2()
        {
            InitializeComponent();
        }

        private void LeerDVD()
        {

        }
        private void XML()
        {

        }
        private void AnadirDVD()
        {

        }
        private void BorrarDVD()
        {

        }
        private void ActualizarDVD() 
        {

        }
        private void VolcarAFichero()
        {

        }

        //Métodos Auxiliares
        private void PedirCampos(dvd registro)
        {

        }
        private void LlenarCampos(dvd registro)
        {

        }

        //Evento botón
        private void btnOpcion_Click(object sender, EventArgs e)
        {
            switch (lbxDVD.SelectedIndex)
            {
                case 0:
                    LeerDVD();
                    break;
                case 1:
                    XML();
                    break;
                case 2:
                    AnadirDVD();
                    break;
                case 3:
                    BorrarDVD();
                    break;
                case 4:
                    ActualizarDVD();
                    break;
                case 5:
                    VolcarAFichero();
                    break;
                case 6:
                    c.FiltrarPorPais();
                    MessageBox.Show(c.ToString());
                    break;
            }
        }
        private void btnGenerar_Click(object sender, EventArgs e)
        {

        }

        private void lbxDVD_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
