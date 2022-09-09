using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using projectexem02.CODE.DTO;
using projectexem02.CODE.BLL;

namespace projectexem02
{
    public partial class Form1 : Form
    {
       
        ClientDTO dto = new ClientDTO();
        ClientBLL bll = new ClientBLL();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (TxtName.Text == "")
            {
                MessageBox.Show("Preencha o campo Nome Completo!");
                TxtName.Focus();
            }
            else if (TxtEmail.Text == "")
            {
                MessageBox.Show("Preencha o campo Email!");
                TxtEmail.Focus();
            }
            else if (TxtEndereco.Text == "")
            {
                MessageBox.Show("Preencha o campo Endereço!");
                TxtEndereco.Focus();
            }
            else
            {
                dto.Nome = TxtName.Text;
                dto.Email = TxtEmail.Text;
                dto.Endereco = TxtEndereco.Text;
                bll.Inserir(dto);
            }

            /*
           
            if(TxtNomeCompleto.Text != "")
            {
                if(TxtEmail.Text != "")
                {
                    if(TxtEndereco.Text != "")
                    {
                        string dados =
                            $"Nome Completo: {TxtNomeCompleto.Text} \n" +
                            $"Email: {TxtEmail.Text} \n" +
                            $"Endereço: {TxtEndereco.Text}";
                        MessageBox.Show(dados);
                    }
                    else
                    {
                        MessageBox.Show("Preencha o campo Endereço!");
                        TxtEndereco.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Preencha o campo Email!");
                    TxtEmail.Focus();
                }
            }
            else
            {
                MessageBox.Show("Preencha o campo Nome Completo!");
                TxtNomeCompleto.Focus();
            }
            */
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            LimparComponentes();
        }
        public void LimparComponentes()
        {
            TxtName.Clear();
            TxtEmail.Clear();
            TxtEndereco.Clear();
        }

        private void btnOK_Click_1(object sender, EventArgs e)
        {
            dto.Nome = TxtName.Text;
            dto.Email = TxtEmail.Text;
            dto.Endereco = TxtEndereco.Text;
            bll.Inserir(dto);
        }
    }
}
