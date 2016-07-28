namespace SisSalute
{
    partial class inicialForm
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
            this.sisSaluteDataSet = new SisSalute.SisSaluteDataSet();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientesTableAdapter = new SisSalute.SisSaluteDataSetTableAdapters.ClientesTableAdapter();
            this.tableAdapterManager = new SisSalute.SisSaluteDataSetTableAdapters.TableAdapterManager();
            this.painelMenuPrincipal = new System.Windows.Forms.Panel();
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.menuPrincipalArquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrincipalFechar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrincipalCadastros = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrincipalCadastroClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrincipalCadastroProfissionais = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrincipalCadastroTratamentos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrincipalSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.painelPrincipal = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.sisSaluteDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            this.painelMenuPrincipal.SuspendLayout();
            this.menuPrincipal.SuspendLayout();
            this.SuspendLayout();
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
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientesTableAdapter = this.clientesTableAdapter;
            this.tableAdapterManager.ConsultaTableAdapter = null;
            this.tableAdapterManager.EnderecosTableAdapter = null;
            this.tableAdapterManager.InsumoTableAdapter = null;
            this.tableAdapterManager.InsumoTratamentosTableAdapter = null;
            this.tableAdapterManager.ProfissionaisConsultaTableAdapter = null;
            this.tableAdapterManager.ProfissionaisTableAdapter = null;
            this.tableAdapterManager.TratamentosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SisSalute.SisSaluteDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // painelMenuPrincipal
            // 
            this.painelMenuPrincipal.Controls.Add(this.menuPrincipal);
            this.painelMenuPrincipal.Dock = System.Windows.Forms.DockStyle.Top;
            this.painelMenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.painelMenuPrincipal.Name = "painelMenuPrincipal";
            this.painelMenuPrincipal.Size = new System.Drawing.Size(1008, 25);
            this.painelMenuPrincipal.TabIndex = 0;
            this.painelMenuPrincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.painelMenuPrincipal_Paint);
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPrincipalArquivo,
            this.menuPrincipalCadastros,
            this.menuPrincipalSobre});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(1008, 24);
            this.menuPrincipal.TabIndex = 2;
            this.menuPrincipal.Text = "menuPrincipal";
            // 
            // menuPrincipalArquivo
            // 
            this.menuPrincipalArquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPrincipalFechar});
            this.menuPrincipalArquivo.Name = "menuPrincipalArquivo";
            this.menuPrincipalArquivo.Size = new System.Drawing.Size(61, 20);
            this.menuPrincipalArquivo.Text = "Arquivo";
            // 
            // menuPrincipalFechar
            // 
            this.menuPrincipalFechar.Name = "menuPrincipalFechar";
            this.menuPrincipalFechar.Size = new System.Drawing.Size(109, 22);
            this.menuPrincipalFechar.Text = "Fechar";
            this.menuPrincipalFechar.Click += new System.EventHandler(this.menuPrincipalFechar_Click_1);
            // 
            // menuPrincipalCadastros
            // 
            this.menuPrincipalCadastros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPrincipalCadastroClientes,
            this.menuPrincipalCadastroProfissionais,
            this.menuPrincipalCadastroTratamentos});
            this.menuPrincipalCadastros.Name = "menuPrincipalCadastros";
            this.menuPrincipalCadastros.Size = new System.Drawing.Size(71, 20);
            this.menuPrincipalCadastros.Text = "Cadastros";
            // 
            // menuPrincipalCadastroClientes
            // 
            this.menuPrincipalCadastroClientes.Name = "menuPrincipalCadastroClientes";
            this.menuPrincipalCadastroClientes.Size = new System.Drawing.Size(141, 22);
            this.menuPrincipalCadastroClientes.Text = "Clientes";
            this.menuPrincipalCadastroClientes.Click += new System.EventHandler(this.menuPrincipalCadastroClientes_Click_1);
            // 
            // menuPrincipalCadastroProfissionais
            // 
            this.menuPrincipalCadastroProfissionais.Name = "menuPrincipalCadastroProfissionais";
            this.menuPrincipalCadastroProfissionais.Size = new System.Drawing.Size(141, 22);
            this.menuPrincipalCadastroProfissionais.Text = "Profissionais";
            // 
            // menuPrincipalCadastroTratamentos
            // 
            this.menuPrincipalCadastroTratamentos.Name = "menuPrincipalCadastroTratamentos";
            this.menuPrincipalCadastroTratamentos.Size = new System.Drawing.Size(141, 22);
            this.menuPrincipalCadastroTratamentos.Text = "Tratamentos";
            // 
            // menuPrincipalSobre
            // 
            this.menuPrincipalSobre.Name = "menuPrincipalSobre";
            this.menuPrincipalSobre.Size = new System.Drawing.Size(49, 20);
            this.menuPrincipalSobre.Text = "Sobre";
            // 
            // painelPrincipal
            // 
            this.painelPrincipal.BackColor = System.Drawing.Color.Red;
            this.painelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.painelPrincipal.Location = new System.Drawing.Point(0, 25);
            this.painelPrincipal.Name = "painelPrincipal";
            this.painelPrincipal.Size = new System.Drawing.Size(1008, 705);
            this.painelPrincipal.TabIndex = 1;
            this.painelPrincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.painelPrincipal_Paint);
            // 
            // inicialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.painelPrincipal);
            this.Controls.Add(this.painelMenuPrincipal);
            this.MaximumSize = new System.Drawing.Size(1024, 768);
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "inicialForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SisSalute 1.0";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.inicialForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sisSaluteDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            this.painelMenuPrincipal.ResumeLayout(false);
            this.painelMenuPrincipal.PerformLayout();
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private SisSaluteDataSet sisSaluteDataSet;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private SisSaluteDataSetTableAdapters.ClientesTableAdapter clientesTableAdapter;
        private SisSaluteDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel painelMenuPrincipal;
        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem menuPrincipalArquivo;
        private System.Windows.Forms.ToolStripMenuItem menuPrincipalFechar;
        private System.Windows.Forms.ToolStripMenuItem menuPrincipalCadastros;
        private System.Windows.Forms.ToolStripMenuItem menuPrincipalCadastroClientes;
        private System.Windows.Forms.ToolStripMenuItem menuPrincipalCadastroProfissionais;
        private System.Windows.Forms.ToolStripMenuItem menuPrincipalCadastroTratamentos;
        private System.Windows.Forms.ToolStripMenuItem menuPrincipalSobre;
        private System.Windows.Forms.Panel painelPrincipal;
    }
}