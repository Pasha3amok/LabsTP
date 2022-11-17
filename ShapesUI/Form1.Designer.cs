
namespace ShapesUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GetDemoObject = new System.Windows.Forms.Button();
            this.textAllocator = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GetDemoObject
            // 
            this.GetDemoObject.BackColor = System.Drawing.SystemColors.HotTrack;
            this.GetDemoObject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GetDemoObject.FlatAppearance.BorderSize = 0;
            this.GetDemoObject.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.GetDemoObject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GetDemoObject.Location = new System.Drawing.Point(9, 79);
            this.GetDemoObject.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.GetDemoObject.Name = "GetDemoObject";
            this.GetDemoObject.Size = new System.Drawing.Size(163, 59);
            this.GetDemoObject.TabIndex = 0;
            this.GetDemoObject.Text = "Browse";
            this.GetDemoObject.UseVisualStyleBackColor = false;
            this.GetDemoObject.Click += new System.EventHandler(this.GetDemoObject_Click);
            // 
            // textAllocator
            // 
            this.textAllocator.Location = new System.Drawing.Point(14, 37);
            this.textAllocator.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textAllocator.Multiline = true;
            this.textAllocator.Name = "textAllocator";
            this.textAllocator.Size = new System.Drawing.Size(855, 363);
            this.textAllocator.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(9, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 60);
            this.button1.TabIndex = 2;
            this.button1.Text = "Result";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.ButtonResult_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.GetDemoObject);
            this.panel1.Location = new System.Drawing.Point(889, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(183, 155);
            this.panel1.TabIndex = 3;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(889, 198);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(183, 49);
            this.textBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1077, 412);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textAllocator);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Shapes";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GetDemoObject;
        private System.Windows.Forms.TextBox textAllocator;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

