namespace Colors
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
            this.slRGB1 = new System.Windows.Forms.TrackBar();
            this.tbRGB3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.slRGB3 = new System.Windows.Forms.TrackBar();
            this.tbRGB1 = new System.Windows.Forms.TextBox();
            this.tbRGB2 = new System.Windows.Forms.TextBox();
            this.tbHSV1 = new System.Windows.Forms.TextBox();
            this.tbHSV3 = new System.Windows.Forms.TextBox();
            this.tbHSV2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.slRGB2 = new System.Windows.Forms.TrackBar();
            this.slLAB1 = new System.Windows.Forms.TrackBar();
            this.slLAB2 = new System.Windows.Forms.TrackBar();
            this.slLAB3 = new System.Windows.Forms.TrackBar();
            this.tbLAB1 = new System.Windows.Forms.TextBox();
            this.tbLAB2 = new System.Windows.Forms.TextBox();
            this.tbLAB3 = new System.Windows.Forms.TextBox();
            this.slHSV1 = new System.Windows.Forms.TrackBar();
            this.slHSV2 = new System.Windows.Forms.TrackBar();
            this.slHSV3 = new System.Windows.Forms.TrackBar();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.slRGB1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slRGB3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slRGB2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slLAB1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slLAB2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slLAB3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slHSV1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slHSV2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slHSV3)).BeginInit();
            this.SuspendLayout();
            // 
            // slRGB1
            // 
            this.slRGB1.Location = new System.Drawing.Point(96, 79);
            this.slRGB1.Maximum = 255;
            this.slRGB1.Name = "slRGB1";
            this.slRGB1.Size = new System.Drawing.Size(193, 56);
            this.slRGB1.TabIndex = 12;
            this.slRGB1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.slRGB1.ValueChanged += new System.EventHandler(this.RgbChanged);
            // 
            // tbRGB3
            // 
            this.tbRGB3.Location = new System.Drawing.Point(20, 245);
            this.tbRGB3.Name = "tbRGB3";
            this.tbRGB3.Size = new System.Drawing.Size(70, 22);
            this.tbRGB3.TabIndex = 23;
            this.tbRGB3.Text = "0";
            this.tbRGB3.TextChanged += new System.EventHandler(this.tbRGB3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(726, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "LAB";
            // 
            // slRGB3
            // 
            this.slRGB3.Location = new System.Drawing.Point(96, 245);
            this.slRGB3.Maximum = 255;
            this.slRGB3.Name = "slRGB3";
            this.slRGB3.Size = new System.Drawing.Size(193, 56);
            this.slRGB3.TabIndex = 14;
            this.slRGB3.TickStyle = System.Windows.Forms.TickStyle.None;
            this.slRGB3.ValueChanged += new System.EventHandler(this.RgbChanged);
            // 
            // tbRGB1
            // 
            this.tbRGB1.Location = new System.Drawing.Point(20, 79);
            this.tbRGB1.Name = "tbRGB1";
            this.tbRGB1.Size = new System.Drawing.Size(70, 22);
            this.tbRGB1.TabIndex = 21;
            this.tbRGB1.Text = "0";
            this.tbRGB1.TextChanged += new System.EventHandler(this.tbRGB1_TextChanged);
            // 
            // tbRGB2
            // 
            this.tbRGB2.Location = new System.Drawing.Point(20, 165);
            this.tbRGB2.Name = "tbRGB2";
            this.tbRGB2.Size = new System.Drawing.Size(70, 22);
            this.tbRGB2.TabIndex = 22;
            this.tbRGB2.Text = "0";
            this.tbRGB2.TextChanged += new System.EventHandler(this.tbRGB2_TextChanged);
            // 
            // tbHSV1
            // 
            this.tbHSV1.Location = new System.Drawing.Point(320, 79);
            this.tbHSV1.Name = "tbHSV1";
            this.tbHSV1.Size = new System.Drawing.Size(70, 22);
            this.tbHSV1.TabIndex = 24;
            this.tbHSV1.Text = "0";
            this.tbHSV1.TextChanged += new System.EventHandler(this.tbHSV1_TextChanged);
            // 
            // tbHSV3
            // 
            this.tbHSV3.Location = new System.Drawing.Point(320, 245);
            this.tbHSV3.Name = "tbHSV3";
            this.tbHSV3.Size = new System.Drawing.Size(70, 22);
            this.tbHSV3.TabIndex = 25;
            this.tbHSV3.Text = "0";
            this.tbHSV3.TextChanged += new System.EventHandler(this.tbHSV3_TextChanged);
            // 
            // tbHSV2
            // 
            this.tbHSV2.Location = new System.Drawing.Point(320, 165);
            this.tbHSV2.Name = "tbHSV2";
            this.tbHSV2.Size = new System.Drawing.Size(70, 22);
            this.tbHSV2.TabIndex = 26;
            this.tbHSV2.Text = "0";
            this.tbHSV2.TextChanged += new System.EventHandler(this.tbHSV2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(437, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "HSV";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "RGB\r\n";
            // 
            // slRGB2
            // 
            this.slRGB2.Location = new System.Drawing.Point(96, 165);
            this.slRGB2.Maximum = 255;
            this.slRGB2.Name = "slRGB2";
            this.slRGB2.Size = new System.Drawing.Size(193, 56);
            this.slRGB2.TabIndex = 13;
            this.slRGB2.TickStyle = System.Windows.Forms.TickStyle.None;
            this.slRGB2.ValueChanged += new System.EventHandler(this.RgbChanged);
            // 
            // slLAB1
            // 
            this.slLAB1.Location = new System.Drawing.Point(696, 79);
            this.slLAB1.Maximum = 100;
            this.slLAB1.Name = "slLAB1";
            this.slLAB1.Size = new System.Drawing.Size(183, 56);
            this.slLAB1.TabIndex = 18;
            this.slLAB1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.slLAB1.ValueChanged += new System.EventHandler(this.LabChanged);
            // 
            // slLAB2
            // 
            this.slLAB2.Location = new System.Drawing.Point(696, 165);
            this.slLAB2.Maximum = 128;
            this.slLAB2.Minimum = -128;
            this.slLAB2.Name = "slLAB2";
            this.slLAB2.Size = new System.Drawing.Size(183, 56);
            this.slLAB2.TabIndex = 19;
            this.slLAB2.TickStyle = System.Windows.Forms.TickStyle.None;
            this.slLAB2.ValueChanged += new System.EventHandler(this.LabChanged);
            // 
            // slLAB3
            // 
            this.slLAB3.Location = new System.Drawing.Point(696, 245);
            this.slLAB3.Maximum = 128;
            this.slLAB3.Minimum = -128;
            this.slLAB3.Name = "slLAB3";
            this.slLAB3.Size = new System.Drawing.Size(183, 56);
            this.slLAB3.TabIndex = 20;
            this.slLAB3.TickStyle = System.Windows.Forms.TickStyle.None;
            this.slLAB3.ValueChanged += new System.EventHandler(this.LabChanged);
            // 
            // tbLAB1
            // 
            this.tbLAB1.Location = new System.Drawing.Point(609, 79);
            this.tbLAB1.Name = "tbLAB1";
            this.tbLAB1.Size = new System.Drawing.Size(70, 22);
            this.tbLAB1.TabIndex = 27;
            this.tbLAB1.Text = "0";
            this.tbLAB1.TextChanged += new System.EventHandler(this.tbLAB1_TextChanged);
            // 
            // tbLAB2
            // 
            this.tbLAB2.Location = new System.Drawing.Point(609, 165);
            this.tbLAB2.Name = "tbLAB2";
            this.tbLAB2.Size = new System.Drawing.Size(70, 22);
            this.tbLAB2.TabIndex = 28;
            this.tbLAB2.Text = "0";
            this.tbLAB2.TextChanged += new System.EventHandler(this.tbLAB2_TextChanged);
            // 
            // tbLAB3
            // 
            this.tbLAB3.Location = new System.Drawing.Point(609, 245);
            this.tbLAB3.Name = "tbLAB3";
            this.tbLAB3.Size = new System.Drawing.Size(70, 22);
            this.tbLAB3.TabIndex = 29;
            this.tbLAB3.Text = "0";
            this.tbLAB3.TextChanged += new System.EventHandler(this.tbLAB3_TextChanged);
            // 
            // slHSV1
            // 
            this.slHSV1.Location = new System.Drawing.Point(407, 79);
            this.slHSV1.Maximum = 360;
            this.slHSV1.Name = "slHSV1";
            this.slHSV1.Size = new System.Drawing.Size(183, 56);
            this.slHSV1.TabIndex = 30;
            this.slHSV1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.slHSV1.ValueChanged += new System.EventHandler(this.HsvChanged);
            // 
            // slHSV2
            // 
            this.slHSV2.Location = new System.Drawing.Point(407, 165);
            this.slHSV2.Maximum = 100;
            this.slHSV2.Name = "slHSV2";
            this.slHSV2.Size = new System.Drawing.Size(183, 56);
            this.slHSV2.TabIndex = 31;
            this.slHSV2.TickStyle = System.Windows.Forms.TickStyle.None;
            this.slHSV2.ValueChanged += new System.EventHandler(this.HsvChanged);
            // 
            // slHSV3
            // 
            this.slHSV3.Location = new System.Drawing.Point(407, 245);
            this.slHSV3.Maximum = 100;
            this.slHSV3.Name = "slHSV3";
            this.slHSV3.Size = new System.Drawing.Size(183, 56);
            this.slHSV3.TabIndex = 32;
            this.slHSV3.TickStyle = System.Windows.Forms.TickStyle.None;
            this.slHSV3.ValueChanged += new System.EventHandler(this.HsvChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(567, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 33);
            this.button1.TabIndex = 33;
            this.button1.Text = "Choose color";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 532);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.slHSV3);
            this.Controls.Add(this.slHSV2);
            this.Controls.Add(this.slHSV1);
            this.Controls.Add(this.tbLAB3);
            this.Controls.Add(this.tbLAB2);
            this.Controls.Add(this.tbLAB1);
            this.Controls.Add(this.tbHSV2);
            this.Controls.Add(this.tbHSV3);
            this.Controls.Add(this.tbHSV1);
            this.Controls.Add(this.tbRGB3);
            this.Controls.Add(this.tbRGB2);
            this.Controls.Add(this.tbRGB1);
            this.Controls.Add(this.slLAB3);
            this.Controls.Add(this.slLAB2);
            this.Controls.Add(this.slLAB1);
            this.Controls.Add(this.slRGB3);
            this.Controls.Add(this.slRGB2);
            this.Controls.Add(this.slRGB1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Conversions";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.slRGB1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slRGB3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slRGB2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slLAB1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slLAB2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slLAB3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slHSV1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slHSV2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slHSV3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbRGB3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar slRGB3;
        private System.Windows.Forms.TextBox tbRGB1;
        private System.Windows.Forms.TextBox tbRGB2;
        private System.Windows.Forms.TextBox tbHSV1;
        private System.Windows.Forms.TextBox tbHSV3;
        private System.Windows.Forms.TextBox tbHSV2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar slRGB2;
        private System.Windows.Forms.TrackBar slLAB1;
        private System.Windows.Forms.TrackBar slLAB2;
        private System.Windows.Forms.TrackBar slLAB3;
        private System.Windows.Forms.TextBox tbLAB1;
        private System.Windows.Forms.TextBox tbLAB2;
        private System.Windows.Forms.TextBox tbLAB3;
        private System.Windows.Forms.TrackBar slHSV1;
        private System.Windows.Forms.TrackBar slHSV2;
        private System.Windows.Forms.TrackBar slHSV3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TrackBar slRGB1;
    }
}

