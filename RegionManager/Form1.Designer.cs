namespace RegionManager
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.drawAreaPanel = new System.Windows.Forms.Panel();
            this.objects1 = new RegionManager.Objects();
            this.tools1 = new RegionManager.Tools();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1048, 33);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(148, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(74, 33);
            this.panel4.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 33);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tools";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(74, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(74, 33);
            this.panel3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "Object";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(74, 33);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Save";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // drawAreaPanel
            // 
            this.drawAreaPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drawAreaPanel.Location = new System.Drawing.Point(0, 33);
            this.drawAreaPanel.Name = "drawAreaPanel";
            this.drawAreaPanel.Size = new System.Drawing.Size(835, 478);
            this.drawAreaPanel.TabIndex = 2;
            this.drawAreaPanel.Click += new System.EventHandler(this.drawAreaPanel_Click);
            this.drawAreaPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.drawAreaPanel_Paint);
            this.drawAreaPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drawAreaPanel_MouseDown);
            this.drawAreaPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.drawAreaPanel_MouseMove);
            this.drawAreaPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.drawAreaPanel_MouseUp);
            // 
            // objects1
            // 
            this.objects1.Dock = System.Windows.Forms.DockStyle.Right;
            this.objects1.Location = new System.Drawing.Point(835, 33);
            this.objects1.Name = "objects1";
            this.objects1.SelectedRegion = RegionManager.Regions.None;
            this.objects1.Size = new System.Drawing.Size(123, 478);
            this.objects1.TabIndex = 3;
            // 
            // tools1
            // 
            this.tools1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tools1.Location = new System.Drawing.Point(958, 33);
            this.tools1.Name = "tools1";
            this.tools1.Size = new System.Drawing.Size(90, 478);
            this.tools1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 511);
            this.Controls.Add(this.drawAreaPanel);
            this.Controls.Add(this.objects1);
            this.Controls.Add(this.tools1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel drawAreaPanel;
        private Objects objects1;
        private Tools tools1;
    }
}

