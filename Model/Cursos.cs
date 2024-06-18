using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace system.Model
{
    class Cursos
    {
        public int IdCurso { get; set; }
        public string Nome { get; set; }
        public string InstituicaoResponsavel { get; set; }
        public string Local { get; set; }
        public string Duracao { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataTermino { get; set; }
        public string Horario { get; set; }
        public string Descricacao { get; set; }
    }
}
