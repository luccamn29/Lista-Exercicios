using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeExercicios
{
    public class VendasCarango
    {
        public void ContabilizarVendas()
        {
            var listaVeiculos = new List<Entidades.Veiculo>();
            while (true)
            {
                var veiculo = LerVendas();
                veiculo = CalcularDesconto(veiculo);
                if (veiculo.ValorBase == 0)
                {
                    break;
                }
                listaVeiculos.Add(veiculo);
            }
            EscreverResultados(listaVeiculos);

        }

        public Entidades.Veiculo LerVendas()
        {

            var veiculo = new Entidades.Veiculo();
            Console.WriteLine("Digite o valor do veículo: ");
            veiculo.ValorBase = Convert.ToDecimal(Console.ReadLine());
            if (veiculo.ValorBase != 0)
            {
                Console.WriteLine("Qual o combustível do veículo: ");
                veiculo.TipoCombustivel = Convert.ToInt16(Console.ReadLine());
            }
            return veiculo;
        }

        public Entidades.Veiculo CalcularDesconto(Entidades.Veiculo veiculo)
        {
            switch (veiculo.TipoCombustivel)
            {
                case 1:
                    veiculo.ValorDesconto = veiculo.ValorBase * 0.25M;
                    break;
                case 2:
                    veiculo.ValorDesconto = veiculo.ValorBase * 0.21M;
                    break;
                case 3:
                    veiculo.ValorDesconto = veiculo.ValorBase * 0.14M;
                    break;
            }
            veiculo.ValorFinal = veiculo.ValorBase - veiculo.ValorDesconto;
            return veiculo;

        }

        public void EscreverResultados(List<Entidades.Veiculo> listaVeiculos)
        {
            decimal totalDesconto = 0, totalPago = 0;
            foreach (var veiculo in listaVeiculos)
            {
                totalDesconto += veiculo.ValorDesconto;
                totalPago += veiculo.ValorFinal;

            }
            Console.WriteLine("Total desconto: " + totalDesconto);
            Console.WriteLine("Total a ser pago: " + totalPago);
        }
    }
}

