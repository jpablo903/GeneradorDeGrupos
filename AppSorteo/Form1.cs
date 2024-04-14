using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AppSorteo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chkDuo_Click(object sender, EventArgs e)
        {
            if (chkDuo.Checked)
            {
                chkTrio.Checked = false;
                chkDuo.Checked = true;
            }
            else
            {
                chkDuo.Checked = false;
                chkTrio.Checked = true;
                
            }
        }

        private void chkTrio_Click(object sender, EventArgs e)
        {
            if (chkTrio.Checked)
            {
                chkTrio.Checked = true;
                chkDuo.Checked = false;
            }
            else
            {
                chkDuo.Checked = true;
                chkTrio.Checked = false;

            }
        }

        private void btnGenerador_Click(object sender, EventArgs e)
        {
            string[] lineas = txtBoxNombres.Lines;
            
            List<string> nombres = new List<string>();

            foreach (string linea in lineas)
            {
                if (!string.IsNullOrWhiteSpace(linea))
                {
                    nombres.Add(linea);
                }
            }


            
           
            
            
            Random rand = new Random();

            nombres = nombres.OrderBy(x=>rand.Next()).ToList();

            if (chkDuo.Checked)
            {
                for (int i = 0; i < nombres.Count; i += 2)
                {
                    /*
                    string duo = nombres[i];

                    if (i + 1 < nombres.Count)
                    {
                        duo += ", " + nombres[i + 1];
                    }
                    MessageBox.Show(duo);*/
                    Grupo1.Visible = true;
                    Grupo2.Visible = true;
                    Grupo3.Visible = true;
                    lvlG7.Visible = true;
                    lvlG8.Visible = true;

                    lvlG3.Visible = false;
                    lvlG6.Visible = false;

                    if (i < nombres.Count)
                    {
                        lvlG1.Text = nombres[i];
                    }
                    if (i + 1 < nombres.Count)
                    {
                        lvlG2.Text = nombres[i + 1];
                    }
                    if (i + 2 < nombres.Count)
                    {
                        lvlG4.Text = nombres[i + 2];
                    }
                    if (i + 3 < nombres.Count)
                    {
                        lvlG5.Text = nombres[i + 3];
                    }
                    if (i + 4 < nombres.Count)
                    {
                        lvlG7.Text = nombres[i + 4];
                    }
                    if (i + 5 < nombres.Count)
                    {
                        lvlG8.Text = nombres[i + 5];
                    }
                    i += 5;

                }
            }
            else if (chkTrio.Checked)
            {

                for (int i = 0; i < nombres.Count; i += 3)
                {
                    /* string trio = nombres[i];
                     if (i + 1 < nombres.Count)
                     {
                         trio += ", " + nombres[i + 1];
                     }
                     if (i + 2 < nombres.Count)
                     {
                         trio += ", " + nombres[i + 2];
                     }
                     MessageBox.Show(trio);*/
                    Grupo1.Visible = true;
                    Grupo2.Visible = true;
                    Grupo3.Visible = false;
                    lvlG3.Visible = true;
                    lvlG6.Visible = true;
                 
                    lvlG7.Visible = false;
                    lvlG8.Visible = false;

                    if (i < nombres.Count)
                        {
                            lvlG1.Text = nombres[i];
                        }
                        if (i + 1 < nombres.Count)
                        {
                            lvlG2.Text = nombres[i + 1];
                        }
                        if (i + 2 < nombres.Count)
                        {
                            lvlG3.Text = nombres[i + 2];
                        }
                        if (i + 3 < nombres.Count)
                        {
                            lvlG4.Text = nombres[i + 3];
                        }
                        if (i + 4 < nombres.Count)
                        {
                            lvlG5.Text = nombres[i + 4];
                        }
                        if (i + 5 < nombres.Count)
                        {
                            lvlG6.Text = nombres[i + 5];
                        }
                        i += 5;


                    }
            }

        }

         private void txtBoxNombres_TextChanged(object sender, EventArgs e)
         {

            List<string> lineas = new List<string>(txtBoxNombres.Lines);
            
            lvlContador.Text = txtBoxNombres.Lines.Length.ToString();

            if (lineas.Count > 6  )
             {
                 if (lineas.Take(6).Any(x => string.IsNullOrWhiteSpace(x)))
                 {

                    //MessageBox.Show(string.Join(", ", lineas));
                    MessageBox.Show("NO deben haber espacios en blanco.");
                  
                     lineas.RemoveAll(linea => string.IsNullOrWhiteSpace(linea));

                     txtBoxNombres.Lines = lineas.ToArray();

                     int start = txtBoxNombres.GetFirstCharIndexFromLine(0);
                     
                     txtBoxNombres.Select(start, 6);
                 }
                 else if(txtBoxNombres.Lines.Length > 6)
                {
                     MessageBox.Show("Completo la lista con 6 alumnos, ahora debe generar los grupos.");
                     txtBoxNombres.Enabled = false;
                     lvlContador.Text = "6";
                 }
             }   
         }
        


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtBoxNombres.Text = string.Empty;
            txtBoxNombres.Enabled = true;
            Grupo1.Visible = false;
            Grupo2.Visible = false;
            Grupo3.Visible = false;
        }
    }
}
