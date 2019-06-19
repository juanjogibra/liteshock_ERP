namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.usuario = new System.Windows.Forms.TextBox();
            this.contrasena = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.validar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.usuarios = new WindowsFormsApp1.usuarios();
            this.empleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empleadosTableAdapter = new WindowsFormsApp1.usuariosTableAdapters.empleadosTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.usuariosTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(46, 43);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(66, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(132, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(200, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 50);
            this.label1.TabIndex = 13;
            this.label1.Text = "INICIAR SESION";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-1, -3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(622, 139);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // usuario
            // 
            this.usuario.Location = new System.Drawing.Point(61, 183);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(143, 20);
            this.usuario.TabIndex = 16;
            // 
            // contrasena
            // 
            this.contrasena.Location = new System.Drawing.Point(315, 183);
            this.contrasena.Name = "contrasena";
            this.contrasena.Size = new System.Drawing.Size(138, 20);
            this.contrasena.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(248, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Contraseña";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // validar
            // 
            this.validar.Location = new System.Drawing.Point(189, 237);
            this.validar.Name = "validar";
            this.validar.Size = new System.Drawing.Size(79, 23);
            this.validar.TabIndex = 20;
            this.validar.Text = "Iniciar Sesión";
            this.validar.UseVisualStyleBackColor = true;
            this.validar.Click += new System.EventHandler(this.validar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(146, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Usuario o contraseña incorrectos";
            // 
            // usuarios
            // 
            this.usuarios.DataSetName = "usuarios";
            this.usuarios.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empleadosBindingSource
            // 
            this.empleadosBindingSource.DataMember = "empleados";
            this.empleadosBindingSource.DataSource = this.usuarios;
            // 
            // empleadosTableAdapter
            // 
            this.empleadosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.empleadosTableAdapter = this.empleadosTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.usuariosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 284);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.validar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.contrasena);
            this.Controls.Add(this.usuario);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox usuario;
        private System.Windows.Forms.TextBox contrasena;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button validar;
        private System.Windows.Forms.Label label5;
        private usuarios usuarios;
        private System.Windows.Forms.BindingSource empleadosBindingSource;
        private usuariosTableAdapters.empleadosTableAdapter empleadosTableAdapter;
        private usuariosTableAdapters.TableAdapterManager tableAdapterManager;
    }
}