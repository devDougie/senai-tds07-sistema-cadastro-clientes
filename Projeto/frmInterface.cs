using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroCliente
{
    public partial class frmInterface : Form
    {
        public frmInterface()
        {
            InitializeComponent();
        }

        //Carregando o DataGridView com informações do Banco de Dados:
        private void Form1_Load(object sender, EventArgs e)
        {
            Cadastro cadastro = new Cadastro();
            List<Cadastro> cadastros = cadastro.listaClientes();
            dgvClientes.DataSource = cadastros;

            this.txbNome.Focus();

            btnAtualizar.Enabled = false; //Carrega o Form com o botão 'Atualizar' desabilitado;
            btnExcluir.Enabled = false; //Carrega o Form com o botão 'Excluir' desabilitado;
        }

        //Botão Cadastrar (verifica se campos obrigatórios foram preenchidos e se o cadastro já existe):
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txbNome.Text != "" && txbCelular.Text != "" && txbEmail.Text != "")
            {
                Cadastro cadastro = new Cadastro();
                if (cadastro.VerificarCadastro(txbNome.Text, txbEmail.Text) == false) //Verifica se o cliente já está no banco de dados;
                {
                    cadastro.Inserir(txbNome.Text, txbCidade.Text, txbEndereco.Text, txbCelular.Text, txbEmail.Text, txbNascimento.Text);
                    MessageBox.Show("Cliente CADASTRADO com sucesso!");
                    List<Cadastro> cadastros = cadastro.listaClientes();
                    dgvClientes.DataSource = cadastros;
                    txbNome.Text = "";
                    txbCidade.Text = "";
                    txbEndereco.Text = "";
                    txbCelular.Text = "";
                    txbEmail.Text = "";
                    txbNascimento.Text = "";

                    btnAtualizar.Enabled = false; //Desabilita o botão 'Atualizar' depois do botão 'Localizar' ter habilitado;
                    btnExcluir.Enabled = false; //Desabilita o botão 'Excluir' depois do botão 'Localizar' ter habilitado;
                }
                else
                {
                    MessageBox.Show("Este cliente já está cadastrado.");
                }
            }
            else
            {
                MessageBox.Show("Os campos de Nome, Celular e Email são obrigatórios.");
            }
        }

        //Botão Atualizar:
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbID.Text.Trim());
            Cadastro cadastro = new Cadastro();
            cadastro.Atualizar(id, txbNome.Text, txbCidade.Text, txbEndereco.Text, txbCelular.Text, txbEmail.Text, txbNascimento.Text);
            MessageBox.Show("Cliente ATUALIZADO com sucesso!");
            List<Cadastro> cadastros = cadastro.listaClientes();
            dgvClientes.DataSource = cadastros;
            txbID.Text = "";
            txbNome.Text = "";
            txbCidade.Text = "";
            txbEndereco.Text = "";
            txbCelular.Text = "";
            txbEmail.Text = "";
            txbNascimento.Text = "";

            btnAtualizar.Enabled = false; //Desabilita o botão 'Atualizar' depois do botão 'Localizar' ter habilitado;
            btnExcluir.Enabled = false; //Desabilita o botão 'Excluir' depois do botão 'Localizar' ter habilitado;
        }

        //Botão Excluir:
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbID.Text.Trim());
            Cadastro cadastro = new Cadastro();
            cadastro.Excluir(id);
            MessageBox.Show("Cliente EXCLUÍDO com sucesso!");
            List<Cadastro> cadastros = cadastro.listaClientes();
            dgvClientes.DataSource = cadastros;
            txbID.Text = "";
            txbNome.Text = "";
            txbCidade.Text = "";
            txbEndereco.Text = "";
            txbCelular.Text = "";
            txbEmail.Text = "";
            txbNascimento.Text = "";

            btnAtualizar.Enabled = false; //Desabilita o botão 'Atualizar' depois do botão 'Localizar' ter habilitado;
            btnExcluir.Enabled = false; //Desabilita o botão 'Excluir' depois do botão 'Localizar' ter habilitado;
        }

        //Botão Localizar (verifica se o campo do ID está vazio e se o ID existe no banco de dados):
        private void btnLocalizar_Click(object sender, EventArgs e) 
        {
            int id = Convert.ToInt32(txbID.Text.Trim());
            if(txbID.Text != "" && id > 0) //Verifica se a textbox está vazia e se o ID digitado é maior que zero;
            {
                Cadastro cadastro = new Cadastro();
                if (cadastro.VerificarID(id) != false) //Verifica se o ID existe no banco de dados;
                {
                    cadastro.Localizar(id);
                    MessageBox.Show("Cliente ENCONTRADO com sucesso!");
                    txbNome.Text = cadastro.nome;
                    txbCidade.Text = cadastro.cidade;
                    txbEndereco.Text = cadastro.endereco;
                    txbCelular.Text = cadastro.celular;
                    txbEmail.Text = cadastro.email;
                    txbNascimento.Text = cadastro.nascimento;

                    btnAtualizar.Enabled = true; //Habilita o botão 'Atualizar' após localizar algum registro (cliente);
                    btnExcluir.Enabled = true; //Habilita o botão 'Excluir' após localizar algum registro (cliente);
                }
                else
                {
                    MessageBox.Show("O ID não foi encontrado.");
                }  
            }
            else
            {
                MessageBox.Show("Por favor digite um IP válido.");
            }
        }

        //Botão Limpar (limpa todos os campos):
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbID.Text = "";
            txbID.Text = "";
            txbNome.Text = "";
            txbCidade.Text = "";
            txbEndereco.Text = "";
            txbCelular.Text = "";
            txbEmail.Text = "";
            txbNascimento.Text = "";

            btnAtualizar.Enabled = false; //Desabilita o botão 'Atualizar' depois do botão 'Localizar' ter habilitado;
            btnExcluir.Enabled = false; //Desabilita o botão 'Excluir' depois do botão 'Localizar' ter habilitado;
        }

        //Botão Sair:
        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Deseja realmente fechar o aplicativo?", "Fechar Aplicativo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //Evento de Click para selecionar o cadastro direto da tabela do 'DataGridView':
        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow linha = this.dgvClientes.Rows[e.RowIndex];
                linha.Selected = true;
                txbID.Text = linha.Cells[0].Value.ToString();
                txbNome.Text = linha.Cells[1].Value.ToString();
                txbCidade.Text = linha.Cells[2].Value.ToString();
                txbEndereco.Text = linha.Cells[3].Value.ToString();
                txbCelular.Text = linha.Cells[4].Value.ToString();
                txbEmail.Text = linha.Cells[5].Value.ToString();
                txbNascimento.Text = linha.Cells[6].Value.ToString();

                btnAtualizar.Enabled = true;
                btnExcluir.Enabled = true;
            }
        }
    }
}
