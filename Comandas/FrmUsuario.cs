using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comandas
{
    public partial class FrmUsuario : Form
    {
        private bool ehNovo;

        public FrmUsuario()
        {
            InitializeComponent();
            //metodo que lista os usuarios
            ListarUsuarios();
        }

        private void ListarUsuarios()
        {
            //1.conectar no banco
            using (var banco = new AppDbContext())
            {
                //2.SELECT * FROM usuarios
                var usuarios = banco.Usuarios.ToList();
                //3.popular a tabela na tela DataGridView
                dgvUsuarios.DataSource = usuarios;

            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ehNovo)
                CriarUsuario();
            else
                AtualizarUsuario();

            DesabilitarCampos();
            ListarUsuarios();
            LimparCampos();
            btnNovo.Enabled = true;
            btnEditar.Enabled = false;
            btnSalvar.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = false;
        }

        private void LimparCampos()
        {
            txtId.TextButton = string.Empty;
            txtNome.TextButton = string.Empty;
            txtEmail.TextButton = string.Empty;
            txtSenha.TextButton = string.Empty;
        }

        private void AtualizarUsuario()
        {
            using (var banco = new AppDbContext())
            {
                var id = int.Parse(txtId.TextButton);

                //consulta usuario na tabela usando o Id da tela
                var usuario = banco
                    .Usuarios
                    .Where(e => e.Id == int.Parse(txtId.TextButton))
                    .FirstOrDefault();
                usuario.Nome = txtNome.TextButton;
                usuario.Email = txtEmail.TextButton;
                usuario.Senha = txtSenha.TextButton;
                banco.SaveChanges();
            }


        }


        private void CriarUsuario()
        {
            //acessar o banco 

            using (var banco = new AppDbContext())
            {
                //criar variavel
                var novoUsuario = new Usuario();
                novoUsuario.Nome = txtNome.TextButton;
                novoUsuario.Email = txtEmail.TextButton;
                novoUsuario.Senha = txtSenha.TextButton;
                //salvar as alterãções(INSERT INTO usuarios)
                banco.Usuarios.Add(novoUsuario);
                banco.SaveChanges();

                MessageBox.Show("Usuário cadastrado com sucesso");
            }

            //criar novo ususario 

            //salvar alterações
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            ehNovo = true;
            HabilitarCampos();
        }

        private void HabilitarCampos()
        {
            txtNome.Enabled = true;
            txtEmail.Enabled = true;
            txtSenha.Enabled = true;
        }
        private void DesabilitarCampos()
        {
            txtNome.Enabled = false;
            txtEmail.Enabled = false;
            txtSenha.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void txtNome_Load(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ehNovo = false;
            HabilitarCampos();
            btnNovo.Enabled = false;
            btnEditar.Enabled = false;
            btnSalvar.Enabled = true;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = false;
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            LimparCampos();
            btnNovo.Enabled = true;
            btnEditar.Enabled = false;
            btnSalvar.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = false;
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            CarregarUsuarios();
        }

        private void CarregarUsuarios()
        {
            //conectar no banco 
            using (var banco = new AppDbContext())
            {
                //Realizar consulta na tabela usuarios
                var usuarios = banco.Usuarios.ToList();
                //popular os dados do grid()
                dgvUsuarios.DataSource = usuarios;
            }
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //verifica se o indice da linha é maior ou igual a 0 
            //saber se existe uma linha selecionada
            if (e.RowIndex >= 0)
            {
                //mensage "Linha selecionada 1"
                //MessageBox.Show("Linha selecionada" + (e.RowIndex + 1));

                //obter dados da linha
                var id = dgvUsuarios.Rows[e.RowIndex].Cells["id"].Value.ToString();
                var nome = dgvUsuarios.Rows[e.RowIndex].Cells["Nome"].Value.ToString();
                var email = dgvUsuarios.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                var senha = dgvUsuarios.Rows[e.RowIndex].Cells["Senha"].Value.ToString();

                txtId.TextButton = id;
                txtNome.TextButton = nome;
                txtEmail.TextButton = email;
                txtSenha.TextButton = senha;

                btnEditar.Enabled = true;
                btnNovo.Enabled = false;
                btnSalvar.Enabled = false;
                btnCancelar.Enabled = false;
                btnExcluir.Enabled = true;
            }
        }

        private void txtNome_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //obtem o id do usuario da tela 
            var idUsuario = Convert.ToInt32(txtId.Text);
            //chama o método que exclui da tabela usuario
            ExcluirUsuario(idUsuario);
            ListarUsuarios();
            LimparCampos();
            btnNovo.Enabled = true;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            MessageBox.Show("Usuário excluído com sucesso");
        }

        private void ExcluirUsuario(int idUsuario)
        {
            //conectar no banco de dados, consultar o usuario, avisar o banco que estou excluindo, confirmar exclusão
            using (var banco = new AppDbContext())
            {
                var usuario = banco.Usuarios.First(u => u.Id.Equals(idUsuario));

                banco.Usuarios.Remove(usuario);

                banco.SaveChanges();
            }
        }
    }
}