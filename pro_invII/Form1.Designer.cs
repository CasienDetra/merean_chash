namespace pro_invII
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
            this.txtinv = new System.Windows.Forms.TextBox();
            this.save_btn = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.search_btn = new System.Windows.Forms.Button();
            this.txtpro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.delete_btn = new System.Windows.Forms.Button();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.order_btn = new System.Windows.Forms.Button();
            this.txtqty = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inv_id
            // 
            this.inv_id.AutoSize = true;
            this.inv_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inv_id.Location = new System.Drawing.Point(352, 34);
            this.inv_id.Name = "inv_id";
            this.inv_id.Size = new System.Drawing.Size(74, 29);
            this.inv_id.TabIndex = 0;
            this.inv_id.Text = "inv_d";
            // 
            // txtinv
            // 
            this.txtinv.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtinv.Location = new System.Drawing.Point(503, 34);
            this.txtinv.Name = "txtinv";
            this.txtinv.Size = new System.Drawing.Size(296, 36);
            this.txtinv.TabIndex = 1;
            // 
            // save_btn
            // 
            this.save_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_btn.Location = new System.Drawing.Point(874, 34);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(119, 36);
            this.save_btn.TabIndex = 2;
            this.save_btn.Text = "save";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(357, 295);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(636, 278);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // search_btn
            // 
            this.search_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_btn.Location = new System.Drawing.Point(874, 93);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(119, 36);
            this.search_btn.TabIndex = 6;
            this.search_btn.Text = "search";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // txtpro
            // 
            this.txtpro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpro.Location = new System.Drawing.Point(503, 93);
            this.txtpro.Name = "txtpro";
            this.txtpro.Size = new System.Drawing.Size(296, 36);
            this.txtpro.TabIndex = 5;
            this.txtpro.TextChanged += new System.EventHandler(this.txtpro_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(352, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "pro_name";
            // 
            // delete_btn
            // 
            this.delete_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_btn.Location = new System.Drawing.Point(874, 154);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(119, 36);
            this.delete_btn.TabIndex = 9;
            this.delete_btn.Text = "delete";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // txtprice
            // 
            this.txtprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprice.Location = new System.Drawing.Point(503, 154);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(296, 36);
            this.txtprice.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(352, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "price";
            // 
            // order_btn
            // 
            this.order_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.order_btn.Location = new System.Drawing.Point(874, 212);
            this.order_btn.Name = "order_btn";
            this.order_btn.Size = new System.Drawing.Size(119, 36);
            this.order_btn.TabIndex = 12;
            this.order_btn.Text = "order";
            this.order_btn.UseVisualStyleBackColor = true;
            this.order_btn.Click += new System.EventHandler(this.order_btn_Click);
            // 
            // txtqty
            // 
            this.txtqty.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqty.Location = new System.Drawing.Point(503, 212);
            this.txtqty.Name = "txtqty";
            this.txtqty.Size = new System.Drawing.Size(296, 36);
            this.txtqty.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(352, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "qty";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1379, 622);
            this.Controls.Add(this.order_btn);
            this.Controls.Add(this.txtqty);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.txtpro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.txtinv);
            this.Controls.Add(this.inv_id);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
            this.Load += new System.EventHandler(this.Form1_Load);

        }

        #endregion

        private System.Windows.Forms.Label inv_id;
        private System.Windows.Forms.TextBox txtinv;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.TextBox txtpro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button order_btn;
        private System.Windows.Forms.TextBox txtqty;
        private System.Windows.Forms.Label label4;
    }
}

