namespace SisSalute
{
    partial class cadastroProfissionaisForm
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
            System.Windows.Forms.Label codProfissionalLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label especialidadeLabel;
            System.Windows.Forms.Label telefoneLabel;
            System.Windows.Forms.Label celularLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label logradouroLabel;
            System.Windows.Forms.Label enderecoLabel;
            System.Windows.Forms.Label compEnderecoLabel;
            System.Windows.Forms.Label numEnderecoLabel;
            System.Windows.Forms.Label bairroLabel;
            System.Windows.Forms.Label cidadeLabel;
            System.Windows.Forms.Label estadoLabel;
            System.Windows.Forms.Label cepLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadastroProfissionaisForm));
            this.sisSaluteDataSet = new SisSalute.SisSaluteDataSet();
            this.profissionaisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.profissionaisBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.profissionaisBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.codProfissionalLabel1 = new System.Windows.Forms.Label();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.especialidadeTextBox = new System.Windows.Forms.TextBox();
            this.telefoneTextBox = new System.Windows.Forms.TextBox();
            this.celularTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.enderecosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.logradouroTextBox = new System.Windows.Forms.TextBox();
            this.enderecoTextBox = new System.Windows.Forms.TextBox();
            this.compEnderecoTextBox = new System.Windows.Forms.TextBox();
            this.numEnderecoTextBox = new System.Windows.Forms.TextBox();
            this.bairroTextBox = new System.Windows.Forms.TextBox();
            this.cidadeTextBox = new System.Windows.Forms.TextBox();
            this.estadoTextBox = new System.Windows.Forms.TextBox();
            this.cepTextBox = new System.Windows.Forms.TextBox();
            this.botaoVoltar = new System.Windows.Forms.Button();
            codProfissionalLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            especialidadeLabel = new System.Windows.Forms.Label();
            telefoneLabel = new System.Windows.Forms.Label();
            celularLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            logradouroLabel = new System.Windows.Forms.Label();
            enderecoLabel = new System.Windows.Forms.Label();
            compEnderecoLabel = new System.Windows.Forms.Label();
            numEnderecoLabel = new System.Windows.Forms.Label();
            bairroLabel = new System.Windows.Forms.Label();
            cidadeLabel = new System.Windows.Forms.Label();
            estadoLabel = new System.Windows.Forms.Label();
            cepLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sisSaluteDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profissionaisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profissionaisBindingNavigator)).BeginInit();
            this.profissionaisBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enderecosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // codProfissionalLabel
            // 
            codProfissionalLabel.AutoSize = true;
            codProfissionalLabel.Location = new System.Drawing.Point(722, 25);
            codProfissionalLabel.Name = "codProfissionalLabel";
            codProfissionalLabel.Size = new System.Drawing.Size(84, 13);
            codProfissionalLabel.TabIndex = 1;
            codProfissionalLabel.Text = "cod Profissional:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(73, 98);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(36, 13);
            nomeLabel.TabIndex = 3;
            nomeLabel.Text = "nome:";
            // 
            // especialidadeLabel
            // 
            especialidadeLabel.AutoSize = true;
            especialidadeLabel.Location = new System.Drawing.Point(34, 136);
            especialidadeLabel.Name = "especialidadeLabel";
            especialidadeLabel.Size = new System.Drawing.Size(75, 13);
            especialidadeLabel.TabIndex = 5;
            especialidadeLabel.Text = "especialidade:";
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.Location = new System.Drawing.Point(61, 178);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new System.Drawing.Size(48, 13);
            telefoneLabel.TabIndex = 7;
            telefoneLabel.Text = "telefone:";
            // 
            // celularLabel
            // 
            celularLabel.AutoSize = true;
            celularLabel.Location = new System.Drawing.Point(68, 214);
            celularLabel.Name = "celularLabel";
            celularLabel.Size = new System.Drawing.Size(41, 13);
            celularLabel.TabIndex = 9;
            celularLabel.Text = "celular:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(75, 251);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(34, 13);
            emailLabel.TabIndex = 11;
            emailLabel.Text = "email:";
            // 
            // logradouroLabel
            // 
            logradouroLabel.AutoSize = true;
            logradouroLabel.Location = new System.Drawing.Point(332, 98);
            logradouroLabel.Name = "logradouroLabel";
            logradouroLabel.Size = new System.Drawing.Size(60, 13);
            logradouroLabel.TabIndex = 13;
            logradouroLabel.Text = "logradouro:";
            // 
            // enderecoLabel
            // 
            enderecoLabel.AutoSize = true;
            enderecoLabel.Location = new System.Drawing.Point(538, 98);
            enderecoLabel.Name = "enderecoLabel";
            enderecoLabel.Size = new System.Drawing.Size(55, 13);
            enderecoLabel.TabIndex = 15;
            enderecoLabel.Text = "endereco:";
            // 
            // compEnderecoLabel
            // 
            compEnderecoLabel.AutoSize = true;
            compEnderecoLabel.Location = new System.Drawing.Point(508, 136);
            compEnderecoLabel.Name = "compEnderecoLabel";
            compEnderecoLabel.Size = new System.Drawing.Size(85, 13);
            compEnderecoLabel.TabIndex = 17;
            compEnderecoLabel.Text = "comp Endereco:";
            // 
            // numEnderecoLabel
            // 
            numEnderecoLabel.AutoSize = true;
            numEnderecoLabel.Location = new System.Drawing.Point(313, 136);
            numEnderecoLabel.Name = "numEnderecoLabel";
            numEnderecoLabel.Size = new System.Drawing.Size(79, 13);
            numEnderecoLabel.TabIndex = 19;
            numEnderecoLabel.Text = "num Endereco:";
            // 
            // bairroLabel
            // 
            bairroLabel.AutoSize = true;
            bairroLabel.Location = new System.Drawing.Point(356, 178);
            bairroLabel.Name = "bairroLabel";
            bairroLabel.Size = new System.Drawing.Size(36, 13);
            bairroLabel.TabIndex = 21;
            bairroLabel.Text = "bairro:";
            // 
            // cidadeLabel
            // 
            cidadeLabel.AutoSize = true;
            cidadeLabel.Location = new System.Drawing.Point(551, 178);
            cidadeLabel.Name = "cidadeLabel";
            cidadeLabel.Size = new System.Drawing.Size(42, 13);
            cidadeLabel.TabIndex = 23;
            cidadeLabel.Text = "cidade:";
            // 
            // estadoLabel
            // 
            estadoLabel.AutoSize = true;
            estadoLabel.Location = new System.Drawing.Point(350, 214);
            estadoLabel.Name = "estadoLabel";
            estadoLabel.Size = new System.Drawing.Size(42, 13);
            estadoLabel.TabIndex = 25;
            estadoLabel.Text = "estado:";
            // 
            // cepLabel
            // 
            cepLabel.AutoSize = true;
            cepLabel.Location = new System.Drawing.Point(565, 214);
            cepLabel.Name = "cepLabel";
            cepLabel.Size = new System.Drawing.Size(28, 13);
            cepLabel.TabIndex = 27;
            cepLabel.Text = "cep:";
            // 
            // sisSaluteDataSet
            // 
            this.sisSaluteDataSet.DataSetName = "SisSaluteDataSet";
            this.sisSaluteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // profissionaisBindingSource
            // 
            this.profissionaisBindingSource.DataMember = "Profissionais";
            this.profissionaisBindingSource.DataSource = this.sisSaluteDataSet;
            // 
            // profissionaisTableAdapter
            // 
            this.profissionaisTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientesTableAdapter = null;
            this.tableAdapterManager.ConsultaTableAdapter = null;
            this.tableAdapterManager.EnderecosTableAdapter = this.enderecosTableAdapter;
            this.tableAdapterManager.InsumoTableAdapter = null;
            this.tableAdapterManager.InsumoTratamentosTableAdapter = null;
            this.tableAdapterManager.ProfissionaisConsultaTableAdapter = null;
            this.tableAdapterManager.ProfissionaisTableAdapter = this.profissionaisTableAdapter;
            this.tableAdapterManager.TratamentosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SisSalute.SisSaluteDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // enderecosTableAdapter
            // 
            this.enderecosTableAdapter.ClearBeforeFill = true;
            // 
            // profissionaisBindingNavigator
            // 
            this.profissionaisBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.profissionaisBindingNavigator.BindingSource = this.profissionaisBindingSource;
            this.profissionaisBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.profissionaisBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.profissionaisBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.profissionaisBindingNavigatorSaveItem});
            this.profissionaisBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.profissionaisBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.profissionaisBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.profissionaisBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.profissionaisBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.profissionaisBindingNavigator.Name = "profissionaisBindingNavigator";
            this.profissionaisBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.profissionaisBindingNavigator.Size = new System.Drawing.Size(1008, 25);
            this.profissionaisBindingNavigator.TabIndex = 0;
            this.profissionaisBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
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
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
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
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
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
            // profissionaisBindingNavigatorSaveItem
            // 
            this.profissionaisBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.profissionaisBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("profissionaisBindingNavigatorSaveItem.Image")));
            this.profissionaisBindingNavigatorSaveItem.Name = "profissionaisBindingNavigatorSaveItem";
            this.profissionaisBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.profissionaisBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.profissionaisBindingNavigatorSaveItem.Click += new System.EventHandler(this.profissionaisBindingNavigatorSaveItem_Click);
            // 
            // codProfissionalLabel1
            // 
            this.codProfissionalLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profissionaisBindingSource, "codProfissional", true));
            this.codProfissionalLabel1.Location = new System.Drawing.Point(812, 25);
            this.codProfissionalLabel1.Name = "codProfissionalLabel1";
            this.codProfissionalLabel1.Size = new System.Drawing.Size(100, 23);
            this.codProfissionalLabel1.TabIndex = 2;
            this.codProfissionalLabel1.Text = "label1";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profissionaisBindingSource, "nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(115, 95);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(100, 20);
            this.nomeTextBox.TabIndex = 4;
            // 
            // especialidadeTextBox
            // 
            this.especialidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profissionaisBindingSource, "especialidade", true));
            this.especialidadeTextBox.Location = new System.Drawing.Point(115, 133);
            this.especialidadeTextBox.Name = "especialidadeTextBox";
            this.especialidadeTextBox.Size = new System.Drawing.Size(100, 20);
            this.especialidadeTextBox.TabIndex = 6;
            // 
            // telefoneTextBox
            // 
            this.telefoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profissionaisBindingSource, "telefone", true));
            this.telefoneTextBox.Location = new System.Drawing.Point(115, 175);
            this.telefoneTextBox.Name = "telefoneTextBox";
            this.telefoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.telefoneTextBox.TabIndex = 8;
            // 
            // celularTextBox
            // 
            this.celularTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profissionaisBindingSource, "celular", true));
            this.celularTextBox.Location = new System.Drawing.Point(115, 211);
            this.celularTextBox.Name = "celularTextBox";
            this.celularTextBox.Size = new System.Drawing.Size(100, 20);
            this.celularTextBox.TabIndex = 10;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profissionaisBindingSource, "email", true));
            this.emailTextBox.Location = new System.Drawing.Point(115, 248);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(100, 20);
            this.emailTextBox.TabIndex = 12;
            // 
            // enderecosBindingSource
            // 
            this.enderecosBindingSource.DataMember = "Enderecos";
            this.enderecosBindingSource.DataSource = this.sisSaluteDataSet;
            // 
            // logradouroTextBox
            // 
            this.logradouroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.enderecosBindingSource, "logradouro", true));
            this.logradouroTextBox.Location = new System.Drawing.Point(398, 95);
            this.logradouroTextBox.Name = "logradouroTextBox";
            this.logradouroTextBox.Size = new System.Drawing.Size(100, 20);
            this.logradouroTextBox.TabIndex = 14;
            // 
            // enderecoTextBox
            // 
            this.enderecoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.enderecosBindingSource, "endereco", true));
            this.enderecoTextBox.Location = new System.Drawing.Point(599, 95);
            this.enderecoTextBox.Name = "enderecoTextBox";
            this.enderecoTextBox.Size = new System.Drawing.Size(225, 20);
            this.enderecoTextBox.TabIndex = 16;
            // 
            // compEnderecoTextBox
            // 
            this.compEnderecoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profissionaisBindingSource, "compEndereco", true));
            this.compEnderecoTextBox.Location = new System.Drawing.Point(599, 133);
            this.compEnderecoTextBox.Name = "compEnderecoTextBox";
            this.compEnderecoTextBox.Size = new System.Drawing.Size(225, 20);
            this.compEnderecoTextBox.TabIndex = 18;
            // 
            // numEnderecoTextBox
            // 
            this.numEnderecoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profissionaisBindingSource, "numEndereco", true));
            this.numEnderecoTextBox.Location = new System.Drawing.Point(398, 133);
            this.numEnderecoTextBox.Name = "numEnderecoTextBox";
            this.numEnderecoTextBox.Size = new System.Drawing.Size(100, 20);
            this.numEnderecoTextBox.TabIndex = 20;
            // 
            // bairroTextBox
            // 
            this.bairroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.enderecosBindingSource, "bairro", true));
            this.bairroTextBox.Location = new System.Drawing.Point(398, 175);
            this.bairroTextBox.Name = "bairroTextBox";
            this.bairroTextBox.Size = new System.Drawing.Size(100, 20);
            this.bairroTextBox.TabIndex = 22;
            // 
            // cidadeTextBox
            // 
            this.cidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.enderecosBindingSource, "cidade", true));
            this.cidadeTextBox.Location = new System.Drawing.Point(599, 175);
            this.cidadeTextBox.Name = "cidadeTextBox";
            this.cidadeTextBox.Size = new System.Drawing.Size(225, 20);
            this.cidadeTextBox.TabIndex = 24;
            // 
            // estadoTextBox
            // 
            this.estadoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.enderecosBindingSource, "estado", true));
            this.estadoTextBox.Location = new System.Drawing.Point(398, 211);
            this.estadoTextBox.Name = "estadoTextBox";
            this.estadoTextBox.Size = new System.Drawing.Size(100, 20);
            this.estadoTextBox.TabIndex = 26;
            // 
            // cepTextBox
            // 
            this.cepTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.enderecosBindingSource, "cep", true));
            this.cepTextBox.Location = new System.Drawing.Point(599, 211);
            this.cepTextBox.Name = "cepTextBox";
            this.cepTextBox.Size = new System.Drawing.Size(225, 20);
            this.cepTextBox.TabIndex = 28;
            // 
            // botaoVoltar
            // 
            this.botaoVoltar.Location = new System.Drawing.Point(760, 368);
            this.botaoVoltar.Name = "botaoVoltar";
            this.botaoVoltar.Size = new System.Drawing.Size(64, 25);
            this.botaoVoltar.TabIndex = 29;
            this.botaoVoltar.Text = "Voltar";
            this.botaoVoltar.UseVisualStyleBackColor = true;
            this.botaoVoltar.Click += new System.EventHandler(this.botaoVoltar_Click);
            // 
            // cadastroProfissionaisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.botaoVoltar);
            this.Controls.Add(cepLabel);
            this.Controls.Add(this.cepTextBox);
            this.Controls.Add(estadoLabel);
            this.Controls.Add(this.estadoTextBox);
            this.Controls.Add(cidadeLabel);
            this.Controls.Add(this.cidadeTextBox);
            this.Controls.Add(bairroLabel);
            this.Controls.Add(this.bairroTextBox);
            this.Controls.Add(numEnderecoLabel);
            this.Controls.Add(this.numEnderecoTextBox);
            this.Controls.Add(compEnderecoLabel);
            this.Controls.Add(this.compEnderecoTextBox);
            this.Controls.Add(enderecoLabel);
            this.Controls.Add(this.enderecoTextBox);
            this.Controls.Add(logradouroLabel);
            this.Controls.Add(this.logradouroTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(celularLabel);
            this.Controls.Add(this.celularTextBox);
            this.Controls.Add(telefoneLabel);
            this.Controls.Add(this.telefoneTextBox);
            this.Controls.Add(especialidadeLabel);
            this.Controls.Add(this.especialidadeTextBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(codProfissionalLabel);
            this.Controls.Add(this.codProfissionalLabel1);
            this.Controls.Add(this.profissionaisBindingNavigator);
            this.MaximumSize = new System.Drawing.Size(1024, 768);
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "cadastroProfissionaisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "cadastroProfissionais";
            this.Load += new System.EventHandler(this.cadastroProfissionais_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sisSaluteDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profissionaisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profissionaisBindingNavigator)).EndInit();
            this.profissionaisBindingNavigator.ResumeLayout(false);
            this.profissionaisBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enderecosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SisSaluteDataSet sisSaluteDataSet;
        private System.Windows.Forms.BindingSource profissionaisBindingSource;
        private SisSaluteDataSetTableAdapters.ProfissionaisTableAdapter profissionaisTableAdapter;
        private SisSaluteDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator profissionaisBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton profissionaisBindingNavigatorSaveItem;
        private System.Windows.Forms.Label codProfissionalLabel1;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox especialidadeTextBox;
        private System.Windows.Forms.TextBox telefoneTextBox;
        private System.Windows.Forms.TextBox celularTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private SisSaluteDataSetTableAdapters.EnderecosTableAdapter enderecosTableAdapter;
        private System.Windows.Forms.BindingSource enderecosBindingSource;
        private System.Windows.Forms.TextBox logradouroTextBox;
        private System.Windows.Forms.TextBox enderecoTextBox;
        private System.Windows.Forms.TextBox compEnderecoTextBox;
        private System.Windows.Forms.TextBox numEnderecoTextBox;
        private System.Windows.Forms.TextBox bairroTextBox;
        private System.Windows.Forms.TextBox cidadeTextBox;
        private System.Windows.Forms.TextBox estadoTextBox;
        private System.Windows.Forms.TextBox cepTextBox;
        private System.Windows.Forms.Button botaoVoltar;
    }
}