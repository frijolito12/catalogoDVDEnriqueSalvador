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
        Catalogo c = new Catalogo();
        static dvd registro;
        private List<dvdLocal> _miLista = new List<dvdLocal>();
            
        public frm_gui2()
        {
            InitializeComponent();
        }

        private void LeerDVD()
        {
            c.LeerDVD();

            string catalogo = "";

            catalogo = c.ToString().TrimStart('\n'); ;
            catalogo = catalogo.TrimEnd(',');
            catalogo = catalogo.TrimEnd('\n');
            string[] datos = catalogo.Split('\n');
            
            foreach (var item in datos)
            {
                string[] dvd = item.Replace(", ",";").Split(';');
                dvdLocal nuevoDVD;
                nuevoDVD.codigo = dvd[0].ToString().Trim();
                nuevoDVD.titulo = dvd[1].ToString().Trim();
                nuevoDVD.artista = dvd[2].ToString().Trim();
                nuevoDVD.pais = dvd[3].ToString().Trim();
                nuevoDVD.compania = dvd[4].ToString().Trim();
                nuevoDVD.precio = dvd[5].ToString().Trim();
                nuevoDVD.anio = dvd[6].ToString().Trim();
                lbxCatalogo.Items.Add(nuevoDVD.titulo);
                _miLista.Add(nuevoDVD);
            }
            lbxCatalogo.Show();
        }
        private void XML()
        {
            c.LeerDVD();
            frm_salida salidaXML = new frm_salida(c.Xml);
            salidaXML.ShowDialog();
        }
        private void AnadirDVD()
        {
            lblMensaje.Show();
            lblMensaje.Text = "Inserte el código de DVD para añadir y pulse Generar";
            btnGenerar.Text = "Generar";
            btnGenerar.Show();
        }
        private void BorrarDVD()
        {
            lblMensaje.Show();
            lblMensaje.Text = "Inserte el código de DVD para borrar y pulse Borrar";
            btnGenerar.Text = "Borrar";
            btnGenerar.Show();
        }
        private void ActualizarDVD()
        {
            lblMensaje.Show();
            lblMensaje.Text = "Inserte el código de DVD para modificar o rellene los campos";
            registro = c.LeerDVD(tbxCodigo.Text);
            if (registro != null)
            {
                LlenarCampos(registro);
                lblMensaje.Text = "Presione Actualizar cuando acabe";
                btnGenerar.Text = "Actualizar";
                btnGenerar.Show();
            }
            else
                MessageBox.Show("Disco no encontrado");
        }
        private void VolcarAFichero()
        {
            c.XmlAFichero();
        }

        //Métodos Auxiliares
        private void PedirCampos(dvd registro)
        {
            registro.Titulo = tbxTitulo.Text;
            registro.Artista = tbxArtista.Text;
            registro.Pais = tbxPais.Text;
            registro.Compania = tbxCompania.Text;
            registro.Precio = Decimal.Parse(tbxPrecio.Text);
            registro.Anio = ushort.Parse(tbxAnio.Text);
        }
        private void LlenarCampos(dvd registro)
        {
            tbxTitulo.Text = tbxTitulo.Text;
            tbxArtista.Text = registro.Artista;
            tbxPais.Text = registro.Pais;
            tbxCompania.Text = registro.Compania;
            tbxPrecio.Text = registro.Precio.ToString();
            tbxAnio.Text = registro.Anio.ToString();
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
            if (btnGenerar.Text == "Generar")
            {
                lblMensaje.Text = "Añadido el DVD con código: " + tbxCodigo.Text;
                c.AddEntrada(tbxCodigo.Text);
                dvdLocal nuevoDVD;
                nuevoDVD.codigo = tbxCodigo.Text;
                nuevoDVD.titulo = tbxTitulo.Text;
                nuevoDVD.artista = tbxArtista.Text;
                nuevoDVD.pais = tbxPais.Text;
                nuevoDVD.compania = tbxCompania.Text;
                nuevoDVD.precio = tbxPrecio.Text;
                nuevoDVD.anio = tbxAnio.Text;
                lbxCatalogo.Items.Add(nuevoDVD.titulo);
                _miLista.Add(nuevoDVD);
            }
            if (btnGenerar.Text == "Borrar")
            {
                lblMensaje.Text = "Borrado el DVD con código: " + tbxCodigo.Text;
                c.BorrarDVD(tbxCodigo.Text);
            }
            if (btnGenerar.Text == "Actualizar")
            {
                PedirCampos(registro);

                if (MessageBox.Show("Es correcto?" + registro.ToString(), "Confirmar actualizar DVD", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    if (c.ActualizarDVD(registro) == 1)
                        MessageBox.Show("\nRegistro actualizado correctamente");
                    else
                        MessageBox.Show("Error al actualizar el registro");
                }
                else
                {
                    MessageBox.Show("Registro no actualizado");
                }
            }
        }

        private void lbxCatalogo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxCatalogo.SelectedIndex > -1)
            {
                dvdLocal miDVD = _miLista[lbxCatalogo.SelectedIndex];
                tbxCodigo.Text = miDVD.codigo;
                tbxTitulo.Text = miDVD.titulo;
                tbxArtista.Text = miDVD.artista;
                tbxPais.Text = miDVD.pais;
                tbxCompania.Text = miDVD.compania;
                tbxPrecio.Text = miDVD.precio;
                tbxAnio.Text = miDVD.anio;
            }
            if (btnGenerar.Visible == true)
            {
                lblMensaje.Hide();
                btnGenerar.Hide();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
