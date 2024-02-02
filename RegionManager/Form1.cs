using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegionManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.DoubleBuffered = true;
            InitializeComponent();
            objects1.Visible = tools1.Visible = false;
        }

        private int startX, startY;
        private Point offSet;
        private bool isDragging = false, isSelectedRegionDragging = false;
        //private IRegion SelectedDrawnRegion;


        private void drawAreaPanel_MouseDown(object sender, MouseEventArgs e)
        {
            var m = e as MouseEventArgs;
            isSelectedRegionDragging = RegionController.CheckSelectedDrawnRegion(m.Location);
            drawAreaPanel.Invalidate();

            if (tools1.ToolType != Tool.None && isSelectedRegionDragging)
            {

                RegionController.SetOffSet(e.Location);
                RegionController.RegionToolManager(tools1.ToolType, e.Location);
            }

            if(objects1.SelectedRegion != Regions.None)
            {
                startX = 0;
                startY = 0;
                isDragging = true;
                RegionController.AddRegion(objects1.SelectedRegion, e.Location);
                tools1.ToolType = Tool.None;
            }
        }

        private void drawAreaPanel_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
            isSelectedRegionDragging = false;
            if(objects1.SelectedRegion != Regions.None)
            {
                RegionController.ClearRegion();
                objects1.SelectedRegion = Regions.None;
            }
        }

        private void drawAreaPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if(isSelectedRegionDragging)
            {
                if (tools1.ToolType == Tool.Move)
                {
                    RegionController.RegionToolManager(tools1.ToolType, e.Location);
                }
            }
            if (isDragging && objects1.SelectedRegion != Regions.None)
            {
                RegionController.RegionToolManager(tools1.ToolType, e.Location);
            }
            drawAreaPanel.Invalidate();
        }

        private void drawAreaPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            RegionController.DrawRegion(g);
        }

        private void drawAreaPanel_Click(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {
            objects1.Visible = !objects1.Visible;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            tools1.Visible = !tools1.Visible;
        }
    }
}
