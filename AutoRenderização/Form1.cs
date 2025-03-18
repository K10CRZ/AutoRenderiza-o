using System;
using System.Drawing;
using System.Windows.Forms;

namespace AutoRenderização
{
    public partial class Form1 : Form
    {
        private bool renderizado = false;
        private TextBox txt_showProducts;
        private TextBox txt_quantidade;

        public Form1()
        {
            InitializeComponent();          
            
        }

        private bool created = false;
        private void createTP()
        {

                txt_showProducts = new TextBox()
                {
                    Name = " txt_mostraProdutos ",
                    Location = new Point(148, 264),
                    Size = new Size(281, 20),
                    Height = 100,
                    Multiline = true,
                    ReadOnly = true

                };

                Label lbl_produto = new Label()
                {
                    Name = "lbl_prod",
                    Text = "Produto",
                    Location = new Point(265, 240),
                    Width = 65,

                };
    
                this.Controls.Add(lbl_produto);
                this.Controls.Add(txt_showProducts);

                created = true;

        }

         private void addElements()
        {

            if (!created)
            {
                createTP();
                
            }

            string nome = txtNome.Text;
            string preco = txtPreco.Text;
            txt_showProducts.Text += $"Nome: {nome} / Preço: {preco} / Quantidade: {txt_quantidade.Text} \r\n";

        }
      
        

        private void Renderizar()
        {
            Label lbl_quantidade = new Label()
            {
                Name = "lbl_quantidade",
                Text = "Quantidade",
                Location = new Point(80, 167),
                Width = 65
            };
            
            this.Controls.Add(lbl_quantidade);

            Label lbl_descricao = new Label()
            {
                Name = "lbl_descricao",
                Text = "Descricao",
                Location = new Point(80, 200),
                Width = 65
            };
            
            this.Controls.Add(lbl_descricao);

            txt_quantidade = new TextBox
            {
                Name = "txt_quantidade",
                Location = new Point(147, 167),
                Width = 100
                //100; 20
            };

            TextBox txt_descricao = new TextBox
            {
                Name = "txt_descricao",
                Location = new Point(147, 200),
                Width = 100,
            

            };

            this.Controls.Add(txt_quantidade);
            this.Controls.Add(txt_descricao);

            Button btn_cadastrar = new Button
            {
                Name = "btn_cadastrar",
                Text = "Cadastrar",
                Location = new Point(311, 170),
                Size = new Size(129, 58),
                               
            };

            this.Controls.Add(btn_cadastrar);

            btn_cadastrar.Click += (s, e) =>
            {
                // Usando txt_quantidade e txt_descricao ao invés de txtNome e txtPreco
                string quantidade = txt_quantidade.Text;
                string descricao = txt_descricao.Text;

                // Coloque a lógica que você quiser aqui. Como exemplo:
                MessageBox.Show($"Produto Cadastrado: {quantidade}, {descricao}");
                        
                            
                addElements();
                renderizado = true;

            };
         }


        private void Form1_Load(object sender, EventArgs e)
        {
            // Você pode chamar o método Renderizar aqui também, caso queira que ele seja chamado ao carregar o formulário.
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            if (!renderizado)
            {
                this.Renderizar();
            }
        }
    }
}
