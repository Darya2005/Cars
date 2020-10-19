using System;
using System.Windows.Forms;
using System.Data.Common;
using System.Drawing;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formula1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            

            List<string> results = Program.Select("SELECT * FROM cars");

            int y = 50;


            for (int i = 0; i < results.Count; i = i + 7)
            {
                //Для каждой создаем лейбл

                labelCars.Text += results[i + 0] + Environment.NewLine +
                results[i + 1] + Environment.NewLine + y;
                //Чтобы оно открылось в новом окне, сохраняем текст и описание
              
                pictureBox1.Image = Image.FromFile("Pictures/Haas.jpg");
            }
          


           
          
        }

        private void labelCars_Click(object sender, EventArgs e)
        {

        }
    }
}
