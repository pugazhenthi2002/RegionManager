using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegionManager
{
    class CircleRegion:IRegion
    {
        public int RegionID { get; set; }
        public string RegionName { get; set; }
        public int NoOfEdges { get; }
        public int RegionWidth { get; set; }
        public int RegionHeight { get; set; }
        public Point RegionCoOrdinates { get; set; }

        public void MoveRegion(Point e, Point offSet)
        {
            RegionCoOrdinates = new Point(e.X - offSet.X, e.Y - offSet.Y);
        }

        public void Draw(Point e)
        {
            if(RegionCoOrdinates.X > e.X || RegionCoOrdinates.Y > e.Y)
            {
                return;
            }
            else
            {
                RegionWidth = e.X - RegionCoOrdinates.X;
                RegionHeight = e.Y - RegionCoOrdinates.Y;
            }
        }

        public void Resize(Point e)
        {
            if(RegionCoOrdinates.X > e.X || RegionCoOrdinates.Y > e.Y)
            {
                return;
            }
            else
            {
                RegionWidth = e.X - RegionCoOrdinates.X;
                RegionHeight = e.Y - RegionCoOrdinates.Y;
            }
        }

        public void DrawRegion(Graphics g)
        {
            Brush b = new SolidBrush(Color.Red);
            g.FillEllipse(b, new Rectangle(RegionCoOrdinates, new Size(RegionWidth, RegionHeight)));
        }

        public void RotateCW()
        {
            int temp = RegionHeight;
            RegionHeight = RegionWidth;
            RegionWidth = temp;
        }

        public void RotateAW()
        {
            int temp = RegionHeight;
            RegionHeight = RegionWidth;
            RegionWidth = temp;
        }

        public void FlipH()
        {
            ;
        }


        public void FlipV()
        {
            ;
        }


    }
}
