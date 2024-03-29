﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string elem = txtNombre.Text;
            lvElementos.Items.Add(elem);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboColorFav.Items.Add("Rojo");
            cboColorFav.Items.Add("Negro");
            cboColorFav.Items.Add("Azul");
            cboColorFav.Items.Add("Amarillo");


        }

        private void btnVerPerfil_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            DateTime fecha = dateTimePickerFechaNacimiento.Value;
            // operador ternario
            string chocolate = ckbChocolate.Checked == true ? "Le gusta el chocolate" : "Odia el chocolate";
            string tipo;
            if (rbtMuggle.Checked)
            {
                tipo = "Muggle";
            }else if (rbtWizard.Checked)
            {
                tipo = "Wizard";
            }
            else
            {
                tipo = "Squibs";
            }

            string colorFavorito = cboColorFav.SelectedItem.ToString();

            string numeroFavorito = numNumeroFavorito.Value.ToString();

            string mensaje = chocolate + ", es " + tipo + " , su color es " + colorFavorito + ", su numero es : " + numeroFavorito ;
            MessageBox.Show("Nombre: " + nombre + "Fecha: " + fecha + ", " + mensaje);
        }

        private void lvElementos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
