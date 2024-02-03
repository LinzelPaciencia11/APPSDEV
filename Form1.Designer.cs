namespace WinFormsApp1
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
            OrderForm = new Label();
            label2 = new Label();
            label3 = new Label();
            txtform1 = new TextBox();
            txtlrg = new TextBox();
            txtsm = new TextBox();
            txtmd = new TextBox();
            button1 = new Button();
            btnadd = new Button();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // OrderForm
            // 
            OrderForm.AutoSize = true;
            OrderForm.Font = new Font("Impact", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OrderForm.Location = new Point(286, 36);
            OrderForm.Name = "OrderForm";
            OrderForm.Size = new Size(196, 45);
            OrderForm.TabIndex = 0;
            OrderForm.Text = "Order Form";
            OrderForm.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(104, 96);
            label2.Name = "label2";
            label2.Size = new Size(226, 26);
            label2.TabIndex = 1;
            label2.Text = "Number of bags ordered:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(366, 292);
            label3.Name = "label3";
            label3.Size = new Size(116, 17);
            label3.TabIndex = 2;
            label3.Text = "Your total cost is:";
            label3.Click += label3_Click;
            // 
            // txtform1
            // 
            txtform1.Location = new Point(403, 103);
            txtform1.Name = "txtform1";
            txtform1.Size = new Size(98, 23);
            txtform1.TabIndex = 3;
            // 
            // txtlrg
            // 
            txtlrg.Location = new Point(404, 138);
            txtlrg.Name = "txtlrg";
            txtlrg.Size = new Size(97, 23);
            txtlrg.TabIndex = 4;
            txtlrg.TextChanged += txtlrg_TextChanged;
            // 
            // txtsm
            // 
            txtsm.Location = new Point(404, 196);
            txtsm.Name = "txtsm";
            txtsm.Size = new Size(97, 23);
            txtsm.TabIndex = 5;
            txtsm.TextChanged += txtsm_TextChanged;
            // 
            // txtmd
            // 
            txtmd.Location = new Point(404, 167);
            txtmd.Name = "txtmd";
            txtmd.Size = new Size(97, 23);
            txtmd.TabIndex = 6;
            txtmd.TextChanged += txtmd_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 7;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnadd
            // 
            btnadd.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnadd.Location = new Point(403, 234);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(112, 46);
            btnadd.TabIndex = 8;
            btnadd.Text = "Place order";
            btnadd.UseVisualStyleBackColor = true;
            btnadd.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(271, 168);
            label1.Name = "label1";
            label1.Size = new Size(68, 17);
            label1.TabIndex = 9;
            label1.Text = "Medium -";
            label1.Click += label1_Click_2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(277, 139);
            label4.Name = "label4";
            label4.Size = new Size(51, 17);
            label4.TabIndex = 10;
            label4.Text = "Large -";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(279, 197);
            label5.Name = "label5";
            label5.Size = new Size(51, 17);
            label5.TabIndex = 11;
            label5.Text = "Small -";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(btnadd);
            Controls.Add(button1);
            Controls.Add(txtmd);
            Controls.Add(txtsm);
            Controls.Add(txtlrg);
            Controls.Add(txtform1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(OrderForm);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label OrderForm;
        private Label label2;
        private Label label3;
        private TextBox txtform1;
        private TextBox txtlrg;
        private TextBox txtsm;
        private TextBox txtmd;
        private Button button1;
        private Button btnadd;
        private Label label1;
        private Label label4;
        private Label label5;
    }
}
