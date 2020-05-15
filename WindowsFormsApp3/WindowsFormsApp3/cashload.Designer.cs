namespace WindowsFormsApp3
{
    partial class cashload
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
            this.label1 = new System.Windows.Forms.Label();
            this.atmpin = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.newpin = new System.Windows.Forms.TextBox();
            this.pinenter = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cashload1 = new System.Windows.Forms.TextBox();
            this.cashenter = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(22, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "введите пинкод:";
            // 
            // atmpin
            // 
            this.atmpin.Location = new System.Drawing.Point(153, 11);
            this.atmpin.Margin = new System.Windows.Forms.Padding(2);
            this.atmpin.Name = "atmpin";
            this.atmpin.Size = new System.Drawing.Size(68, 20);
            this.atmpin.TabIndex = 1;
            this.atmpin.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(235, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 19);
            this.button1.TabIndex = 2;
            this.button1.Text = "ввод";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(22, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "установить новый пинкод:";
            // 
            // newpin
            // 
            this.newpin.Location = new System.Drawing.Point(234, 32);
            this.newpin.Margin = new System.Windows.Forms.Padding(2);
            this.newpin.Name = "newpin";
            this.newpin.Size = new System.Drawing.Size(76, 20);
            this.newpin.TabIndex = 4;
            // 
            // pinenter
            // 
            this.pinenter.Location = new System.Drawing.Point(321, 32);
            this.pinenter.Margin = new System.Windows.Forms.Padding(2);
            this.pinenter.Name = "pinenter";
            this.pinenter.Size = new System.Drawing.Size(56, 19);
            this.pinenter.TabIndex = 5;
            this.pinenter.Text = "ввод";
            this.pinenter.UseVisualStyleBackColor = true;
            this.pinenter.Click += new System.EventHandler(this.Pinenter_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(20, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "загрузить деньги:";
            // 
            // cashload1
            // 
            this.cashload1.Location = new System.Drawing.Point(172, 59);
            this.cashload1.Margin = new System.Windows.Forms.Padding(2);
            this.cashload1.Name = "cashload1";
            this.cashload1.Size = new System.Drawing.Size(76, 20);
            this.cashload1.TabIndex = 7;
            // 
            // cashenter
            // 
            this.cashenter.Location = new System.Drawing.Point(260, 58);
            this.cashenter.Margin = new System.Windows.Forms.Padding(2);
            this.cashenter.Name = "cashenter";
            this.cashenter.Size = new System.Drawing.Size(56, 19);
            this.cashenter.TabIndex = 8;
            this.cashenter.Text = "ввод";
            this.cashenter.UseVisualStyleBackColor = true;
            this.cashenter.Click += new System.EventHandler(this.Cashenter_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(146, 102);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 43);
            this.button2.TabIndex = 9;
            this.button2.Text = "вернуться на главный экран";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(22, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "текущий баланс:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Lime;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(159, 84);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(79, 17);
            this.textBox1.TabIndex = 11;
            // 
            // cashload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(393, 147);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cashenter);
            this.Controls.Add(this.cashload1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pinenter);
            this.Controls.Add(this.newpin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.atmpin);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "cashload";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "cashload";
            this.Load += new System.EventHandler(this.Cashload_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox atmpin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox newpin;
        private System.Windows.Forms.Button pinenter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cashload1;
        private System.Windows.Forms.Button cashenter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
    }
}