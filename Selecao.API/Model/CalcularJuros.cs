using Selecao.API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Selecao.API.Model
{
    public class CalcularJuros
    {
        public CalcularJuros()
        {
            this.TaxaJuros = new TaxaJuros();
        }

        public decimal ValorJuros { get; set; }

        public TaxaJuros TaxaJuros { get; set; }

        public decimal ValorFinal { get; set; }

        public decimal CalcularTaxaJuros(decimal valorInicial, int mes)
        {
            var valorJurosMes = Convert.ToDecimal(Math.Pow(Convert.ToDouble(1 + TaxaJuros.PorcentagemTaxaJuros), mes));
            ValorJuros = valorInicial * valorJurosMes;
            ValorFinal = Math.Truncate(100.0M * ValorJuros) / 100.00M;

            return this.ValorFinal;   
        }
  
    }
}
