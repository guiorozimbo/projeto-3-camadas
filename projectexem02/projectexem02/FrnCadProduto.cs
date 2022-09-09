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

using System.Resources;
[assembly:NeutralResourcesLanguageAttribute("en-US")]

namespace projectexem02
{
    public partial class FrnCadProduto : Form
    {
        ProductDTO dto = new ProductDTO();
        productBLL bll = new productBLL();
        public FrnCadProduto()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            dto.Produto=TxtNameProduto.Text;
            dto.Quatidade_estoque = Convert.ToInt32(TxtQuantidade.Text);
            dto.Valor_unitario = string.Format(TxtValor.Text,"00.00");
            bll.Inserir(dto);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnCleAR_Click(object sender, EventArgs e)
        {
            LimparComponentes();
        }
        public void LimparComponentes()
        {
            TxtNameProduto.Clear();
            TxtQuantidade.Clear();
            TxtValor.Clear();
        }
    }
}
