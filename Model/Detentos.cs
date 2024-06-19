using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace system.Model
{
    class Detentos
    {
        public int IdDetento { get; set; }
        public string Nome { get; set; }
        public string Genero { get; set; }
        public string BI { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Endereco { get; set; }
        public string Crime { get; set; }
        public DateTime DataCrime { get; set; }
        public string SetorPolicial { get; set; }
        public string SentencaPenal { get; set; }
        public DateTime DataSentenca { get; set; }
        public string JuizResponsavel { get; set; }
        public DateTime DataSoltura { get; set; }
        public string Descricao { get; set; }
        public int IdCela { get; set; }
        public int IdCurso { get; set; }
        public string Cela { get; set; }
    }
}
