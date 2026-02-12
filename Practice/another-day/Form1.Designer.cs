namespace another_day
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
            this.browse_btn = new System.Windows.Forms.Button();
            this.previousll_btn = new System.Windows.Forms.Button();
            this.next_btn = new System.Windows.Forms.Button();
            this.remove_btn = new System.Windows.Forms.Button();
            this.clear_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // browse_btn
            // 
            this.browse_btn.Location = new System.Drawing.Point(623, 89);
            this.browse_btn.Name = "browse_btn";
            this.browse_btn.Size = new System.Drawing.Size(115, 41);
            this.browse_btn.TabIndex = 0;
            this.browse_btn.Text = "browse";
            this.browse_btn.UseVisualStyleBackColor = true;
            this.browse_btn.Click += new System.EventHandler(this.browse_btn_Click);
            // 
            // previousll_btn
            // 
            this.previousll_btn.Location = new System.Drawing.Point(623, 136);
            this.previousll_btn.Name = "previousll_btn";
            this.previousll_btn.Size = new System.Drawing.Size(115, 41);
            this.previousll_btn.TabIndex = 1;
            this.previousll_btn.Text = "prev";
            this.previousll_btn.UseVisualStyleBackColor = true;
            this.previousll_btn.Click += new System.EventHandler(this.previousll_btn_Click);
            // 
            // next_btn
            // 
            this.next_btn.Location = new System.Drawing.Point(623, 183);
            this.next_btn.Name = "next_btn";
            this.next_btn.Size = new System.Drawing.Size(115, 41);
            this.next_btn.TabIndex = 2;
            this.next_btn.Text = "next";
            this.next_btn.UseVisualStyleBackColor = true;
            this.next_btn.Click += new System.EventHandler(this.next_btn_Click);
            // 
            // remove_btn
            // 
            this.remove_btn.Location = new System.Drawing.Point(623, 230);
            this.remove_btn.Name = "remove_btn";
            this.remove_btn.Size = new System.Drawing.Size(115, 41);
            this.remove_btn.TabIndex = 3;
            this.remove_btn.Text = "remove";
            this.remove_btn.UseVisualStyleBackColor = true;
            this.remove_btn.Click += new System.EventHandler(this.remove_btn_Click);
            // 
            // clear_btn
            // 
            this.clear_btn.Location = new System.Drawing.Point(422, 305);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(115, 41);
            this.clear_btn.TabIndex = 4;
            this.clear_btn.Text = "clear";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(339, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(278, 224);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 545);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.remove_btn);
            this.Controls.Add(this.next_btn);
            this.Controls.Add(this.previousll_btn);
            this.Controls.Add(this.browse_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button browse_btn;
        private System.Windows.Forms.Button previousll_btn;
        private System.Windows.Forms.Button next_btn;
        private System.Windows.Forms.Button remove_btn;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

