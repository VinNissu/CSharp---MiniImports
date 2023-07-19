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
    public partial class cadfor : Form
    {
        public cadfor()
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClearAllBoxes();
        }

        private void cadfor_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'mini_imports_realDataSet.cadastrarFornecedores'. Você pode movê-la ou removê-la conforme necessário.
            this.cadastrarFornecedoresTableAdapter.Fill(this.mini_imports_realDataSet.cadastrarFornecedores);
            cadastrarFornecedoresBindingSource.AddNew();


            textBox1.MaxLength = 50;
            textBox2.MaxLength = 50;
            textBox3.MaxLength = 15;
            textBox4.MaxLength = 15;
            textBox5.MaxLength = 15;
            textBox6.MaxLength = 50;
            textBox7.MaxLength = 15;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Validate();
            cadastrarFornecedoresBindingSource.EndEdit();
            cadastrarFornecedoresTableAdapter.Update(mini_imports_realDataSet.cadastrarFornecedores);
            this.cadastrarFornecedoresTableAdapter.Fill(this.mini_imports_realDataSet.cadastrarFornecedores);
            cadastrarFornecedoresBindingSource.MoveLast();
            cadastrarFornecedoresBindingSource.AddNew();

            textBox2.Focus();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pesquisarfor frl = new pesquisarfor();
            frl.Show();
            this.Visible = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
