namespace SisSalute
{
    partial class cadastroClientesForm
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
            System.Windows.Forms.Label codClienteLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label cpfLabel;
            System.Windows.Forms.Label telefoneLabel;
            System.Windows.Forms.Label celular2Label;
            System.Windows.Forms.Label celular1Label;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label facebookLabel;
            System.Windows.Forms.Label profissaoLabel;
            System.Windows.Forms.Label estadoCivilLabel;
            System.Windows.Forms.Label dataNascimentoLabel;
            System.Windows.Forms.Label sexoLabel;
            System.Windows.Forms.Label dataCadastroLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadastroClientesForm));
            this.botaoVoltar = new System.Windows.Forms.Button();
            this.sisSaluteDataSet = new SisSalute.SisSaluteDataSet();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.codClienteLabel1 = new System.Windows.Forms.Label();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.cpfTextBox = new System.Windows.Forms.TextBox();
            this.telefoneTextBox = new System.Windows.Forms.TextBox();
            this.celular2TextBox = new System.Windows.Forms.TextBox();
            this.celular1TextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.facebookTextBox = new System.Windows.Forms.TextBox();
            this.profissaoTextBox = new System.Windows.Forms.TextBox();
            this.estadoCivilTextBox = new System.Windows.Forms.TextBox();
            this.dataNascimentoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.sexoComboBox = new System.Windows.Forms.ComboBox();
            this.dataCadastroDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.enderecosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            codClienteLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            cpfLabel = new System.Windows.Forms.Label();
            telefoneLabel = new System.Windows.Forms.Label();
            celular2Label = new System.Windows.Forms.Label();
            celular1Label = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            facebookLabel = new System.Windows.Forms.Label();
            profissaoLabel = new System.Windows.Forms.Label();
            estadoCivilLabel = new System.Windows.Forms.Label();
            dataNascimentoLabel = new System.Windows.Forms.Label();
            sexoLabel = new System.Windows.Forms.Label();
            dataCadastroLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sisSaluteDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingNavigator)).BeginInit();
            this.clientesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enderecosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // codClienteLabel
            // 
            codClienteLabel.AutoSize = true;
            codClienteLabel.Location = new System.Drawing.Point(824, 37);
            codClienteLabel.Name = "codClienteLabel";
            codClienteLabel.Size = new System.Drawing.Size(93, 13);
            codClienteLabel.TabIndex = 2;
            codClienteLabel.Text = "Código do Cliente:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(62, 94);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(38, 13);
            nomeLabel.TabIndex = 4;
            nomeLabel.Text = "Nome:";
            // 
            // cpfLabel
            // 
            cpfLabel.AutoSize = true;
            cpfLabel.Location = new System.Drawing.Point(70, 127);
            cpfLabel.Name = "cpfLabel";
            cpfLabel.Size = new System.Drawing.Size(30, 13);
            cpfLabel.TabIndex = 6;
            cpfLabel.Text = "CPF:";
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.Location = new System.Drawing.Point(26, 153);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new System.Drawing.Size(74, 13);
            telefoneLabel.TabIndex = 8;
            telefoneLabel.Text = "Telefone Fixo:";
            // 
            // celular2Label
            // 
            celular2Label.AutoSize = true;
            celular2Label.Location = new System.Drawing.Point(51, 182);
            celular2Label.Name = "celular2Label";
            celular2Label.Size = new System.Drawing.Size(47, 13);
            celular2Label.TabIndex = 10;
            celular2Label.Text = "celular2:";
            // 
            // celular1Label
            // 
            celular1Label.AutoSize = true;
            celular1Label.Location = new System.Drawing.Point(51, 208);
            celular1Label.Name = "celular1Label";
            celular1Label.Size = new System.Drawing.Size(47, 13);
            celular1Label.TabIndex = 12;
            celular1Label.Text = "celular1:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(604, 108);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(34, 13);
            emailLabel.TabIndex = 14;
            emailLabel.Text = "email:";
            // 
            // facebookLabel
            // 
            facebookLabel.AutoSize = true;
            facebookLabel.Location = new System.Drawing.Point(583, 140);
            facebookLabel.Name = "facebookLabel";
            facebookLabel.Size = new System.Drawing.Size(55, 13);
            facebookLabel.TabIndex = 16;
            facebookLabel.Text = "facebook:";
            // 
            // profissaoLabel
            // 
            profissaoLabel.AutoSize = true;
            profissaoLabel.Location = new System.Drawing.Point(586, 178);
            profissaoLabel.Name = "profissaoLabel";
            profissaoLabel.Size = new System.Drawing.Size(52, 13);
            profissaoLabel.TabIndex = 18;
            profissaoLabel.Text = "profissao:";
            // 
            // estadoCivilLabel
            // 
            estadoCivilLabel.AutoSize = true;
            estadoCivilLabel.Location = new System.Drawing.Point(574, 211);
            estadoCivilLabel.Name = "estadoCivilLabel";
            estadoCivilLabel.Size = new System.Drawing.Size(64, 13);
            estadoCivilLabel.TabIndex = 20;
            estadoCivilLabel.Text = "estado Civil:";
            // 
            // dataNascimentoLabel
            // 
            dataNascimentoLabel.AutoSize = true;
            dataNascimentoLabel.Location = new System.Drawing.Point(548, 249);
            dataNascimentoLabel.Name = "dataNascimentoLabel";
            dataNascimentoLabel.Size = new System.Drawing.Size(90, 13);
            dataNascimentoLabel.TabIndex = 22;
            dataNascimentoLabel.Text = "data Nascimento:";
            // 
            // sexoLabel
            // 
            sexoLabel.AutoSize = true;
            sexoLabel.Location = new System.Drawing.Point(606, 277);
            sexoLabel.Name = "sexoLabel";
            sexoLabel.Size = new System.Drawing.Size(32, 13);
            sexoLabel.TabIndex = 24;
            sexoLabel.Text = "sexo:";
            // 
            // dataCadastroLabel
            // 
            dataCadastroLabel.AutoSize = true;
            dataCadastroLabel.Location = new System.Drawing.Point(562, 315);
            dataCadastroLabel.Name = "dataCadastroLabel";
            dataCadastroLabel.Size = new System.Drawing.Size(76, 13);
            dataCadastroLabel.TabIndex = 26;
            dataCadastroLabel.Text = "data Cadastro:";
            // 
            // botaoVoltar
            // 
            this.botaoVoltar.Location = new System.Drawing.Point(895, 675);
            this.botaoVoltar.Name = "botaoVoltar";
            this.botaoVoltar.Size = new System.Drawing.Size(75, 23);
            this.botaoVoltar.TabIndex = 0;
            this.botaoVoltar.Text = "Voltar";
            this.botaoVoltar.UseVisualStyleBackColor = true;
            this.botaoVoltar.Click += new System.EventHandler(this.botaoVoltar_Click);
            // 
            // sisSaluteDataSet
            // 
            this.sisSaluteDataSet.DataSetName = "SisSaluteDataSet";
            this.sisSaluteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.sisSaluteDataSet;
            // 
            // clientesTableAdapter
            // 
            //this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            //this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            //this.tableAdapterManager.ClientesTableAdapter = this.clientesTableAdapter;
            //this.tableAdapterManager.ConsultaTableAdapter = null;
            //this.tableAdapterManager.EnderecosTableAdapter = this.enderecosTableAdapter;
            //this.tableAdapterManager.InsumoTableAdapter = null;
            //this.tableAdapterManager.InsumoTratamentosTableAdapter = null;
            //this.tableAdapterManager.ProfissionaisConsultaTableAdapter = null;
            //this.tableAdapterManager.ProfissionaisTableAdapter = null;
            //this.tableAdapterManager.TratamentosTableAdapter = null;
            //this.tableAdapterManager.UpdateOrder = SisSalute.SisSaluteDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;///*
            // 
            // enderecosTableAdapter
            // 
            //this.enderecosTableAdapter.ClearBeforeFill = true;
            // 
            // clientesBindingNavigator
            // 
            this.clientesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.clientesBindingNavigator.BindingSource = this.clientesBindingSource;
            this.clientesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.clientesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
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
            this.clientesBindingNavigatorSaveItem,
            this.toolStripProgressBar1});
            this.clientesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.clientesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.clientesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.clientesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.clientesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.clientesBindingNavigator.Name = "clientesBindingNavigator";
            this.clientesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.clientesBindingNavigator.Size = new System.Drawing.Size(1008, 25);
            this.clientesBindingNavigator.TabIndex = 1;
            this.clientesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
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
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
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
            this.clientesBindingNavigatorSaveItem.Text = "Save Data";
            this.clientesBindingNavigatorSaveItem.Click += new System.EventHandler(this.clientesBindingNavigatorSaveItem_Click);
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 22);
            // 
            // codClienteLabel1
            // 
            this.codClienteLabel1.Location = new System.Drawing.Point(0, 0);
            this.codClienteLabel1.Name = "codClienteLabel1";
            this.codClienteLabel1.Size = new System.Drawing.Size(100, 23);
            this.codClienteLabel1.TabIndex = 28;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.AcceptsReturn = true;
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(104, 91);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(294, 20);
            this.nomeTextBox.TabIndex = 5;
            // 
            // cpfTextBox
            // 
            this.cpfTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "cpf", true));
            this.cpfTextBox.Location = new System.Drawing.Point(104, 124);
            this.cpfTextBox.Name = "cpfTextBox";
            this.cpfTextBox.Size = new System.Drawing.Size(294, 20);
            this.cpfTextBox.TabIndex = 7;
            // 
            // telefoneTextBox
            // 
            this.telefoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "telefone", true));
            this.telefoneTextBox.Location = new System.Drawing.Point(104, 153);
            this.telefoneTextBox.Name = "telefoneTextBox";
            this.telefoneTextBox.Size = new System.Drawing.Size(294, 20);
            this.telefoneTextBox.TabIndex = 9;
            this.telefoneTextBox.TextChanged += new System.EventHandler(this.telefoneTextBox_TextChanged);
            // 
            // celular2TextBox
            // 
            this.celular2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "celular2", true));
            this.celular2TextBox.Location = new System.Drawing.Point(104, 179);
            this.celular2TextBox.Name = "celular2TextBox";
            this.celular2TextBox.Size = new System.Drawing.Size(100, 20);
            this.celular2TextBox.TabIndex = 11;
            // 
            // celular1TextBox
            // 
            this.celular1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "celular1", true));
            this.celular1TextBox.Location = new System.Drawing.Point(104, 205);
            this.celular1TextBox.Name = "celular1TextBox";
            this.celular1TextBox.Size = new System.Drawing.Size(100, 20);
            this.celular1TextBox.TabIndex = 13;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "email", true));
            this.emailTextBox.Location = new System.Drawing.Point(644, 105);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(100, 20);
            this.emailTextBox.TabIndex = 15;
            // 
            // facebookTextBox
            // 
            this.facebookTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "facebook", true));
            this.facebookTextBox.Location = new System.Drawing.Point(644, 137);
            this.facebookTextBox.Name = "facebookTextBox";
            this.facebookTextBox.Size = new System.Drawing.Size(100, 20);
            this.facebookTextBox.TabIndex = 17;
            // 
            // profissaoTextBox
            // 
            this.profissaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "profissao", true));
            this.profissaoTextBox.Location = new System.Drawing.Point(644, 175);
            this.profissaoTextBox.Name = "profissaoTextBox";
            this.profissaoTextBox.Size = new System.Drawing.Size(100, 20);
            this.profissaoTextBox.TabIndex = 19;
            // 
            // estadoCivilTextBox
            // 
            this.estadoCivilTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "estadoCivil", true));
            this.estadoCivilTextBox.Location = new System.Drawing.Point(644, 208);
            this.estadoCivilTextBox.Name = "estadoCivilTextBox";
            this.estadoCivilTextBox.Size = new System.Drawing.Size(100, 20);
            this.estadoCivilTextBox.TabIndex = 21;
            // 
            // dataNascimentoDateTimePicker
            // 
            this.dataNascimentoDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.dataNascimentoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.clientesBindingSource, "dataNascimento", true));
            this.dataNascimentoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dataNascimentoDateTimePicker.Location = new System.Drawing.Point(644, 245);
            this.dataNascimentoDateTimePicker.Name = "dataNascimentoDateTimePicker";
            this.dataNascimentoDateTimePicker.Size = new System.Drawing.Size(121, 20);
            this.dataNascimentoDateTimePicker.TabIndex = 23;
            this.dataNascimentoDateTimePicker.ValueChanged += new System.EventHandler(this.dataNascimentoDateTimePicker_ValueChanged);
            // 
            // sexoComboBox
            // 
            this.sexoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "sexo", true));
            this.sexoComboBox.DisplayMember = "M";
            this.sexoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sexoComboBox.FormattingEnabled = true;
            this.sexoComboBox.Items.AddRange(new object[] {
            "M",
            "F"});
            this.sexoComboBox.Location = new System.Drawing.Point(644, 274);
            this.sexoComboBox.MaxDropDownItems = 2;
            this.sexoComboBox.MaxLength = 1;
            this.sexoComboBox.Name = "sexoComboBox";
            this.sexoComboBox.Size = new System.Drawing.Size(121, 21);
            this.sexoComboBox.TabIndex = 25;
            this.sexoComboBox.SelectedIndexChanged += new System.EventHandler(this.sexoComboBox_SelectedIndexChanged);
            // 
            // dataCadastroDateTimePicker
            // 
            this.dataCadastroDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.dataCadastroDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.clientesBindingSource, "dataCadastro", true));
            this.dataCadastroDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dataCadastroDateTimePicker.Location = new System.Drawing.Point(644, 311);
            this.dataCadastroDateTimePicker.Name = "dataCadastroDateTimePicker";
            this.dataCadastroDateTimePicker.Size = new System.Drawing.Size(121, 20);
            this.dataCadastroDateTimePicker.TabIndex = 27;
            // 
            // enderecosBindingSource
            // 
            this.enderecosBindingSource.DataMember = "Enderecos";
            this.enderecosBindingSource.DataSource = this.sisSaluteDataSet;
            // 
            // cadastroClientesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(dataCadastroLabel);
            this.Controls.Add(this.dataCadastroDateTimePicker);
            this.Controls.Add(sexoLabel);
            this.Controls.Add(this.sexoComboBox);
            this.Controls.Add(dataNascimentoLabel);
            this.Controls.Add(this.dataNascimentoDateTimePicker);
            this.Controls.Add(estadoCivilLabel);
            this.Controls.Add(this.estadoCivilTextBox);
            this.Controls.Add(profissaoLabel);
            this.Controls.Add(this.profissaoTextBox);
            this.Controls.Add(facebookLabel);
            this.Controls.Add(this.facebookTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(celular1Label);
            this.Controls.Add(this.celular1TextBox);
            this.Controls.Add(celular2Label);
            this.Controls.Add(this.celular2TextBox);
            this.Controls.Add(telefoneLabel);
            this.Controls.Add(this.telefoneTextBox);
            this.Controls.Add(cpfLabel);
            this.Controls.Add(this.cpfTextBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(codClienteLabel);
            this.Controls.Add(this.codClienteLabel1);
            this.Controls.Add(this.clientesBindingNavigator);
            this.Controls.Add(this.botaoVoltar);
            this.MaximumSize = new System.Drawing.Size(1024, 768);
            this.MinimumSize = new System.Drawing.Size(1024, 726);
            this.Name = "cadastroClientesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "cadastroClientesForm";
            this.Load += new System.EventHandler(this.cadastroClientesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sisSaluteDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingNavigator)).EndInit();
            this.clientesBindingNavigator.ResumeLayout(false);
            this.clientesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enderecosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botaoVoltar;
        private SisSaluteDataSet sisSaluteDataSet;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private SisSaluteDataSetTableAdapters.ClientesTableAdapter clientesTableAdapter;
        private SisSaluteDataSetTableAdapters.TableAdapterManager tableAdapterManager;
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
        private System.Windows.Forms.Label codClienteLabel1;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox cpfTextBox;
        private System.Windows.Forms.TextBox telefoneTextBox;
        private System.Windows.Forms.TextBox celular2TextBox;
        private System.Windows.Forms.TextBox celular1TextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox facebookTextBox;
        private System.Windows.Forms.TextBox profissaoTextBox;
        private System.Windows.Forms.TextBox estadoCivilTextBox;
        private System.Windows.Forms.DateTimePicker dataNascimentoDateTimePicker;
        private System.Windows.Forms.ComboBox sexoComboBox;
        private SisSaluteDataSetTableAdapters.EnderecosTableAdapter enderecosTableAdapter;
        private System.Windows.Forms.DateTimePicker dataCadastroDateTimePicker;
        private System.Windows.Forms.BindingSource enderecosBindingSource;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;

    }
}