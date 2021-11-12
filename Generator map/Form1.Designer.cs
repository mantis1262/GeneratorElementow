
namespace Generator_map
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.przeszkody = new System.Windows.Forms.NumericUpDown();
            this.gory = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.piasek = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.woda = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.trawa = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.przeszkody)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piasek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.woda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trawa)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(53, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Generuj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "ilosć przeszkód";
            // 
            // przeszkody
            // 
            this.przeszkody.Location = new System.Drawing.Point(154, 108);
            this.przeszkody.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.przeszkody.Name = "przeszkody";
            this.przeszkody.Size = new System.Drawing.Size(120, 23);
            this.przeszkody.TabIndex = 2;
            // 
            // gory
            // 
            this.gory.Location = new System.Drawing.Point(536, 168);
            this.gory.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.gory.Name = "gory";
            this.gory.Size = new System.Drawing.Size(120, 23);
            this.gory.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(424, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "góry";
            // 
            // piasek
            // 
            this.piasek.Location = new System.Drawing.Point(536, 197);
            this.piasek.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.piasek.Name = "piasek";
            this.piasek.Size = new System.Drawing.Size(120, 23);
            this.piasek.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(424, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "piasek";
            // 
            // woda
            // 
            this.woda.Location = new System.Drawing.Point(536, 139);
            this.woda.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.woda.Name = "woda";
            this.woda.Size = new System.Drawing.Size(120, 23);
            this.woda.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(424, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "woda";
            // 
            // trawa
            // 
            this.trawa.Location = new System.Drawing.Point(536, 110);
            this.trawa.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.trawa.Name = "trawa";
            this.trawa.Size = new System.Drawing.Size(120, 23);
            this.trawa.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(424, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "trawa";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(154, 44);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(66, 19);
            this.radioButton1.TabIndex = 11;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Losowo";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.trawa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.woda);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.piasek);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.przeszkody);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.przeszkody)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piasek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.woda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trawa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown przeszkody;
        private System.Windows.Forms.NumericUpDown gory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown piasek;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown woda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown trawa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

