using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mini_imports
{
    public partial class cadprod : Form
    {
        public cadprod()
        {
            InitializeComponent();
        }
        private void ClearAllBoxes()
        {
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls)
                {

                    if (control is TextBox || control is ComboBox)
                    {
                        control.ResetText();
                    }
                    else
                        func(control.Controls);
                }
            };
            func(Controls);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            menu outroform = new menu();
            this.Hide();
            outroform.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ClearAllBoxes();
        }


        private void cadprod_Load(object sender, EventArgs e)
        {

            // TODO: esta linha de código carrega dados na tabela 'mini_imports_realDataSet.CadastrarProdutos'. Você pode movê-la ou removê-la conforme necessário.
            this.cadastrarProdutosTableAdapter.Fill(this.mini_imports_realDataSet.CadastrarProdutos);
            cadastrarProdutosBindingSource.AddNew();



            textBox2.MaxLength = 50; // DESCRICAO
            textBox3.MaxLength = 40; // MARCA
            textBox4.MaxLength = 50; // TAMANHO
            textBox6.MaxLength = 50; // FORNECEDOR

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }


        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            menu frl = new menu();
            this.Hide();
            frl.ShowDialog();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            ClearAllBoxes();
        }

        private void pictureBox2_Click_2(object sender, EventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            cadastrarProdutosBindingSource.EndEdit();
            cadastrarProdutosTableAdapter.Update(mini_imports_realDataSet.CadastrarProdutos);
            this.cadastrarProdutosTableAdapter.Fill(this.mini_imports_realDataSet.CadastrarProdutos);
            cadastrarProdutosBindingSource.MoveLast();
            cadastrarProdutosBindingSource.AddNew();
            MessageBox.Show("Produto cadastrado com sucesso");

            textBox2.Focus();
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            pesquisaprod frl = new pesquisaprod();
            this.Hide();
            frl.Show();
        }
    }
}
