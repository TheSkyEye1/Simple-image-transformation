namespace lab3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.IMG1 = new Emgu.CV.UI.ImageBox();
            this.IMG2 = new Emgu.CV.UI.ImageBox();
            this.load = new System.Windows.Forms.Button();
            this.tracki = new System.Windows.Forms.TrackBar();
            this.resizeb = new System.Windows.Forms.Button();
            this.lb1 = new System.Windows.Forms.Label();
            this.homobut = new System.Windows.Forms.Button();
            this.rotbut = new System.Windows.Forms.Button();
            this.rotbar = new System.Windows.Forms.TrackBar();
            this.lb2 = new System.Windows.Forms.Label();
            this.flipb = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.RadioButton();
            this.b2 = new System.Windows.Forms.RadioButton();
            this.b3 = new System.Windows.Forms.RadioButton();
            this.b4 = new System.Windows.Forms.RadioButton();
            this.lb3 = new System.Windows.Forms.Label();
            this.trackj = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.IMG1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMG2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tracki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackj)).BeginInit();
            this.SuspendLayout();
            // 
            // IMG1
            // 
            this.IMG1.Location = new System.Drawing.Point(12, 12);
            this.IMG1.Name = "IMG1";
            this.IMG1.Size = new System.Drawing.Size(640, 480);
            this.IMG1.TabIndex = 2;
            this.IMG1.TabStop = false;
            this.IMG1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.IMG1_MouseClick);
            // 
            // IMG2
            // 
            this.IMG2.Location = new System.Drawing.Point(809, 12);
            this.IMG2.Name = "IMG2";
            this.IMG2.Size = new System.Drawing.Size(640, 480);
            this.IMG2.TabIndex = 3;
            this.IMG2.TabStop = false;
            // 
            // load
            // 
            this.load.Location = new System.Drawing.Point(658, 12);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(145, 23);
            this.load.TabIndex = 4;
            this.load.Text = "Load";
            this.load.UseVisualStyleBackColor = true;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // tracki
            // 
            this.tracki.LargeChange = 10;
            this.tracki.Location = new System.Drawing.Point(658, 41);
            this.tracki.Maximum = 50;
            this.tracki.Minimum = 10;
            this.tracki.Name = "tracki";
            this.tracki.Size = new System.Drawing.Size(145, 45);
            this.tracki.TabIndex = 10;
            this.tracki.Value = 10;
            this.tracki.ValueChanged += new System.EventHandler(this.rtb_ValueChanged);
            // 
            // resizeb
            // 
            this.resizeb.Location = new System.Drawing.Point(658, 149);
            this.resizeb.Name = "resizeb";
            this.resizeb.Size = new System.Drawing.Size(145, 23);
            this.resizeb.TabIndex = 11;
            this.resizeb.Text = "Resize";
            this.resizeb.UseVisualStyleBackColor = true;
            this.resizeb.Click += new System.EventHandler(this.resizeb_Click);
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(784, 73);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(13, 13);
            this.lb1.TabIndex = 12;
            this.lb1.Text = "1";
            // 
            // homobut
            // 
            this.homobut.Location = new System.Drawing.Point(658, 178);
            this.homobut.Name = "homobut";
            this.homobut.Size = new System.Drawing.Size(145, 23);
            this.homobut.TabIndex = 13;
            this.homobut.Text = "Homography";
            this.homobut.UseVisualStyleBackColor = true;
            this.homobut.Click += new System.EventHandler(this.homobut_Click);
            // 
            // rotbut
            // 
            this.rotbut.Location = new System.Drawing.Point(658, 265);
            this.rotbut.Name = "rotbut";
            this.rotbut.Size = new System.Drawing.Size(145, 23);
            this.rotbut.TabIndex = 14;
            this.rotbut.Text = "Rotate";
            this.rotbut.UseVisualStyleBackColor = true;
            this.rotbut.Click += new System.EventHandler(this.rotbut_Click);
            // 
            // rotbar
            // 
            this.rotbar.LargeChange = 3;
            this.rotbar.Location = new System.Drawing.Point(658, 214);
            this.rotbar.Maximum = 6;
            this.rotbar.Minimum = 1;
            this.rotbar.Name = "rotbar";
            this.rotbar.Size = new System.Drawing.Size(145, 45);
            this.rotbar.TabIndex = 1;
            this.rotbar.Value = 1;
            this.rotbar.ValueChanged += new System.EventHandler(this.rotbar_ValueChanged);
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(778, 249);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(25, 13);
            this.lb2.TabIndex = 16;
            this.lb2.Text = "180";
            // 
            // flipb
            // 
            this.flipb.Location = new System.Drawing.Point(658, 388);
            this.flipb.Name = "flipb";
            this.flipb.Size = new System.Drawing.Size(145, 23);
            this.flipb.TabIndex = 17;
            this.flipb.Text = "Flip";
            this.flipb.UseVisualStyleBackColor = true;
            this.flipb.Click += new System.EventHandler(this.but1_Click);
            // 
            // b1
            // 
            this.b1.AutoSize = true;
            this.b1.Checked = true;
            this.b1.Location = new System.Drawing.Point(658, 294);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(40, 17);
            this.b1.TabIndex = 18;
            this.b1.TabStop = true;
            this.b1.Text = "1;1";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.CheckedChanged += new System.EventHandler(this.b1_CheckedChanged);
            // 
            // b2
            // 
            this.b2.AutoSize = true;
            this.b2.Location = new System.Drawing.Point(658, 317);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(43, 17);
            this.b2.TabIndex = 19;
            this.b2.Text = "-1;1";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.CheckedChanged += new System.EventHandler(this.b2_CheckedChanged);
            // 
            // b3
            // 
            this.b3.AutoSize = true;
            this.b3.Location = new System.Drawing.Point(658, 340);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(43, 17);
            this.b3.TabIndex = 20;
            this.b3.Text = "1;-1";
            this.b3.UseVisualStyleBackColor = true;
            this.b3.CheckedChanged += new System.EventHandler(this.b3_CheckedChanged);
            // 
            // b4
            // 
            this.b4.AutoSize = true;
            this.b4.Location = new System.Drawing.Point(658, 363);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(46, 17);
            this.b4.TabIndex = 21;
            this.b4.Text = "-1;-1";
            this.b4.UseVisualStyleBackColor = true;
            this.b4.CheckedChanged += new System.EventHandler(this.b4_CheckedChanged);
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.Location = new System.Drawing.Point(784, 124);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(13, 13);
            this.lb3.TabIndex = 23;
            this.lb3.Text = "1";
            // 
            // trackj
            // 
            this.trackj.LargeChange = 10;
            this.trackj.Location = new System.Drawing.Point(658, 92);
            this.trackj.Maximum = 50;
            this.trackj.Minimum = 10;
            this.trackj.Name = "trackj";
            this.trackj.Size = new System.Drawing.Size(145, 45);
            this.trackj.TabIndex = 22;
            this.trackj.Value = 10;
            this.trackj.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1461, 627);
            this.Controls.Add(this.lb3);
            this.Controls.Add(this.trackj);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.flipb);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.rotbar);
            this.Controls.Add(this.rotbut);
            this.Controls.Add(this.homobut);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.resizeb);
            this.Controls.Add(this.tracki);
            this.Controls.Add(this.load);
            this.Controls.Add(this.IMG2);
            this.Controls.Add(this.IMG1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.IMG1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMG2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tracki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackj)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox IMG1;
        private Emgu.CV.UI.ImageBox IMG2;
        private System.Windows.Forms.Button load;
        private System.Windows.Forms.TrackBar tracki;
        private System.Windows.Forms.Button resizeb;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Button homobut;
        private System.Windows.Forms.Button rotbut;
        private System.Windows.Forms.TrackBar rotbar;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Button flipb;
        private System.Windows.Forms.RadioButton b1;
        private System.Windows.Forms.RadioButton b2;
        private System.Windows.Forms.RadioButton b3;
        private System.Windows.Forms.RadioButton b4;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.TrackBar trackj;
    }
}

