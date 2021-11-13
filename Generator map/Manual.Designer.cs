
namespace Generator_map
{
    partial class Manual
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
            this.leftTop = new System.Windows.Forms.TrackBar();
            this.leftBot = new System.Windows.Forms.TrackBar();
            this.top = new System.Windows.Forms.TrackBar();
            this.mid = new System.Windows.Forms.TrackBar();
            this.bot = new System.Windows.Forms.TrackBar();
            this.rightTop = new System.Windows.Forms.TrackBar();
            this.rightBot = new System.Windows.Forms.TrackBar();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.leftTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftBot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.top)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightBot)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "0 - trawa\r\n1 - woda\r\n2 - piasek\r\n3 - gory ";
            // 
            // leftTop
            // 
            this.leftTop.BackColor = System.Drawing.Color.Green;
            this.leftTop.Location = new System.Drawing.Point(169, 112);
            this.leftTop.Maximum = 3;
            this.leftTop.Name = "leftTop";
            this.leftTop.Size = new System.Drawing.Size(104, 45);
            this.leftTop.TabIndex = 1;
            this.leftTop.Scroll += new System.EventHandler(this.leftTop_Scroll);
            // 
            // leftBot
            // 
            this.leftBot.BackColor = System.Drawing.Color.Green;
            this.leftBot.Location = new System.Drawing.Point(169, 215);
            this.leftBot.Maximum = 3;
            this.leftBot.Name = "leftBot";
            this.leftBot.Size = new System.Drawing.Size(104, 45);
            this.leftBot.TabIndex = 2;
            this.leftBot.Scroll += new System.EventHandler(this.leftBot_Scroll);
            // 
            // top
            // 
            this.top.BackColor = System.Drawing.Color.Green;
            this.top.Location = new System.Drawing.Point(303, 81);
            this.top.Maximum = 3;
            this.top.Name = "top";
            this.top.Size = new System.Drawing.Size(104, 45);
            this.top.TabIndex = 3;
            this.top.Scroll += new System.EventHandler(this.top_Scroll);
            // 
            // mid
            // 
            this.mid.BackColor = System.Drawing.Color.Green;
            this.mid.Location = new System.Drawing.Point(303, 164);
            this.mid.Maximum = 3;
            this.mid.Name = "mid";
            this.mid.Size = new System.Drawing.Size(104, 45);
            this.mid.TabIndex = 4;
            this.mid.Scroll += new System.EventHandler(this.mid_Scroll);
            // 
            // bot
            // 
            this.bot.BackColor = System.Drawing.Color.Green;
            this.bot.Location = new System.Drawing.Point(303, 259);
            this.bot.Maximum = 3;
            this.bot.Name = "bot";
            this.bot.Size = new System.Drawing.Size(104, 45);
            this.bot.TabIndex = 5;
            this.bot.Scroll += new System.EventHandler(this.bot_Scroll);
            // 
            // rightTop
            // 
            this.rightTop.BackColor = System.Drawing.Color.Green;
            this.rightTop.Location = new System.Drawing.Point(454, 112);
            this.rightTop.Maximum = 3;
            this.rightTop.Name = "rightTop";
            this.rightTop.Size = new System.Drawing.Size(104, 45);
            this.rightTop.TabIndex = 6;
            this.rightTop.Scroll += new System.EventHandler(this.rightTop_Scroll);
            // 
            // rightBot
            // 
            this.rightBot.BackColor = System.Drawing.Color.Green;
            this.rightBot.Location = new System.Drawing.Point(454, 215);
            this.rightBot.Maximum = 3;
            this.rightBot.Name = "rightBot";
            this.rightBot.Size = new System.Drawing.Size(104, 45);
            this.rightBot.TabIndex = 7;
            this.rightBot.Scroll += new System.EventHandler(this.rightBot_Scroll);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(303, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Generuj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Manual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rightBot);
            this.Controls.Add(this.rightTop);
            this.Controls.Add(this.bot);
            this.Controls.Add(this.mid);
            this.Controls.Add(this.top);
            this.Controls.Add(this.leftBot);
            this.Controls.Add(this.leftTop);
            this.Controls.Add(this.label1);
            this.Name = "Manual";
            this.Text = "Manual";
            ((System.ComponentModel.ISupportInitialize)(this.leftTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftBot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.top)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightBot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar leftTop;
        private System.Windows.Forms.TrackBar leftBot;
        private System.Windows.Forms.TrackBar top;
        private System.Windows.Forms.TrackBar mid;
        private System.Windows.Forms.TrackBar bot;
        private System.Windows.Forms.TrackBar rightTop;
        private System.Windows.Forms.TrackBar trackBar7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TrackBar rightBot;
    }
}