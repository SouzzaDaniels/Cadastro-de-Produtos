using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace Projeto_de_Estágio
{
    public partial class Form1 : Form
    {
        List<Produto> _produtos;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var Produto = new Produto(textBoxNome.Text,
                textBoxDescricao.Text,
                float.Parse(textBoxValor.Text),
                textBoxDisponivel.Text.ToLower() == "sim" ? true : false);

            ProdutoRepositorio.Add(Produto);

            LimparCampos();
            BuscarTodosProdutos();
        }
        private void LimparCampos()
        {
            textBoxNome.Text = string.Empty;
            textBoxDescricao.Text = string.Empty;
            textBoxValor.Text = string.Empty;
            textBoxDisponivel.Text = string.Empty;
        }
        private void BuscarTodosProdutos() 
        {
            _produtos = ProdutoRepositorio.Buscar();

            dgProduto.DataSource = null;
            dgProduto.DataSource = _produtos.OrderByDescending(produto => produto.Valor).ToList();
        }

        private void dgProduto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            BuscarTodosProdutos();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}