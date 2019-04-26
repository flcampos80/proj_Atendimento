using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAtendimento.Models
{
    class Guiche
    {
        #region atributos
        private int id;
        private Queue<Senha> atendimentos;
        #endregion

        #region propriedades
        public Queue<Senha> Atendimentos
        {
            get
            {
                return atendimentos;
            }
        }
        #endregion

        #region metodos
        public Guiche()
        {
            id = 0;
            atendimentos = new Queue<Senha>();
        }
        public Guiche(int id)
        {
            this.id = id;
            this.atendimentos = new Queue<Senha>();
        }
        public bool chamar(Queue<Senha> filaSenhas)
        {
            if (filaSenhas.Count == 0) return false;
            Senha agora = filaSenhas.Dequeue();
            agora.DataAtend = DateTime.Now;
            agora.HoraAtend = DateTime.Now;
            atendimentos.Enqueue(agora);
            return true;
        }
        #endregion
    }
}
