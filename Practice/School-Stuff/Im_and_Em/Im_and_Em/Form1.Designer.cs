namespace Im_and_Em
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
            this.inv_id = new System.Windows.Forms.Label();
            this.inv_txt = new System.Windows.Forms.TextBox();
            this.pro_txt = new System.Windows.Forms.TextBox();
            this.pro_name = new System.Windows.Forms.Label();
            this.qty_txt = new System.Windows.Forms.TextBox();
            this.qty = new System.Windows.Forms.Label();
            this.price_txt = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.Label();
            this.amount_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pay_btn = new System.Windows.Forms.Button();
            this.search_btn = new System.Windows.Forms.Button();
            this.report_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inv_id
            // 
            this.inv_id.AutoSize = true;
            this.inv_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inv_id.Location = new System.Drawing.Point(178, 35);
            this.inv_id.Name = "inv_id";
            this.inv_id.Size = new System.Drawing.Size(95, 36);
            this.inv_id.TabIndex = 0;
            this.inv_id.Text = "inv_id";
            // 
            // inv_txt
            // 
            this.inv_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inv_txt.Location = new System.Drawing.Point(406, 35);
            this.inv_txt.Name = "inv_txt";
            this.inv_txt.Size = new System.Drawing.Size(190, 41);
            this.inv_txt.TabIndex = 1;
            // 
            // pro_txt
            // 
            this.pro_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pro_txt.Location = new System.Drawing.Point(406, 92);
            this.pro_txt.Name = "pro_txt";
            this.pro_txt.Size = new System.Drawing.Size(190, 41);
            this.pro_txt.TabIndex = 2;
            // 
            // pro_name
            // 
            this.pro_name.AutoSize = true;
            this.pro_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pro_name.Location = new System.Drawing.Point(178, 92);
            this.pro_name.Name = "pro_name";
            this.pro_name.Size = new System.Drawing.Size(196, 36);
            this.pro_name.TabIndex = 2;
            this.pro_name.Text = "product name";
            // 
            // qty_txt
            // 
            this.qty_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qty_txt.Location = new System.Drawing.Point(406, 153);
            this.qty_txt.Name = "qty_txt";
            this.qty_txt.Size = new System.Drawing.Size(190, 41);
            this.qty_txt.TabIndex = 3;
            this.qty_txt.TextChanged += new System.EventHandler(this.qty_txt_TextChanged);
            // 
            // qty
            // 
            this.qty.AutoSize = true;
            this.qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qty.Location = new System.Drawing.Point(178, 153);
            this.qty.Name = "qty";
            this.qty.Size = new System.Drawing.Size(60, 36);
            this.qty.TabIndex = 4;
            this.qty.Text = "Qty";
            // 
            // price_txt
            // 
            this.price_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price_txt.Location = new System.Drawing.Point(406, 217);
            this.price_txt.Name = "price_txt";
            this.price_txt.Size = new System.Drawing.Size(190, 41);
            this.price_txt.TabIndex = 4;
            this.price_txt.TextChanged += new System.EventHandler(this.price_txt_TextChanged);
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.Location = new System.Drawing.Point(178, 217);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(80, 36);
            this.price.TabIndex = 6;
            this.price.Text = "price";
            // 
            // amount_txt
            // 
            this.amount_txt.BackColor = System.Drawing.SystemColors.GrayText;
            this.amount_txt.Enabled = false;
            this.amount_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount_txt.Location = new System.Drawing.Point(406, 278);
            this.amount_txt.Name = "amount_txt";
            this.amount_txt.Size = new System.Drawing.Size(190, 41);
            this.amount_txt.TabIndex = 9;
            this.amount_txt.TextChanged += new System.EventHandler(this.amount_txt_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(178, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 36);
            this.label5.TabIndex = 8;
            this.label5.Text = "Amount";
            // 
            // pay_btn
            // 
            this.pay_btn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pay_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pay_btn.Location = new System.Drawing.Point(94, 356);
            this.pay_btn.Name = "pay_btn";
            this.pay_btn.Size = new System.Drawing.Size(145, 47);
            this.pay_btn.TabIndex = 5;
            this.pay_btn.Text = "Pay";
            this.pay_btn.UseVisualStyleBackColor = false;
            this.pay_btn.Click += new System.EventHandler(this.pay_btn_Click);
            // 
            // search_btn
            // 
            this.search_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_btn.Location = new System.Drawing.Point(317, 356);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(145, 47);
            this.search_btn.TabIndex = 6;
            this.search_btn.Text = "Search";
            this.search_btn.UseVisualStyleBackColor = true;
            // 
            // report_btn
            // 
            this.report_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.report_btn.Location = new System.Drawing.Point(544, 356);
            this.report_btn.Name = "report_btn";
            this.report_btn.Size = new System.Drawing.Size(145, 47);
            this.report_btn.TabIndex = 7;
            this.report_btn.Text = "Report";
            this.report_btn.UseVisualStyleBackColor = true;
            this.report_btn.Click += new System.EventHandler(this.report_btn_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.report_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.report_btn);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.pay_btn);
            this.Controls.Add(this.amount_txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.price_txt);
            this.Controls.Add(this.price);
            this.Controls.Add(this.qty_txt);
            this.Controls.Add(this.qty);
            this.Controls.Add(this.pro_txt);
            this.Controls.Add(this.pro_name);
            this.Controls.Add(this.inv_txt);
            this.Controls.Add(this.inv_id);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label inv_id;
        private System.Windows.Forms.TextBox inv_txt;
        private System.Windows.Forms.TextBox pro_txt;
        private System.Windows.Forms.Label pro_name;
        private System.Windows.Forms.TextBox qty_txt;
        private System.Windows.Forms.Label qty;
        private System.Windows.Forms.TextBox price_txt;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.TextBox amount_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button pay_btn;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Button report_btn;
    }
}

