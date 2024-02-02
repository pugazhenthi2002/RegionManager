using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegionManager
{
    static class RegionController
    {
        public static List<IRegion> regionCollection = new List<IRegion>();
        public static List<Rectangle> regionRectangleCollection = new List<Rectangle>();
        public static IRegion SelectedRegion;
        public static IRegion SelectedDrawnRegion;
        public static Point OffSet;

        public static void AddRegion(Regions region, Point Location)
        {
            switch (region)
            {
                case Regions.Circle:
                    SelectedRegion = new CircleRegion
                    {
                        RegionID = regionCollection.Count,
                        RegionName = "Circle " + regionCollection.Count,
                        RegionWidth = 0,
                        RegionHeight = 0,
                        RegionCoOrdinates = new Point(Location.X, Location.Y)
                    };
                    break;

                case Regions.Rectangle:
                    SelectedRegion = new RectangleRegion
                    {
                        RegionID = regionCollection.Count,
                        RegionName = "Rectangle " + regionCollection.Count,
                        RegionWidth = 0,
                        RegionHeight = 0,
                        RegionCoOrdinates = new Point(Location.X, Location.Y)
                    };
                    break;

                case Regions.Triangle:
                    SelectedRegion = new TriangleRegion
                    {
                        RegionID = regionCollection.Count,
                        RegionName = "Triangle " + regionCollection.Count,
                        RegionWidth = 0,
                        RegionHeight = 0,
                        RegionCoOrdinates = new Point(Location.X, Location.Y)
                    };
                    break;

                case Regions.SemiCircle:
                    SelectedRegion = new SemiCircleRegion
                    {
                        RegionID = regionCollection.Count,
                        RegionName = "SemiCircle " + regionCollection.Count,
                        RegionWidth = 0,
                        RegionHeight = 0,
                        RegionCoOrdinates = new Point(Location.X, Location.Y)
                    };
                    break;
            }
            regionCollection.Add(SelectedRegion);
        }

        public static void ClearRegion()
        {
            SelectedRegion = null;
        }

        public static void DrawRegion(Graphics g)
        {
            
            Brush b = new SolidBrush(Color.Red);
            for (int ctr = 0; ctr < RegionController.regionCollection.Count; ctr++)
            {
                RegionController.regionCollection[ctr].DrawRegion(g);
            }

            if(SelectedDrawnRegion!=null)
            {
                g.DrawRectangle(new Pen(Color.Black), new Rectangle(SelectedDrawnRegion.RegionCoOrdinates, new Size(SelectedDrawnRegion.RegionWidth, SelectedDrawnRegion.RegionHeight)));
            }

        }

        public static bool CheckSelectedDrawnRegion(Point m)
        {
            for (int ctr = 0; ctr < regionCollection.Count; ctr++)
            {
                if ((m.X >= regionCollection[ctr].RegionCoOrdinates.X && m.X <= regionCollection[ctr].RegionCoOrdinates.X + regionCollection[ctr].RegionWidth) && (m.Y >= regionCollection[ctr].RegionCoOrdinates.Y && m.Y <= regionCollection[ctr].RegionCoOrdinates.Y + regionCollection[ctr].RegionHeight))
                {
                    SelectedDrawnRegion = regionCollection[ctr];
                    return true;
                }
            }
            SelectedDrawnRegion = null;
            return false;
        }

        //public static bool CheckCursorPoint(Point e)
        //{
        //    IRegion IterRegion;
        //    for (int ctr = 0; ctr < RegionController.regionCollection.Count; ctr++)
        //    {
        //        IterRegion = regionCollection[ctr];
        //        if(IterRegion.RegionCoOrdinates.X + IterRegion.RegionWidth)
        //    }
        //    SelectedDrawnRegion = null;
        //    return false;
        //}

        public static void SetOffSet(Point e)
        {
            OffSet = new Point(e.X - SelectedDrawnRegion.RegionCoOrdinates.X, e.Y - SelectedDrawnRegion.RegionCoOrdinates.Y);
        }

        public static void RegionToolManager(Tool toolType, Point Location)
        {
            switch (toolType)
            {
                case Tool.None: SelectedRegion.Draw(Location); break;
                case Tool.Move: SelectedDrawnRegion.MoveRegion(Location, OffSet); break;
                case Tool.RotateCW: SelectedDrawnRegion.RotateCW(); break;
                case Tool.RotateAW: SelectedDrawnRegion.RotateAW(); break;
                case Tool.FlipH: SelectedDrawnRegion.FlipH(); break;
                case Tool.FlipV: SelectedDrawnRegion.FlipV(); break;
            }
        }

    }
}
