namespace study_class
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
            this.Add_btn = new System.Windows.Forms.Button();
            this.text_Bid = new System.Windows.Forms.TextBox();
            this.book_id = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.text_title = new System.Windows.Forms.TextBox();
            this.show_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.text_author = new System.Windows.Forms.TextBox();
            this.remove_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.text_qty = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Add_btn
            // 
            this.Add_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_btn.Location = new System.Drawing.Point(613, 61);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(114, 39);
            this.Add_btn.TabIndex = 0;
            this.Add_btn.Text = "add";
            this.Add_btn.UseVisualStyleBackColor = true;
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // text_Bid
            // 
            this.text_Bid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Bid.Location = new System.Drawing.Point(325, 61);
            this.text_Bid.Name = "text_Bid";
            this.text_Bid.Size = new System.Drawing.Size(198, 30);
            this.text_Bid.TabIndex = 1;
            // 
            // book_id
            // 
            this.book_id.AutoSize = true;
            this.book_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.book_id.Location = new System.Drawing.Point(138, 67);
            this.book_id.Name = "book_id";
            this.book_id.Size = new System.Drawing.Size(55, 25);
            this.book_id.TabIndex = 2;
            this.book_id.Text = "B_ID";
            this.book_id.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(138, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Title";
            // 
            // text_title
            // 
            this.text_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_title.Location = new System.Drawing.Point(325, 120);
            this.text_title.Name = "text_title";
            this.text_title.Size = new System.Drawing.Size(198, 30);
            this.text_title.TabIndex = 4;
            // 
            // show_btn
            // 
            this.show_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_btn.Location = new System.Drawing.Point(613, 120);
            this.show_btn.Name = "show_btn";
            this.show_btn.Size = new System.Drawing.Size(114, 39);
            this.show_btn.TabIndex = 3;
            this.show_btn.Text = "show";
            this.show_btn.UseVisualStyleBackColor = true;
            this.show_btn.Click += new System.EventHandler(this.show_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(138, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "A-name";
            // 
            // text_author
            // 
            this.text_author.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_author.Location = new System.Drawing.Point(325, 174);
            this.text_author.Name = "text_author";
            this.text_author.Size = new System.Drawing.Size(198, 30);
            this.text_author.TabIndex = 7;
            // 
            // remove_btn
            // 
            this.remove_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remove_btn.Location = new System.Drawing.Point(613, 174);
            this.remove_btn.Name = "remove_btn";
            this.remove_btn.Size = new System.Drawing.Size(114, 39);
            this.remove_btn.TabIndex = 6;
            this.remove_btn.Text = "remove";
            this.remove_btn.UseVisualStyleBackColor = true;
            this.remove_btn.Click += new System.EventHandler(this.remove_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(138, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "qty";
            // 
            // text_qty
            // 
            this.text_qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_qty.Location = new System.Drawing.Point(325, 239);
            this.text_qty.Name = "text_qty";
            this.text_qty.Size = new System.Drawing.Size(198, 30);
            this.text_qty.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.text_qty);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.text_author);
            this.Controls.Add(this.remove_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text_title);
            this.Controls.Add(this.show_btn);
            this.Controls.Add(this.book_id);
            this.Controls.Add(this.text_Bid);
            this.Controls.Add(this.Add_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add_btn;
        private System.Windows.Forms.TextBox text_Bid;
        private System.Windows.Forms.Label book_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_title;
        private System.Windows.Forms.Button show_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_author;
        private System.Windows.Forms.Button remove_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox text_qty;
    }
}

