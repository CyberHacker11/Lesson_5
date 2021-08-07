using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cars = new List<Car>
            {
                new Car
                {
                     Model = "BMW Alpina",
                     Vendor = "Germany",
                     Engine = 3.2M,
                     Year = 2011
                },
                new Car
                {
                     Model = "Mercedes Mclaren",
                     Vendor = "Germany",
                     Engine = 6.1M,
                     Year = 2009
                },
                new Car
                {
                     Model = "KIA Rio X-Line",
                     Vendor = "Korean",
                     Engine = 1.6M,
                     Year = 2021
                },
                new Car
                {
                     Model = "Ferrary Pista",
                     Vendor = "Italy",
                     Engine = 4.4M,
                     Year = 2014
                },
                new Car
                {
                     Model = "Lamborghini Murcielago",
                     Vendor = "Italy",
                     Engine = 6.5M,
                     Year = 2018
                }
            };
            pictures = new List<PictureBox>
            {
                new PictureBox
                {
                    Image = Properties.Resources.BMW,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Size = new Size(352, 265),
                },
                new PictureBox
                {
                    Image = Properties.Resources.Mercedes,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Size = new Size(352, 265),
                },
                new PictureBox
                {
                    Image = Properties.Resources.Kia,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Size = new Size(352, 265),
                },
                new PictureBox
                {
                    Image = Properties.Resources.Ferrari,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Size = new Size(352, 265),
                },
                new PictureBox
                {
                    Image = Properties.Resources.Lamba,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Size = new Size(352, 265),
                },
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pbx_Display.Image = pictures[Next].Image;
            lbl_Model.Text = $"Model: {cars[Next].Model}";
            lbl_Vendor.Text = $"Vendor: {cars[Next].Vendor}";
            lbl_Year.Text = $"Year: {cars[Next].Year}";
            lbl_Engine.Text = $"Engine: {cars[Next].Engine}";
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            if (Next < cars.Count - 1) Next++;
            Form1_Load(this, e);
        }

        List<Car> cars;
        List<PictureBox> pictures;
        public short Next { get; set; } = 0;

        private void btn_Back_Click(object sender, EventArgs e)
        {
            if (Next - 1 >= 0) Next--;
            Form1_Load(this, e);
        }
    }
}