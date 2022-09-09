using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projectexem02.CODE.DTO;
using projectexem02.CODE.DAL;

namespace projectexem02.CODE.BLL
{
    class ClientBLL
    {
        AcessoBancoDados db = new AcessoBancoDados();
        public void Inserir(ClientDTO dto)
        {
            db.Conectar();
            string comando = "insert into cliente(nome,email,endereco) values('" + dto.Nome + "','" + dto.Email + "','" + dto.Endereco + "')";
            db.ExecutarComandoSQL(comando);
        }
    }
}
