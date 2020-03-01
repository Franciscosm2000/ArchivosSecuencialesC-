using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Proyecto_Aleatorios_Archivos
{
    class Archivo
    {
        ListView lista_,lista2,lista3;
        
        char[] separador = { ',' };

        //Metodo para agregar valores al txt
        public void Agregar(String a, String b, String c, String d)
        {
            String ruta = "Datos.txt";

            StreamWriter escribir = File.AppendText(ruta);

            escribir.WriteLine(a + ", " + b + ", " + c + ", " + d);
            escribir.Close();

            MessageBox.Show("Agregado Correctamente");
        }

        // Metodo para Mostrar todos los registros
        public void mostrar_todo(ListView lista)
        {
            String[] datos = new String[4];
            String cadena;
            this.lista_ = lista;
            //Lectura de archivo

            StreamReader leer = File.OpenText("Datos.txt");
            cadena = leer.ReadLine();
            while (cadena != null)
            {
                datos = cadena.Split(separador);
                ListViewItem sub = new ListViewItem(datos[0]);
                sub.SubItems.Add(datos[1].Trim());
                sub.SubItems.Add(datos[2].Trim());
                sub.SubItems.Add(datos[3].Trim());
                lista_.Items.Add(sub);
                cadena = leer.ReadLine();
            }
            leer.Close();
        }

        //Metodo para buscar un registro por nombre

        public void buscar_por_nombre(String nombre, ListView lista)
        {
            String[] datos = new String[4];
            String cadena;
            bool encontrado = false;
            //haciendo referencia que List_view pasado por parametro es el mismo que el declarado
            this.lista2 = lista;
            try
            {
                StreamReader leer = new StreamReader("Datos.txt");
                cadena = leer.ReadLine();

                while (cadena != null && encontrado == false)
                {
                    datos = cadena.Split(separador);

                    if (datos[0].Trim().Equals(nombre))
                    {
                        MessageBox.Show("Encontrado :)");
                        ListViewItem sub = new ListViewItem(datos[0]);
                        sub.SubItems.Add(datos[1].Trim());
                        sub.SubItems.Add(datos[2].Trim());
                        sub.SubItems.Add(datos[3].Trim());
                        lista2.Items.Add(sub);
                        encontrado = true;
                    }
                    else
                    {
                        cadena = leer.ReadLine();
                    }
                }
                if (encontrado == false)
                {
                    MessageBox.Show("No se encuentra en la base de datos :(");
                }
                leer.Close();
            }
            catch (IOException e) { MessageBox.Show("Error"); }
        }

        // Buscar por Sueldo Metodo
        public void buscar_por_sueldo(String sueldo, ListView lista)
        {
            String[] datos = new String[4];
            String cadena;
            bool encontrado = false;
            //haciendo referencia que List_view pasado por parametro es el mismo que el declarado
            this.lista3 = lista;
            try
            {
                StreamReader leer = new StreamReader("Datos.txt");
                cadena = leer.ReadLine();

                while (cadena != null && encontrado == false)
                {
                    datos = cadena.Split(separador);

                    if (datos[3].Trim().Equals(sueldo))
                    {
                        MessageBox.Show("Encontrado :)");
                        ListViewItem sub = new ListViewItem(datos[0]);
                        sub.SubItems.Add(datos[1].Trim());
                        sub.SubItems.Add(datos[2].Trim());
                        sub.SubItems.Add(datos[3].Trim());
                        lista3.Items.Add(sub);
                        encontrado = true;
                    }
                    else
                    {
                        cadena = leer.ReadLine();
                    }
                }
                if (encontrado == false)
                {
                    MessageBox.Show("No se encuentra en la base de datos :(");
                }
                leer.Close();
            }
            catch (IOException e) { MessageBox.Show("Error"); }
        }

        //Elinar datos 

        public void eliminando(String eli)
        {
            StreamWriter escri;
            StreamReader leer;
            String[] datos = new String[4];
            String cadena;
            bool encontrado = false;

            try
            {
              escri = File.CreateText("Tmp.txt");
              leer  = File.OpenText("Datos.txt");

                cadena = leer.ReadLine();

                while (cadena != null)
                {
                    datos = cadena.Split(separador);

                    if (datos[0].Trim().Equals(eli))
                    {
                        encontrado = true;
                    }
                    else
                    {
                        escri.WriteLine(cadena);
                    }
                    cadena = leer.ReadLine();
                }
                if (encontrado == true)
                { MessageBox.Show("Eliminado Correctamente :)"); }
                leer.Close();
                escri.Close();
                File.Delete("Datos.txt");
                File.Move("Tmp.txt", "Datos.txt");
            }
            catch (IOException e)
            {
                MessageBox.Show("Error");
            }
            

        }

        //Metodo para Modificar un registro

        public void Modificar(String registro, String nuevo_)
        {
            String[] datos = new String[4];
            String cadena;
            bool encontrado = false;
            try
            {
                StreamReader leer = File.OpenText("Datos.txt");
                StreamWriter escribir = File.CreateText("Tmp.txt");

                cadena = leer.ReadLine();
                while (cadena != null)
                {
                    datos = cadena.Split(separador);

                    if (datos[0].Trim().Equals(registro))
                    {
                        encontrado = true;
                        escribir.WriteLine(nuevo_+", "+datos[1] + ", "+datos[2] + ", "+datos[3]);
                    }
                    else
                    {
                        escribir.WriteLine(cadena);
                    }
                    cadena = leer.ReadLine();
                }
                leer.Close();
                escribir.Close();

                File.Delete("Datos.txt");
                File.Move("Tmp.txt", "Datos.txt");
                MessageBox.Show("Modificado Correctamente");
            }
            catch (IOException e) { MessageBox.Show("Error"); }
            
        }

    }
}
