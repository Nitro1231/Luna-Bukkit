namespace LunaBukkit.Controls {
    partial class SideButton {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.selectPanel = new System.Windows.Forms.Panel();
            this.menuPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.menuPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // selectPanel
            // 
            this.selectPanel.Location = new System.Drawing.Point(0, 5);
            this.selectPanel.Name = "selectPanel";
            this.selectPanel.Size = new System.Drawing.Size(8, 50);
            this.selectPanel.TabIndex = 0;
            // 
            // menuPictureBox
            // 
            this.menuPictureBox.Location = new System.Drawing.Point(19, 5);
            this.menuPictureBox.Name = "menuPictureBox";
            this.menuPictureBox.Size = new System.Drawing.Size(50, 50);
            this.menuPictureBox.TabIndex = 1;
            this.menuPictureBox.TabStop = false;
            // 
            // SideButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.menuPictureBox);
            this.Controls.Add(this.selectPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.Name = "SideButton";
            this.Size = new System.Drawing.Size(80, 60);
            ((System.ComponentModel.ISupportInitialize)(this.menuPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel selectPanel;
        private System.Windows.Forms.PictureBox menuPictureBox;
    }
}
