namespace Molino
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.corriente = new System.Windows.Forms.Label();
            this.temperatura = new System.Windows.Forms.Label();
            this.rpm = new System.Windows.Forms.Label();
            this.altura = new System.Windows.Forms.Label();
            this.fino = new System.Windows.Forms.Button();
            this.medio = new System.Windows.Forms.Button();
            this.grueso = new System.Windows.Forms.Button();
            this.labelMarcha = new System.Windows.Forms.Label();
            this.labelParo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.estadoPanel = new System.Windows.Forms.Panel();
            this.buttonConectar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxPuerto = new System.Windows.Forms.ComboBox();
            this.buttonDesconectar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pnl_medio = new System.Windows.Forms.Panel();
            this.pnl_grueso = new System.Windows.Forms.Panel();
            this.pnl_fino = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // corriente
            // 
            this.corriente.AutoSize = true;
            this.corriente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.corriente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.corriente.Location = new System.Drawing.Point(749, 185);
            this.corriente.Name = "corriente";
            this.corriente.Size = new System.Drawing.Size(0, 22);
            this.corriente.TabIndex = 0;
            // 
            // temperatura
            // 
            this.temperatura.AutoSize = true;
            this.temperatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temperatura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.temperatura.Location = new System.Drawing.Point(749, 404);
            this.temperatura.Name = "temperatura";
            this.temperatura.Size = new System.Drawing.Size(0, 22);
            this.temperatura.TabIndex = 1;
            // 
            // rpm
            // 
            this.rpm.AutoSize = true;
            this.rpm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rpm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.rpm.Location = new System.Drawing.Point(749, 295);
            this.rpm.Name = "rpm";
            this.rpm.Size = new System.Drawing.Size(0, 22);
            this.rpm.TabIndex = 2;
            // 
            // altura
            // 
            this.altura.AutoSize = true;
            this.altura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.altura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.altura.Location = new System.Drawing.Point(749, 523);
            this.altura.Name = "altura";
            this.altura.Size = new System.Drawing.Size(0, 22);
            this.altura.TabIndex = 3;
            // 
            // fino
            // 
            this.fino.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.fino.Enabled = false;
            this.fino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fino.ForeColor = System.Drawing.Color.Transparent;
            this.fino.Location = new System.Drawing.Point(52, 150);
            this.fino.Name = "fino";
            this.fino.Size = new System.Drawing.Size(163, 69);
            this.fino.TabIndex = 5;
            this.fino.Text = "FINO";
            this.fino.UseVisualStyleBackColor = false;
            this.fino.Click += new System.EventHandler(this.fino_Click_1);
            // 
            // medio
            // 
            this.medio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.medio.Enabled = false;
            this.medio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.medio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medio.ForeColor = System.Drawing.Color.White;
            this.medio.Location = new System.Drawing.Point(272, 150);
            this.medio.Name = "medio";
            this.medio.Size = new System.Drawing.Size(163, 69);
            this.medio.TabIndex = 6;
            this.medio.Text = "MEDIO";
            this.medio.UseVisualStyleBackColor = false;
            this.medio.Click += new System.EventHandler(this.medio_Click_1);
            // 
            // grueso
            // 
            this.grueso.BackColor = System.Drawing.Color.Blue;
            this.grueso.Enabled = false;
            this.grueso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grueso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grueso.ForeColor = System.Drawing.Color.White;
            this.grueso.Location = new System.Drawing.Point(480, 150);
            this.grueso.Name = "grueso";
            this.grueso.Size = new System.Drawing.Size(163, 69);
            this.grueso.TabIndex = 7;
            this.grueso.Text = "GRUESO";
            this.grueso.UseVisualStyleBackColor = false;
            this.grueso.Click += new System.EventHandler(this.grueso_Click_1);
            // 
            // labelMarcha
            // 
            this.labelMarcha.BackColor = System.Drawing.Color.Lime;
            this.labelMarcha.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelMarcha.Enabled = false;
            this.labelMarcha.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMarcha.ForeColor = System.Drawing.Color.White;
            this.labelMarcha.Location = new System.Drawing.Point(1074, 238);
            this.labelMarcha.Name = "labelMarcha";
            this.labelMarcha.Size = new System.Drawing.Size(160, 94);
            this.labelMarcha.TabIndex = 8;
            this.labelMarcha.Text = "START";
            this.labelMarcha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMarcha.Click += new System.EventHandler(this.labelMarcha_Click);
            // 
            // labelParo
            // 
            this.labelParo.BackColor = System.Drawing.Color.Red;
            this.labelParo.Enabled = false;
            this.labelParo.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelParo.ForeColor = System.Drawing.Color.White;
            this.labelParo.Location = new System.Drawing.Point(1070, 430);
            this.labelParo.Name = "labelParo";
            this.labelParo.Size = new System.Drawing.Size(164, 94);
            this.labelParo.TabIndex = 9;
            this.labelParo.Text = "STOP";
            this.labelParo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelParo.Click += new System.EventHandler(this.labelParo_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Roboto", 31.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(386, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1438, 106);
            this.label1.TabIndex = 11;
            this.label1.Text = "SUPERVISORY CONTROL AND DATA ADQUISITION";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // estadoPanel
            // 
            this.estadoPanel.Location = new System.Drawing.Point(248, 431);
            this.estadoPanel.Margin = new System.Windows.Forms.Padding(4);
            this.estadoPanel.Name = "estadoPanel";
            this.estadoPanel.Size = new System.Drawing.Size(27, 25);
            this.estadoPanel.TabIndex = 1;
            // 
            // buttonConectar
            // 
            this.buttonConectar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(119)))), ((int)(((byte)(0)))));
            this.buttonConectar.FlatAppearance.BorderSize = 0;
            this.buttonConectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConectar.ForeColor = System.Drawing.Color.White;
            this.buttonConectar.Location = new System.Drawing.Point(40, 221);
            this.buttonConectar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonConectar.Name = "buttonConectar";
            this.buttonConectar.Size = new System.Drawing.Size(212, 58);
            this.buttonConectar.TabIndex = 4;
            this.buttonConectar.Text = "Conectar";
            this.buttonConectar.UseVisualStyleBackColor = false;
            this.buttonConectar.Click += new System.EventHandler(this.buttonConectar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(33, 431);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Estado de la conexión:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(32, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Seleccionar puerto";
            // 
            // comboBoxPuerto
            // 
            this.comboBoxPuerto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPuerto.FormattingEnabled = true;
            this.comboBoxPuerto.Location = new System.Drawing.Point(40, 151);
            this.comboBoxPuerto.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxPuerto.Name = "comboBoxPuerto";
            this.comboBoxPuerto.Size = new System.Drawing.Size(212, 28);
            this.comboBoxPuerto.TabIndex = 2;
            // 
            // buttonDesconectar
            // 
            this.buttonDesconectar.BackColor = System.Drawing.Color.DarkCyan;
            this.buttonDesconectar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonDesconectar.FlatAppearance.BorderSize = 0;
            this.buttonDesconectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDesconectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDesconectar.ForeColor = System.Drawing.Color.White;
            this.buttonDesconectar.Location = new System.Drawing.Point(40, 317);
            this.buttonDesconectar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDesconectar.Name = "buttonDesconectar";
            this.buttonDesconectar.Padding = new System.Windows.Forms.Padding(27, 0, 27, 0);
            this.buttonDesconectar.Size = new System.Drawing.Size(212, 58);
            this.buttonDesconectar.TabIndex = 1;
            this.buttonDesconectar.Text = "Desconectar";
            this.buttonDesconectar.UseVisualStyleBackColor = false;
            this.buttonDesconectar.Click += new System.EventHandler(this.buttonDesconectar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonConectar);
            this.groupBox1.Controls.Add(this.estadoPanel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBoxPuerto);
            this.groupBox1.Controls.Add(this.buttonDesconectar);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Font = new System.Drawing.Font("Roboto", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(34, 300);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 535);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CONEXIÓN";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pnl_medio);
            this.groupBox2.Controls.Add(this.pnl_grueso);
            this.groupBox2.Controls.Add(this.pnl_fino);
            this.groupBox2.Controls.Add(this.fino);
            this.groupBox2.Controls.Add(this.medio);
            this.groupBox2.Controls.Add(this.grueso);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox2.Font = new System.Drawing.Font("Roboto", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(591, 626);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(695, 282);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TIPO DE MOLIENDA";
            // 
            // pnl_medio
            // 
            this.pnl_medio.Location = new System.Drawing.Point(335, 87);
            this.pnl_medio.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_medio.Name = "pnl_medio";
            this.pnl_medio.Size = new System.Drawing.Size(40, 30);
            this.pnl_medio.TabIndex = 16;
            // 
            // pnl_grueso
            // 
            this.pnl_grueso.Location = new System.Drawing.Point(546, 87);
            this.pnl_grueso.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_grueso.Name = "pnl_grueso";
            this.pnl_grueso.Size = new System.Drawing.Size(40, 30);
            this.pnl_grueso.TabIndex = 15;
            // 
            // pnl_fino
            // 
            this.pnl_fino.Location = new System.Drawing.Point(118, 87);
            this.pnl_fino.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_fino.Name = "pnl_fino";
            this.pnl_fino.Size = new System.Drawing.Size(40, 30);
            this.pnl_fino.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(590, 523);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 24);
            this.label4.TabIndex = 17;
            this.label4.Text = "Altura";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(590, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "RPM:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(590, 402);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 24);
            this.label6.TabIndex = 15;
            this.label6.Text = "Temperatura";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(587, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 24);
            this.label7.TabIndex = 14;
            this.label7.Text = "Corriente:";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Molino.Properties.Resources.pngwing_com__5_;
            this.pictureBox6.Location = new System.Drawing.Point(904, 488);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(100, 87);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 22;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Molino.Properties.Resources.pngegg__2_;
            this.pictureBox5.Location = new System.Drawing.Point(907, 382);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(100, 87);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 21;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Molino.Properties.Resources.pngegg__1_;
            this.pictureBox4.Location = new System.Drawing.Point(907, 269);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 87);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 20;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Molino.Properties.Resources.pngwing_com__4_;
            this.pictureBox3.Location = new System.Drawing.Point(907, 153);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 87);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Molino.Properties.Resources.molinillo_de_cafe;
            this.pictureBox2.Location = new System.Drawing.Point(1293, 218);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(597, 550);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(65, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(235, 219);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelParo);
            this.Controls.Add(this.labelMarcha);
            this.Controls.Add(this.altura);
            this.Controls.Add(this.rpm);
            this.Controls.Add(this.temperatura);
            this.Controls.Add(this.corriente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MOLINO";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label corriente;
        private System.Windows.Forms.Label temperatura;
        private System.Windows.Forms.Label rpm;
        private System.Windows.Forms.Label altura;
        private System.Windows.Forms.Button fino;
        private System.Windows.Forms.Button medio;
        private System.Windows.Forms.Button grueso;
        private System.Windows.Forms.Label labelMarcha;
        private System.Windows.Forms.Label labelParo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel estadoPanel;
        private System.Windows.Forms.Button buttonConectar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxPuerto;
        private System.Windows.Forms.Button buttonDesconectar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel pnl_medio;
        private System.Windows.Forms.Panel pnl_grueso;
        private System.Windows.Forms.Panel pnl_fino;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}

