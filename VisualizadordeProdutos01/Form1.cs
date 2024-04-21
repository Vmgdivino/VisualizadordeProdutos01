using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Eventing.Reader;
using System.Security.Cryptography.X509Certificates;

namespace VisualizadordeProdutos01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] nomefotosdoscelulares = Directory.GetFiles(@"V:\C#\VisualizadordeProdutos01\ImagensCell");
            foreach (string img in nomefotosdoscelulares)
            {

                string[] separador = img.Split('\\');
                string[] nomeSelecionado = separador[4].Split('.');

                if (comboBox2.Text == nomeSelecionado[0])
                {
                    pictureBox2.ImageLocation = @"V:\C#\VisualizadordeProdutos01\ImagensCell\" + comboBox2.Text + ".JPG";
                    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }


        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Text = string.Empty;

            if (comboBox1.Text == "IPHONE")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("15 PRO MAX");
                comboBox2.Items.Add("14 PRO MAX");
                comboBox2.Items.Add("13 PRO MAX");
            }
            else if (comboBox1.Text == "SAMSUNG")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("S23 ULTRA");
                comboBox2.Items.Add("S24 ULTRA");

            }
            else if (comboBox1.Text == "XIAOMI")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("12C");
                comboBox2.Items.Add("POCO M3");

            }
            else if (comboBox1.Text == "OPPO")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("A17");
                comboBox2.Items.Add("A94");
            }





        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = null;

            comboBox1.Text = null;
            comboBox2.Text = null;

            {

            }
        }



    }

}



  