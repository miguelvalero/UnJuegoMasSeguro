namespace GeneradorClaves
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
            this.generar = new System.Windows.Forms.Button();
            this.PBox = new System.Windows.Forms.TextBox();
            this.QBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabla = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.fraseBox = new System.Windows.Forms.TextBox();
            this.fraseEncriptadaLbl = new System.Windows.Forms.Label();
            this.fraseRecuperadaLbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numeroBox = new System.Windows.Forms.TextBox();
            this.numeroRecuperadoLbl = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.numeroEncriptadoLbl = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // generar
            // 
            this.generar.Location = new System.Drawing.Point(122, 68);
            this.generar.Name = "generar";
            this.generar.Size = new System.Drawing.Size(110, 23);
            this.generar.TabIndex = 0;
            this.generar.Text = "Generar claves";
            this.generar.UseVisualStyleBackColor = true;
            this.generar.Click += new System.EventHandler(this.generar_Click);
            // 
            // PBox
            // 
            this.PBox.Location = new System.Drawing.Point(59, 52);
            this.PBox.Name = "PBox";
            this.PBox.Size = new System.Drawing.Size(39, 20);
            this.PBox.TabIndex = 1;
            // 
            // QBox
            // 
            this.QBox.Location = new System.Drawing.Point(59, 78);
            this.QBox.Name = "QBox";
            this.QBox.Size = new System.Drawing.Size(39, 20);
            this.QBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "P";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Escribe dos números primos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Q";
            // 
            // tabla
            // 
            this.tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla.Location = new System.Drawing.Point(59, 112);
            this.tabla.Name = "tabla";
            this.tabla.RowHeadersVisible = false;
            this.tabla.Size = new System.Drawing.Size(240, 393);
            this.tabla.TabIndex = 6;
            this.tabla.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabla_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Texto recuperado con clave (N,d)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Texto encriptado con clave (N,e)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(120, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Texto original";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(464, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Test frase";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fraseBox
            // 
            this.fraseBox.Location = new System.Drawing.Point(201, 66);
            this.fraseBox.Name = "fraseBox";
            this.fraseBox.Size = new System.Drawing.Size(240, 20);
            this.fraseBox.TabIndex = 13;
            // 
            // fraseEncriptadaLbl
            // 
            this.fraseEncriptadaLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fraseEncriptadaLbl.Location = new System.Drawing.Point(201, 99);
            this.fraseEncriptadaLbl.Name = "fraseEncriptadaLbl";
            this.fraseEncriptadaLbl.Size = new System.Drawing.Size(240, 32);
            this.fraseEncriptadaLbl.TabIndex = 14;
            // 
            // fraseRecuperadaLbl
            // 
            this.fraseRecuperadaLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fraseRecuperadaLbl.Location = new System.Drawing.Point(201, 143);
            this.fraseRecuperadaLbl.Name = "fraseRecuperadaLbl";
            this.fraseRecuperadaLbl.Size = new System.Drawing.Size(240, 31);
            this.fraseRecuperadaLbl.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fraseBox);
            this.groupBox1.Controls.Add(this.fraseRecuperadaLbl);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.fraseEncriptadaLbl);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(376, 222);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(565, 195);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Encriptación de frases";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numeroBox);
            this.groupBox2.Controls.Add(this.numeroRecuperadoLbl);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.numeroEncriptadoLbl);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(376, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(401, 195);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Encriptación de números";
            // 
            // numeroBox
            // 
            this.numeroBox.Location = new System.Drawing.Point(214, 40);
            this.numeroBox.Name = "numeroBox";
            this.numeroBox.Size = new System.Drawing.Size(54, 20);
            this.numeroBox.TabIndex = 13;
            // 
            // numeroRecuperadoLbl
            // 
            this.numeroRecuperadoLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numeroRecuperadoLbl.Location = new System.Drawing.Point(214, 100);
            this.numeroRecuperadoLbl.Name = "numeroRecuperadoLbl";
            this.numeroRecuperadoLbl.Size = new System.Drawing.Size(54, 31);
            this.numeroRecuperadoLbl.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(173, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Número recuperado cin cleve (N,d)";
            // 
            // numeroEncriptadoLbl
            // 
            this.numeroEncriptadoLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numeroEncriptadoLbl.Location = new System.Drawing.Point(214, 65);
            this.numeroEncriptadoLbl.Name = "numeroEncriptadoLbl";
            this.numeroEncriptadoLbl.Size = new System.Drawing.Size(54, 32);
            this.numeroEncriptadoLbl.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(173, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Número encriptado con cleve (N,e)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(120, 40);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "Número original";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(294, 63);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Test número";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(238, 68);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 18;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 712);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabla);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.QBox);
            this.Controls.Add(this.PBox);
            this.Controls.Add(this.generar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button generar;
        private System.Windows.Forms.TextBox PBox;
        private System.Windows.Forms.TextBox QBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView tabla;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox fraseBox;
        private System.Windows.Forms.Label fraseEncriptadaLbl;
        private System.Windows.Forms.Label fraseRecuperadaLbl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox numeroBox;
        private System.Windows.Forms.Label numeroRecuperadoLbl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label numeroEncriptadoLbl;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

