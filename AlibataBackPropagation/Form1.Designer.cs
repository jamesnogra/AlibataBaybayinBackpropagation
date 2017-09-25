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
            this.train = new System.Windows.Forms.Button();
            this.trainProgressBar = new System.Windows.Forms.ProgressBar();
            this.test = new System.Windows.Forms.Button();
            this.legend = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.resultPicBox = new System.Windows.Forms.PictureBox();
            this.stopTraining = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.drawer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.legend)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // drawer
            // 
            this.drawer.BackColor = System.Drawing.Color.White;
            this.drawer.Location = new System.Drawing.Point(13, 13);
            this.drawer.Name = "drawer";
            this.drawer.Size = new System.Drawing.Size(320, 320);
            this.drawer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
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
            this.clearDrawing.Location = new System.Drawing.Point(339, 13);
            this.clearDrawing.Name = "clearDrawing";
            this.clearDrawing.Size = new System.Drawing.Size(362, 35);
            this.clearDrawing.TabIndex = 1;
            this.clearDrawing.Text = "Clear Drawing";
            this.clearDrawing.UseVisualStyleBackColor = false;
            this.clearDrawing.Click += new System.EventHandler(this.clearDrawing_Click);
            // 
            // train
            // 
            this.train.BackColor = System.Drawing.Color.SteelBlue;
            this.train.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.train.ForeColor = System.Drawing.Color.White;
            this.train.Location = new System.Drawing.Point(340, 55);
            this.train.Name = "train";
            this.train.Size = new System.Drawing.Size(362, 35);
            this.train.TabIndex = 2;
            this.train.Text = "Train";
            this.train.UseVisualStyleBackColor = false;
            this.train.Click += new System.EventHandler(this.train_Click);
            // 
            // trainProgressBar
            // 
            this.trainProgressBar.Location = new System.Drawing.Point(340, 55);
            this.trainProgressBar.Name = "trainProgressBar";
            this.trainProgressBar.Size = new System.Drawing.Size(361, 35);
            this.trainProgressBar.TabIndex = 3;
            // 
            // test
            // 
            this.test.BackColor = System.Drawing.Color.SeaGreen;
            this.test.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.test.ForeColor = System.Drawing.Color.White;
            this.test.Location = new System.Drawing.Point(339, 96);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(362, 35);
            this.test.TabIndex = 4;
            this.test.Text = "Test";
            this.test.UseVisualStyleBackColor = false;
            this.test.Click += new System.EventHandler(this.test_Click);
            // 
            // legend
            // 
            this.legend.Location = new System.Drawing.Point(441, 140);
            this.legend.Name = "legend";
            this.legend.Size = new System.Drawing.Size(159, 87);
            this.legend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.legend.TabIndex = 5;
            this.legend.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.resultLabel);
            this.groupBox1.Controls.Add(this.resultPicBox);
            this.groupBox1.Location = new System.Drawing.Point(340, 233);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Result";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.Location = new System.Drawing.Point(70, 43);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(288, 18);
            this.resultLabel.TabIndex = 1;
            this.resultLabel.Text = "0.0000 0.0000 0.0000 0.0000 ";
            // 
            // resultPicBox
            // 
            this.resultPicBox.BackColor = System.Drawing.Color.White;
            this.resultPicBox.Location = new System.Drawing.Point(7, 17);
            this.resultPicBox.Name = "resultPicBox";
            this.resultPicBox.Size = new System.Drawing.Size(59, 74);
            this.resultPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.resultPicBox.TabIndex = 0;
            this.resultPicBox.TabStop = false;
            // 
            // stopTraining
            // 
            this.stopTraining.BackColor = System.Drawing.Color.Transparent;
            this.stopTraining.Location = new System.Drawing.Point(472, 61);
            this.stopTraining.Name = "stopTraining";
            this.stopTraining.Size = new System.Drawing.Size(98, 23);
            this.stopTraining.TabIndex = 7;
            this.stopTraining.Text = "Stop Training";
            this.stopTraining.UseVisualStyleBackColor = false;
            this.stopTraining.Click += new System.EventHandler(this.stopTraining_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 347);
            this.Controls.Add(this.train);
            this.Controls.Add(this.stopTraining);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.legend);
            this.Controls.Add(this.test);
            this.Controls.Add(this.clearDrawing);
            this.Controls.Add(this.drawer);
            this.Controls.Add(this.trainProgressBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Alibata Baybayin Backpropagation";
            ((System.ComponentModel.ISupportInitialize)(this.drawer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.legend)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultPicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox drawer;
        private System.Windows.Forms.Button clearDrawing;
        private System.Windows.Forms.Button train;
        private System.Windows.Forms.ProgressBar trainProgressBar;
        private System.Windows.Forms.Button test;
        private System.Windows.Forms.PictureBox legend;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.PictureBox resultPicBox;
        private System.Windows.Forms.Button stopTraining;
    }
}

