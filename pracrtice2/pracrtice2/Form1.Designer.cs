
namespace pracrtice2
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
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtjan = new System.Windows.Forms.TextBox();
            this.txtfeb = new System.Windows.Forms.TextBox();
            this.txtmar = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcom = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chb1 = new System.Windows.Forms.CheckBox();
            this.chb2 = new System.Windows.Forms.CheckBox();
            this.chb3 = new System.Windows.Forms.CheckBox();
            this.btnbutton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(127, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "February";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox1.Controls.Add(this.txtmar);
            this.groupBox1.Controls.Add(this.txtfeb);
            this.groupBox1.Controls.Add(this.txtjan);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe Script", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(196, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(412, 177);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SALES";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(127, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "January";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Location = new System.Drawing.Point(127, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "March";
            // 
            // txtjan
            // 
            this.txtjan.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtjan.Location = new System.Drawing.Point(246, 49);
            this.txtjan.Name = "txtjan";
            this.txtjan.Size = new System.Drawing.Size(117, 28);
            this.txtjan.TabIndex = 4;
            this.txtjan.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtfeb
            // 
            this.txtfeb.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfeb.Location = new System.Drawing.Point(246, 87);
            this.txtfeb.Name = "txtfeb";
            this.txtfeb.Size = new System.Drawing.Size(117, 28);
            this.txtfeb.TabIndex = 5;
            // 
            // txtmar
            // 
            this.txtmar.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmar.Location = new System.Drawing.Point(246, 122);
            this.txtmar.Name = "txtmar";
            this.txtmar.Size = new System.Drawing.Size(117, 28);
            this.txtmar.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.txtcom);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(196, 269);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(412, 45);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label4.Location = new System.Drawing.Point(15, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Total sales commission: ";
            // 
            // txtcom
            // 
            this.txtcom.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcom.Location = new System.Drawing.Point(246, 5);
            this.txtcom.Name = "txtcom";
            this.txtcom.Size = new System.Drawing.Size(117, 28);
            this.txtcom.TabIndex = 7;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox3.Controls.Add(this.chb3);
            this.groupBox3.Controls.Add(this.chb2);
            this.groupBox3.Controls.Add(this.chb1);
            this.groupBox3.Location = new System.Drawing.Point(196, 222);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(412, 41);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            // 
            // chb1
            // 
            this.chb1.AutoSize = true;
            this.chb1.Location = new System.Drawing.Point(19, 12);
            this.chb1.Name = "chb1";
            this.chb1.Size = new System.Drawing.Size(46, 17);
            this.chb1.TabIndex = 0;
            this.chb1.Text = "50%";
            this.chb1.UseVisualStyleBackColor = true;
            // 
            // chb2
            // 
            this.chb2.AutoSize = true;
            this.chb2.Location = new System.Drawing.Point(166, 12);
            this.chb2.Name = "chb2";
            this.chb2.Size = new System.Drawing.Size(46, 17);
            this.chb2.TabIndex = 1;
            this.chb2.Text = "10%";
            this.chb2.UseVisualStyleBackColor = true;
            // 
            // chb3
            // 
            this.chb3.AutoSize = true;
            this.chb3.Location = new System.Drawing.Point(308, 12);
            this.chb3.Name = "chb3";
            this.chb3.Size = new System.Drawing.Size(46, 17);
            this.chb3.TabIndex = 2;
            this.chb3.Text = "15%";
            this.chb3.UseVisualStyleBackColor = true;
            // 
            // btnbutton
            // 
            this.btnbutton.Location = new System.Drawing.Point(340, 320);
            this.btnbutton.Name = "btnbutton";
            this.btnbutton.Size = new System.Drawing.Size(121, 23);
            this.btnbutton.TabIndex = 6;
            this.btnbutton.Text = "Compute commission";
            this.btnbutton.UseVisualStyleBackColor = true;
            this.btnbutton.Click += new System.EventHandler(this.btnbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnbutton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtjan;
        private System.Windows.Forms.TextBox txtmar;
        private System.Windows.Forms.TextBox txtfeb;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtcom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chb2;
        private System.Windows.Forms.CheckBox chb1;
        private System.Windows.Forms.CheckBox chb3;
        private System.Windows.Forms.Button btnbutton;
    }
}

