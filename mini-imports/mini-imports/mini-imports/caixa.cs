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
    public partial class caixa : Form
    {
        public caixa()
        {
            InitializeComponent();
        }

        private void caixa_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'mini_imports_realDataSet.CadastrarProdutos'. Você pode movê-la ou removê-la conforme necessário.
            this.cadastrarProdutosTableAdapter.Fill(this.mini_imports_realDataSet.CadastrarProdutos);

            button3.Enabled = false;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Length != 0)
            {
                cadastrarProdutosBindingSource.Filter = String.Format("cadProd_id = {0}", textBox2.Text);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pesquisa = textBox2.Text;
            foreach (DataGridViewRow row in
                dataGridView1.SelectedRows)
            {
                if (row.Cells[0].Value.ToString().Contains(pesquisa))
                {
                    Produtos.Items.Add(row.Cells[1].Value.ToString()
                        + " | " +
                        row.Cells[2].Value.ToString()
                        + " | R$ " +
                        row.Cells[5].Value.ToString()
                        );

                    listBox1.Items.Add (row.Cells[5].Value.ToString());
                    double valorTotal = 0.00;

                    listBox2.Items.Add(row.Cells[0].Value.ToString());

                    foreach (string v in listBox1.Items)
                    {
                        double dv = Double.Parse(v);

                        valorTotal += dv;


                       
                    }
                    textBox1.Text = "Valor total: " + "R$" + valorTotal.ToString();
                    
                    break;

                }


            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Produtos.Items.Count > 0)
            {
                string pesquisa = textBox2.Text;
                foreach (DataGridViewRow row in
                    dataGridView1.SelectedRows)
                {
                    if (row.Cells[0].Value.ToString().Contains(pesquisa))
                    {
                        Produtos.Items.Remove(
                            row.Cells[1].Value.ToString()
                             + " | " +
                            row.Cells[2].Value.ToString()
                              + " | R$ " +
                            row.Cells[5].Value.ToString()
                            );



                        listBox1.Items.Remove(row.Cells[5].Value.ToString());
                        double valorTotal = 0.00;

                        foreach (string v in listBox1.Items)
                        {
                            double dv = Double.Parse(v);
                            valorTotal += dv;
                        }
                        textBox1.Text = "Valor total: " + valorTotal.ToString();

                        break;

                    }


                }
                MessageBox.Show("O item foi removido com sucesso", "Remoção de item", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }

        }

            private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }


        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label2.Visible = false;
            button3.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            menu frl = new menu();
            this.Hide();
            frl.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Finalizando operação");

            MessageBox.Show("Valores abatido do estoque");

            caixa frl = new caixa();
            this.Hide();
            frl.ShowDialog();


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
