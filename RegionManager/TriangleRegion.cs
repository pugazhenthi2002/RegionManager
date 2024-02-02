using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegionManager
{
    class TriangleRegion: IRegion
    {
        private Point[] trianglePoints = new Point[3] { new Point(0, 0), new Point(0, 0), new Point(0, 0) };
        private int rotateCount = 0;
        public int RegionID { get; set; }
        public string RegionName { get; set; }
        public int NoOfEdges { get; }
        public int RegionWidth { get; set; }
        public int RegionHeight { get; set; }
        public Point RegionCoOrdinates { get; set; }

        public void MoveRegion(Point e, Point offSet)
        {
            RegionCoOrdinates = new Point(e.X - offSet.X, e.Y - offSet.Y);
            UpdateTriPoint();
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
                UpdateTriPoint();
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
                UpdateTriPoint();
            }
        }

        public void DrawRegion(Graphics g)
        {
            Brush b = new SolidBrush(Color.Red);
            g.FillPolygon(b, trianglePoints);
        }

        public void RotateCW()
        {
            rotateCount++;
            int temp = RegionHeight;
            RegionHeight = RegionWidth;
            RegionWidth = temp;
            UpdateTriPoint();
        }

        public void RotateAW()
        {
            rotateCount--;
            int temp = RegionHeight;
            RegionHeight = RegionWidth;
            RegionWidth = temp;
            UpdateTriPoint();
        }

        public void FlipH()
        {
            if(rotateCount%2==1)
            {
                rotateCount += 2;
            }
            UpdateTriPoint();
        }
        

        public void FlipV()
        {
            if(rotateCount%2==0)
            {
                rotateCount += 2;
            }
            UpdateTriPoint();
        }

        private void UpdateTriPoint()
        {
            if (rotateCount % 4 == 0)
            {
                trianglePoints = new Point[3] { new Point(RegionCoOrdinates.X + RegionWidth / 2, RegionCoOrdinates.Y), new Point(RegionCoOrdinates.X, RegionCoOrdinates.Y + RegionHeight), new Point(RegionCoOrdinates.X + RegionWidth, RegionCoOrdinates.Y + RegionHeight) };
            }
            else if (rotateCount % 4 == 1)
            {
                trianglePoints = new Point[3] { new Point(RegionCoOrdinates.X, RegionCoOrdinates.Y), new Point(RegionCoOrdinates.X + RegionWidth, RegionCoOrdinates.Y + RegionHeight / 2), new Point(RegionCoOrdinates.X, RegionCoOrdinates.Y + RegionHeight) };
            }
            else if (rotateCount % 4 == 2)
            {
                trianglePoints = new Point[3] { new Point(RegionCoOrdinates.X + RegionWidth / 2, RegionCoOrdinates.Y + RegionHeight), new Point(RegionCoOrdinates.X, RegionCoOrdinates.Y), new Point(RegionCoOrdinates.X + RegionWidth, RegionCoOrdinates.Y) };
            }
            else
            {
                trianglePoints = new Point[3] { new Point(RegionCoOrdinates.X, RegionCoOrdinates.Y + RegionHeight / 2), new Point(RegionCoOrdinates.X + RegionWidth, RegionCoOrdinates.Y), new Point(RegionCoOrdinates.X + RegionWidth, RegionCoOrdinates.Y + RegionHeight) };
            }
        }
    }
}
