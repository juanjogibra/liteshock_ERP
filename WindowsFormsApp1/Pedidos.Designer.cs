namespace WindowsFormsApp1
{
    partial class Pedidos
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
            System.Windows.Forms.Label cantidadLabel;
            System.Windows.Forms.Label precioLabel;
            System.Windows.Forms.Label precio_sinIva_Label;
            System.Windows.Forms.Label importeLabel;
            System.Windows.Forms.Label fechaenvioLabel;
            System.Windows.Forms.Label fechapedidoLabel;
            System.Windows.Forms.Label idclienteLabel;
            System.Windows.Forms.Label compañiaLabel;
            System.Windows.Forms.Label tipoenvioLabel;
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label ciudadLabel;
            System.Windows.Forms.Label provinciaLabel;
            System.Windows.Forms.Label paisLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pedidos));
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.erpDataSet2 = new WindowsFormsApp1.erpDataSet2();
            this.pedidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pedidoTableAdapter = new WindowsFormsApp1.erpDataSet2TableAdapters.pedidoTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.erpDataSet2TableAdapters.TableAdapterManager();
            this.pedidoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.pedidoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.cantidadTextBox = new System.Windows.Forms.TextBox();
            this.precioTextBox = new System.Windows.Forms.TextBox();
            this.precio_sinIva_TextBox = new System.Windows.Forms.TextBox();
            this.importeTextBox = new System.Windows.Forms.TextBox();
            this.fechaenvioDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fechapedidoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.idclienteTextBox = new System.Windows.Forms.TextBox();
            this.compañiaTextBox = new System.Windows.Forms.TextBox();
            this.tipoenvioTextBox = new System.Windows.Forms.TextBox();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.ciudadTextBox = new System.Windows.Forms.TextBox();
            this.provinciaTextBox = new System.Windows.Forms.TextBox();
            this.paisTextBox = new System.Windows.Forms.TextBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            idLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            cantidadLabel = new System.Windows.Forms.Label();
            precioLabel = new System.Windows.Forms.Label();
            precio_sinIva_Label = new System.Windows.Forms.Label();
            importeLabel = new System.Windows.Forms.Label();
            fechaenvioLabel = new System.Windows.Forms.Label();
            fechapedidoLabel = new System.Windows.Forms.Label();
            idclienteLabel = new System.Windows.Forms.Label();
            compañiaLabel = new System.Windows.Forms.Label();
            tipoenvioLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            ciudadLabel = new System.Windows.Forms.Label();
            provinciaLabel = new System.Windows.Forms.Label();
            paisLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingNavigator)).BeginInit();
            this.pedidoBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(83, 183);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(18, 13);
            idLabel.TabIndex = 21;
            idLabel.Text = "id:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(83, 209);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(45, 13);
            nombreLabel.TabIndex = 23;
            nombreLabel.Text = "nombre:";
            // 
            // cantidadLabel
            // 
            cantidadLabel.AutoSize = true;
            cantidadLabel.Location = new System.Drawing.Point(83, 235);
            cantidadLabel.Name = "cantidadLabel";
            cantidadLabel.Size = new System.Drawing.Size(51, 13);
            cantidadLabel.TabIndex = 25;
            cantidadLabel.Text = "cantidad:";
            // 
            // precioLabel
            // 
            precioLabel.AutoSize = true;
            precioLabel.Location = new System.Drawing.Point(83, 261);
            precioLabel.Name = "precioLabel";
            precioLabel.Size = new System.Drawing.Size(39, 13);
            precioLabel.TabIndex = 27;
            precioLabel.Text = "precio:";
            // 
            // precio_sinIva_Label
            // 
            precio_sinIva_Label.AutoSize = true;
            precio_sinIva_Label.Location = new System.Drawing.Point(83, 287);
            precio_sinIva_Label.Name = "precio_sinIva_Label";
            precio_sinIva_Label.Size = new System.Drawing.Size(76, 13);
            precio_sinIva_Label.TabIndex = 29;
            precio_sinIva_Label.Text = "precio(sin Iva):";
            // 
            // importeLabel
            // 
            importeLabel.AutoSize = true;
            importeLabel.Location = new System.Drawing.Point(83, 313);
            importeLabel.Name = "importeLabel";
            importeLabel.Size = new System.Drawing.Size(44, 13);
            importeLabel.TabIndex = 31;
            importeLabel.Text = "importe:";
            // 
            // fechaenvioLabel
            // 
            fechaenvioLabel.AutoSize = true;
            fechaenvioLabel.Location = new System.Drawing.Point(83, 340);
            fechaenvioLabel.Name = "fechaenvioLabel";
            fechaenvioLabel.Size = new System.Drawing.Size(63, 13);
            fechaenvioLabel.TabIndex = 33;
            fechaenvioLabel.Text = "fechaenvio:";
            // 
            // fechapedidoLabel
            // 
            fechapedidoLabel.AutoSize = true;
            fechapedidoLabel.Location = new System.Drawing.Point(83, 366);
            fechapedidoLabel.Name = "fechapedidoLabel";
            fechapedidoLabel.Size = new System.Drawing.Size(69, 13);
            fechapedidoLabel.TabIndex = 35;
            fechapedidoLabel.Text = "fechapedido:";
            // 
            // idclienteLabel
            // 
            idclienteLabel.AutoSize = true;
            idclienteLabel.Location = new System.Drawing.Point(506, 186);
            idclienteLabel.Name = "idclienteLabel";
            idclienteLabel.Size = new System.Drawing.Size(49, 13);
            idclienteLabel.TabIndex = 37;
            idclienteLabel.Text = "idcliente:";
            // 
            // compañiaLabel
            // 
            compañiaLabel.AutoSize = true;
            compañiaLabel.Location = new System.Drawing.Point(506, 212);
            compañiaLabel.Name = "compañiaLabel";
            compañiaLabel.Size = new System.Drawing.Size(56, 13);
            compañiaLabel.TabIndex = 39;
            compañiaLabel.Text = "compañia:";
            // 
            // tipoenvioLabel
            // 
            tipoenvioLabel.AutoSize = true;
            tipoenvioLabel.Location = new System.Drawing.Point(506, 238);
            tipoenvioLabel.Name = "tipoenvioLabel";
            tipoenvioLabel.Size = new System.Drawing.Size(53, 13);
            tipoenvioLabel.TabIndex = 41;
            tipoenvioLabel.Text = "tipoenvio:";
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Location = new System.Drawing.Point(506, 264);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(53, 13);
            direccionLabel.TabIndex = 43;
            direccionLabel.Text = "direccion:";
            // 
            // ciudadLabel
            // 
            ciudadLabel.AutoSize = true;
            ciudadLabel.Location = new System.Drawing.Point(506, 290);
            ciudadLabel.Name = "ciudadLabel";
            ciudadLabel.Size = new System.Drawing.Size(42, 13);
            ciudadLabel.TabIndex = 45;
            ciudadLabel.Text = "ciudad:";
            // 
            // provinciaLabel
            // 
            provinciaLabel.AutoSize = true;
            provinciaLabel.Location = new System.Drawing.Point(506, 316);
            provinciaLabel.Name = "provinciaLabel";
            provinciaLabel.Size = new System.Drawing.Size(53, 13);
            provinciaLabel.TabIndex = 47;
            provinciaLabel.Text = "provincia:";
            // 
            // paisLabel
            // 
            paisLabel.AutoSize = true;
            paisLabel.Location = new System.Drawing.Point(506, 342);
            paisLabel.Name = "paisLabel";
            paisLabel.Size = new System.Drawing.Size(29, 13);
            paisLabel.TabIndex = 49;
            paisLabel.Text = "pais:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(46, 45);
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
            this.pictureBox1.Location = new System.Drawing.Point(239, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(317, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 50);
            this.label1.TabIndex = 18;
            this.label1.Text = "NUEVO PEDIDO";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1037, 139);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // erpDataSet2
            // 
            this.erpDataSet2.DataSetName = "erpDataSet2";
            this.erpDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pedidoBindingSource
            // 
            this.pedidoBindingSource.DataMember = "pedido";
            this.pedidoBindingSource.DataSource = this.erpDataSet2;
            // 
            // pedidoTableAdapter
            // 
            this.pedidoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clientesTableAdapter = null;
            this.tableAdapterManager.empleadosTableAdapter = null;
            this.tableAdapterManager.pedidoTableAdapter = this.pedidoTableAdapter;
            this.tableAdapterManager.productosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.erpDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ventaTableAdapter = null;
            // 
            // pedidoBindingNavigator
            // 
            this.pedidoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pedidoBindingNavigator.BindingSource = this.pedidoBindingSource;
            this.pedidoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pedidoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pedidoBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pedidoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.pedidoBindingNavigatorSaveItem});
            this.pedidoBindingNavigator.Location = new System.Drawing.Point(0, 408);
            this.pedidoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pedidoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pedidoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pedidoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pedidoBindingNavigator.Name = "pedidoBindingNavigator";
            this.pedidoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pedidoBindingNavigator.Size = new System.Drawing.Size(907, 25);
            this.pedidoBindingNavigator.TabIndex = 21;
            this.pedidoBindingNavigator.Text = "bindingNavigator1";
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
            // pedidoBindingNavigatorSaveItem
            // 
            this.pedidoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pedidoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pedidoBindingNavigatorSaveItem.Image")));
            this.pedidoBindingNavigatorSaveItem.Name = "pedidoBindingNavigatorSaveItem";
            this.pedidoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.pedidoBindingNavigatorSaveItem.Text = "Guardar datos";
            this.pedidoBindingNavigatorSaveItem.Click += new System.EventHandler(this.pedidoBindingNavigatorSaveItem_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedidoBindingSource, "id", true));
            this.helpProvider1.SetHelpString(this.idTextBox, "Identificador del producto");
            this.idTextBox.Location = new System.Drawing.Point(206, 180);
            this.idTextBox.Name = "idTextBox";
            this.helpProvider1.SetShowHelp(this.idTextBox, true);
            this.idTextBox.Size = new System.Drawing.Size(45, 20);
            this.idTextBox.TabIndex = 22;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedidoBindingSource, "nombre", true));
            this.helpProvider1.SetHelpString(this.nombreTextBox, "Nombre del producto");
            this.nombreTextBox.Location = new System.Drawing.Point(206, 206);
            this.nombreTextBox.Name = "nombreTextBox";
            this.helpProvider1.SetShowHelp(this.nombreTextBox, true);
            this.nombreTextBox.Size = new System.Drawing.Size(140, 20);
            this.nombreTextBox.TabIndex = 24;
            // 
            // cantidadTextBox
            // 
            this.cantidadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedidoBindingSource, "cantidad", true));
            this.helpProvider1.SetHelpString(this.cantidadTextBox, "Cantidad del producto ");
            this.cantidadTextBox.Location = new System.Drawing.Point(206, 232);
            this.cantidadTextBox.Name = "cantidadTextBox";
            this.helpProvider1.SetShowHelp(this.cantidadTextBox, true);
            this.cantidadTextBox.Size = new System.Drawing.Size(45, 20);
            this.cantidadTextBox.TabIndex = 26;
            // 
            // precioTextBox
            // 
            this.precioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedidoBindingSource, "precio", true));
            this.helpProvider1.SetHelpString(this.precioTextBox, "Precio del producto ");
            this.precioTextBox.Location = new System.Drawing.Point(206, 258);
            this.precioTextBox.Name = "precioTextBox";
            this.helpProvider1.SetShowHelp(this.precioTextBox, true);
            this.precioTextBox.Size = new System.Drawing.Size(95, 20);
            this.precioTextBox.TabIndex = 28;
            // 
            // precio_sinIva_TextBox
            // 
            this.precio_sinIva_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedidoBindingSource, "precio(sinIva)", true));
            this.helpProvider1.SetHelpString(this.precio_sinIva_TextBox, "Impuesto valor añadido");
            this.precio_sinIva_TextBox.Location = new System.Drawing.Point(206, 284);
            this.precio_sinIva_TextBox.Name = "precio_sinIva_TextBox";
            this.helpProvider1.SetShowHelp(this.precio_sinIva_TextBox, true);
            this.precio_sinIva_TextBox.Size = new System.Drawing.Size(95, 20);
            this.precio_sinIva_TextBox.TabIndex = 30;
            // 
            // importeTextBox
            // 
            this.importeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedidoBindingSource, "importe", true));
            this.helpProvider1.SetHelpString(this.importeTextBox, "Precio con IVA incluido");
            this.importeTextBox.Location = new System.Drawing.Point(206, 310);
            this.importeTextBox.Name = "importeTextBox";
            this.helpProvider1.SetShowHelp(this.importeTextBox, true);
            this.importeTextBox.Size = new System.Drawing.Size(95, 20);
            this.importeTextBox.TabIndex = 32;
            // 
            // fechaenvioDateTimePicker
            // 
            this.fechaenvioDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pedidoBindingSource, "fechaenvio", true));
            this.helpProvider1.SetHelpString(this.fechaenvioDateTimePicker, "Fecha de envio de los productos");
            this.fechaenvioDateTimePicker.Location = new System.Drawing.Point(206, 336);
            this.fechaenvioDateTimePicker.Name = "fechaenvioDateTimePicker";
            this.helpProvider1.SetShowHelp(this.fechaenvioDateTimePicker, true);
            this.fechaenvioDateTimePicker.Size = new System.Drawing.Size(140, 20);
            this.fechaenvioDateTimePicker.TabIndex = 34;
            // 
            // fechapedidoDateTimePicker
            // 
            this.fechapedidoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pedidoBindingSource, "fechapedido", true));
            this.helpProvider1.SetHelpString(this.fechapedidoDateTimePicker, "Fecha de llegada del pedido");
            this.fechapedidoDateTimePicker.Location = new System.Drawing.Point(206, 362);
            this.fechapedidoDateTimePicker.Name = "fechapedidoDateTimePicker";
            this.helpProvider1.SetShowHelp(this.fechapedidoDateTimePicker, true);
            this.fechapedidoDateTimePicker.Size = new System.Drawing.Size(140, 20);
            this.fechapedidoDateTimePicker.TabIndex = 36;
            // 
            // idclienteTextBox
            // 
            this.idclienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedidoBindingSource, "idcliente", true));
            this.helpProvider1.SetHelpString(this.idclienteTextBox, "Identificador del cliente ");
            this.idclienteTextBox.Location = new System.Drawing.Point(622, 183);
            this.idclienteTextBox.Name = "idclienteTextBox";
            this.helpProvider1.SetShowHelp(this.idclienteTextBox, true);
            this.idclienteTextBox.Size = new System.Drawing.Size(49, 20);
            this.idclienteTextBox.TabIndex = 38;
            // 
            // compañiaTextBox
            // 
            this.compañiaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedidoBindingSource, "compañia", true));
            this.helpProvider1.SetHelpString(this.compañiaTextBox, "Compaía que gestiona el envio");
            this.compañiaTextBox.Location = new System.Drawing.Point(622, 209);
            this.compañiaTextBox.Name = "compañiaTextBox";
            this.helpProvider1.SetShowHelp(this.compañiaTextBox, true);
            this.compañiaTextBox.Size = new System.Drawing.Size(141, 20);
            this.compañiaTextBox.TabIndex = 40;
            // 
            // tipoenvioTextBox
            // 
            this.tipoenvioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedidoBindingSource, "tipoenvio", true));
            this.helpProvider1.SetHelpString(this.tipoenvioTextBox, "Tipo de envio. Puede ser urgente o estandar");
            this.tipoenvioTextBox.Location = new System.Drawing.Point(622, 235);
            this.tipoenvioTextBox.Name = "tipoenvioTextBox";
            this.helpProvider1.SetShowHelp(this.tipoenvioTextBox, true);
            this.tipoenvioTextBox.Size = new System.Drawing.Size(104, 20);
            this.tipoenvioTextBox.TabIndex = 42;
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedidoBindingSource, "direccion", true));
            this.helpProvider1.SetHelpString(this.direccionTextBox, "Direccion asociada al cliente");
            this.direccionTextBox.Location = new System.Drawing.Point(622, 261);
            this.direccionTextBox.Name = "direccionTextBox";
            this.helpProvider1.SetShowHelp(this.direccionTextBox, true);
            this.direccionTextBox.Size = new System.Drawing.Size(200, 20);
            this.direccionTextBox.TabIndex = 44;
            // 
            // ciudadTextBox
            // 
            this.ciudadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedidoBindingSource, "ciudad", true));
            this.helpProvider1.SetHelpString(this.ciudadTextBox, "Ciudad a la que se dirige el envio");
            this.ciudadTextBox.Location = new System.Drawing.Point(622, 287);
            this.ciudadTextBox.Name = "ciudadTextBox";
            this.helpProvider1.SetShowHelp(this.ciudadTextBox, true);
            this.ciudadTextBox.Size = new System.Drawing.Size(141, 20);
            this.ciudadTextBox.TabIndex = 46;
            // 
            // provinciaTextBox
            // 
            this.provinciaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedidoBindingSource, "provincia", true));
            this.helpProvider1.SetHelpString(this.provinciaTextBox, "Provincia a la que pertenece la ciudad del envio");
            this.provinciaTextBox.Location = new System.Drawing.Point(622, 313);
            this.provinciaTextBox.Name = "provinciaTextBox";
            this.helpProvider1.SetShowHelp(this.provinciaTextBox, true);
            this.provinciaTextBox.Size = new System.Drawing.Size(104, 20);
            this.provinciaTextBox.TabIndex = 48;
            // 
            // paisTextBox
            // 
            this.paisTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedidoBindingSource, "pais", true));
            this.helpProvider1.SetHelpString(this.paisTextBox, "Pais del envío ");
            this.paisTextBox.Location = new System.Drawing.Point(622, 339);
            this.paisTextBox.Name = "paisTextBox";
            this.helpProvider1.SetShowHelp(this.paisTextBox, true);
            this.paisTextBox.Size = new System.Drawing.Size(104, 20);
            this.paisTextBox.TabIndex = 50;
            // 
            // Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 433);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(cantidadLabel);
            this.Controls.Add(this.cantidadTextBox);
            this.Controls.Add(precioLabel);
            this.Controls.Add(this.precioTextBox);
            this.Controls.Add(precio_sinIva_Label);
            this.Controls.Add(this.precio_sinIva_TextBox);
            this.Controls.Add(importeLabel);
            this.Controls.Add(this.importeTextBox);
            this.Controls.Add(fechaenvioLabel);
            this.Controls.Add(this.fechaenvioDateTimePicker);
            this.Controls.Add(fechapedidoLabel);
            this.Controls.Add(this.fechapedidoDateTimePicker);
            this.Controls.Add(idclienteLabel);
            this.Controls.Add(this.idclienteTextBox);
            this.Controls.Add(compañiaLabel);
            this.Controls.Add(this.compañiaTextBox);
            this.Controls.Add(tipoenvioLabel);
            this.Controls.Add(this.tipoenvioTextBox);
            this.Controls.Add(direccionLabel);
            this.Controls.Add(this.direccionTextBox);
            this.Controls.Add(ciudadLabel);
            this.Controls.Add(this.ciudadTextBox);
            this.Controls.Add(provinciaLabel);
            this.Controls.Add(this.provinciaTextBox);
            this.Controls.Add(paisLabel);
            this.Controls.Add(this.paisTextBox);
            this.Controls.Add(this.pedidoBindingNavigator);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Pedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pedidos";
            this.Load += new System.EventHandler(this.Pedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingNavigator)).EndInit();
            this.pedidoBindingNavigator.ResumeLayout(false);
            this.pedidoBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private erpDataSet2 erpDataSet2;
        private System.Windows.Forms.BindingSource pedidoBindingSource;
        private erpDataSet2TableAdapters.pedidoTableAdapter pedidoTableAdapter;
        private erpDataSet2TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pedidoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton pedidoBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox cantidadTextBox;
        private System.Windows.Forms.TextBox precioTextBox;
        private System.Windows.Forms.TextBox precio_sinIva_TextBox;
        private System.Windows.Forms.TextBox importeTextBox;
        private System.Windows.Forms.DateTimePicker fechaenvioDateTimePicker;
        private System.Windows.Forms.DateTimePicker fechapedidoDateTimePicker;
        private System.Windows.Forms.TextBox idclienteTextBox;
        private System.Windows.Forms.TextBox compañiaTextBox;
        private System.Windows.Forms.TextBox tipoenvioTextBox;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.TextBox ciudadTextBox;
        private System.Windows.Forms.TextBox provinciaTextBox;
        private System.Windows.Forms.TextBox paisTextBox;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}