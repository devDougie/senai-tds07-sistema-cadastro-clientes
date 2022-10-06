
namespace CadastroCliente
{
    partial class frmInterface
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInterface));
            this.lblID = new System.Windows.Forms.Label();
            this.txbID = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txbCidade = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txbEndereco = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txbCelular = new System.Windows.Forms.TextBox();
            this.lblCelular = new System.Windows.Forms.Label();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txbNascimento = new System.Windows.Forms.TextBox();
            this.lblNascimento = new System.Windows.Forms.Label();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLocalizar = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.btnLimpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblID
            // 
            resources.ApplyResources(this.lblID, "lblID");
            this.lblID.Name = "lblID";
            // 
            // txbID
            // 
            resources.ApplyResources(this.txbID, "txbID");
            this.txbID.Name = "txbID";
            // 
            // btnCadastrar
            // 
            resources.ApplyResources(this.btnCadastrar, "btnCadastrar");
            this.btnCadastrar.ForeColor = System.Drawing.Color.Green;
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txbNome
            // 
            resources.ApplyResources(this.txbNome, "txbNome");
            this.txbNome.Name = "txbNome";
            // 
            // lblNome
            // 
            resources.ApplyResources(this.lblNome, "lblNome");
            this.lblNome.Name = "lblNome";
            // 
            // txbCidade
            // 
            resources.ApplyResources(this.txbCidade, "txbCidade");
            this.txbCidade.Name = "txbCidade";
            // 
            // lblCidade
            // 
            resources.ApplyResources(this.lblCidade, "lblCidade");
            this.lblCidade.Name = "lblCidade";
            // 
            // txbEndereco
            // 
            resources.ApplyResources(this.txbEndereco, "txbEndereco");
            this.txbEndereco.Name = "txbEndereco";
            // 
            // lblEndereco
            // 
            resources.ApplyResources(this.lblEndereco, "lblEndereco");
            this.lblEndereco.Name = "lblEndereco";
            // 
            // txbCelular
            // 
            resources.ApplyResources(this.txbCelular, "txbCelular");
            this.txbCelular.Name = "txbCelular";
            // 
            // lblCelular
            // 
            resources.ApplyResources(this.lblCelular, "lblCelular");
            this.lblCelular.Name = "lblCelular";
            // 
            // txbEmail
            // 
            resources.ApplyResources(this.txbEmail, "txbEmail");
            this.txbEmail.Name = "txbEmail";
            // 
            // lblEmail
            // 
            resources.ApplyResources(this.lblEmail, "lblEmail");
            this.lblEmail.Name = "lblEmail";
            // 
            // txbNascimento
            // 
            resources.ApplyResources(this.txbNascimento, "txbNascimento");
            this.txbNascimento.Name = "txbNascimento";
            // 
            // lblNascimento
            // 
            resources.ApplyResources(this.lblNascimento, "lblNascimento");
            this.lblNascimento.Name = "lblNascimento";
            // 
            // btnAtualizar
            // 
            resources.ApplyResources(this.btnAtualizar, "btnAtualizar");
            this.btnAtualizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnExcluir
            // 
            resources.ApplyResources(this.btnExcluir, "btnExcluir");
            this.btnExcluir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.btnSair, "btnSair");
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Name = "btnSair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLocalizar
            // 
            resources.ApplyResources(this.btnLocalizar, "btnLocalizar");
            this.btnLocalizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnLocalizar.Name = "btnLocalizar";
            this.btnLocalizar.UseVisualStyleBackColor = true;
            this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.BackgroundColor = System.Drawing.Color.White;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dgvClientes, "dgvClientes");
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellClick);
            // 
            // btnLimpar
            // 
            resources.ApplyResources(this.btnLimpar, "btnLimpar");
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // frmInterface
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.btnLocalizar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.txbNascimento);
            this.Controls.Add(this.lblNascimento);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txbCelular);
            this.Controls.Add(this.lblCelular);
            this.Controls.Add(this.txbEndereco);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.txbCidade);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txbID);
            this.Controls.Add(this.lblID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInterface";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txbCidade;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox txbEndereco;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.TextBox txbCelular;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txbNascimento;
        private System.Windows.Forms.Label lblNascimento;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLocalizar;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Button btnLimpar;
    }
}

