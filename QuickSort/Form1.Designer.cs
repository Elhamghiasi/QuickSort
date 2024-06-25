namespace QuickSort
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
            this.btnSortSequential = new System.Windows.Forms.Button();
            this.btnSortSequentialLarge = new System.Windows.Forms.Button();
            this.btnSortParallelLarge = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSortSequential
            // 
            this.btnSortSequential.Location = new System.Drawing.Point(378, 74);
            this.btnSortSequential.Name = "btnSortSequential";
            this.btnSortSequential.Size = new System.Drawing.Size(176, 23);
            this.btnSortSequential.TabIndex = 0;
            this.btnSortSequential.Text = "Sort Sequential";
            this.btnSortSequential.UseVisualStyleBackColor = true;
            this.btnSortSequential.Click += new System.EventHandler(this.btnSortSequential_Click);
            // 
            // btnSortSequentialLarge
            // 
            this.btnSortSequentialLarge.Location = new System.Drawing.Point(378, 140);
            this.btnSortSequentialLarge.Name = "btnSortSequentialLarge";
            this.btnSortSequentialLarge.Size = new System.Drawing.Size(176, 23);
            this.btnSortSequentialLarge.TabIndex = 1;
            this.btnSortSequentialLarge.Text = "Sort Sequential Large";
            this.btnSortSequentialLarge.UseVisualStyleBackColor = true;
            this.btnSortSequentialLarge.Click += new System.EventHandler(this.btnSortSequentialLarge_Click);
            // 
            // btnSortParallelLarge
            // 
            this.btnSortParallelLarge.Location = new System.Drawing.Point(378, 204);
            this.btnSortParallelLarge.Name = "btnSortParallelLarge";
            this.btnSortParallelLarge.Size = new System.Drawing.Size(176, 23);
            this.btnSortParallelLarge.TabIndex = 2;
            this.btnSortParallelLarge.Text = "Sort Parallel Large";
            this.btnSortParallelLarge.UseVisualStyleBackColor = true;
            this.btnSortParallelLarge.Click += new System.EventHandler(this.btnSortParallelLarge_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSortParallelLarge);
            this.Controls.Add(this.btnSortSequentialLarge);
            this.Controls.Add(this.btnSortSequential);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSortSequential;
        private System.Windows.Forms.Button btnSortSequentialLarge;
        private System.Windows.Forms.Button btnSortParallelLarge;
    }
}

