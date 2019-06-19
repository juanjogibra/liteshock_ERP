namespace WindowsFormsApp1
{
    partial class Facturas
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
            System.Windows.Forms.Label id_clienteLabel;
            System.Windows.Forms.Label fechaLabel;
            System.Windows.Forms.Label precio_brutoLabel;
            System.Windows.Forms.Label ivaLabel;
            System.Windows.Forms.Label precio_totalLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Facturas));
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.erpDataSetFeb = new WindowsFormsApp1.erpDataSetFeb();
            this.facturasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.facturasTableAdapter = new WindowsFormsApp1.erpDataSetFebTableAdapters.facturasTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.erpDataSetFebTableAdapters.TableAdapterManager();
            this.lin_facturasTableAdapter = new WindowsFormsApp1.erpDataSetFebTableAdapters.lin_facturasTableAdapter();
            this.facturasBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.facturasBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.id_clienteTextBox = new System.Windows.Forms.TextBox();
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.precio_brutoTextBox = new System.Windows.Forms.TextBox();
            this.ivaTextBox = new System.Windows.Forms.TextBox();
            this.precio_totalTextBox = new System.Windows.Forms.TextBox();
            this.lin_facturasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lin_facturasDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            idLabel = new System.Windows.Forms.Label();
            id_clienteLabel = new System.Windows.Forms.Label();
            fechaLabel = new System.Windows.Forms.Label();
            precio_brutoLabel = new System.Windows.Forms.Label();
            ivaLabel = new System.Windows.Forms.Label();
            precio_totalLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpDataSetFeb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturasBindingNavigator)).BeginInit();
            this.facturasBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lin_facturasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lin_facturasDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(455, 148);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(18, 13);
            idLabel.TabIndex = 20;
            idLabel.Text = "id:";
            // 
            // id_clienteLabel
            // 
            id_clienteLabel.AutoSize = true;
            id_clienteLabel.Location = new System.Drawing.Point(455, 174);
            id_clienteLabel.Name = "id_clienteLabel";
            id_clienteLabel.Size = new System.Drawing.Size(52, 13);
            id_clienteLabel.TabIndex = 22;
            id_clienteLabel.Text = "id cliente:";
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Location = new System.Drawing.Point(26, 148);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(37, 13);
            fechaLabel.TabIndex = 24;
            fechaLabel.Text = "fecha:";
            // 
            // precio_brutoLabel
            // 
            precio_brutoLabel.AutoSize = true;
            precio_brutoLabel.Location = new System.Drawing.Point(26, 178);
            precio_brutoLabel.Name = "precio_brutoLabel";
            precio_brutoLabel.Size = new System.Drawing.Size(66, 13);
            precio_brutoLabel.TabIndex = 26;
            precio_brutoLabel.Text = "precio bruto:";
            // 
            // ivaLabel
            // 
            ivaLabel.AutoSize = true;
            ivaLabel.Location = new System.Drawing.Point(26, 204);
            ivaLabel.Name = "ivaLabel";
            ivaLabel.Size = new System.Drawing.Size(24, 13);
            ivaLabel.TabIndex = 28;
            ivaLabel.Text = "iva:";
            // 
            // precio_totalLabel
            // 
            precio_totalLabel.AutoSize = true;
            precio_totalLabel.Location = new System.Drawing.Point(26, 230);
            precio_totalLabel.Name = "precio_totalLabel";
            precio_totalLabel.Size = new System.Drawing.Size(62, 13);
            precio_totalLabel.TabIndex = 30;
            precio_totalLabel.Text = "precio total:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(33, 47);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(66, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(176, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(254, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 50);
            this.label1.TabIndex = 17;
            this.label1.Text = "NUEVA FACTURA";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(870, 139);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // erpDataSetFeb
            // 
            this.erpDataSetFeb.DataSetName = "erpDataSetFeb";
            this.erpDataSetFeb.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // facturasBindingSource
            // 
            this.facturasBindingSource.DataMember = "facturas";
            this.facturasBindingSource.DataSource = this.erpDataSetFeb;
            // 
            // facturasTableAdapter
            // 
            this.facturasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clientesTableAdapter = null;
            this.tableAdapterManager.empleadosTableAdapter = null;
            this.tableAdapterManager.facturasTableAdapter = this.facturasTableAdapter;
            this.tableAdapterManager.lin_facturasTableAdapter = this.lin_facturasTableAdapter;
            this.tableAdapterManager.pedidoTableAdapter = null;
            this.tableAdapterManager.productosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.erpDataSetFebTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ventaTableAdapter = null;
            // 
            // lin_facturasTableAdapter
            // 
            this.lin_facturasTableAdapter.ClearBeforeFill = true;
            // 
            // facturasBindingNavigator
            // 
            this.facturasBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.facturasBindingNavigator.BindingSource = this.facturasBindingSource;
            this.facturasBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.facturasBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.facturasBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.facturasBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.facturasBindingNavigatorSaveItem});
            this.facturasBindingNavigator.Location = new System.Drawing.Point(0, 439);
            this.facturasBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.facturasBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.facturasBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.facturasBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.facturasBindingNavigator.Name = "facturasBindingNavigator";
            this.facturasBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.facturasBindingNavigator.Size = new System.Drawing.Size(740, 25);
            this.facturasBindingNavigator.TabIndex = 20;
            this.facturasBindingNavigator.Text = "bindingNavigator1";
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
            // facturasBindingNavigatorSaveItem
            // 
            this.facturasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.facturasBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("facturasBindingNavigatorSaveItem.Image")));
            this.facturasBindingNavigatorSaveItem.Name = "facturasBindingNavigatorSaveItem";
            this.facturasBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.facturasBindingNavigatorSaveItem.Text = "Guardar datos";
            this.facturasBindingNavigatorSaveItem.Click += new System.EventHandler(this.facturasBindingNavigatorSaveItem_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.facturasBindingSource, "id", true));
            this.helpProvider1.SetHelpString(this.idTextBox, "identificación de la factura");
            this.idTextBox.Location = new System.Drawing.Point(527, 145);
            this.idTextBox.Name = "idTextBox";
            this.helpProvider1.SetShowHelp(this.idTextBox, true);
            this.idTextBox.Size = new System.Drawing.Size(28, 20);
            this.idTextBox.TabIndex = 21;
            // 
            // id_clienteTextBox
            // 
            this.id_clienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.facturasBindingSource, "id_cliente", true));
            this.helpProvider1.SetHelpString(this.id_clienteTextBox, "Identificador del cliente");
            this.id_clienteTextBox.Location = new System.Drawing.Point(527, 171);
            this.id_clienteTextBox.Name = "id_clienteTextBox";
            this.helpProvider1.SetShowHelp(this.id_clienteTextBox, true);
            this.id_clienteTextBox.Size = new System.Drawing.Size(28, 20);
            this.id_clienteTextBox.TabIndex = 23;
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.facturasBindingSource, "fecha", true));
            this.helpProvider1.SetHelpString(this.fechaDateTimePicker, "Coloque la fecha de expedición de la fecha de la factura");
            this.fechaDateTimePicker.Location = new System.Drawing.Point(98, 144);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.helpProvider1.SetShowHelp(this.fechaDateTimePicker, true);
            this.fechaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaDateTimePicker.TabIndex = 25;
            // 
            // precio_brutoTextBox
            // 
            this.precio_brutoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.facturasBindingSource, "precio_bruto", true));
            this.helpProvider1.SetHelpString(this.precio_brutoTextBox, "Precio sin IVA de la factura");
            this.precio_brutoTextBox.Location = new System.Drawing.Point(98, 175);
            this.precio_brutoTextBox.Name = "precio_brutoTextBox";
            this.helpProvider1.SetShowHelp(this.precio_brutoTextBox, true);
            this.precio_brutoTextBox.Size = new System.Drawing.Size(63, 20);
            this.precio_brutoTextBox.TabIndex = 27;
            // 
            // ivaTextBox
            // 
            this.ivaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.facturasBindingSource, "iva", true));
            this.helpProvider1.SetHelpString(this.ivaTextBox, "Porcentaje de IVA ");
            this.ivaTextBox.Location = new System.Drawing.Point(98, 201);
            this.ivaTextBox.Name = "ivaTextBox";
            this.helpProvider1.SetShowHelp(this.ivaTextBox, true);
            this.ivaTextBox.Size = new System.Drawing.Size(63, 20);
            this.ivaTextBox.TabIndex = 29;
            // 
            // precio_totalTextBox
            // 
            this.precio_totalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.facturasBindingSource, "precio_total", true));
            this.helpProvider1.SetHelpString(this.precio_totalTextBox, "Precio total con IVA incluido de la factura");
            this.precio_totalTextBox.Location = new System.Drawing.Point(98, 227);
            this.precio_totalTextBox.Name = "precio_totalTextBox";
            this.helpProvider1.SetShowHelp(this.precio_totalTextBox, true);
            this.precio_totalTextBox.Size = new System.Drawing.Size(63, 20);
            this.precio_totalTextBox.TabIndex = 31;
            // 
            // lin_facturasBindingSource
            // 
            this.lin_facturasBindingSource.DataMember = "lin_facturas";
            this.lin_facturasBindingSource.DataSource = this.erpDataSetFeb;
            // 
            // lin_facturasDataGridView
            // 
            this.lin_facturasDataGridView.AutoGenerateColumns = false;
            this.lin_facturasDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.lin_facturasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lin_facturasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.lin_facturasDataGridView.DataSource = this.lin_facturasBindingSource;
            this.helpProvider1.SetHelpString(this.lin_facturasDataGridView, "Lineas de la factura. Coloque aquí los productos");
            this.lin_facturasDataGridView.Location = new System.Drawing.Point(0, 253);
            this.lin_facturasDataGridView.Name = "lin_facturasDataGridView";
            this.helpProvider1.SetShowHelp(this.lin_facturasDataGridView, true);
            this.lin_facturasDataGridView.Size = new System.Drawing.Size(751, 183);
            this.lin_facturasDataGridView.TabIndex = 31;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_factura";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_factura";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "id_producto";
            this.dataGridViewTextBoxColumn2.HeaderText = "id_producto";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "descripcion";
            this.dataGridViewTextBoxColumn3.HeaderText = "descripcion";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "unidades";
            this.dataGridViewTextBoxColumn4.HeaderText = "unidades";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "precio";
            this.dataGridViewTextBoxColumn5.HeaderText = "precio";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "descuento";
            this.dataGridViewTextBoxColumn6.HeaderText = "descuento";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "importe";
            this.dataGridViewTextBoxColumn7.HeaderText = "importe";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // Facturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 464);
            this.Controls.Add(this.lin_facturasDataGridView);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(id_clienteLabel);
            this.Controls.Add(this.id_clienteTextBox);
            this.Controls.Add(fechaLabel);
            this.Controls.Add(this.fechaDateTimePicker);
            this.Controls.Add(precio_brutoLabel);
            this.Controls.Add(this.precio_brutoTextBox);
            this.Controls.Add(ivaLabel);
            this.Controls.Add(this.ivaTextBox);
            this.Controls.Add(precio_totalLabel);
            this.Controls.Add(this.precio_totalTextBox);
            this.Controls.Add(this.facturasBindingNavigator);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Facturas";
            this.Text = "Facturas";
            this.Load += new System.EventHandler(this.Facturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpDataSetFeb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturasBindingNavigator)).EndInit();
            this.facturasBindingNavigator.ResumeLayout(false);
            this.facturasBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lin_facturasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lin_facturasDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private erpDataSetFeb erpDataSetFeb;
        private System.Windows.Forms.BindingSource facturasBindingSource;
        private erpDataSetFebTableAdapters.facturasTableAdapter facturasTableAdapter;
        private erpDataSetFebTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator facturasBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton facturasBindingNavigatorSaveItem;
        private erpDataSetFebTableAdapters.lin_facturasTableAdapter lin_facturasTableAdapter;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox id_clienteTextBox;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        private System.Windows.Forms.TextBox precio_brutoTextBox;
        private System.Windows.Forms.TextBox ivaTextBox;
        private System.Windows.Forms.TextBox precio_totalTextBox;
        private System.Windows.Forms.BindingSource lin_facturasBindingSource;
        private System.Windows.Forms.DataGridView lin_facturasDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}