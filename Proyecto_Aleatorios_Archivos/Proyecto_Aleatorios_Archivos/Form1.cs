using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Proyecto_Aleatorios_Archivos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Agregando los datos al fichero
            Archivo ar = new Archivo();
            ar.Agregar(nom.Text,edad.Text,dire.Text,sueldo.Text);
            //Mandando los datos a una lista en forma de tabla
            ListViewItem lista = new ListViewItem(nom.Text);
            lista.SubItems.Add(edad.Text);
            lista.SubItems.Add(dire.Text);
            lista.SubItems.Add(sueldo.Text);
            lista_.Items.Add(lista);
            c = 0;
            lista1.Items.Clear();
            //Limpiando los texBox
            Nombre.Text = "";
            edad.Text = "";
            dire.Text = "";
            sueldo.Text = "";
        }

        private void nom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==(char)Keys.Enter)
            {
                edad.Focus();
            }
        }

        private void edad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                dire.Focus();
            }
        }

        private void dire_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {
                sueldo.Focus();
            }
        }

        private void sueldo_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {
                agregar.Focus();
            }
        }

        private void agregar_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {
                // Agregando los datos al fichero
                Archivo ar = new Archivo();
                ar.Agregar(nom.Text, edad.Text, dire.Text, sueldo.Text);
                //Mandando los datos a una lista en forma de tabla
                ListViewItem lista = new ListViewItem(nom.Text);
                lista.SubItems.Add(nom.Text);
                lista.SubItems.Add(edad.Text);
                lista.SubItems.Add(dire.Text);
                lista.SubItems.Add(sueldo.Text);
                lista_.Items.Add(lista);
                //Limpiando los texBox
                Nombre.Text = "";
                edad.Text = "";
                dire.Text = "";
                sueldo.Text = "";
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            lbl_cambio.Show();
            lbl_cambio.Text = "Nombre :";
            buscar_.Show();
            buscar_datos.Show();
            buscar_datos.Text = "Buscar";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            lbl_cambio.Show();
            lbl_cambio.Text = "Sueldo :";
            buscar_.Show();
            buscar_datos.Show();
            buscar_datos.Text = "Buscar";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void buscar_datos_Click(object sender, EventArgs e)
        {
            if (lbl_cambio.Text.Equals("Nombre :"))
            {
                Archivo ar = new Archivo();
                ar.buscar_por_nombre(buscar_.Text, lista1);
                buscar_.Text = "";
            }
            else if (lbl_cambio.Text.Equals("Sueldo :"))
            {
                Archivo ar = new Archivo();
                ar.buscar_por_sueldo(buscar_.Text, lista1);
                buscar_.Text = "";
            }
            else if (lbl_cambio.Text.Equals("Nuevo Nombre :"))
            {
                foreach (ListViewItem lista in lista1.SelectedItems)
                {
                    Archivo ar = new Archivo();
                    ar.Modificar( lista.Text, buscar_.Text);
                    buscar_.Text = "";
                }
                
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            foreach (ListViewItem lista in lista1.SelectedItems)
            {
                Archivo ar = new Archivo();
                ar.eliminando(lista.Text.ToString());
                lista.Remove();
            }
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            c++;
            lbl_cambio.Hide();
            lbl_cambio.Text = "Bucar";
            buscar_.Hide();
            if (c == 1)
            {
                buscar_datos.Hide();
                Archivo ar = new Archivo();
                ar.mostrar_todo(lista1);
            }
        }
        int c=0;

        private void button1_Click_2(object sender, EventArgs e)
        {
            lbl_cambio.Text ="Nuevo Nombre :" ;
            lbl_cambio.Show();
            buscar_.Show();
            buscar_datos.Show();
            buscar_datos.Text = "Modificar";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lista1.Items.Clear();
            Archivo ar = new Archivo();
            ar.mostrar_todo(lista1);
        }
    }
}
