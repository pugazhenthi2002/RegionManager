using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegionManager
{
    class SemiCircleRegion:IRegion
    {
        private int rotateCount = 0, startAngle = 180, sweepAngle = 180;
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
            if (RegionCoOrdinates.X > e.X || RegionCoOrdinates.Y > e.Y)
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
            if (RegionCoOrdinates.X > e.X || RegionCoOrdinates.Y > e.Y)
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
            if (RegionWidth > 0 && RegionHeight > 0)
            g.FillPie(b, new Rectangle(RegionCoOrdinates, new Size(RegionWidth, RegionHeight)), startAngle, sweepAngle);
        }

        public void RotateCW()
        {
            startAngle += 90;
            int temp = RegionHeight;
            RegionHeight = RegionWidth;
            RegionWidth = temp;
        }

        public void RotateAW()
        {
            startAngle -= 90;
            int temp = RegionHeight;
            RegionHeight = RegionWidth;
            RegionWidth = temp;
        }

        public void FlipH()
        {
            if(startAngle%180==90)
            {
                startAngle += 180;
            }
        }

        public void FlipV()
        {
            if(startAngle%180==0)
            {
                startAngle += 180;
            }
        }

    }
}
