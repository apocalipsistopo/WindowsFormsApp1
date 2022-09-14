using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteWindows
{
    
    public partial class Form1 : Form
    {
        private static string Seleccionado = "";
        private static bool primero=true;
        public Form1()
        {
            
            InitializeComponent();
        }

        //Llamar al servicio
        private static WindowsFormsApp1.ServiceReference1.WebService4SoapClient servicio = new WindowsFormsApp1.ServiceReference1.WebService4SoapClient() ;

        private void Form1_Load(object sender, EventArgs e)
        {
            btnActualizar.Visible = false;
            btnAgregar.Visible = false;
            btnBuscar.Visible = false;
            btnEliminar.Visible = false;
            lbl1.Visible = false;
            lbl2.Visible = false;
            lbl3.Visible = false;
            txt3.Visible = false;
            txt1.Visible = false;
            txt2.Visible = false;
            txtBuscar.Visible = false;
            dgvRegion.Visible = false;
            cbBuscar.Visible = false;
            


        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            if (lbl1.Text.Contains("Region"))
            {
                //leer las cajas de texto
                int id = int.Parse(txt1.Text.Trim());
                string descripcion = txt2.Text.Trim();
                // ir al servicio y obtener la respuesta del mismo
                servicio = new WindowsFormsApp1.ServiceReference1.WebService4SoapClient();
                string[] rsta = servicio.AgregarRegion(id,descripcion).ToArray();
                if (rsta[0] == "0")
                {
                    dgvRegion.DataSource = servicio.ListarRegion().Tables[0];
                }
                MessageBox.Show(rsta[1]);
            }
            else if (lbl1.Text.Contains("Customer"))
            {
                //leer las cajas de texto
                int id = int.Parse(txt1.Text.Trim());
                string descripcion = txt2.Text.Trim();
                // ir al servicio y obtener la respuesta del mismo
                servicio = new WindowsFormsApp1.ServiceReference1.WebService4SoapClient();
                string[] rsta = servicio.AgregarCustomerDemographics(id.ToString(),descripcion).ToArray();
                if (rsta[0] == "0")
                {
                    dgvRegion.DataSource = servicio.ListarCustomerDemographics().Tables[0];
                }
                MessageBox.Show(rsta[1]);
            }
            else {
                //leer las cajas de texto
                int id = int.Parse(txt1.Text.Trim());
                string descripcion = txt2.Text.Trim();
                string tercero = txt3.Text.Trim();
                // ir al servicio y obtener la respuesta del mismo
                servicio = new WindowsFormsApp1.ServiceReference1.WebService4SoapClient();
                string[] rsta = servicio.AgregarShippers(id,descripcion,tercero).ToArray();
                if (rsta[0] == "0")
                {
                    dgvRegion.DataSource = servicio.ListarShippers().Tables[0];
                }
                MessageBox.Show(rsta[1]);
            }
            limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lbl1.Text.Contains("Region"))
            {
                //leer las cajas de texto
                int id = int.Parse(txt1.Text.Trim());
                // ir al servicio y obtener la respuesta del mismo
                servicio = new WindowsFormsApp1.ServiceReference1.WebService4SoapClient();
                string[] rsta = servicio.EliminarRegion(id).ToArray();
                if (rsta[0] == "0")
                {
                    dgvRegion.DataSource = servicio.ListarRegion().Tables[0];
                }
                MessageBox.Show(rsta[1]); 
               
            }
            else if (lbl1.Text.Contains("Customer"))
            {
                //leer las cajas de texto
                int id = int.Parse(txt1.Text.Trim());
                // ir al servicio y obtener la respuesta del mismo
                servicio = new WindowsFormsApp1.ServiceReference1.WebService4SoapClient();
                string[] rsta = servicio.EliminarCustomerDemographics(id.ToString()).ToArray();
                if (rsta[0] == "0")
                {
                    dgvRegion.DataSource = servicio.ListarCustomerDemographics().Tables[0];
                }
                MessageBox.Show(rsta[1]);
            }
            else
            {
                //leer las cajas de texto
                int id = int.Parse(txt1.Text.Trim());
                // ir al servicio y obtener la respuesta del mismo
                servicio = new WindowsFormsApp1.ServiceReference1.WebService4SoapClient();
                string[] rsta = servicio.EliminarShippers(id).ToArray();
                if (rsta[0] == "0")
                {
                    dgvRegion.DataSource = servicio.ListarShippers().Tables[0];
                }
                MessageBox.Show(rsta[1]);
            }
            limpiar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (lbl1.Text.Contains("Region"))
            {
                //leer las cajas de texto
                int id = int.Parse(txt1.Text.Trim());
                string descripcion = txt2.Text.Trim();
                // ir al servicio y obtener la respuesta del mismo
                servicio = new WindowsFormsApp1.ServiceReference1.WebService4SoapClient();
                string[] rsta = servicio.ActualizarRegion(id, descripcion).ToArray();
                if (rsta[0] == "0")
                {
                    dgvRegion.DataSource = servicio.ListarRegion().Tables[0];
                }
                MessageBox.Show(rsta[1]);
            }
            else if (lbl1.Text.Contains("Customer"))
            {
                //leer las cajas de texto
                int id = int.Parse(txt1.Text.Trim());
                string descripcion = txt2.Text.Trim();
                // ir al servicio y obtener la respuesta del mismo
                servicio = new WindowsFormsApp1.ServiceReference1.WebService4SoapClient();
                string[] rsta = servicio.ActualizarCustomerDemographics(id.ToString(), descripcion).ToArray();
                if (rsta[0] == "0")
                {
                    dgvRegion.DataSource = servicio.ListarCustomerDemographics().Tables[0];
                }
                MessageBox.Show(rsta[1]);
            }
            else
            {
                //leer las cajas de texto
                int id = int.Parse(txt1.Text.Trim());
                string descripcion = txt2.Text.Trim();
                string tercero = txt3.Text.Trim();
                // ir al servicio y obtener la respuesta del mismo
                servicio = new WindowsFormsApp1.ServiceReference1.WebService4SoapClient();
                string[] rsta = servicio.ActualizarShippers(id, descripcion, tercero).ToArray();
                if (rsta[0] == "0")
                {
                    dgvRegion.DataSource = servicio.ListarShippers().Tables[0];
                }
                MessageBox.Show(rsta[1]);
            }
            limpiar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (lbl1.Text.Contains("Region"))
            {
                dgvRegion.DataSource = servicio.BuscarRegion(int.Parse(txtBuscar.Text.Trim())).Tables[0];
            }
            else if (lbl1.Text.Contains("Customer"))
            {
                dgvRegion.DataSource = servicio.BuscarCustomerDemographics(txtBuscar.Text.Trim()).Tables[0];
            }
            else
            {               
                dgvRegion.DataSource = servicio.BuscarShippers(txtBuscar.Text.Trim(), cbBuscar.SelectedItem.ToString()).Tables[0];
            }
            

        }

        private void btnRegion_Click(object sender, EventArgs e)
        {
            lbl1.Text = "Region ID";
            lbl2.Text = "Region Descipcion";
            dgvRegion.DataSource = servicio.ListarRegion().Tables[0];
            Ocultarmostrar(true);
        }
      
      

        private void btnCustomerDemo_Click(object sender, EventArgs e)
        {
            lbl1.Text = "Customer Type ID";
            lbl2.Text = "Customes Descripcion";
            dgvRegion.DataSource = servicio.ListarCustomerDemographics().Tables[0];
            Ocultarmostrar(true);
        }

        private void btnShippers_Click(object sender, EventArgs e)
        {
            lbl1.Text = "Shipper ID";
            lbl2.Text = "Company Name";
            lbl3.Text = "Phone";
            dgvRegion.DataSource = servicio.ListarShippers().Tables[0];
            Ocultarmostrar(false);
        }
        private void Ocultarmostrar(bool ocultar)
        {
            if (primero)
            {
                btnActualizar.Visible = true;
                btnAgregar.Visible = true;
                btnBuscar.Visible = true;
                btnEliminar.Visible = true;
                lbl1.Visible = true;
                lbl2.Visible = true;
                txt1.Visible = true;
                txt2.Visible = true;
                txtBuscar.Visible = true;
                dgvRegion.Visible = true;
            }
            if (ocultar)
            {
                limpiar();
                txt3.Visible = false;
                lbl3.Visible = false;
                cbBuscar.Visible = false;
            }
            else
            {
                limpiar();
                txt3.Visible = true;
                lbl3.Visible = true;
                cbBuscar.Visible = true;
            }


        }
        private void limpiar() {
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
        }

    }
}
