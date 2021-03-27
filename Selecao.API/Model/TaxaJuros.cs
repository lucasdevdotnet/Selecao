using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Selecao.API.Model
{
    public class TaxaJuros
    {
        public TaxaJuros()
        {
            this.PorcentagemTaxaJuros = 0.01M;
        }
        public decimal  PorcentagemTaxaJuros { get; set; }
    }
}
