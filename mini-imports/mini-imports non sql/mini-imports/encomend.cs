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
    public partial class encomend : Form
    {
        public encomend()
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

        private void button5_Click(object sender, EventArgs e)
        {
            pesquisarEncomend outroform = new pesquisarEncomend();
            this.Hide();
            outroform.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClearAllBoxes();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Validate();
            produtosEncomendadosBindingSource.EndEdit();
            produtosEncomendadosTableAdapter.Update(mini_imports_realDataSet.produtosEncomendados);
            this.produtosEncomendadosTableAdapter.Fill(this.mini_imports_realDataSet.produtosEncomendados);
            produtosEncomendadosBindingSource.MoveLast();
            produtosEncomendadosBindingSource.AddNew();

            textBox2.Focus();
        }

        private void encomend_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'mini_imports_realDataSet.produtosEncomendados'. Você pode movê-la ou removê-la conforme necessário.
            //this.produtosEncomendadosTableAdapter.Fill(this.mini_imports_realDataSet.produtosEncomendados);
            produtosEncomendadosBindingSource.AddNew();
        }



    }
}
