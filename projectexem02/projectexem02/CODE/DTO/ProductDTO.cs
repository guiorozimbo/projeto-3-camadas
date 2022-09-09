using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectexem02.CODE.DTO
{
    class ProductDTO
    {
        private int id_produto;
        private string produto;
        private int quatidade_estoque;
        private string valor_unitario;

        public int Id_produto { get => id_produto; set => id_produto = value; }
        public string Produto { get => produto; set => produto = value; }
        public int Quatidade_estoque { get => quatidade_estoque; set => quatidade_estoque = value; }
        public string Valor_unitario { get => valor_unitario; set => valor_unitario = value; }
    }
}
