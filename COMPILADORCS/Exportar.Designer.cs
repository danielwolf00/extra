namespace COMPILADORCS
{
    partial class Exportar
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
            this.Filtrar_Btn = new System.Windows.Forms.Button();
            this.fecha2_Dtp = new System.Windows.Forms.DateTimePicker();
            this.fecha1_Dtp = new System.Windows.Forms.DateTimePicker();
            this.Usuario_Txt = new System.Windows.Forms.TextBox();
            this.Fecha_Ch = new System.Windows.Forms.CheckBox();
            this.Lenguaje_Ch = new System.Windows.Forms.CheckBox();
            this.Usuario_Ch = new System.Windows.Forms.CheckBox();
            this.Exportar_Excel = new System.Windows.Forms.Button();
            this.Exportar_Csv = new System.Windows.Forms.Button();
            this.Exportar_Txt = new System.Windows.Forms.Button();
            this.grd = new System.Windows.Forms.DataGridView();
            this.Lenguaje_Cb = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            this.SuspendLayout();
            // 
            // Filtrar_Btn
            // 
            this.Filtrar_Btn.Location = new System.Drawing.Point(623, 167);
            this.Filtrar_Btn.Name = "Filtrar_Btn";
            this.Filtrar_Btn.Size = new System.Drawing.Size(75, 23);
            this.Filtrar_Btn.TabIndex = 29;
            this.Filtrar_Btn.Text = "Filtrar";
            this.Filtrar_Btn.UseVisualStyleBackColor = true;
            this.Filtrar_Btn.Click += new System.EventHandler(this.Filtrar_Btn_Click);
            // 
            // fecha2_Dtp
            // 
            this.fecha2_Dtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecha2_Dtp.Location = new System.Drawing.Point(688, 123);
            this.fecha2_Dtp.Name = "fecha2_Dtp";
            this.fecha2_Dtp.Size = new System.Drawing.Size(100, 20);
            this.fecha2_Dtp.TabIndex = 28;
            // 
            // fecha1_Dtp
            // 
            this.fecha1_Dtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecha1_Dtp.Location = new System.Drawing.Point(583, 123);
            this.fecha1_Dtp.Name = "fecha1_Dtp";
            this.fecha1_Dtp.Size = new System.Drawing.Size(100, 20);
            this.fecha1_Dtp.TabIndex = 26;
            // 
            // Usuario_Txt
            // 
            this.Usuario_Txt.Location = new System.Drawing.Point(583, 46);
            this.Usuario_Txt.Name = "Usuario_Txt";
            this.Usuario_Txt.Size = new System.Drawing.Size(121, 20);
            this.Usuario_Txt.TabIndex = 24;
            // 
            // Fecha_Ch
            // 
            this.Fecha_Ch.AutoSize = true;
            this.Fecha_Ch.Location = new System.Drawing.Point(518, 123);
            this.Fecha_Ch.Name = "Fecha_Ch";
            this.Fecha_Ch.Size = new System.Drawing.Size(56, 17);
            this.Fecha_Ch.TabIndex = 22;
            this.Fecha_Ch.Text = "Fecha";
            this.Fecha_Ch.UseVisualStyleBackColor = true;
            // 
            // Lenguaje_Ch
            // 
            this.Lenguaje_Ch.AutoSize = true;
            this.Lenguaje_Ch.Location = new System.Drawing.Point(518, 82);
            this.Lenguaje_Ch.Name = "Lenguaje_Ch";
            this.Lenguaje_Ch.Size = new System.Drawing.Size(70, 17);
            this.Lenguaje_Ch.TabIndex = 21;
            this.Lenguaje_Ch.Text = "Lenguaje";
            this.Lenguaje_Ch.UseVisualStyleBackColor = true;
            // 
            // Usuario_Ch
            // 
            this.Usuario_Ch.AutoSize = true;
            this.Usuario_Ch.Location = new System.Drawing.Point(518, 46);
            this.Usuario_Ch.Name = "Usuario_Ch";
            this.Usuario_Ch.Size = new System.Drawing.Size(62, 17);
            this.Usuario_Ch.TabIndex = 20;
            this.Usuario_Ch.Text = "Usuario";
            this.Usuario_Ch.UseVisualStyleBackColor = true;
            // 
            // Exportar_Excel
            // 
            this.Exportar_Excel.Location = new System.Drawing.Point(713, 237);
            this.Exportar_Excel.Name = "Exportar_Excel";
            this.Exportar_Excel.Size = new System.Drawing.Size(75, 50);
            this.Exportar_Excel.TabIndex = 19;
            this.Exportar_Excel.Text = "XLSX";
            this.Exportar_Excel.UseVisualStyleBackColor = true;
            this.Exportar_Excel.Click += new System.EventHandler(this.Exportar_Excel_Click);
            // 
            // Exportar_Csv
            // 
            this.Exportar_Csv.Location = new System.Drawing.Point(623, 237);
            this.Exportar_Csv.Name = "Exportar_Csv";
            this.Exportar_Csv.Size = new System.Drawing.Size(75, 50);
            this.Exportar_Csv.TabIndex = 18;
            this.Exportar_Csv.Text = "CSV";
            this.Exportar_Csv.UseVisualStyleBackColor = true;
            this.Exportar_Csv.Click += new System.EventHandler(this.Exportar_Csv_Click);
            // 
            // Exportar_Txt
            // 
            this.Exportar_Txt.Location = new System.Drawing.Point(533, 237);
            this.Exportar_Txt.Name = "Exportar_Txt";
            this.Exportar_Txt.Size = new System.Drawing.Size(75, 50);
            this.Exportar_Txt.TabIndex = 17;
            this.Exportar_Txt.Text = "TXT";
            this.Exportar_Txt.UseVisualStyleBackColor = true;
            this.Exportar_Txt.Click += new System.EventHandler(this.Exportar_Txt_Click);
            // 
            // grd
            // 
            this.grd.AllowUserToAddRows = false;
            this.grd.AllowUserToDeleteRows = false;
            this.grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd.Location = new System.Drawing.Point(12, 7);
            this.grd.Name = "grd";
            this.grd.ReadOnly = true;
            this.grd.Size = new System.Drawing.Size(500, 300);
            this.grd.TabIndex = 15;
            // 
            // Lenguaje_Cb
            // 
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
            this.Lenguaje_Cb.Location = new System.Drawing.Point(583, 78);
            this.Lenguaje_Cb.Name = "Lenguaje_Cb";
            this.Lenguaje_Cb.Size = new System.Drawing.Size(121, 21);
            this.Lenguaje_Cb.TabIndex = 30;
            // 
            // Exportar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 319);
            this.Controls.Add(this.Lenguaje_Cb);
            this.Controls.Add(this.Filtrar_Btn);
            this.Controls.Add(this.fecha2_Dtp);
            this.Controls.Add(this.fecha1_Dtp);
            this.Controls.Add(this.Usuario_Txt);
            this.Controls.Add(this.Fecha_Ch);
            this.Controls.Add(this.Lenguaje_Ch);
            this.Controls.Add(this.Usuario_Ch);
            this.Controls.Add(this.Exportar_Excel);
            this.Controls.Add(this.Exportar_Csv);
            this.Controls.Add(this.Exportar_Txt);
            this.Controls.Add(this.grd);
            this.Name = "Exportar";
            this.Text = "Exportar";
            this.Load += new System.EventHandler(this.Exportar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Filtrar_Btn;
        private System.Windows.Forms.DateTimePicker fecha2_Dtp;
        private System.Windows.Forms.DateTimePicker fecha1_Dtp;
        private System.Windows.Forms.TextBox Usuario_Txt;
        private System.Windows.Forms.CheckBox Fecha_Ch;
        private System.Windows.Forms.CheckBox Lenguaje_Ch;
        private System.Windows.Forms.CheckBox Usuario_Ch;
        private System.Windows.Forms.Button Exportar_Excel;
        private System.Windows.Forms.Button Exportar_Csv;
        private System.Windows.Forms.Button Exportar_Txt;
        private System.Windows.Forms.DataGridView grd;
        private System.Windows.Forms.ComboBox Lenguaje_Cb;
    }
}