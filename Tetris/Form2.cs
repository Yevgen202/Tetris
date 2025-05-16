using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tetris.Controllers;

namespace Tetris
{
    public partial class Form2: Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Start_game_Click(object sender, EventArgs e)
        {
            Form1 gameForm = new Form1();
            gameForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Visible = !button2.Visible;
            button3.Visible = !button3.Visible;
            button4.Visible = !button4.Visible;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MapController.Interval = 500;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MapController.Interval = 300;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MapController.Interval = 100;

        }

        private void інформаціяПроГруToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Для початку гри оберіть складність та натисніть кнопку 'Почати гру'.\n" +
                "Управління:\n" +
                "Стрілка вгору - обертання фігури\n" +
                "Стрілка вниз - прискорити падіння фігури\n" +
                "Стрілка вліво - перемістити фігуру вліво\n" +
                "Стрілка вправо - перемістити фігуру вправо\n" +
                "Esc - пауза");
        }
    }
}
