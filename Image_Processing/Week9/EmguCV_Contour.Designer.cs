
namespace WindowsFormsApp1.Week9
{
    partial class EmguCV_Contour
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findContToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortingContourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shapeDetectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Shape_Detection = new System.Windows.Forms.PictureBox();
            this.Sorting_Contour = new System.Windows.Forms.PictureBox();
            this.Find_Contour = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Shape_Detection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sorting_Contour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Find_Contour)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(822, 25);
            this.menuStrip1.TabIndex = 28;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.findContToolStripMenuItem,
            this.sortingContourToolStripMenuItem,
            this.shapeDetectionToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // findContToolStripMenuItem
            // 
            this.findContToolStripMenuItem.Name = "findContToolStripMenuItem";
            this.findContToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.findContToolStripMenuItem.Text = "Find Contour";
            this.findContToolStripMenuItem.Click += new System.EventHandler(this.findContToolStripMenuItem_Click);
            // 
            // sortingContourToolStripMenuItem
            // 
            this.sortingContourToolStripMenuItem.Name = "sortingContourToolStripMenuItem";
            this.sortingContourToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.sortingContourToolStripMenuItem.Text = "Sorting_Contour";
            this.sortingContourToolStripMenuItem.Click += new System.EventHandler(this.sortingContourToolStripMenuItem_Click);
            // 
            // shapeDetectionToolStripMenuItem
            // 
            this.shapeDetectionToolStripMenuItem.Name = "shapeDetectionToolStripMenuItem";
            this.shapeDetectionToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.shapeDetectionToolStripMenuItem.Text = "Shape Detection";
            this.shapeDetectionToolStripMenuItem.Click += new System.EventHandler(this.shapeDetectionToolStripMenuItem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.Location = new System.Drawing.Point(542, 432);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 16);
            this.label4.TabIndex = 32;
            this.label4.Text = "Shape Detection";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(154, 432);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 31;
            this.label3.Text = "Sorting Contour";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(542, -4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 30;
            this.label2.Text = "Find Contour";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(154, -4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 29;
            this.label1.Text = "Input Image";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(45, 109);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(345, 289);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // Shape_Detection
            // 
            this.Shape_Detection.Location = new System.Drawing.Point(445, 473);
            this.Shape_Detection.Name = "Shape_Detection";
            this.Shape_Detection.Size = new System.Drawing.Size(346, 289);
            this.Shape_Detection.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Shape_Detection.TabIndex = 35;
            this.Shape_Detection.TabStop = false;
            // 
            // Sorting_Contour
            // 
            this.Sorting_Contour.Location = new System.Drawing.Point(45, 473);
            this.Sorting_Contour.Name = "Sorting_Contour";
            this.Sorting_Contour.Size = new System.Drawing.Size(346, 289);
            this.Sorting_Contour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Sorting_Contour.TabIndex = 34;
            this.Sorting_Contour.TabStop = false;
            // 
            // Find_Contour
            // 
            this.Find_Contour.Location = new System.Drawing.Point(445, 109);
            this.Find_Contour.Name = "Find_Contour";
            this.Find_Contour.Size = new System.Drawing.Size(346, 289);
            this.Find_Contour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Find_Contour.TabIndex = 33;
            this.Find_Contour.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label5.Location = new System.Drawing.Point(542, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 16);
            this.label5.TabIndex = 38;
            this.label5.Text = "Find Contour";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label6.Location = new System.Drawing.Point(154, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 16);
            this.label6.TabIndex = 37;
            this.label6.Text = "Input Image";
            // 
            // EmguCV_Contour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 758);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Shape_Detection);
            this.Controls.Add(this.Sorting_Contour);
            this.Controls.Add(this.Find_Contour);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EmguCV_Contour";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Shape_Detection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sorting_Contour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Find_Contour)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findContToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortingContourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shapeDetectionToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Shape_Detection;
        private System.Windows.Forms.PictureBox Sorting_Contour;
        private System.Windows.Forms.PictureBox Find_Contour;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}