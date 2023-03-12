namespace Musketeers_BackpropagationApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.test = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.output = new System.Windows.Forms.Label();
            this.train = new System.Windows.Forms.Button();
            this.create = new System.Windows.Forms.Button();
            this.epoch = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(219, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sepal Length (cm):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(219, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sepal Width (cm):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Indigo;
            this.label3.Location = new System.Drawing.Point(219, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Petal Length (cm):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Indigo;
            this.label4.Location = new System.Drawing.Point(222, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Petal Width (cm):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Malgun Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Indigo;
            this.label5.Location = new System.Drawing.Point(137, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(426, 37);
            this.label5.TabIndex = 4;
            this.label5.Text = "Iris Flower Species Classification";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Malgun Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.Color.Green;
            this.textBox1.Location = new System.Drawing.Point(406, 134);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(110, 27);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Malgun Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox2.ForeColor = System.Drawing.Color.Green;
            this.textBox2.Location = new System.Drawing.Point(406, 175);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(110, 27);
            this.textBox2.TabIndex = 6;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Font = new System.Drawing.Font("Malgun Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox3.ForeColor = System.Drawing.Color.Green;
            this.textBox3.Location = new System.Drawing.Point(406, 219);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(110, 27);
            this.textBox3.TabIndex = 7;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Font = new System.Drawing.Font("Malgun Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox4.ForeColor = System.Drawing.Color.Green;
            this.textBox4.Location = new System.Drawing.Point(406, 261);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(110, 27);
            this.textBox4.TabIndex = 8;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // test
            // 
            this.test.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.test.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.test.ForeColor = System.Drawing.Color.Indigo;
            this.test.Location = new System.Drawing.Point(440, 371);
            this.test.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(95, 33);
            this.test.TabIndex = 9;
            this.test.Text = "TEST";
            this.test.UseVisualStyleBackColor = false;
            this.test.Click += new System.EventHandler(this.test_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Indigo;
            this.label6.Location = new System.Drawing.Point(222, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "SPECIES:";
            // 
            // output
            // 
            this.output.AutoSize = true;
            this.output.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.output.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.output.ForeColor = System.Drawing.Color.Indigo;
            this.output.Location = new System.Drawing.Point(326, 304);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(190, 21);
            this.output.TabIndex = 11;
            this.output.Text = "                              ";
            // 
            // train
            // 
            this.train.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.train.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.train.ForeColor = System.Drawing.Color.Indigo;
            this.train.Location = new System.Drawing.Point(322, 371);
            this.train.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.train.Name = "train";
            this.train.Size = new System.Drawing.Size(95, 33);
            this.train.TabIndex = 12;
            this.train.Text = "TRAIN";
            this.train.UseVisualStyleBackColor = false;
            this.train.Click += new System.EventHandler(this.train_Click);
            // 
            // create
            // 
            this.create.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.create.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.create.ForeColor = System.Drawing.Color.Indigo;
            this.create.Location = new System.Drawing.Point(202, 371);
            this.create.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(95, 33);
            this.create.TabIndex = 13;
            this.create.Text = "CREATE";
            this.create.UseVisualStyleBackColor = false;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // epoch
            // 
            this.epoch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.epoch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.epoch.Font = new System.Drawing.Font("Malgun Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.epoch.ForeColor = System.Drawing.Color.Green;
            this.epoch.Location = new System.Drawing.Point(406, 94);
            this.epoch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.epoch.Name = "epoch";
            this.epoch.Size = new System.Drawing.Size(110, 27);
            this.epoch.TabIndex = 15;
            this.epoch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Indigo;
            this.label8.Location = new System.Drawing.Point(176, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(195, 21);
            this.label8.TabIndex = 14;
            this.label8.Text = "Enter number of epoch:";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.name.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.name.ForeColor = System.Drawing.Color.Indigo;
            this.name.Location = new System.Drawing.Point(326, 336);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(190, 21);
            this.name.TabIndex = 16;
            this.name.Text = "                              ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(746, 430);
            this.Controls.Add(this.name);
            this.Controls.Add(this.epoch);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.create);
            this.Controls.Add(this.train);
            this.Controls.Add(this.output);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.test);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Iris Flower Species Classification";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button test;
        private Label label6;
        private Label output;
        private Button train;
        private Button create;
        private TextBox epoch;
        private Label label8;
        private Label name;
    }
}