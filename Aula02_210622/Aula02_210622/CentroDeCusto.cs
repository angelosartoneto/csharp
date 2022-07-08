using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula02_210622
{
    internal class CentroDeCusto
    {
        public int Id { get; set; }

        public string descricao { get; set; }

        public DateTime DateTime { get; set; }

        public Decimal VerbaLiberada { get; set; }

        public int AnoVerbaLiberada { get; set; }

        //public CentroDeCusto (int id, string descricao,
           // DateTime dataCriacao, int anoVerbaLiberada);
    }
}
