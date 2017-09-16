using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace GSM
{
    public partial class Main : Form
    {
        public LinkedList<Cell> cells;
        public static Graphics bitmapGraphics;
        public Pen p;
        public ControlPanel control;
        public static int maxWidth, maxHeight;

        public Main()
        {
            InitializeComponent();
            maxWidth = 600;
            maxHeight = 600;
            control = new ControlPanel();
            control.Show();
        }

        private void Main_Paint(object sender, PaintEventArgs e)
        {
            cells = new LinkedList<Cell>();
            Main.bitmapGraphics = e.Graphics;
            p = new Pen(Color.Black);

            float x = 20, y = 0, side = 40;
            int sign = 1;

            for (int i = 1; i < 5; i++)
            {
                for (int j = 1; j < 5; j++)
                {
                    Cell c = new Cell(x + (j-1)*3*side, y);
                    c.drawCell(bitmapGraphics, p);
                    cells.AddLast(c);
                }
                y = y + (float)(Math.Cos(30 * Math.PI / 180) * side);
                x = x + (float)(sign * 1.5 * side);
                sign *= -1;
            }

            addUser();
            /*
            Bitmap bitmap = new Bitmap(400 , 400);
            Graphics bitmapGraphics = Graphics.FromImage(bitmap);
            SolidBrush sb = new SolidBrush(Color.Black);
            Graphics graphicsObject = e.Graphics;
            Rectangle drawArea1 = new Rectangle( 5, 35, 30, 100 );
            LinearGradientBrush linearBrush = new LinearGradientBrush(drawArea1, Color.Blue, Color.Yellow, LinearGradientMode.ForwardDiagonal);
            //draw ellipse filled with a blue-yellow gradient
         	graphicsObject.FillEllipse( linearBrush, 5, 30, 65, 100 );
             */
        }

        public void addCell(float x, float y)
        {
            p = new Pen(Color.Black);
            Cell c = new Cell(x , y);
            c.drawCell(Main.bitmapGraphics, p);
            cells.AddLast(c);
        }

        public void deleteCell(float x, float y)
        {
            p = new Pen(Color.White);
            Cell c = new Cell(x, y);
            c.drawCell(Main.bitmapGraphics, p);
            //cells.AddLast(c);
        }

        public void addUser()
        {
            int x = 1;
            int y = 10;
            
            while (true)
            {
                p = new Pen(Color.Black);
                Point p1 = new Point(x+10,y+10);
                Point p2 = new Point(x+10,y+11);
                //bitmapGraphics.DrawString(".", new Font("Microsoft Sans Serif",9), 
                bitmapGraphics.DrawLine(p, p1, p2);

                x++;
            }
        }

        public void deleteUser()
        {
        }
    }

    public class Cell
    {
        float x;  //X co-ordinate of left top of cell
        float y;  //Y co-ordinate of left top of cell
        float side = 40;    //Length of side of hexagon	
        float h = (float)(Math.Sin(30 * Math.PI / 180) * 40); //20
        float r = (float)(Math.Cos(30 * Math.PI / 180) * 40); //35
        PointF[] points;

        public Cell(float x, float y)
        {
            this.x = x;
            this.y = y;
            points = new PointF[6];
        }

        public void drawCell(Graphics s, Pen p)
        {
            //Console.Write(Main.ActiveForm.Width + " " + Main.ActiveForm.Height + "Printed" + this.x + this.y); 
            points[0] = new PointF(x, y);
            points[1] = new PointF(x + side, y);
            points[2] = new PointF(x + side + h, y + r);
            points[3] = new PointF(x + side, y + r + r);
            points[4] = new PointF(x, y + r + r);
            points[5] = new PointF(x - h, y + r);

            if (this.x >= 0 && this.x <= (Main.maxWidth - 2*side) && this.y >= 0 && this.y <= (Main.maxHeight - 2*side))
            {
                s.DrawPolygon(p, points);
            }
            else
            {
                MessageBox.Show("Cannot create a cell at specified location");
            }
            //Console.WriteLine(h + " " + r + " " + points[0] + " " + points[1] + " " + points[2] + " " + points[3] + " " + points[4] + " " + points[5] + " ");
        }
    }
}
