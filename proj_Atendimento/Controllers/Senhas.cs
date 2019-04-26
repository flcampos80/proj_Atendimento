using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoAtendimento.Models;

namespace ProjetoAtendimento.Controllers
{
    class Senhas
    {
        #region atributos
        private int proximoAtendimento;
        private Queue<Senha> filaSenhas;
        #endregion

        #region propriedades
        public Queue<Senha> FilaSenhas
        {
            get
            {
                return filaSenhas;
            }
        }
        #endregion

        #region metodos
        public Senhas()
        {
            proximoAtendimento = 1;
            filaSenhas = new Queue<Senha>();
        }

        public void gerar()
        {
            filaSenhas.Enqueue(new Senha(proximoAtendimento));
            proximoAtendimento++;
        }
        #endregion
    }
}
