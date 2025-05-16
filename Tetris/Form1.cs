using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tetris.Controllers;

namespace Tetris
{
    public partial class Form1 : Form
    {


        string playerName;

        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            if (!File.Exists(RecordsController.recordPath))
                File.Create(RecordsController.recordPath);
            playerName = Microsoft.VisualBasic.Interaction.InputBox("Введіть ім'я гравця", "Налаштування гравця", "Новий гравець");
            if (playerName == "")
            {
                playerName = "Новий гравець";
            }
            this.KeyUp += new KeyEventHandler(keyFunc);
            this.Focus(); // Додаємо фокус
            Init();
        }

        public void Init()
        {
            this.Text = "Тетріс: Поточний гравець - " + playerName;
            MapController.size = 25;
            MapController.score = 0;
            MapController.linesRemoved = 0;
            MapController.currentShape = new Shape(3, 0);
            
            label1.Text = "Score: " + MapController.score;
            label2.Text = "Lines: " + MapController.linesRemoved;



            timer1.Interval = MapController.Interval;
            timer1.Tick += new EventHandler(update);
            timer1.Start();


            Invalidate();
        }

        private void keyFunc(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:

                    if (!MapController.IsIntersects())
                    {
                        MapController.ResetArea();
                        MapController.currentShape.RotateShape();
                        MapController.Merge();
                        Invalidate();
                    }
                    break;
                case Keys.Down:
                    timer1.Interval = 10;
                    break;
                case Keys.Right:
                    if (!MapController.CollideHor(1))
                    {
                        MapController.ResetArea();
                        MapController.currentShape.MoveRight();
                        MapController.Merge();
                        Invalidate();
                    }
                    break;
                case Keys.Left:
                    if (!MapController.CollideHor(-1))
                    {
                        MapController.ResetArea();
                        MapController.currentShape.MoveLeft();
                        MapController.Merge();
                        Invalidate();
                    }
                    break;
            }
        }


        private void update(object sender, EventArgs e)
        {
            MapController.ResetArea();
            if (!MapController.Collide())
            {
                MapController.currentShape.MoveDown();
            }
            else
            {
                MapController.Merge();
                MapController.SliceMap(label1, label2);
                timer1.Interval = MapController.Interval;
                MapController.currentShape.ResetShape(3, 0);
                if (MapController.Collide())
                {
                    MapController.ClearMap();
                    timer1.Tick -= new EventHandler(update);
                    timer1.Stop();
                    MessageBox.Show("Ваш результат: " + MapController.score);
                    Init();
                }
            }
            MapController.Merge();
            Invalidate();
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
            MapController.DrawGrid(e.Graphics);
            MapController.DrawMap(e.Graphics);
            MapController.ShowNextShape(e.Graphics);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btn_pouse.Visible = !btn_pouse.Visible;
            btn_restart.Visible = !btn_restart.Visible;
            btn_dovidka.Visible = !btn_dovidka.Visible;
        }

        private void btn_pouse_Click(object sender, EventArgs e)
{
    if (timer1.Enabled)
    {
        if (sender is ToolStripMenuItem menuItem)
            menuItem.Text = "Продовжить";
        else if (sender is Button btn)
            btn.Text = "Продовжить";
        timer1.Stop();
    }
    else
    {
        if (sender is ToolStripMenuItem menuItem)
            menuItem.Text = "Пауза";
        else if (sender is Button btn)
            btn.Text = "Пауза";
        timer1.Start();
    }
}

        private void btn_restart_Click(object sender, EventArgs e)
        {
            timer1.Tick -= update;
            timer1.Stop();
            MapController.ClearMap();
            Init();
        }

        private void btn_dovidka_Click(object sender, EventArgs e)
        {
            string infoString = "";
            infoString = "Для керування фігурами використовуйте стрілочку вліво/вправо.\n";
            infoString += "Щоб прискорить падіння фігури - натисніть стрілочку вниз.\n";
            infoString += "Для поворота фігури використовуйте стрілочку вгору.\n";
            MessageBox.Show(infoString, "Довідка");
        }
    }
}