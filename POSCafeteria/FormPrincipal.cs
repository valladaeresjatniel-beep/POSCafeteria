using POSCafeteria.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace POSCafeteria
{
    public partial class FormPrincipal : Form
    {
        private Form _frmlogin;
        private Usuario _usuarioSesion;
        public FormPrincipal(Usuario user, Form frmlogin)
        {
            InitializeComponent();
            this._usuarioSesion = user;
            this._frmlogin = frmlogin;
        }


        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            lblBienvenido.Text = $"¡Bienvenido(a), {_usuarioSesion.NombreCompleto}!";
            lblUsuario.Text = _usuarioSesion.NombreUsuario;
            //lblRol.Text = "";
            lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void btnMenuUsuarios_Click(object sender, EventArgs e)
        {
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            // Cerrar la sesión actual y volver al formulario de inicio de sesión
            _frmlogin.Show();
            this.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnVentasprincipal_Click(object sender, EventArgs e)
        {
            FormCrédito frmCrédito = new FormCrédito();
            this.Hide();
            frmCrédito.Show();
        }

        private void btnClientesprincipal_Click(object sender, EventArgs e)
        {
            FormClientes frmClientes = new FormClientes();
            this.Hide();
            frmClientes.Show();
        }

        private void btnProductoprincipal_Click(object sender, EventArgs e)
        {
            FormProductos frmProductos = new FormProductos();
            this.Hide();
            frmProductos.Show();
        }

        private void btnUsuarioprincipal_Click(object sender, EventArgs e)
        {
            FormUser frmUser = new FormUser();
            this.Hide();
            frmUser.Show();
        }

        private void btnAbonoprincipal_Click(object sender, EventArgs e)
        {
            FormAbono formAbono = new FormAbono();
            this.Hide();
            formAbono.Show();
        }
    }
}
