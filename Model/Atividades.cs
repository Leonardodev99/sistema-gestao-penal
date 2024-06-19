using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace system.Model
{
    class Atividades
    {
        public int IdAtividade { get; set; }
        public string NomeAgente { get; set; }
        public string NipAgente { get; set; }
        public DateTime DataHoraRegistro { get; set; }
        public DateTime DataAtividade { get; set; }
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraTermino { get; set; }
        public string TipoAtividade { get; set; }
        public string Descricao { get; set; }
    }
}
