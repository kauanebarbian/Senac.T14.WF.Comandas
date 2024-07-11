using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comandas
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            CriarBancoDeDados();
        }

        // método (visibilidade= private, retrono=void no
        private void CriarBancoDeDados()
        {
            // criar uma variavel do tipo AppDbContext
            // usar a variavel e acessar o contexto
            // executar a migração == F5
            using (var banco = new AppDbContext())
            {
                //executa a migração(CREATE TABLE usuarios)
                banco.Database.Migrate();
            }
        }

        //evento de clique
        private void btnCardapio_Click(object sender, EventArgs e)
        {
            //cria o formulario e exibe
            new FrmCardapio().ShowDialog();
        }

        private void btnComanda_Click_1(object sender, EventArgs e)
        {
            new FrmComanda().ShowDialog();
        }

        private void btnPedidoCozinha_Click(object sender, EventArgs e)
        {
            new FrmPedidoCozinha().ShowDialog();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            new FrmUsuario().ShowDialog();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
