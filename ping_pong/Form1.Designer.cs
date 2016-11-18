namespace ping_pong
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda wsparcia projektanta - nie należy modyfikować
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.wynik = new System.Windows.Forms.Label();
            this.label_score = new System.Windows.Forms.Label();
            this.ball = new System.Windows.Forms.PictureBox();
            this.racket = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label_f1 = new System.Windows.Forms.Label();
            this.label_esc = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racket)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_esc);
            this.panel1.Controls.Add(this.label_f1);
            this.panel1.Controls.Add(this.wynik);
            this.panel1.Controls.Add(this.label_score);
            this.panel1.Controls.Add(this.ball);
            this.panel1.Controls.Add(this.racket);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 362);
            this.panel1.TabIndex = 0;
            // 
            // wynik
            // 
            this.wynik.AutoSize = true;
            this.wynik.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wynik.Location = new System.Drawing.Point(-5, 0);
            this.wynik.Name = "wynik";
            this.wynik.Size = new System.Drawing.Size(155, 25);
            this.wynik.TabIndex = 3;
            this.wynik.Text = "Twoj wynik to: ";
            this.wynik.Visible = false;
            // 
            // label_score
            // 
            this.label_score.AutoSize = true;
            this.label_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_score.Location = new System.Drawing.Point(15, 15);
            this.label_score.Name = "label_score";
            this.label_score.Size = new System.Drawing.Size(0, 25);
            this.label_score.TabIndex = 2;
            // 
            // ball
            // 
            this.ball.Image = global::ping_pong.Properties.Resources._1475107607_Red_Ball;
            this.ball.Location = new System.Drawing.Point(178, 59);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(31, 33);
            this.ball.TabIndex = 1;
            this.ball.TabStop = false;
            // 
            // racket
            // 
            this.racket.BackColor = System.Drawing.Color.Black;
            this.racket.Location = new System.Drawing.Point(84, 187);
            this.racket.Name = "racket";
            this.racket.Size = new System.Drawing.Size(200, 20);
            this.racket.TabIndex = 0;
            this.racket.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label_f1
            // 
            this.label_f1.AutoSize = true;
            this.label_f1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_f1.Location = new System.Drawing.Point(165, 123);
            this.label_f1.Name = "label_f1";
            this.label_f1.Size = new System.Drawing.Size(211, 25);
            this.label_f1.TabIndex = 4;
            this.label_f1.Text = "F1 - zacznij od nowa";
            // 
            // label_esc
            // 
            this.label_esc.AutoSize = true;
            this.label_esc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_esc.Location = new System.Drawing.Point(175, 147);
            this.label_esc.Name = "label_esc";
            this.label_esc.Size = new System.Drawing.Size(184, 25);
            this.label_esc.TabIndex = 5;
            this.label_esc.Text = "ESC - wyjdz z gry";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 362);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racket)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.PictureBox racket;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label_score;
        private System.Windows.Forms.Label wynik;
        private System.Windows.Forms.Label label_esc;
        private System.Windows.Forms.Label label_f1;
    }
}

