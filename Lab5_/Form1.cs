using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Lab5_
{
    enum direction : byte { Up, Right, Down, Left };
    public partial class Form1 : Form
    {
        Cockroach workCockroach;//рабочий Таракан - активный Таракан, который будет выполнять алгоритм
        PictureBox workpb;//рабочее поле PictureBox - поле на которой будет рабочий Таракан
        List<Cockroach> LC;//Список для хранения созданных Тараканов
        List<PictureBox> PB;//Список для хранения созданных объектов PictureBox

        List<Cockroach> workAction;
        List<PictureBox> workField;
        Cockroach cockroach;
        Random rnd = new Random();
        int AlgStep; //текущая комманда

        public Form1()
        {
            InitializeComponent();
            LC = new List<Cockroach>();
            PB = new List<PictureBox>();
            workField = new List<PictureBox>();
            workAction = new List<Cockroach>();
            Random rnd = new Random();
        }
        public void RePaint(Cockroach c, PictureBox p)
        {
            p.Bounds = new Rectangle(c.X, c.Y, c.Image.Width, c.Image.Height);//создание новых границ изображения для PictureBox
            p.Image = c.Image;
        }

        public void Show(Cockroach c, PictureBox p, Panel owner)
        {
            RePaint(c, p);
            owner.Controls.Add(p);//добавляем PictureBox к элементу Panel
        }

        private void IMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (Form.ModifierKeys != Keys.Control)
                {
                    ClearWorkItems();
                }
                int k = PB.IndexOf(sender as PictureBox);//запоминаем номер нажатого компонента PictureBox
                workpb = sender as PictureBox;//объявляем его рабочим
                workCockroach = LC[k];//по найденному номеру находим Таракана в списке
                if (!workField.Any())
                {
                    workAction.Add(workCockroach);
                    workField.Add(workpb);
                }
                else if (!workField.Contains(workpb))
                {
                    workAction.Add(workCockroach);
                    workField.Add(workpb);
                }
            }
            else
            if (e.Button == MouseButtons.Right)//cмена образа таракана нажатием ПКМ
            {
                ClearWorkItems();
                int k = PB.IndexOf(sender as PictureBox);
                workpb = sender as PictureBox;
                if ((LC[k].Image.Tag).ToString() == "1")
                {
                    LC[k] = new Cockroach(new Bitmap("cockroach1.png"));
                    LC[k].Image.Tag = "2";
                }
                else
                {
                    LC[k] = new Cockroach(new Bitmap("cockroach.png"));
                    LC[k].Image.Tag = "1";
                }
                workField.Add(workpb);
                workAction.Add(LC[k]);
                RePaint(LC[k], PB[k]);
            }
        }

        private void IMouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                PictureBox picture = sender as PictureBox;
                picture.Tag = new Point(picture.Location.X + e.X + 1, picture.Location.Y + e.Y + 1);//запоминаем координаты мыши в момент начала перетаскивания
                picture.DoDragDrop(sender, DragDropEffects.Move);//начинаем перетаскивание ЧЕГО и с КАКИМ ЭФФЕКТОМ
            }
        }

        private void NewHero_Click(object sender, EventArgs e)
        {
            int dx = rnd.Next(Field.Width);
            int dy = rnd.Next(Field.Height);
            cockroach = new Cockroach(new Bitmap("cockroach.png"));
            cockroach.Image.Tag = "1";
            cockroach.newcoordinates(dx, dy);
            PictureBox p = new PictureBox();
            p.Location = new Point(dx, dy);
            Show(cockroach, p, Field);
            p.MouseMove += new MouseEventHandler(IMouseMove);
            p.MouseDown += new MouseEventHandler(IMouseDown);
            PB.Add(p);
            LC.Add(cockroach);
            workCockroach = cockroach;
            workpb = p;
            ClearWorkItems();
            workField.Add(workpb);
            workAction.Add(workCockroach);
        }

        private void Field_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(PictureBox)))
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void Field_DragDrop(object sender, DragEventArgs e)
        {
            if (Form.ModifierKeys == Keys.Control)
            {
                return;
            }
            //извлекаем PictureBox
            PictureBox picture = (PictureBox)e.Data.GetData(typeof(PictureBox));
            Panel panel = sender as Panel;
            //получаем клиентские координаты в момент отпускания кнопки
            Point pointDrop = panel.PointToClient(new Point(e.X, e.Y));
            //извлекаем клиентские координаты мыши в момент начала перетаскивания
            Point pointDrag = (Point)picture.Tag;
            //вычисляем и устанавливаем Location для PictureBox в Panel
            picture.Location = new Point(pointDrop.X - pointDrag.X + picture.Location.X, pointDrop.Y - pointDrag.Y + picture.Location.Y);
            workAction[0].X = picture.Location.X;
            workAction[0].Y = picture.Location.Y;
            workField[0].Location = picture.Location;
            picture.Parent = panel;
        }

        private void timerAlgorithm_Tick(object sender, EventArgs e)
        {
            if (AlgStep == Algorithm.Items.Count)//конец алгоритма
            {
                TimerAlgorithm.Stop();//выключение таймера
            }
            else//выполнение команды из списка
            {
                for (int i = 0; i < workField.Count; i++)
                {
                    string s = (string)Algorithm.Items[AlgStep];
                    Algorithm.SetSelected(AlgStep, true);
                    if (s == "Step")
                        workAction[i].Step();
                    else
                        workAction[i].ChangeTrend(s[0]);
                    RePaint(workAction[i], workField[i]);
                }
                AlgStep++;
            }
        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            TimerAlgorithm.Enabled = true;
            AlgStep = 0;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            Algorithm.Items.Clear();
        }

        private void DeleteButton_Click(object sender, EventArgs e)//кнопка удаления таракана
        {
            while (workField.Count > 0)
            {
                workField[0].Dispose();
                workField.RemoveAt(0);
            }
            if (workpb != null)
            {
                workpb.Dispose();
            }
            ClearWorkItems();
        }

        private void ClearWorkItems()
        {
            workAction.Clear();
            workField.Clear();
        }

        private void UpButton_Click(object sender, EventArgs e)
        {
            Algorithm.Items.Add((sender as Button).Text);
        }
        private void RightButton_Click(object sender, EventArgs e)
        {
            Algorithm.Items.Add((sender as Button).Text);
        }
        private void DownButton_Click(object sender, EventArgs e)
        {
            Algorithm.Items.Add((sender as Button).Text);
        }
        private void LeftButton_Click(object sender, EventArgs e)
        {
            Algorithm.Items.Add((sender as Button).Text);
        }
        private void StepButton_Click(object sender, EventArgs e)
        {
            Algorithm.Items.Add((sender as Button).Text);
        }
    }
}

