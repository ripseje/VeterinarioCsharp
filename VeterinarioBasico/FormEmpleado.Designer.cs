namespace VeterinarioBasico
{
    partial class FormEmpleado
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.areaEmpleado = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.panelCitas = new System.Windows.Forms.Panel();
            this.idEmpleado = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.imagenEmpleado = new System.Windows.Forms.PictureBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panelDetalles = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.textoMotivo = new System.Windows.Forms.Label();
            this.id_dniLabel = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.fhLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ccLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.vacunadoLabel = new System.Windows.Forms.Label();
            this.fotoMascota = new System.Windows.Forms.PictureBox();
            this.pesoLabel = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.nombrelabel = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.alturaLabel = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.edadLabel = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.especielabel = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.id_label = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.areaEmpleado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagenEmpleado)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panelDetalles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoMascota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.areaEmpleado);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1029, 590);
            this.tabControl1.TabIndex = 1;
            // 
            // areaEmpleado
            // 
            this.areaEmpleado.Controls.Add(this.label9);
            this.areaEmpleado.Controls.Add(this.panelCitas);
            this.areaEmpleado.Controls.Add(this.idEmpleado);
            this.areaEmpleado.Controls.Add(this.label7);
            this.areaEmpleado.Controls.Add(this.user);
            this.areaEmpleado.Controls.Add(this.label5);
            this.areaEmpleado.Controls.Add(this.label4);
            this.areaEmpleado.Controls.Add(this.label3);
            this.areaEmpleado.Controls.Add(this.label2);
            this.areaEmpleado.Controls.Add(this.label1);
            this.areaEmpleado.Controls.Add(this.imagenEmpleado);
            this.areaEmpleado.Controls.Add(this.monthCalendar1);
            this.areaEmpleado.ImageIndex = 1;
            this.areaEmpleado.Location = new System.Drawing.Point(4, 25);
            this.areaEmpleado.Name = "areaEmpleado";
            this.areaEmpleado.Padding = new System.Windows.Forms.Padding(3);
            this.areaEmpleado.Size = new System.Drawing.Size(1021, 561);
            this.areaEmpleado.TabIndex = 0;
            this.areaEmpleado.Text = "Area Empleado";
            this.areaEmpleado.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Citas Pendientes";
            // 
            // panelCitas
            // 
            this.panelCitas.AutoScroll = true;
            this.panelCitas.Location = new System.Drawing.Point(41, 41);
            this.panelCitas.Name = "panelCitas";
            this.panelCitas.Size = new System.Drawing.Size(504, 512);
            this.panelCitas.TabIndex = 11;
            // 
            // idEmpleado
            // 
            this.idEmpleado.AutoSize = true;
            this.idEmpleado.Location = new System.Drawing.Point(802, 186);
            this.idEmpleado.Name = "idEmpleado";
            this.idEmpleado.Size = new System.Drawing.Size(24, 13);
            this.idEmpleado.TabIndex = 10;
            this.idEmpleado.Text = "test";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(724, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "id Empleado: ";
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Location = new System.Drawing.Point(777, 156);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(24, 13);
            this.user.TabIndex = 8;
            this.user.Text = "test";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(721, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Usuario: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(786, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(721, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Apellidos: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(777, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(721, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre: ";
            // 
            // imagenEmpleado
            // 
            this.imagenEmpleado.Location = new System.Drawing.Point(581, 89);
            this.imagenEmpleado.Name = "imagenEmpleado";
            this.imagenEmpleado.Size = new System.Drawing.Size(119, 111);
            this.imagenEmpleado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagenEmpleado.TabIndex = 2;
            this.imagenEmpleado.TabStop = false;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(634, 308);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panelDetalles);
            this.tabPage2.Controls.Add(this.dataGridView);
            this.tabPage2.ImageIndex = 2;
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1021, 561);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Citas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panelDetalles
            // 
            this.panelDetalles.BackColor = System.Drawing.Color.White;
            this.panelDetalles.Controls.Add(this.label8);
            this.panelDetalles.Controls.Add(this.textoMotivo);
            this.panelDetalles.Controls.Add(this.id_dniLabel);
            this.panelDetalles.Controls.Add(this.label16);
            this.panelDetalles.Controls.Add(this.idLabel);
            this.panelDetalles.Controls.Add(this.label13);
            this.panelDetalles.Controls.Add(this.label12);
            this.panelDetalles.Controls.Add(this.fhLabel);
            this.panelDetalles.Controls.Add(this.label11);
            this.panelDetalles.Controls.Add(this.ccLabel);
            this.panelDetalles.Controls.Add(this.label6);
            this.panelDetalles.Location = new System.Drawing.Point(531, 287);
            this.panelDetalles.Name = "panelDetalles";
            this.panelDetalles.Size = new System.Drawing.Size(484, 271);
            this.panelDetalles.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(33, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "Motivo de la cita:";
            // 
            // textoMotivo
            // 
            this.textoMotivo.Location = new System.Drawing.Point(36, 155);
            this.textoMotivo.Name = "textoMotivo";
            this.textoMotivo.Size = new System.Drawing.Size(409, 100);
            this.textoMotivo.TabIndex = 9;
            // 
            // id_dniLabel
            // 
            this.id_dniLabel.Location = new System.Drawing.Point(304, 84);
            this.id_dniLabel.Name = "id_dniLabel";
            this.id_dniLabel.Size = new System.Drawing.Size(98, 13);
            this.id_dniLabel.TabIndex = 8;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(204, 82);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(94, 16);
            this.label16.TabIndex = 7;
            this.label16.Text = "DNI Cliente: ";
            // 
            // idLabel
            // 
            this.idLabel.Location = new System.Drawing.Point(143, 81);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(51, 13);
            this.idLabel.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(33, 79);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 16);
            this.label13.TabIndex = 5;
            this.label13.Text = "Id Empleado: ";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(380, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 13);
            this.label12.TabIndex = 4;
            // 
            // fhLabel
            // 
            this.fhLabel.Location = new System.Drawing.Point(304, 30);
            this.fhLabel.Name = "fhLabel";
            this.fhLabel.Size = new System.Drawing.Size(70, 13);
            this.fhLabel.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(189, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 16);
            this.label11.TabIndex = 2;
            this.label11.Text = "Fecha y Hora: ";
            // 
            // ccLabel
            // 
            this.ccLabel.Location = new System.Drawing.Point(132, 27);
            this.ccLabel.Name = "ccLabel";
            this.ccLabel.Size = new System.Drawing.Size(51, 13);
            this.ccLabel.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Código Cita:";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(3, 3);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(522, 555);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel1);
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.ImageIndex = 0;
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1021, 561);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Mascotas";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.vacunadoLabel);
            this.panel1.Controls.Add(this.fotoMascota);
            this.panel1.Controls.Add(this.pesoLabel);
            this.panel1.Controls.Add(this.label26);
            this.panel1.Controls.Add(this.nombrelabel);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.alturaLabel);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.edadLabel);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.especielabel);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.id_label);
            this.panel1.Controls.Add(this.label24);
            this.panel1.Location = new System.Drawing.Point(531, 287);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 271);
            this.panel1.TabIndex = 2;
            // 
            // vacunadoLabel
            // 
            this.vacunadoLabel.Location = new System.Drawing.Point(113, 226);
            this.vacunadoLabel.Name = "vacunadoLabel";
            this.vacunadoLabel.Size = new System.Drawing.Size(51, 13);
            this.vacunadoLabel.TabIndex = 16;
            // 
            // fotoMascota
            // 
            this.fotoMascota.Location = new System.Drawing.Point(235, 136);
            this.fotoMascota.Name = "fotoMascota";
            this.fotoMascota.Size = new System.Drawing.Size(128, 112);
            this.fotoMascota.TabIndex = 15;
            this.fotoMascota.TabStop = false;
            // 
            // pesoLabel
            // 
            this.pesoLabel.Location = new System.Drawing.Point(383, 85);
            this.pesoLabel.Name = "pesoLabel";
            this.pesoLabel.Size = new System.Drawing.Size(69, 16);
            this.pesoLabel.TabIndex = 14;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(325, 85);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(52, 16);
            this.label26.TabIndex = 13;
            this.label26.Text = "Peso: ";
            // 
            // nombrelabel
            // 
            this.nombrelabel.Location = new System.Drawing.Point(402, 28);
            this.nombrelabel.Name = "nombrelabel";
            this.nombrelabel.Size = new System.Drawing.Size(70, 13);
            this.nombrelabel.TabIndex = 12;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(325, 25);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(71, 16);
            this.label20.TabIndex = 11;
            this.label20.Text = "Nombre: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(21, 223);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 16);
            this.label10.TabIndex = 10;
            this.label10.Text = "Vacunado: ";
            // 
            // alturaLabel
            // 
            this.alturaLabel.Location = new System.Drawing.Point(232, 85);
            this.alturaLabel.Name = "alturaLabel";
            this.alturaLabel.Size = new System.Drawing.Size(69, 16);
            this.alturaLabel.TabIndex = 8;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(170, 83);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(56, 16);
            this.label17.TabIndex = 7;
            this.label17.Text = "Altura: ";
            // 
            // edadLabel
            // 
            this.edadLabel.Location = new System.Drawing.Point(72, 120);
            this.edadLabel.Name = "edadLabel";
            this.edadLabel.Size = new System.Drawing.Size(51, 13);
            this.edadLabel.TabIndex = 6;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(17, 117);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(49, 16);
            this.label19.TabIndex = 5;
            this.label19.Text = "Edad:";
            // 
            // especielabel
            // 
            this.especielabel.Location = new System.Drawing.Point(249, 27);
            this.especielabel.Name = "especielabel";
            this.especielabel.Size = new System.Drawing.Size(70, 13);
            this.especielabel.TabIndex = 3;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(170, 27);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(73, 16);
            this.label22.TabIndex = 2;
            this.label22.Text = "Especie: ";
            // 
            // id_label
            // 
            this.id_label.Location = new System.Drawing.Point(113, 28);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(51, 13);
            this.id_label.TabIndex = 1;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(17, 25);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(90, 16);
            this.label24.TabIndex = 0;
            this.label24.Text = "ID Mascota:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(522, 555);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // FormEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 590);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormEmpleado";
            this.Text = "FormEmpleado";
            this.tabControl1.ResumeLayout(false);
            this.areaEmpleado.ResumeLayout(false);
            this.areaEmpleado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagenEmpleado)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panelDetalles.ResumeLayout(false);
            this.panelDetalles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoMascota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage areaEmpleado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox imagenEmpleado;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label idEmpleado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label user;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panelCitas;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Panel panelDetalles;
        private System.Windows.Forms.Label textoMotivo;
        private System.Windows.Forms.Label id_dniLabel;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label fhLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label ccLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label vacunadoLabel;
        private System.Windows.Forms.PictureBox fotoMascota;
        private System.Windows.Forms.Label pesoLabel;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label nombrelabel;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label alturaLabel;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label edadLabel;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label especielabel;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label id_label;
        private System.Windows.Forms.Label label24;
    }
}