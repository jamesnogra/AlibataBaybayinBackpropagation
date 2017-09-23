namespace AlibataBackPropagation
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
            this.drawer = new System.Windows.Forms.PictureBox();
            this.clearDrawing = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.drawer)).BeginInit();
            this.SuspendLayout();
            // 
            // drawer
            // 
            this.drawer.BackColor = System.Drawing.Color.White;
            this.drawer.Location = new System.Drawing.Point(13, 13);
            this.drawer.Name = "drawer";
            this.drawer.Size = new System.Drawing.Size(320, 320);
            this.drawer.TabIndex = 0;
            this.drawer.TabStop = false;
            this.drawer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drawer_MouseDown);
            this.drawer.MouseMove += new System.Windows.Forms.MouseEventHandler(this.drawer_MouseMove);
            this.drawer.MouseUp += new System.Windows.Forms.MouseEventHandler(this.drawer_MouseUp);
            // 
            // clearDrawing
            // 
            this.clearDrawing.BackColor = System.Drawing.Color.IndianRed;
            this.clearDrawing.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearDrawing.ForeColor = System.Drawing.Color.White;
            this.clearDrawing.Location = new System.Drawing.Point(340, 13);
            this.clearDrawing.Name = "clearDrawing";
            this.clearDrawing.Size = new System.Drawing.Size(274, 35);
            this.clearDrawing.TabIndex = 1;
            this.clearDrawing.Text = "Clear Drawing";
            this.clearDrawing.UseVisualStyleBackColor = false;
            this.clearDrawing.Click += new System.EventHandler(this.clearDrawing_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 347);
            this.Controls.Add(this.clearDrawing);
            this.Controls.Add(this.drawer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Alibata Baybayin Backpropagation";
            ((System.ComponentModel.ISupportInitialize)(this.drawer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox drawer;
        private System.Windows.Forms.Button clearDrawing;
    }
}

