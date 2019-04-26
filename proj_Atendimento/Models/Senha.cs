using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAtendimento.Models
{
    class Senha
    {
        #region atributos
        private int id;
        private DateTime dataGerac, horaGerac, dataAtend, horaAtend;
        #endregion

        #region propriedades
        public DateTime DataGerac
        {
            get
            {
                return this.dataGerac;
            }
            set
            {
                this.dataGerac = value;
            }
        }
        public DateTime HoraGerac
        {
            get
            {
                return this.horaGerac;
            }
            set
            {
                this.horaGerac = value;
            }
        }
        public DateTime DataAtend
        {
            get
            {
                return this.dataAtend;
            }
            set
            {
                this.dataAtend = value;
            }
        }
        public DateTime HoraAtend
        {
            get
            {
                return this.horaAtend;
            }
            set
            {
                this.horaAtend = value;
            }
        }
        #endregion

        #region metodos
        public Senha(int id)
        {
            this.id = id;
            this.dataGerac = DateTime.Now;
            this.horaGerac = DateTime.Now;
        }
        public string dadosParciais()
        {
            return id + " - " + dataGerac.ToString("dd/MM/yy") + " - " + horaGerac.ToString("HH:mm:ss");
        }

        public string dadosCompletos()
        {
            return id + " - " + dataGerac.ToString("dd/MM/yy") + " - " + horaGerac.ToString("HH:mm:ss") + 
                " - " + dataAtend.ToString("dd/MM/yy") + " - " + horaAtend.ToString("HH:mm:ss");
        }
        #endregion
    }
}
