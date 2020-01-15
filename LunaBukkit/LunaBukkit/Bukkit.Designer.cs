using System.Windows.Forms;

namespace LunaBukkit {
    partial class Bukkit {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.sidePanel = new System.Windows.Forms.Panel();
            this.sideFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.colorPanel = new System.Windows.Forms.Panel();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.LOGO = new System.Windows.Forms.PictureBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.mainLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.topPanel = new System.Windows.Forms.Panel();
            this.minBox = new System.Windows.Forms.PictureBox();
            this.closeBox = new System.Windows.Forms.PictureBox();
            this.titleText = new System.Windows.Forms.Label();
            this.sidePanel.SuspendLayout();
            this.logoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LOGO)).BeginInit();
            this.mainPanel.SuspendLayout();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBox)).BeginInit();
            this.SuspendLayout();
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.sidePanel.Controls.Add(this.sideFlowLayoutPanel);
            this.sidePanel.Controls.Add(this.colorPanel);
            this.sidePanel.Controls.Add(this.logoPanel);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(80, 550);
            this.sidePanel.TabIndex = 0;
            // 
            // sideFlowLayoutPanel
            // 
            this.sideFlowLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.sideFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sideFlowLayoutPanel.Location = new System.Drawing.Point(0, 80);
            this.sideFlowLayoutPanel.Name = "sideFlowLayoutPanel";
            this.sideFlowLayoutPanel.Size = new System.Drawing.Size(80, 465);
            this.sideFlowLayoutPanel.TabIndex = 2;
            this.sideFlowLayoutPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Bukkit_MouseMove);
            // 
            // colorPanel
            // 
            this.colorPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(203)))), ((int)(((byte)(196)))));
            this.colorPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.colorPanel.Location = new System.Drawing.Point(0, 545);
            this.colorPanel.Name = "colorPanel";
            this.colorPanel.Size = new System.Drawing.Size(80, 5);
            this.colorPanel.TabIndex = 1;
            this.colorPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Bukkit_MouseMove);
            // 
            // logoPanel
            // 
            this.logoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(203)))), ((int)(((byte)(196)))));
            this.logoPanel.Controls.Add(this.LOGO);
            this.logoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(80, 80);
            this.logoPanel.TabIndex = 0;
            // 
            // LOGO
            // 
            this.LOGO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LOGO.Location = new System.Drawing.Point(0, 0);
            this.LOGO.Name = "LOGO";
            this.LOGO.Size = new System.Drawing.Size(80, 80);
            this.LOGO.TabIndex = 0;
            this.LOGO.TabStop = false;
            this.LOGO.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Bukkit_MouseMove);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.mainPanel.Controls.Add(this.mainLayoutPanel);
            this.mainPanel.Controls.Add(this.topPanel);
            this.mainPanel.Location = new System.Drawing.Point(80, 10);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(820, 530);
            this.mainPanel.TabIndex = 1;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            this.mainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Bukkit_MouseMove);
            // 
            // mainLayoutPanel
            // 
            this.mainLayoutPanel.Location = new System.Drawing.Point(20, 24);
            this.mainLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.mainLayoutPanel.Name = "mainLayoutPanel";
            this.mainLayoutPanel.Size = new System.Drawing.Size(800, 506);
            this.mainLayoutPanel.TabIndex = 1;
            this.mainLayoutPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Bukkit_MouseMove);
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.titleText);
            this.topPanel.Controls.Add(this.minBox);
            this.topPanel.Controls.Add(this.closeBox);
            this.topPanel.Location = new System.Drawing.Point(20, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(800, 24);
            this.topPanel.TabIndex = 0;
            this.topPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Bukkit_MouseMove);
            // 
            // minBox
            // 
            this.minBox.Location = new System.Drawing.Point(753, 2);
            this.minBox.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.minBox.Name = "minBox";
            this.minBox.Size = new System.Drawing.Size(20, 20);
            this.minBox.TabIndex = 1;
            this.minBox.TabStop = false;
            this.minBox.Click += new System.EventHandler(this.minBox_Click);
            // 
            // closeBox
            // 
            this.closeBox.Location = new System.Drawing.Point(777, 2);
            this.closeBox.Name = "closeBox";
            this.closeBox.Size = new System.Drawing.Size(20, 20);
            this.closeBox.TabIndex = 2;
            this.closeBox.TabStop = false;
            this.closeBox.Click += new System.EventHandler(this.closeBox_Click);
            // 
            // titleText
            // 
            this.titleText.AutoSize = true;
            this.titleText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleText.Location = new System.Drawing.Point(4, 4);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(52, 17);
            this.titleText.TabIndex = 3;
            this.titleText.Text = "titleText";
            // 
            // Bukkit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.sidePanel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Bukkit";
            this.Text = "Luna Bukkit";
            this.TransparencyKey = System.Drawing.Color.Green;
            this.Load += new System.EventHandler(this.Bukkit_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Bukkit_Paint);
            this.sidePanel.ResumeLayout(false);
            this.logoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LOGO)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Panel colorPanel;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.FlowLayoutPanel sideFlowLayoutPanel;
        private System.Windows.Forms.Panel mainPanel;
        private PictureBox LOGO;
        private Panel topPanel;
        private PictureBox minBox;
        private PictureBox closeBox;
        private FlowLayoutPanel mainLayoutPanel;
        private Label titleText;
    }
}