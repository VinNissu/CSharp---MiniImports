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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'mini_imports_realDataSet.cadastrarFuncionarios'. Você pode movê-la ou removê-la conforme necessário.
            this.cadastrarFuncionariosTableAdapter.Fill(this.mini_imports_realDataSet.cadastrarFuncionarios);


            textBox1.Text = "";
            textBox2.Text = "";

            button2.Enabled = false;
            button1.Enabled = false;




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
            ClearAllBoxes();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0 && textBox2.Text.Length == 0)
            {
                MessageBox.Show("Entre com os dados");
            }
            else
            {
                cadastrarFuncionariosBindingSource.Filter = "cadFun_login='" + textBox5.Text + "'";
                if (textBox1.Text.ToUpper() != textBox5.Text.ToUpper())
                {
                    MessageBox.Show("USUARIO ERRADO");
                    return;
                }

                cadastrarFuncionariosBindingSource.Filter = "cadFun_senha='" + textBox6.Text + "'";
                if (textBox2.Text.ToUpper() != textBox6.Text.ToUpper())
                {
                    MessageBox.Show("SENHA ERRADA");
                    return;
                }

                cadastrarFuncionariosBindingSource.Filter = "cadFun_cargo='" + textBox3.Text + "'";
                if (textBox4.Text.ToUpper() != textBox3.Text.ToUpper())
                {
                    MessageBox.Show("CARGO ERRADO");
                    return;
                }
                menu frl = new menu();
                this.Hide();
                frl.Show();

            }
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length >= 3)
            {
                button2.UseVisualStyleBackColor = false;
                button2.Enabled = true;
                
            }
            else
            {
                button2.Enabled = false;
                button2.UseVisualStyleBackColor = true;

            }

            if (textBox1.Text.Length >= 1)
            {
                button1.UseVisualStyleBackColor = false;
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
                button1.UseVisualStyleBackColor = true;

            }


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
