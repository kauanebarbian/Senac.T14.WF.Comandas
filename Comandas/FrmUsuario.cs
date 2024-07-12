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
            //metodo que ira inserir usuario no banco
            CriarUsuario();

            //AtualizarUsuario();
            AtualizarUsuario();
        }

        private void AtualizarUsuario()
        {
            using (var banco = new AppDbContext())
            {
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
        }
    }
}
