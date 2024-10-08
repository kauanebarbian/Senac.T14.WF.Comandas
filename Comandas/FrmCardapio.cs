﻿namespace Comandas
{
    public partial class FrmCardapio : Form
    {
        //variaveis locais
        public int ID { get; set; }
        public string? TITULO { get; set; }
        public bool POSSUI_PREPARO { get; set; }
        public string? DESCRICAO { get; set; }
        public decimal PRECO { get; set; }

        public FrmCardapio()
        {
            InitializeComponent();
            ListarCardapios();
        }

        public void ListarCardapios()
        {
            using (var banco = new BancoDeDados())
            {
                var cardapios = banco.Cardapios.ToList();
                dgvCardapio.DataSource = cardapios;
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            var ehNovo = true;
            new FrmCardapioCad(ehNovo, this).ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var ehNovo = false;
            new FrmCardapioCad(ehNovo, ID, TITULO, DESCRICAO, PRECO, POSSUI_PREPARO, this).ShowDialog();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            // criei uma variavel booleana para indicar o tipo da cad
            var ehNovo = true;
            new FrmCardapioCad(ehNovo).ShowDialog();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show($"Confirma a exclusão do item {TITULO} ?", "Excluir Cardapio", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
           if (result == DialogResult.No)
            {
                return;
            }
            //chamar o método excluir 
            if (ExcluirCardapio(ID))
            {
                ListarCardapios();
                //exibe a mensagem de sucesso
                MessageBox.Show($"Cardápio '{TITULO}' excluído com sucesso!");
                //desabilita o botão excluir
                btnExcluir.Enabled = false;
            }
        }

        private bool ExcluirCardapio(int iD)
        {
            //conectar no banco 
            using (var banco = new BancoDeDados())
            {
            //buscar o cardaio atraves do id dele
            //SELECT * FROM Cardapios WHERE id = $iD
                var card = banco.Cardapios.First(c=>c.Id == iD);
            //avisar o banco da exclusao
                banco.Cardapios.Remove(card);
            //confirmar para o banco a açao
                banco.SaveChanges();
            }

            return true;

        }

        private void dgvCardapio_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // obtem o numero da linha clicada
            var numeroLinha = e.RowIndex;
            // verifica se alguma linha foi selecionda
            if (numeroLinha >= 0)
            {
                var id = dgvCardapio.Rows[numeroLinha].Cells["Id"].Value.ToString();
                var titulo = dgvCardapio.Rows[numeroLinha].Cells["Titulo"].Value.ToString();
                var descricao = dgvCardapio.Rows[numeroLinha].Cells["Descricao"].Value.ToString();
                var preco = dgvCardapio.Rows[numeroLinha].Cells["Preco"].Value.ToString();
                var possuiPreparo = dgvCardapio.Rows[numeroLinha].Cells["PossuiPreparo"].Value.ToString();

                // CONVERTER PARA os tipos corretos
                ID = int.Parse(id);
                TITULO = titulo;
                DESCRICAO = descricao;
                PRECO = decimal.Parse(preco);
                POSSUI_PREPARO = bool.Parse(possuiPreparo);

                // habilitar o botão Editar e botão Excluir
                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
            }
        }
    }
}
