namespace COMPILADORCS
{
    partial class Login
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
            this.Inicio_Btn = new System.Windows.Forms.Button();
            this.Signin_Btn = new System.Windows.Forms.Button();
            this.Lenguaje_Btn = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Nombre_Txt = new System.Windows.Forms.TextBox();
            this.Contraseña_Txt = new System.Windows.Forms.TextBox();
            this.Lenguaje_Cb = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Inicio_Btn
            // 
            this.Inicio_Btn.Location = new System.Drawing.Point(191, 144);
            this.Inicio_Btn.Name = "Inicio_Btn";
            this.Inicio_Btn.Size = new System.Drawing.Size(75, 55);
            this.Inicio_Btn.TabIndex = 0;
            this.Inicio_Btn.Text = "Iniciar Sesion";
            this.Inicio_Btn.UseVisualStyleBackColor = true;
            this.Inicio_Btn.Click += new System.EventHandler(this.Inicio_Btn_Click);
            // 
            // Signin_Btn
            // 
            this.Signin_Btn.Location = new System.Drawing.Point(50, 144);
            this.Signin_Btn.Name = "Signin_Btn";
            this.Signin_Btn.Size = new System.Drawing.Size(75, 55);
            this.Signin_Btn.TabIndex = 1;
            this.Signin_Btn.Text = "Registrar Usuario";
            this.Signin_Btn.UseVisualStyleBackColor = true;
            this.Signin_Btn.Click += new System.EventHandler(this.Signin_Btn_Click);
            // 
            // Lenguaje_Btn
            // 
            this.Lenguaje_Btn.Enabled = false;
            this.Lenguaje_Btn.Location = new System.Drawing.Point(420, 144);
            this.Lenguaje_Btn.Name = "Lenguaje_Btn";
            this.Lenguaje_Btn.Size = new System.Drawing.Size(75, 55);
            this.Lenguaje_Btn.TabIndex = 3;
            this.Lenguaje_Btn.Text = "Elegir Lenguaje";
            this.Lenguaje_Btn.UseVisualStyleBackColor = true;
            this.Lenguaje_Btn.Click += new System.EventHandler(this.Lenguaje_Btn_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Label2.Location = new System.Drawing.Point(46, 59);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(73, 19);
            this.Label2.TabIndex = 34;
            this.Label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(21, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 19);
            this.label1.TabIndex = 35;
            this.label1.Text = "Contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(284, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 19);
            this.label3.TabIndex = 36;
            this.label3.Text = "Lenguaje";
            // 
            // Nombre_Txt
            // 
            this.Nombre_Txt.Location = new System.Drawing.Point(126, 61);
            this.Nombre_Txt.Name = "Nombre_Txt";
            this.Nombre_Txt.Size = new System.Drawing.Size(140, 20);
            this.Nombre_Txt.TabIndex = 37;
            // 
            // Contraseña_Txt
            // 
            this.Contraseña_Txt.Location = new System.Drawing.Point(126, 97);
            this.Contraseña_Txt.Name = "Contraseña_Txt";
            this.Contraseña_Txt.Size = new System.Drawing.Size(112, 20);
            this.Contraseña_Txt.TabIndex = 38;
            this.Contraseña_Txt.UseSystemPasswordChar = true;
            // 
            // Lenguaje_Cb
            // 
            this.Lenguaje_Cb.Enabled = false;
            this.Lenguaje_Cb.FormattingEnabled = true;
            this.Lenguaje_Cb.Items.AddRange(new object[] {
            "Clipper",
            "Basic",
            "Cobol",
            "Fortran",
            "FoxPro",
            "Java",
            "Pascal",
            "Python",
            "Visual Basic"});
            this.Lenguaje_Cb.Location = new System.Drawing.Point(374, 79);
            this.Lenguaje_Cb.Name = "Lenguaje_Cb";
            this.Lenguaje_Cb.Size = new System.Drawing.Size(121, 21);
            this.Lenguaje_Cb.TabIndex = 39;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 249);
            this.Controls.Add(this.Lenguaje_Cb);
            this.Controls.Add(this.Contraseña_Txt);
            this.Controls.Add(this.Nombre_Txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Lenguaje_Btn);
            this.Controls.Add(this.Signin_Btn);
            this.Controls.Add(this.Inicio_Btn);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Inicio_Btn;
        private System.Windows.Forms.Button Signin_Btn;
        private System.Windows.Forms.Button Lenguaje_Btn;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Nombre_Txt;
        private System.Windows.Forms.TextBox Contraseña_Txt;
        private System.Windows.Forms.ComboBox Lenguaje_Cb;
    }
}