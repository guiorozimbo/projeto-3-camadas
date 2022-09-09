using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectexem02.CODE.DTO
{
    class ClientDTO
    {
        private int id_cliente;
        private string nome;
        private string email;
        private string endereco;

        public int Id_cliente { get => id_cliente; set => id_cliente = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Email { get => email; set => email = value; }
        public string Endereco { get => endereco; set => endereco = value; }
    }
}
