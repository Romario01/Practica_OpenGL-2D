namespace LinesPointsQuads
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
            this.components = new System.ComponentModel.Container();
            this.glControl1 = new OpenTK.GLControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTrackBar1 = new MetroFramework.Controls.MetroTrackBar();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.metroTrackBar2 = new MetroFramework.Controls.MetroTrackBar();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox3 = new MetroFramework.Controls.MetroTextBox();
            this.metroTrackBar3 = new MetroFramework.Controls.MetroTrackBar();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rdaPunto = new System.Windows.Forms.RadioButton();
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.rdaLinea = new System.Windows.Forms.RadioButton();
            this.rdaTriangulo = new System.Windows.Forms.RadioButton();
            this.txtX1 = new System.Windows.Forms.TextBox();
            this.txtY1 = new System.Windows.Forms.TextBox();
            this.lblX = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rdaCuadrado = new System.Windows.Forms.RadioButton();
            this.rdaRec = new System.Windows.Forms.RadioButton();
            this.rdaCirculo = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // glControl1
            // 
            this.glControl1.BackColor = System.Drawing.Color.Black;
            this.glControl1.Location = new System.Drawing.Point(23, 63);
            this.glControl1.Name = "glControl1";
            this.glControl1.Size = new System.Drawing.Size(312, 312);
            this.glControl1.TabIndex = 0;
            this.glControl1.VSync = false;
            this.glControl1.Load += new System.EventHandler(this.glControl1_Load);
            this.glControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.glControl1_Paint);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(366, 303);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(17, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "R";
            // 
            // metroTrackBar1
            // 
            this.metroTrackBar1.BackColor = System.Drawing.Color.Transparent;
            this.metroTrackBar1.Location = new System.Drawing.Point(395, 303);
            this.metroTrackBar1.Maximum = 255;
            this.metroTrackBar1.Name = "metroTrackBar1";
            this.metroTrackBar1.Size = new System.Drawing.Size(107, 23);
            this.metroTrackBar1.TabIndex = 3;
            this.metroTrackBar1.Text = "metroTrackBar1";
            this.metroTrackBar1.Value = 255;
            this.metroTrackBar1.ValueChanged += new System.EventHandler(this.metroTrackBar1_ValueChanged);
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(12, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[] {
        "255"};
            this.metroTextBox1.Location = new System.Drawing.Point(508, 303);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ReadOnly = true;
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(34, 23);
            this.metroTextBox1.TabIndex = 4;
            this.metroTextBox1.Text = "255";
            this.metroTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox2
            // 
            // 
            // 
            // 
            this.metroTextBox2.CustomButton.Image = null;
            this.metroTextBox2.CustomButton.Location = new System.Drawing.Point(12, 1);
            this.metroTextBox2.CustomButton.Name = "";
            this.metroTextBox2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox2.CustomButton.TabIndex = 1;
            this.metroTextBox2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox2.CustomButton.UseSelectable = true;
            this.metroTextBox2.CustomButton.Visible = false;
            this.metroTextBox2.Lines = new string[] {
        "255"};
            this.metroTextBox2.Location = new System.Drawing.Point(509, 332);
            this.metroTextBox2.MaxLength = 32767;
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.PasswordChar = '\0';
            this.metroTextBox2.ReadOnly = true;
            this.metroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox2.SelectedText = "";
            this.metroTextBox2.SelectionLength = 0;
            this.metroTextBox2.SelectionStart = 0;
            this.metroTextBox2.ShortcutsEnabled = true;
            this.metroTextBox2.Size = new System.Drawing.Size(34, 23);
            this.metroTextBox2.TabIndex = 7;
            this.metroTextBox2.Text = "255";
            this.metroTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.metroTextBox2.UseSelectable = true;
            this.metroTextBox2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTrackBar2
            // 
            this.metroTrackBar2.BackColor = System.Drawing.Color.Transparent;
            this.metroTrackBar2.Location = new System.Drawing.Point(396, 332);
            this.metroTrackBar2.Maximum = 255;
            this.metroTrackBar2.Name = "metroTrackBar2";
            this.metroTrackBar2.Size = new System.Drawing.Size(107, 23);
            this.metroTrackBar2.TabIndex = 6;
            this.metroTrackBar2.Text = "metroTrackBar2";
            this.metroTrackBar2.Value = 255;
            this.metroTrackBar2.ValueChanged += new System.EventHandler(this.metroTrackBar2_ValueChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(366, 332);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(18, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "G";
            // 
            // metroTextBox3
            // 
            // 
            // 
            // 
            this.metroTextBox3.CustomButton.Image = null;
            this.metroTextBox3.CustomButton.Location = new System.Drawing.Point(12, 1);
            this.metroTextBox3.CustomButton.Name = "";
            this.metroTextBox3.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox3.CustomButton.TabIndex = 1;
            this.metroTextBox3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox3.CustomButton.UseSelectable = true;
            this.metroTextBox3.CustomButton.Visible = false;
            this.metroTextBox3.Lines = new string[] {
        "255"};
            this.metroTextBox3.Location = new System.Drawing.Point(509, 361);
            this.metroTextBox3.MaxLength = 32767;
            this.metroTextBox3.Name = "metroTextBox3";
            this.metroTextBox3.PasswordChar = '\0';
            this.metroTextBox3.ReadOnly = true;
            this.metroTextBox3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox3.SelectedText = "";
            this.metroTextBox3.SelectionLength = 0;
            this.metroTextBox3.SelectionStart = 0;
            this.metroTextBox3.ShortcutsEnabled = true;
            this.metroTextBox3.Size = new System.Drawing.Size(34, 23);
            this.metroTextBox3.TabIndex = 10;
            this.metroTextBox3.Text = "255";
            this.metroTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.metroTextBox3.UseSelectable = true;
            this.metroTextBox3.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox3.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTrackBar3
            // 
            this.metroTrackBar3.BackColor = System.Drawing.Color.Transparent;
            this.metroTrackBar3.Location = new System.Drawing.Point(396, 361);
            this.metroTrackBar3.Maximum = 255;
            this.metroTrackBar3.Name = "metroTrackBar3";
            this.metroTrackBar3.Size = new System.Drawing.Size(107, 23);
            this.metroTrackBar3.TabIndex = 9;
            this.metroTrackBar3.Text = "metroTrackBar3";
            this.metroTrackBar3.Value = 255;
            this.metroTrackBar3.ValueChanged += new System.EventHandler(this.metroTrackBar3_ValueChanged);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(367, 361);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(17, 19);
            this.metroLabel3.TabIndex = 8;
            this.metroLabel3.Text = "B";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(383, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Dibujar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(352, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(352, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Y";
            // 
            // rdaPunto
            // 
            this.rdaPunto.AutoSize = true;
            this.rdaPunto.Location = new System.Drawing.Point(355, 189);
            this.rdaPunto.Name = "rdaPunto";
            this.rdaPunto.Size = new System.Drawing.Size(58, 17);
            this.rdaPunto.TabIndex = 0;
            this.rdaPunto.TabStop = true;
            this.rdaPunto.Text = "Puntos";
            this.rdaPunto.UseVisualStyleBackColor = true;
            this.rdaPunto.CheckedChanged += new System.EventHandler(this.rdaPunto_CheckedChanged);
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(372, 81);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(100, 20);
            this.txtX.TabIndex = 17;
            this.txtX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtX_KeyPress);
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(372, 107);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(100, 20);
            this.txtY.TabIndex = 18;
            this.txtY.TextChanged += new System.EventHandler(this.txtY_TextChanged);
            this.txtY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtY_KeyPress);
            // 
            // rdaLinea
            // 
            this.rdaLinea.AutoSize = true;
            this.rdaLinea.Location = new System.Drawing.Point(355, 212);
            this.rdaLinea.Name = "rdaLinea";
            this.rdaLinea.Size = new System.Drawing.Size(51, 17);
            this.rdaLinea.TabIndex = 19;
            this.rdaLinea.TabStop = true;
            this.rdaLinea.Text = "Linea";
            this.rdaLinea.UseVisualStyleBackColor = true;
            this.rdaLinea.CheckedChanged += new System.EventHandler(this.rdaLinea_CheckedChanged);
            // 
            // rdaTriangulo
            // 
            this.rdaTriangulo.AutoSize = true;
            this.rdaTriangulo.Location = new System.Drawing.Point(355, 236);
            this.rdaTriangulo.Name = "rdaTriangulo";
            this.rdaTriangulo.Size = new System.Drawing.Size(69, 17);
            this.rdaTriangulo.TabIndex = 20;
            this.rdaTriangulo.TabStop = true;
            this.rdaTriangulo.Text = "Triangulo";
            this.rdaTriangulo.UseVisualStyleBackColor = true;
            this.rdaTriangulo.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // txtX1
            // 
            this.txtX1.Location = new System.Drawing.Point(549, 81);
            this.txtX1.Name = "txtX1";
            this.txtX1.Size = new System.Drawing.Size(100, 20);
            this.txtX1.TabIndex = 21;
            // 
            // txtY1
            // 
            this.txtY1.Location = new System.Drawing.Point(549, 107);
            this.txtY1.Name = "txtY1";
            this.txtY1.Size = new System.Drawing.Size(100, 20);
            this.txtY1.TabIndex = 22;
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(488, 84);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(20, 13);
            this.lblX.TabIndex = 23;
            this.lblX.Text = "X1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(488, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Y1";
            // 
            // rdaCuadrado
            // 
            this.rdaCuadrado.AutoSize = true;
            this.rdaCuadrado.Location = new System.Drawing.Point(355, 260);
            this.rdaCuadrado.Name = "rdaCuadrado";
            this.rdaCuadrado.Size = new System.Drawing.Size(71, 17);
            this.rdaCuadrado.TabIndex = 25;
            this.rdaCuadrado.TabStop = true;
            this.rdaCuadrado.Text = "Cuadrado";
            this.rdaCuadrado.UseVisualStyleBackColor = true;
            this.rdaCuadrado.CheckedChanged += new System.EventHandler(this.rdaCuadrado_CheckedChanged);
            // 
            // rdaRec
            // 
            this.rdaRec.AutoSize = true;
            this.rdaRec.Location = new System.Drawing.Point(471, 189);
            this.rdaRec.Name = "rdaRec";
            this.rdaRec.Size = new System.Drawing.Size(80, 17);
            this.rdaRec.TabIndex = 26;
            this.rdaRec.TabStop = true;
            this.rdaRec.Text = "Rectangulo";
            this.rdaRec.UseVisualStyleBackColor = true;
            this.rdaRec.CheckedChanged += new System.EventHandler(this.rdaRec_CheckedChanged);
            // 
            // rdaCirculo
            // 
            this.rdaCirculo.AutoSize = true;
            this.rdaCirculo.Location = new System.Drawing.Point(471, 213);
            this.rdaCirculo.Name = "rdaCirculo";
            this.rdaCirculo.Size = new System.Drawing.Size(57, 17);
            this.rdaCirculo.TabIndex = 27;
            this.rdaCirculo.TabStop = true;
            this.rdaCirculo.Text = "Circulo";
            this.rdaCirculo.UseVisualStyleBackColor = true;
            this.rdaCirculo.CheckedChanged += new System.EventHandler(this.rdaCirculo_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(549, 260);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 28;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 402);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.rdaCirculo);
            this.Controls.Add(this.rdaRec);
            this.Controls.Add(this.rdaCuadrado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.txtY1);
            this.Controls.Add(this.txtX1);
            this.Controls.Add(this.rdaTriangulo);
            this.Controls.Add(this.rdaLinea);
            this.Controls.Add(this.rdaPunto);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.metroTextBox3);
            this.Controls.Add(this.metroTrackBar3);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroTextBox2);
            this.Controls.Add(this.metroTrackBar2);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.metroTrackBar1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.glControl1);
            this.Name = "Form1";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpenTK.GLControl glControl1;
        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTrackBar metroTrackBar1;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroTextBox metroTextBox2;
        private MetroFramework.Controls.MetroTrackBar metroTrackBar2;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox metroTextBox3;
        private MetroFramework.Controls.MetroTrackBar metroTrackBar3;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdaPunto;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.RadioButton rdaLinea;
        private System.Windows.Forms.RadioButton rdaTriangulo;
        private System.Windows.Forms.TextBox txtX1;
        private System.Windows.Forms.TextBox txtY1;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdaCuadrado;
        private System.Windows.Forms.RadioButton rdaRec;
        private System.Windows.Forms.RadioButton rdaCirculo;
        private System.Windows.Forms.Button button2;
    }
}

