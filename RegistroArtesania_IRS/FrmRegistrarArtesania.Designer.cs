namespace RegistroArtesania_IRS
{
    partial class FrmRegistrarArtesania
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNombreA = new System.Windows.Forms.TextBox();
            this.txtCodA = new System.Windows.Forms.TextBox();
            this.dtpA = new System.Windows.Forms.DateTimePicker();
            this.txtDescripA = new System.Windows.Forms.TextBox();
            this.txtPVentaA = new System.Windows.Forms.TextBox();
            this.txtCantidadA = new System.Windows.Forms.TextBox();
            this.txtCodE = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dgvArtesanias = new System.Windows.Forms.DataGridView();
            this.colCodArt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombreArt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstadoArt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechRegArt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescripArt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPVentaArt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantArt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstadoP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombreEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnCancelarR = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.cboEmpleados = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtesanias)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12.5F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(25, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "DATOS DE LA ARTESANIA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12.5F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(26, 204);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "TABLA DE LA ARTESANIA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12.5F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(25, 130);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "DATOS DEL ENCARGADO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.5F);
            this.label4.Location = new System.Drawing.Point(27, 57);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nombre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11.5F);
            this.label5.Location = new System.Drawing.Point(365, 56);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Codigo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 11.5F);
            this.label6.Location = new System.Drawing.Point(673, 57);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 18);
            this.label6.TabIndex = 4;
            this.label6.Text = "Fecha:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 11.5F);
            this.label7.Location = new System.Drawing.Point(519, 93);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 18);
            this.label7.TabIndex = 5;
            this.label7.Text = "Precio de Venta:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 11.5F);
            this.label8.Location = new System.Drawing.Point(494, 57);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 18);
            this.label8.TabIndex = 6;
            this.label8.Text = "Estado:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 11.5F);
            this.label9.Location = new System.Drawing.Point(26, 92);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 18);
            this.label9.TabIndex = 7;
            this.label9.Text = "Descripcion:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 11.5F);
            this.label10.Location = new System.Drawing.Point(717, 92);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 18);
            this.label10.TabIndex = 8;
            this.label10.Text = "Cantidad:";
            // 
            // txtNombreA
            // 
            this.txtNombreA.Font = new System.Drawing.Font("Arial", 11F);
            this.txtNombreA.Location = new System.Drawing.Point(99, 54);
            this.txtNombreA.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtNombreA.Name = "txtNombreA";
            this.txtNombreA.Size = new System.Drawing.Size(255, 24);
            this.txtNombreA.TabIndex = 9;
            // 
            // txtCodA
            // 
            this.txtCodA.Font = new System.Drawing.Font("Arial", 11F);
            this.txtCodA.Location = new System.Drawing.Point(433, 53);
            this.txtCodA.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtCodA.Name = "txtCodA";
            this.txtCodA.ReadOnly = true;
            this.txtCodA.Size = new System.Drawing.Size(46, 24);
            this.txtCodA.TabIndex = 10;
            // 
            // dtpA
            // 
            this.dtpA.Font = new System.Drawing.Font("Arial", 11F);
            this.dtpA.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpA.Location = new System.Drawing.Point(733, 54);
            this.dtpA.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtpA.Name = "dtpA";
            this.dtpA.Size = new System.Drawing.Size(113, 24);
            this.dtpA.TabIndex = 12;
            // 
            // txtDescripA
            // 
            this.txtDescripA.Font = new System.Drawing.Font("Arial", 11F);
            this.txtDescripA.Location = new System.Drawing.Point(126, 89);
            this.txtDescripA.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtDescripA.Name = "txtDescripA";
            this.txtDescripA.Size = new System.Drawing.Size(383, 24);
            this.txtDescripA.TabIndex = 13;
            // 
            // txtPVentaA
            // 
            this.txtPVentaA.Font = new System.Drawing.Font("Arial", 11F);
            this.txtPVentaA.Location = new System.Drawing.Point(647, 89);
            this.txtPVentaA.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtPVentaA.Name = "txtPVentaA";
            this.txtPVentaA.Size = new System.Drawing.Size(59, 24);
            this.txtPVentaA.TabIndex = 14;
            this.txtPVentaA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPVentaA_KeyPress);
            // 
            // txtCantidadA
            // 
            this.txtCantidadA.Font = new System.Drawing.Font("Arial", 11F);
            this.txtCantidadA.Location = new System.Drawing.Point(807, 89);
            this.txtCantidadA.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtCantidadA.Name = "txtCantidadA";
            this.txtCantidadA.Size = new System.Drawing.Size(39, 24);
            this.txtCantidadA.TabIndex = 15;
            this.txtCantidadA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadA_KeyPress);
            // 
            // txtCodE
            // 
            this.txtCodE.Font = new System.Drawing.Font("Arial", 11F);
            this.txtCodE.Location = new System.Drawing.Point(358, 161);
            this.txtCodE.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtCodE.Name = "txtCodE";
            this.txtCodE.ReadOnly = true;
            this.txtCodE.Size = new System.Drawing.Size(46, 24);
            this.txtCodE.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 11.5F);
            this.label11.Location = new System.Drawing.Point(290, 164);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 18);
            this.label11.TabIndex = 17;
            this.label11.Text = "Codigo:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 11.5F);
            this.label12.Location = new System.Drawing.Point(26, 164);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 18);
            this.label12.TabIndex = 16;
            this.label12.Text = "Nombre:";
            // 
            // dgvArtesanias
            // 
            this.dgvArtesanias.AllowDrop = true;
            this.dgvArtesanias.AllowUserToAddRows = false;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvArtesanias.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvArtesanias.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Arial", 10F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArtesanias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvArtesanias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArtesanias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodArt,
            this.colNombreArt,
            this.colEstadoArt,
            this.colFechRegArt,
            this.colDescripArt,
            this.colPVentaArt,
            this.colCantArt,
            this.colEstadoP,
            this.colCodEmp,
            this.colNombreEmp});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Arial", 10F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvArtesanias.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvArtesanias.Location = new System.Drawing.Point(30, 237);
            this.dgvArtesanias.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvArtesanias.Name = "dgvArtesanias";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Arial", 10F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArtesanias.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvArtesanias.RowHeadersVisible = false;
            this.dgvArtesanias.Size = new System.Drawing.Size(816, 241);
            this.dgvArtesanias.TabIndex = 22;
            this.dgvArtesanias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArtesanias_CellClick);
            // 
            // colCodArt
            // 
            this.colCodArt.DataPropertyName = "codArt";
            this.colCodArt.HeaderText = "Codigo de Artesania";
            this.colCodArt.Name = "colCodArt";
            this.colCodArt.ReadOnly = true;
            this.colCodArt.Width = 80;
            // 
            // colNombreArt
            // 
            this.colNombreArt.DataPropertyName = "nombreArt";
            this.colNombreArt.HeaderText = "Nombre de Artesania";
            this.colNombreArt.Name = "colNombreArt";
            this.colNombreArt.ReadOnly = true;
            this.colNombreArt.Width = 120;
            // 
            // colEstadoArt
            // 
            this.colEstadoArt.DataPropertyName = "estadoArt";
            this.colEstadoArt.HeaderText = "Estado";
            this.colEstadoArt.Name = "colEstadoArt";
            this.colEstadoArt.ReadOnly = true;
            // 
            // colFechRegArt
            // 
            this.colFechRegArt.DataPropertyName = "fechRegis";
            this.colFechRegArt.HeaderText = "Fecha de Registro";
            this.colFechRegArt.Name = "colFechRegArt";
            this.colFechRegArt.ReadOnly = true;
            // 
            // colDescripArt
            // 
            this.colDescripArt.DataPropertyName = "descripArt";
            this.colDescripArt.HeaderText = "Descripcion";
            this.colDescripArt.Name = "colDescripArt";
            this.colDescripArt.ReadOnly = true;
            this.colDescripArt.Width = 250;
            // 
            // colPVentaArt
            // 
            this.colPVentaArt.DataPropertyName = "precioArt";
            this.colPVentaArt.HeaderText = "Precio de Venta";
            this.colPVentaArt.Name = "colPVentaArt";
            this.colPVentaArt.ReadOnly = true;
            // 
            // colCantArt
            // 
            this.colCantArt.DataPropertyName = "cantidadArt";
            this.colCantArt.HeaderText = "Cantidad";
            this.colCantArt.Name = "colCantArt";
            this.colCantArt.ReadOnly = true;
            this.colCantArt.Width = 80;
            // 
            // colEstadoP
            // 
            this.colEstadoP.DataPropertyName = "estadoPuro";
            this.colEstadoP.HeaderText = "Estado Puro";
            this.colEstadoP.Name = "colEstadoP";
            this.colEstadoP.ReadOnly = true;
            this.colEstadoP.Visible = false;
            // 
            // colCodEmp
            // 
            this.colCodEmp.DataPropertyName = "CodEmp";
            this.colCodEmp.HeaderText = "Codigo de Empleado";
            this.colCodEmp.Name = "colCodEmp";
            this.colCodEmp.ReadOnly = true;
            this.colCodEmp.Width = 80;
            // 
            // colNombreEmp
            // 
            this.colNombreEmp.DataPropertyName = "nombreEmp";
            this.colNombreEmp.HeaderText = "Nombre de Empleado";
            this.colNombreEmp.Name = "colNombreEmp";
            this.colNombreEmp.ReadOnly = true;
            this.colNombreEmp.Width = 120;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.Firebrick;
            this.btnRegistrar.Font = new System.Drawing.Font("Arial", 12.5F, System.Drawing.FontStyle.Bold);
            this.btnRegistrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegistrar.Location = new System.Drawing.Point(606, 130);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(113, 36);
            this.btnRegistrar.TabIndex = 23;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnCancelarR
            // 
            this.btnCancelarR.BackColor = System.Drawing.Color.Firebrick;
            this.btnCancelarR.Font = new System.Drawing.Font("Arial", 12.5F, System.Drawing.FontStyle.Bold);
            this.btnCancelarR.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelarR.Location = new System.Drawing.Point(733, 187);
            this.btnCancelarR.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCancelarR.Name = "btnCancelarR";
            this.btnCancelarR.Size = new System.Drawing.Size(113, 36);
            this.btnCancelarR.TabIndex = 24;
            this.btnCancelarR.Text = "Cancelar";
            this.btnCancelarR.UseVisualStyleBackColor = false;
            this.btnCancelarR.Click += new System.EventHandler(this.btnCancelarR_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Firebrick;
            this.btnSalir.Font = new System.Drawing.Font("Arial", 12.5F, System.Drawing.FontStyle.Bold);
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalir.Location = new System.Drawing.Point(606, 187);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(113, 36);
            this.btnSalir.TabIndex = 25;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.button2_Click);
            // 
            // cboEmpleados
            // 
            this.cboEmpleados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmpleados.FormattingEnabled = true;
            this.cboEmpleados.Location = new System.Drawing.Point(99, 163);
            this.cboEmpleados.Name = "cboEmpleados";
            this.cboEmpleados.Size = new System.Drawing.Size(174, 24);
            this.cboEmpleados.TabIndex = 26;
            this.cboEmpleados.SelectedIndexChanged += new System.EventHandler(this.cboEmpleados_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Firebrick;
            this.button1.Font = new System.Drawing.Font("Arial", 12.5F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(733, 130);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 36);
            this.button1.TabIndex = 27;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cboEstado
            // 
            this.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Items.AddRange(new object[] {
            "Normal",
            "Mermado"});
            this.cboEstado.Location = new System.Drawing.Point(561, 54);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(95, 24);
            this.cboEstado.TabIndex = 28;
            // 
            // FrmRegistrarArtesania
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Controls.Add(this.cboEstado);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cboEmpleados);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCancelarR);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.dgvArtesanias);
            this.Controls.Add(this.txtCodE);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtCantidadA);
            this.Controls.Add(this.txtPVentaA);
            this.Controls.Add(this.txtDescripA);
            this.Controls.Add(this.dtpA);
            this.Controls.Add(this.txtCodA);
            this.Controls.Add(this.txtNombreA);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmRegistrarArtesania";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Artesania - La Mano del Artesano";
            this.Load += new System.EventHandler(this.FrmRegistrarArtesania_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtesanias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNombreA;
        private System.Windows.Forms.TextBox txtCodA;
        private System.Windows.Forms.DateTimePicker dtpA;
        private System.Windows.Forms.TextBox txtDescripA;
        private System.Windows.Forms.TextBox txtPVentaA;
        private System.Windows.Forms.TextBox txtCantidadA;
        private System.Windows.Forms.TextBox txtCodE;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgvArtesanias;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnCancelarR;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ComboBox cboEmpleados;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodArt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombreArt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstadoArt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechRegArt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescripArt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPVentaArt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantArt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstadoP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombreEmp;
    }
}

