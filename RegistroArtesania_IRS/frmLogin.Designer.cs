namespace RegistroArtesania_IRS
{
    partial class frmLogin
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
            this.txtUsuarioL = new System.Windows.Forms.TextBox();
            this.lblUsuarioL = new System.Windows.Forms.Label();
            this.txtContraseñaL = new System.Windows.Forms.TextBox();
            this.lblContraseñaL = new System.Windows.Forms.Label();
            this.btnIngresarL = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsuarioL
            // 
            this.txtUsuarioL.Font = new System.Drawing.Font("Arial", 11F);
            this.txtUsuarioL.Location = new System.Drawing.Point(105, 238);
            this.txtUsuarioL.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtUsuarioL.Name = "txtUsuarioL";
            this.txtUsuarioL.Size = new System.Drawing.Size(166, 24);
            this.txtUsuarioL.TabIndex = 11;
            // 
            // lblUsuarioL
            // 
            this.lblUsuarioL.AutoSize = true;
            this.lblUsuarioL.Font = new System.Drawing.Font("Arial", 11.5F);
            this.lblUsuarioL.Location = new System.Drawing.Point(31, 241);
            this.lblUsuarioL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsuarioL.Name = "lblUsuarioL";
            this.lblUsuarioL.Size = new System.Drawing.Size(70, 18);
            this.lblUsuarioL.TabIndex = 10;
            this.lblUsuarioL.Text = "Usuario: ";
            // 
            // txtContraseñaL
            // 
            this.txtContraseñaL.Font = new System.Drawing.Font("Arial", 11F);
            this.txtContraseñaL.Location = new System.Drawing.Point(105, 268);
            this.txtContraseñaL.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtContraseñaL.Name = "txtContraseñaL";
            this.txtContraseñaL.Size = new System.Drawing.Size(166, 24);
            this.txtContraseñaL.TabIndex = 13;
            this.txtContraseñaL.Click += new System.EventHandler(this.txtContraseñaL_Click_1);
            this.txtContraseñaL.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtContraseñaL_MouseClick);
            this.txtContraseñaL.Enter += new System.EventHandler(this.txtContraseñaL_Enter_1);
            // 
            // lblContraseñaL
            // 
            this.lblContraseñaL.AutoSize = true;
            this.lblContraseñaL.Font = new System.Drawing.Font("Arial", 11.5F);
            this.lblContraseñaL.Location = new System.Drawing.Point(8, 271);
            this.lblContraseñaL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContraseñaL.Name = "lblContraseñaL";
            this.lblContraseñaL.Size = new System.Drawing.Size(93, 18);
            this.lblContraseñaL.TabIndex = 12;
            this.lblContraseñaL.Text = "Contraseña:";
            // 
            // btnIngresarL
            // 
            this.btnIngresarL.BackColor = System.Drawing.Color.Firebrick;
            this.btnIngresarL.Font = new System.Drawing.Font("Arial", 12.5F, System.Drawing.FontStyle.Bold);
            this.btnIngresarL.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIngresarL.Location = new System.Drawing.Point(105, 343);
            this.btnIngresarL.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnIngresarL.Name = "btnIngresarL";
            this.btnIngresarL.Size = new System.Drawing.Size(113, 36);
            this.btnIngresarL.TabIndex = 24;
            this.btnIngresarL.Text = "Ingresar";
            this.btnIngresarL.UseVisualStyleBackColor = false;
            this.btnIngresarL.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(105, 298);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(118, 17);
            this.checkBox1.TabIndex = 25;
            this.checkBox1.Text = "Mostrar Contraseña";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RegistroArtesania_IRS.Properties.Resources.userPhoto1;
            this.pictureBox1.Location = new System.Drawing.Point(63, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 186);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 450);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnIngresarL);
            this.Controls.Add(this.txtContraseñaL);
            this.Controls.Add(this.lblContraseñaL);
            this.Controls.Add(this.txtUsuarioL);
            this.Controls.Add(this.lblUsuarioL);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "La Mano Del Artesano";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtUsuarioL;
        private System.Windows.Forms.Label lblUsuarioL;
        private System.Windows.Forms.TextBox txtContraseñaL;
        private System.Windows.Forms.Label lblContraseñaL;
        private System.Windows.Forms.Button btnIngresarL;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}