namespace lab05
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
            this.btnColor = new System.Windows.Forms.Button();
            this.btnFont = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonZoom = new System.Windows.Forms.RadioButton();
            this.radioButtonStretch = new System.Windows.Forms.RadioButton();
            this.radioButtonNormal = new System.Windows.Forms.RadioButton();
            this.btnLoad = new System.Windows.Forms.Button();
            this.panelDraw = new System.Windows.Forms.Panel();
            this.pictureBoxPixels = new System.Windows.Forms.PictureBox();
            this.btnInvert = new System.Windows.Forms.Button();
            this.btnLoadPixels = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPixels)).BeginInit();
            this.SuspendLayout();
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(55, 284);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(75, 23);
            this.btnColor.TabIndex = 0;
            this.btnColor.Text = "Цвет текста";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnFont
            // 
            this.btnFont.Location = new System.Drawing.Point(55, 313);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(75, 23);
            this.btnFont.TabIndex = 1;
            this.btnFont.Text = "Шрифт";
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(392, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 150);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonZoom);
            this.panel1.Controls.Add(this.radioButtonStretch);
            this.panel1.Controls.Add(this.radioButtonNormal);
            this.panel1.Location = new System.Drawing.Point(392, 187);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 100);
            this.panel1.TabIndex = 3;
            // 
            // radioButtonZoom
            // 
            this.radioButtonZoom.AutoSize = true;
            this.radioButtonZoom.Location = new System.Drawing.Point(23, 65);
            this.radioButtonZoom.Name = "radioButtonZoom";
            this.radioButtonZoom.Size = new System.Drawing.Size(52, 17);
            this.radioButtonZoom.TabIndex = 2;
            this.radioButtonZoom.TabStop = true;
            this.radioButtonZoom.Text = "Zoom";
            this.radioButtonZoom.UseVisualStyleBackColor = true;
            // 
            // radioButtonStretch
            // 
            this.radioButtonStretch.AutoSize = true;
            this.radioButtonStretch.Location = new System.Drawing.Point(23, 41);
            this.radioButtonStretch.Name = "radioButtonStretch";
            this.radioButtonStretch.Size = new System.Drawing.Size(59, 17);
            this.radioButtonStretch.TabIndex = 1;
            this.radioButtonStretch.TabStop = true;
            this.radioButtonStretch.Text = "Stretch";
            this.radioButtonStretch.UseVisualStyleBackColor = true;
            // 
            // radioButtonNormal
            // 
            this.radioButtonNormal.AutoSize = true;
            this.radioButtonNormal.Location = new System.Drawing.Point(23, 17);
            this.radioButtonNormal.Name = "radioButtonNormal";
            this.radioButtonNormal.Size = new System.Drawing.Size(58, 17);
            this.radioButtonNormal.TabIndex = 0;
            this.radioButtonNormal.TabStop = true;
            this.radioButtonNormal.Text = "Normal";
            this.radioButtonNormal.UseVisualStyleBackColor = true;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(621, 76);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 4;
            this.btnLoad.Text = "Загрузить";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // panelDraw
            // 
            this.panelDraw.Location = new System.Drawing.Point(597, 145);
            this.panelDraw.Name = "panelDraw";
            this.panelDraw.Size = new System.Drawing.Size(200, 100);
            this.panelDraw.TabIndex = 5;
            this.panelDraw.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDraw_Paint);
            // 
            // pictureBoxPixels
            // 
            this.pictureBoxPixels.Location = new System.Drawing.Point(230, 333);
            this.pictureBoxPixels.Name = "pictureBoxPixels";
            this.pictureBoxPixels.Size = new System.Drawing.Size(156, 105);
            this.pictureBoxPixels.TabIndex = 6;
            this.pictureBoxPixels.TabStop = false;
            // 
            // btnInvert
            // 
            this.btnInvert.Location = new System.Drawing.Point(392, 344);
            this.btnInvert.Name = "btnInvert";
            this.btnInvert.Size = new System.Drawing.Size(105, 23);
            this.btnInvert.TabIndex = 7;
            this.btnInvert.Text = "Инвертировать";
            this.btnInvert.UseVisualStyleBackColor = true;
            this.btnInvert.Click += new System.EventHandler(this.btnInvert_Click);
            // 
            // btnLoadPixels
            // 
            this.btnLoadPixels.Location = new System.Drawing.Point(392, 373);
            this.btnLoadPixels.Name = "btnLoadPixels";
            this.btnLoadPixels.Size = new System.Drawing.Size(75, 23);
            this.btnLoadPixels.TabIndex = 8;
            this.btnLoadPixels.Text = "Загрузить";
            this.btnLoadPixels.UseVisualStyleBackColor = true;
            this.btnLoadPixels.Click += new System.EventHandler(this.btnLoadPixels_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLoadPixels);
            this.Controls.Add(this.btnInvert);
            this.Controls.Add(this.pictureBoxPixels);
            this.Controls.Add(this.panelDraw);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnFont);
            this.Controls.Add(this.btnColor);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPixels)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButtonZoom;
        private System.Windows.Forms.RadioButton radioButtonStretch;
        private System.Windows.Forms.RadioButton radioButtonNormal;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Panel panelDraw;
        private System.Windows.Forms.PictureBox pictureBoxPixels;
        private System.Windows.Forms.Button btnInvert;
        private System.Windows.Forms.Button btnLoadPixels;
    }
}

