using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projectexem02.CODE.DAL;
using projectexem02.CODE.DTO;


namespace projectexem02.CODE.BLL
{
    class productBLL
    {
        AcessoBancoDados db = new AcessoBancoDados();

        public void Inserir(ProductDTO dto)
        {
            db.Conectar();
            string comando= "Insert into produto"+
                "(produto,quantidade_estoque,valor_unitario)"+
                "values('" + dto.Produto + "','" + dto.Quatidade_estoque + "','" + dto.Valor_unitario + "');";
        }

    }
}
