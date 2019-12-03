﻿namespace LunaBukkit {
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.sidePanel.SuspendLayout();
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
            this.sideFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sideFlowLayoutPanel.Location = new System.Drawing.Point(0, 80);
            this.sideFlowLayoutPanel.Name = "sideFlowLayoutPanel";
            this.sideFlowLayoutPanel.Size = new System.Drawing.Size(80, 465);
            this.sideFlowLayoutPanel.TabIndex = 2;
            // 
            // colorPanel
            // 
            this.colorPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(203)))), ((int)(((byte)(196)))));
            this.colorPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.colorPanel.Location = new System.Drawing.Point(0, 545);
            this.colorPanel.Name = "colorPanel";
            this.colorPanel.Size = new System.Drawing.Size(80, 5);
            this.colorPanel.TabIndex = 1;
            // 
            // logoPanel
            // 
            this.logoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(203)))), ((int)(((byte)(196)))));
            this.logoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(80, 80);
            this.logoPanel.TabIndex = 0;
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.mainPanel.Location = new System.Drawing.Point(80, 10);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(820, 530);
            this.mainPanel.TabIndex = 1;
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
            this.sidePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Panel colorPanel;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.FlowLayoutPanel sideFlowLayoutPanel;
        private System.Windows.Forms.Panel mainPanel;
    }
}