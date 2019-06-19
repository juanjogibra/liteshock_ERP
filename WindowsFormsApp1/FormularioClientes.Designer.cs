namespace WindowsFormsApp1
{
    partial class FormularioClientes
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label apellidosLabel;
            System.Windows.Forms.Label telefonoLabel;
            System.Windows.Forms.Label dNILabel;
            System.Windows.Forms.Label domicilioLabel;
            System.Windows.Forms.Label fechaLabel;
            System.Windows.Forms.Label localidadLabel;
            System.Windows.Forms.Label correoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioClientes));
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.erpDataSetFeb = new WindowsFormsApp1.erpDataSetFeb();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientesTableAdapter = new WindowsFormsApp1.erpDataSetFebTableAdapters.clientesTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.erpDataSetFebTableAdapters.TableAdapterManager();
            this.clientesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.clientesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.apellidosTextBox = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.dNITextBox = new System.Windows.Forms.TextBox();
            this.domicilioTextBox = new System.Windows.Forms.TextBox();
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.localidadTextBox = new System.Windows.Forms.TextBox();
            this.correoTextBox = new System.Windows.Forms.TextBox();
            idLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            apellidosLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            dNILabel = new System.Windows.Forms.Label();
            domicilioLabel = new System.Windows.Forms.Label();
            fechaLabel = new System.Windows.Forms.Label();
            localidadLabel = new System.Windows.Forms.Label();
            correoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpDataSetFeb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingNavigator)).BeginInit();
            this.clientesBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(388, 180);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(18, 13);
            idLabel.TabIndex = 21;
            idLabel.Text = "id:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(47, 180);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(45, 13);
            nombreLabel.TabIndex = 23;
            nombreLabel.Text = "nombre:";
            // 
            // apellidosLabel
            // 
            apellidosLabel.AutoSize = true;
            apellidosLabel.Location = new System.Drawing.Point(47, 206);
            apellidosLabel.Name = "apellidosLabel";
            apellidosLabel.Size = new System.Drawing.Size(51, 13);
            apellidosLabel.TabIndex = 25;
            apellidosLabel.Text = "apellidos:";
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Location = new System.Drawing.Point(388, 238);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(48, 13);
            telefonoLabel.TabIndex = 27;
            telefonoLabel.Text = "telefono:";
            // 
            // dNILabel
            // 
            dNILabel.AutoSize = true;
            dNILabel.Location = new System.Drawing.Point(388, 210);
            dNILabel.Name = "dNILabel";
            dNILabel.Size = new System.Drawing.Size(29, 13);
            dNILabel.TabIndex = 29;
            dNILabel.Text = "DNI:";
            // 
            // domicilioLabel
            // 
            domicilioLabel.AutoSize = true;
            domicilioLabel.Location = new System.Drawing.Point(47, 298);
            domicilioLabel.Name = "domicilioLabel";
            domicilioLabel.Size = new System.Drawing.Size(50, 13);
            domicilioLabel.TabIndex = 31;
            domicilioLabel.Text = "domicilio:";
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Location = new System.Drawing.Point(47, 358);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(37, 13);
            fechaLabel.TabIndex = 33;
            fechaLabel.Text = "fecha:";
            // 
            // localidadLabel
            // 
            localidadLabel.AutoSize = true;
            localidadLabel.Location = new System.Drawing.Point(47, 327);
            localidadLabel.Name = "localidadLabel";
            localidadLabel.Size = new System.Drawing.Size(52, 13);
            localidadLabel.TabIndex = 35;
            localidadLabel.Text = "localidad:";
            // 
            // correoLabel
            // 
            correoLabel.AutoSize = true;
            correoLabel.Location = new System.Drawing.Point(47, 238);
            correoLabel.Name = "correoLabel";
            correoLabel.Size = new System.Drawing.Size(40, 13);
            correoLabel.TabIndex = 37;
            correoLabel.Text = "correo:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(33, 44);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(66, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(206, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(284, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 50);
            this.label1.TabIndex = 18;
            this.label1.Text = "NUEVO CLIENTE";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, -3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(857, 139);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // erpDataSetFeb
            // 
            this.erpDataSetFeb.DataSetName = "erpDataSetFeb";
            this.erpDataSetFeb.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "clientes";
            this.clientesBindingSource.DataSource = this.erpDataSetFeb;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clientesTableAdapter = this.clientesTableAdapter;
            this.tableAdapterManager.empleadosTableAdapter = null;
            this.tableAdapterManager.facturasTableAdapter = null;
            this.tableAdapterManager.lin_facturasTableAdapter = null;
            this.tableAdapterManager.pedidoTableAdapter = null;
            this.tableAdapterManager.productosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.erpDataSetFebTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ventaTableAdapter = null;
            // 
            // clientesBindingNavigator
            // 
            this.clientesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.clientesBindingNavigator.BindingSource = this.clientesBindingSource;
            this.clientesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.clientesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.clientesBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.clientesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.clientesBindingNavigatorSaveItem});
            this.clientesBindingNavigator.Location = new System.Drawing.Point(0, 457);
            this.clientesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.clientesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.clientesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.clientesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.clientesBindingNavigator.Name = "clientesBindingNavigator";
            this.clientesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.clientesBindingNavigator.Size = new System.Drawing.Size(727, 25);
            this.clientesBindingNavigator.TabIndex = 21;
            this.clientesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // clientesBindingNavigatorSaveItem
            // 
            this.clientesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.clientesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("clientesBindingNavigatorSaveItem.Image")));
            this.clientesBindingNavigatorSaveItem.Name = "clientesBindingNavigatorSaveItem";
            this.clientesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.clientesBindingNavigatorSaveItem.Text = "Guardar datos";
            this.clientesBindingNavigatorSaveItem.Click += new System.EventHandler(this.clientesBindingNavigatorSaveItem_Click_3);
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "id", true));
            this.idTextBox.Location = new System.Drawing.Point(446, 177);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(33, 20);
            this.idTextBox.TabIndex = 22;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(105, 177);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(155, 20);
            this.nombreTextBox.TabIndex = 24;
            // 
            // apellidosTextBox
            // 
            this.apellidosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "apellidos", true));
            this.apellidosTextBox.Location = new System.Drawing.Point(105, 203);
            this.apellidosTextBox.Name = "apellidosTextBox";
            this.apellidosTextBox.Size = new System.Drawing.Size(200, 20);
            this.apellidosTextBox.TabIndex = 26;
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "telefono", true));
            this.telefonoTextBox.Location = new System.Drawing.Point(446, 235);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(155, 20);
            this.telefonoTextBox.TabIndex = 28;
            // 
            // dNITextBox
            // 
            this.dNITextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "DNI", true));
            this.dNITextBox.Location = new System.Drawing.Point(446, 207);
            this.dNITextBox.Name = "dNITextBox";
            this.dNITextBox.Size = new System.Drawing.Size(111, 20);
            this.dNITextBox.TabIndex = 30;
            // 
            // domicilioTextBox
            // 
            this.domicilioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "domicilio", true));
            this.domicilioTextBox.Location = new System.Drawing.Point(103, 295);
            this.domicilioTextBox.Name = "domicilioTextBox";
            this.domicilioTextBox.Size = new System.Drawing.Size(259, 20);
            this.domicilioTextBox.TabIndex = 32;
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.clientesBindingSource, "fecha", true));
            this.fechaDateTimePicker.Location = new System.Drawing.Point(103, 358);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaDateTimePicker.TabIndex = 34;
            // 
            // localidadTextBox
            // 
            this.localidadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "localidad", true));
            this.localidadTextBox.Location = new System.Drawing.Point(103, 324);
            this.localidadTextBox.Name = "localidadTextBox";
            this.localidadTextBox.Size = new System.Drawing.Size(200, 20);
            this.localidadTextBox.TabIndex = 36;
            // 
            // correoTextBox
            // 
            this.correoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "correo", true));
            this.correoTextBox.Location = new System.Drawing.Point(105, 235);
            this.correoTextBox.Name = "correoTextBox";
            this.correoTextBox.Size = new System.Drawing.Size(200, 20);
            this.correoTextBox.TabIndex = 38;
            // 
            // FormularioClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(727, 482);
            this.ControlBox = false;
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(apellidosLabel);
            this.Controls.Add(this.apellidosTextBox);
            this.Controls.Add(telefonoLabel);
            this.Controls.Add(this.telefonoTextBox);
            this.Controls.Add(dNILabel);
            this.Controls.Add(this.dNITextBox);
            this.Controls.Add(domicilioLabel);
            this.Controls.Add(this.domicilioTextBox);
            this.Controls.Add(fechaLabel);
            this.Controls.Add(this.fechaDateTimePicker);
            this.Controls.Add(localidadLabel);
            this.Controls.Add(this.localidadTextBox);
            this.Controls.Add(correoLabel);
            this.Controls.Add(this.correoTextBox);
            this.Controls.Add(this.clientesBindingNavigator);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormularioClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nuevo Cliente";
            this.Load += new System.EventHandler(this.FormularioClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpDataSetFeb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingNavigator)).EndInit();
            this.clientesBindingNavigator.ResumeLayout(false);
            this.clientesBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private erpDataSetFeb erpDataSetFeb;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private erpDataSetFebTableAdapters.clientesTableAdapter clientesTableAdapter;
        private erpDataSetFebTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator clientesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton clientesBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox apellidosTextBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.TextBox dNITextBox;
        private System.Windows.Forms.TextBox domicilioTextBox;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        private System.Windows.Forms.TextBox localidadTextBox;
        private System.Windows.Forms.TextBox correoTextBox;
    }
}