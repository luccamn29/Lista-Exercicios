using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeExercicios
{
    public class Exercicios
    {
        public void Exercicio01()
        {
            int numeroSoma1, numeroSoma2, soma;

            Console.WriteLine("Digite o primeiro número: ");
            numeroSoma1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            numeroSoma2 = Convert.ToInt32(Console.ReadLine());
            soma = numeroSoma1 + numeroSoma2;
            Console.WriteLine(numeroSoma1 + " + " + numeroSoma2 + " = " + soma);
        }
        public void Exercicio02()
        {
            decimal numero1, numero2, soma, subtracao, multiplicacao, divisao;

            Console.WriteLine("Digite o primeiro número: ");
            numero1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            numero2 = Convert.ToDecimal(Console.ReadLine());
            soma = numero1 + numero2;
            subtracao = numero1 - numero2;
            multiplicacao = numero1 * numero2;
            divisao = numero1 / numero2;
            Console.WriteLine(numero1 + " + " + numero2 + " = " + soma);
            Console.WriteLine(numero1 + " - " + numero2 + " = " + subtracao);
            Console.WriteLine(numero1 + " * " + numero2 + " = " + multiplicacao);
            Console.WriteLine(numero1 + " / " + numero2 + " = " + divisao);
        }
        // EXERCICIO 03
        public void Exercicio03()
        {
            int opcao = 0;
            Console.WriteLine("Digite a opcäo desejada: ");
            Console.WriteLine("1 - Calcular o consumo de gasolina do veículo");
            Console.WriteLine("2 - Calcular a distância máxima a partir do consumo e abastecimento");
            Console.WriteLine("3 - Calcular ambos simultaneamente");
            opcao = Convert.ToInt32(Console.ReadLine());
            switch (opcao)
            {
                case 0:
                    break;

                case 1:
                    CalculoAutonomia();
                    break;

                case 2:
                    DistanciaPercorrida();
                    break;

                case 3:
                    decimal consumoCarro = CalculoAutonomia(true);
                    DistanciaPercorrida(true, consumoCarro);
                    break;

            }

        }
        // Método auxiliar Exercicio 03 para calculo de autonomia
        public decimal CalculoAutonomia(bool case3 = false)
        {
            decimal distanciaTotal, combustivelGasto;
            decimal? consumoCarro;
            Console.WriteLine("Digite a distância total percorrida");
            distanciaTotal = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite a quanto gastou de combustível");
            combustivelGasto = Convert.ToDecimal(Console.ReadLine());

            consumoCarro = distanciaTotal / combustivelGasto;
            if (!case3)
            {
                Console.WriteLine("O consumo médio do seu carro é de " + consumoCarro + " km/l.");
            }
            return consumoCarro.Value;


        }
        // Método auxiliar Exercicio03 para calculo de distäncia percorrida
        public void DistanciaPercorrida(bool case3 = false, decimal consumoCarro = 0)
        {
            decimal litrosAbastecidos, distanciaMaxima;
            if (!case3)
            {
                Console.WriteLine("Digite o consumo do carro em km/l");
                consumoCarro = Convert.ToDecimal(Console.ReadLine());
            }

            Console.WriteLine("Digite quantos litros foram abastecidos");
            litrosAbastecidos = Convert.ToDecimal(Console.ReadLine());

            distanciaMaxima = consumoCarro * litrosAbastecidos;
            Console.WriteLine("Você conseguirá percorrer " + distanciaMaxima);

        }
        public void Exercicio04()
        {
            String nomeVendedor;
            decimal salarioVendedor, vendasMes, comissaoVendedor, salarioTotal;

            Console.WriteLine("Escreva o nome do vendedor: ");
            nomeVendedor = Console.ReadLine();

            Console.WriteLine("Escreva o salário do vendedor: ");
            salarioVendedor = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Escreva em R$ as vendas do vendedor no mês: ");
            vendasMes = Convert.ToDecimal(Console.ReadLine());

            comissaoVendedor = vendasMes * 0.15M;
            salarioTotal = salarioVendedor + comissaoVendedor;

            Console.WriteLine("O vendedor " + nomeVendedor + " recebeu no mês R$ " + salarioTotal + ", sendo R$ " + salarioVendedor + " de salário fixo.");
        }
        public void Exercicio05()
        {
            string nomeAluno;
            decimal media = 0;
            int cnt = 0;

            Console.WriteLine("Digite o nome do aluno");
            nomeAluno = Console.ReadLine();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Digite a nota da: " + (i + 1) + "ª prova");
                media += Convert.ToDecimal(Console.ReadLine());
                cnt++;
            }
            media = media / cnt;
            Console.WriteLine("O aluno " + nomeAluno + " teve uma média de " + media + " pontos.");

        }
        public void Exercicio06()
        {
            int a, b, troca = 0;
            Console.WriteLine("Digite o valor de A");
            a = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Digite o valor de B");
            b = Convert.ToInt16(Console.ReadLine());

            troca = a;
            a = b;
            b = troca;

            Console.WriteLine("O novo valor de A é: " + a);
            Console.WriteLine("O novo valor de B é: " + b);

        }
        public void Exercicio07()
        {
            decimal tempC, tempF;
            Console.WriteLine("Digite a temperatura em Graus Celius");
            tempC = Convert.ToDecimal(Console.ReadLine());
            tempF = (9 * tempC + 160) / 5;
            Console.WriteLine("A temperatura em Graus Fahrenheit é " + tempF);
        }
        public void Exercicio08()
        {
            decimal cotacaoDolar, saldoDolar, saldoReais;
            Console.WriteLine("Digite a cotação atual do dólar");
            cotacaoDolar = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digte seu saldo em dólares:");
            saldoDolar = Convert.ToDecimal(Console.ReadLine());

            saldoReais = saldoDolar * cotacaoDolar;
            Console.WriteLine("Seu saldo em reais é R$ " + saldoReais);
        }
        public void Exercicio09()
        {
            decimal depositoInicial, valorFinal;
            int meses;
            Console.WriteLine("Digite o valor depositado");
            depositoInicial = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Digite quantos meses o dinheiro ficará investido");
            meses = Convert.ToInt32(Console.ReadLine());
            valorFinal = depositoInicial;
            for (int i = 0; i < meses; i++)
            {
                valorFinal = (valorFinal * 1.007M);
            }
            Console.WriteLine("Após um mês, o valor com rendimento será R$ " + valorFinal);

        }
        public void Exercicio10()
        {
            decimal valorCompra, valorPrestacao;
            Console.WriteLine("Digite o valor total da compra");
            valorCompra = Convert.ToDecimal(Console.ReadLine());

            valorPrestacao = valorCompra / 5;
            Console.WriteLine("O valor de cada uma das 5 prestações será de R$ " + valorPrestacao);
        }
        public void Exercicio11()
        {
            decimal custoProduto, margemLucro, precoVenda;
            Console.WriteLine("Digite o custo do produto");
            custoProduto = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite a margem de lucro (de 0 a 100)");
            margemLucro = Convert.ToDecimal(Console.ReadLine());

            precoVenda = custoProduto + (custoProduto * (margemLucro / 100));
            Console.WriteLine("O preco de venda será de R$ " + precoVenda);
        }
        public void Exercicio12()
        {
            decimal custoFabrica;
            Console.WriteLine("Digite o custo de fábrica do carro: ");
            custoFabrica = Convert.ToDecimal(Console.ReadLine());

            custoFabrica *= 1.45M;
            custoFabrica *= 1.28M;

            Console.WriteLine("O preço final do carro para o consumidor será " + custoFabrica);
        }
        public void Exercicio13()
        {
            int numero;
            Console.WriteLine("Digite o número que quer verificar se é maior que 10.");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero > 10)
            {
                Console.WriteLine("O número " + numero + " é maior que 10.");
            }
            else
            {
                Console.WriteLine("O número " + numero + " não é maior que 10.");
            }

        }
        public void Exercicio14()
        {
            int numero1, numero2;
            Console.WriteLine("Digite o primeiro número");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo número");
            numero2 = Convert.ToInt32(Console.ReadLine());

            if (numero1 < numero2)
            {
                Console.WriteLine(numero1 + " < " + numero2);
            }
            else if (numero1 == numero2)
            {
                Console.WriteLine(numero1 + " = " + numero2);
            }
            else
            {
                Console.WriteLine(numero1 + " > " + numero2);
            }

        }
        public void Exercicio15()
        {
            int numero;
            Console.WriteLine("Digite o número que quer verificar se está entre 100 e 200");
            numero = Convert.ToInt32(Console.ReadLine());

            if (100 < numero
                && numero < 200)
            {
                Console.WriteLine("O número " + numero + " está entre 100 e 200");
            }
            else
            {
                Console.WriteLine("O número " + numero + " não está entre 100 e 200");
            }
        }
        public void Exercicio16()
        {
            string nomeAluno;
            decimal notasAluno = 0, mediaAluno;
            Console.WriteLine("Digite o nome do aluno");
            nomeAluno = Console.ReadLine();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Digita a nota da " + (i + 1) + "ª prova");
                notasAluno += Convert.ToDecimal(Console.ReadLine());
            }
            mediaAluno = notasAluno / 3;
            Console.WriteLine("A média do aluno " + nomeAluno + " foi " + mediaAluno + ".");
            if (mediaAluno >= 7)
            {
                Console.WriteLine("SITUAÇÃO: APROVADO");
            }
            else if (mediaAluno >= 5.1M)
            {
                Console.WriteLine("SITUAÇÃO: RECUPERAÇÃO");
            }
            else
            {
                Console.WriteLine("SITUAÇÃO: REPROVADO");
            }
        }
        public void Exercicio17()
        {
            int contador = 0, numero;
            for (int i = 0; i < 80; i++)
            {
                Console.WriteLine("Digite  o numero");
                numero = Convert.ToInt32(Console.ReadLine());
                if (numero >= 10
                    && numero <= 150)
                {
                    contador++;
                }
            }
            Console.WriteLine(contador + " numeros estão entre 10 e 150.");

        }
        public void Exercicio18()
        {
            int idade;
            for (int i = 0; i < 75; i++)
            {
                Console.WriteLine("Digite  a idade");
                idade = Utilities.validacaoIdade();
                if (idade >= 18)
                {
                    Console.WriteLine("Maior de idade");
                }
                else
                {
                    Console.WriteLine("Menor de idade");
                }
            }
        }
        public void Exercicio19()
        {
            char sexo = 'a';
            int contadorF = 0, contadorM = 0;
            for (int i = 0; i < 56; i++)
            {
                sexo = Utilities.validacaoSexo();

                if (sexo.Equals('F'))
                {
                    contadorF++;
                    sexo = 'a';
                }
                else if (sexo.Equals('M'))
                {
                    contadorM++;
                    sexo = 'a';
                }
            }
            Console.WriteLine("Total de homens: " + contadorM);
            Console.WriteLine("Total de mulheres: " + contadorF);

        }
        public void Exercicio20()
        {
            decimal precoCarro, valorTotal = 0, descontoTotal = 0;
            int anoCarro, ate2000 = 0;
            char continuar = 'a';

            while (continuar != 'N')
            {
                Console.WriteLine("Digite o valor do carro");
                precoCarro = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Digite o ano do carro");
                anoCarro = Convert.ToInt32(Console.ReadLine());

                if (anoCarro <= 2000)
                {
                    valorTotal += (precoCarro * 0.88M);
                    descontoTotal += (precoCarro * 0.12M);
                    ate2000++;
                }
                else
                {
                    valorTotal += (precoCarro * 0.93M);
                    descontoTotal += (precoCarro * 0.07M);
                }
                Console.WriteLine("Digite n se já acabou ou qualquer outra tecla para continuar: ");
                continuar = char.ToUpper(Convert.ToChar(Console.ReadLine()));
            }
            Console.WriteLine("Valor total: " + valorTotal);
            Console.WriteLine("Desconto total: " + descontoTotal);
            Console.WriteLine("Carros de 2000 ou mais antigos: " + ate2000);


        }
        public void Exercicio21()
        {
            string nome = "a";
            int idade, saude, sexo, totalAptos = 0;
            while (true)
            {
                Console.WriteLine("Digite o nome ou pressione enter para terminar:");
                nome = Console.ReadLine();
                if (nome == "")
                {
                    break;
                }

                sexo = Utilities.validacaoSexo();

                Console.WriteLine("Como está sua saúde?\n1- Boa\n2- Ruim");
                saude = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite a idade:");
                idade = Utilities.validacaoIdade();

                if (idade == 18 && saude == 1 && sexo == 'M')
                {
                    Console.WriteLine(nome + " deverá cumprir o serviço militar obrigatório.");
                    totalAptos++;
                }
                else
                {
                    Console.WriteLine(nome + "  não deverá cumprir o serviço militar obrigatório.");
                }
                Console.Clear();

            }
            Console.WriteLine("No total, " + totalAptos + " deverão cumprir serviço militar obrigatório");
        }
        public void Exercicio22()
        {
            decimal precoCusto, precoVenda, somaCusto = 0, somaVenda = 0;

            for (int i = 0; i < 40; i++)
            {
                Console.WriteLine("Digite o preco de custo do produto " + (i + 1) + ":");
                precoCusto = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Digite o preco de venda do produto " + (i + 1) + ":");
                precoVenda = Convert.ToDecimal(Console.ReadLine());
                if (precoVenda > precoCusto)
                {
                    Console.WriteLine("O produto " + (i + 1) + " deu lucro!");
                }
                else if (precoVenda == precoCusto)
                {
                    Console.WriteLine("O produto " + (i + 1) + " não deu lucro nem prejuízo!");
                }
                else
                {
                    Console.WriteLine("O produto" + (i + 1) + " deu prejuízo");
                }
                somaCusto += precoCusto;
                somaVenda += precoVenda;
            }
            somaCusto = somaCusto / 40;
            somaVenda = somaVenda / 40;
            Console.WriteLine("A média de preço de custo foi de R$" + somaCusto);
            Console.WriteLine("A média de preço de venda foi de R$" + somaVenda);

        }
        public void Exercicio23()
        {
            Console.WriteLine("Digite o número:");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero > 80 || numero < 25 || numero == 40)
            {
                Console.WriteLine("O número " + numero + " é maior que 80, menor que 25 ou igual a 40.");
            }
        }
        public void Exercicio24()
        {
            int numero = 0;
            while (true)
            {
                Console.WriteLine("Digite o número ou aperte enter para sair:");
                try
                {
                    numero = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();

                    if (numero > 0)
                    {
                        Console.WriteLine("O número " + numero + " é positivo.");
                    }
                    else if (numero < 0)
                    {
                        Console.WriteLine("O número " + numero + " é negativo.");
                    }
                    else
                    {
                        Console.WriteLine("O número " + numero + " é 0.");
                    }
                }
                catch (Exception)
                {
                    break;
                }

                
            }
            
        }
        public void Exercicio25()
        {
            int numero1, numero2;
            Console.WriteLine("Digite o primeiro número: ");
            numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            numero2 = Convert.ToInt32(Console.ReadLine());

            if (numero1 > numero2)
            {
                Console.WriteLine(numero1 + ">" + numero2);
            }
            else if (numero1 < numero2)
            {
                Console.WriteLine(numero1 + "<" + numero2);
            }
            else
            {
                Console.WriteLine(numero1 + "=" + numero2);
            }
        }
        public void Exercicio26()
        {
            Console.WriteLine("Digite o número:");
            int numero = Convert.ToInt32(Console.ReadLine());

            switch (numero)
            {
                case 1:
                    Console.WriteLine("Um");
                    break;

                case 2:
                    Console.WriteLine("Dois");
                    break;

                case 3:
                    Console.WriteLine("Três");
                    break;

                case 4:
                    Console.WriteLine("Quatro");
                    break;

                case 5:
                    Console.WriteLine("Cinco");
                    break;

                default:
                    Console.WriteLine("Número Inválido!");
                    break;

            }
        }
        public void Exercicio27()
        {
            var vendas = new VendasCarango();
            vendas.ContabilizarVendas();
        }
        public void Exercicio28()
        {
            string nomeFuncionario;
            decimal salarioAntigo, reajuste, salarioNovo, reajusteTotal = 0M, salarioMinimo = 1212M;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite o nome do funcionário: ");
                nomeFuncionario = Console.ReadLine();

                Console.WriteLine("Digite o salário do funcionário: ");
                salarioAntigo = Convert.ToDecimal(Console.ReadLine());

                if (salarioAntigo < 3 * salarioMinimo)
                {
                    reajuste = 0.5M * salarioAntigo;
                }
                else if (salarioAntigo < 10 * salarioMinimo)
                {
                    reajuste = 0.2M * salarioAntigo;
                }
                else if (salarioAntigo < 20 * salarioMinimo)
                {
                    reajuste = 0.15M * salarioAntigo;
                }
                else
                {
                    reajuste = 0.10M * salarioAntigo;
                }
                salarioNovo = salarioAntigo + reajuste;
                reajusteTotal += reajuste;

                Console.WriteLine("O funcionário " + nomeFuncionario + " teve um reajuste de R$ " + reajuste + "." +
                "Seu novo salário é R$ " + salarioNovo);
                Console.Clear();
            }
            Console.WriteLine("O valor da folha de pagamento aumentará em R$ " + reajusteTotal);


        }
        public void Exercicio29()
        {
            int mes = 1;
            while (mes != 0)
            {
                Console.WriteLine("Digite o número do mês de 1 a 12 ou 0 para sair: ");
                mes = Convert.ToInt32(Console.ReadLine());

                switch (mes)
                {
                    case 1:
                        Console.WriteLine("Janeiro");
                        break;
                    case 2:
                        Console.WriteLine("Fevereiro");
                        break;
                    case 3:
                        Console.WriteLine("Março");
                        break;
                    case 4:
                        Console.WriteLine("Abril");
                        break;
                    case 5:
                        Console.WriteLine("Maio");
                        break;
                    case 6:
                        Console.WriteLine("Junho");
                        break;
                    case 7:
                        Console.WriteLine("Julho");
                        break;
                    case 8:
                        Console.WriteLine("Agosto");
                        break;
                    case 9:
                        Console.WriteLine("Setembro");
                        break;
                    case 10:
                        Console.WriteLine("Outubro");
                        break;
                    case 11:
                        Console.WriteLine("Novembro");
                        break;
                    case 12:
                        Console.WriteLine("Dezembro");
                        break;
                    default:
                        Console.WriteLine("Opção inválida! Digite o número do mês, de 1 a 12 ou 0 para sair.");
                        break;
                }


            }
        }
        public void Exercicio30()
        {
            string nome;
            int idade;
            char sexo = 'a';
            decimal salario, abono;

            Console.WriteLine("Digite o nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("Digite a idade");
            idade = Utilities.validacaoIdade();
            sexo = Utilities.validacaoSexo();


            Console.WriteLine("Digite o salário: ");
            salario = Convert.ToDecimal(Console.ReadLine());

            if (sexo == 'M')
            {
                if (idade >= 30)
                {
                    abono = 100M;
                }
                else
                {
                    abono = 50M;
                }

            }
            else
            {
                if (idade >= 30)
                {
                    abono = 200M;
                }
                else
                {
                    abono = 80M;
                }

            }

            Console.WriteLine("O salário líquido do(a) " + nome + " será de R$ " + (salario + abono));
        }
        public void Exercicio31()
        {
            int a, b, c, memoria;
            Console.WriteLine("Digite o valor do primeiro número: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o valor do segundo número: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o valor do terceiro número: ");
            c = Convert.ToInt32(Console.ReadLine());

            if (c < a)
            {
                memoria = a;
                a = c;
                c = memoria;
            }
            if (b < a)
            {
                memoria = a;
                a = b;
                b = memoria;

            }
            if (c < b)
            {
                memoria = b;
                b = c;
                c = memoria;
            }
            Console.WriteLine(a + " <= " + b + " <= " + c);
        }
        public void Exercicio32()
        {
            decimal numero1, numero2;
            char operacao;

            Console.WriteLine("Digite o primeiro número: ");
            numero1 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            numero2 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite a opreaçao que quer realizar:\n" +
                              "+ para soma\n" +
                              "- para subtração\n" +
                              "* para multiplicação\n" +
                              "/ para divisáo");

            operacao = Convert.ToChar(Console.ReadLine());
            switch (operacao)
            {
                case '+':
                    Console.WriteLine(numero1 + " + " + numero2 + " = " + (numero1 + numero2));
                    break;

                case '-':
                    Console.WriteLine(numero1 + " - " + numero2 + " = " + (numero1 - numero2));
                    break;

                case '*':
                    Console.WriteLine(numero1 + " * " + numero2 + " = " + (numero1 * numero2));
                    break;

                case '/':
                    if (numero2 == 0)
                    {

                        Console.WriteLine("Não utilizar 0 como divisor!");
                    }
                    else
                    { 
                        Console.WriteLine(numero1 + " / " + numero2 + " = " + (numero1 / numero2));
                    }
                    break;
            }




        }
        public void Exercicio33()
        {
            int a, b, c;
            Console.WriteLine("Digite o primeiro número: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            c = Convert.ToInt32(Console.ReadLine());

            if (a < b + c &&
               b < a + c &&
               c < a + b)
            {
                if (a == b &&
                    b == c)
                {
                    Console.WriteLine("Os números " + a + ", " + b + " e " + c + " formam os lados de um triângulo Equilátero.");
                }
                else if (a == b ||
                         b == c ||
                         a == c)
                {
                    Console.WriteLine("Os números " + a + ", " + b + " e " + c + " formam os lados de um triângulo Isócele.");
                }
                else
                {
                    Console.WriteLine("Os números " + a + ", " + b + " e " + c + " formam os lados de um triângulo Escaleno.");
                }
            }
            else
            {
                Console.WriteLine("Os números " + a + ", " + b + " e " + c + " não podem ser os lados de um mesmo triângulo.");
            }
        }
        public void Exercicio34()
        {
            string nome;
            int nivel, horasTrabalhadas;

            Console.WriteLine("Digite o nome do professor: ");
            nome = Console.ReadLine();

            Console.WriteLine("Digite o nível do professor: ");
            nivel = Convert.ToInt32(Console.ReadLine());
            while (nivel != 1 && nivel != 2 && nivel != 3)
            {
                Console.WriteLine("Nível inválido!");
                Console.WriteLine("Digite o nível do professor: ");
                nivel = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            }

            Console.WriteLine("Digite quantas horas o professor " + nome + " trabalhou:");
            horasTrabalhadas = Convert.ToInt32(Console.ReadLine());

            switch (nivel)
            {
                case 1:
                    Console.WriteLine("O salário do professor " + nome + " será R$ " + (horasTrabalhadas * 12));
                    break;

                case 2:
                    Console.WriteLine("O salário do professor " + nome + " será R$ " + (horasTrabalhadas * 17));
                    break;

                case 3:
                    Console.WriteLine("O salário do professor " + nome + " será R$ " + (horasTrabalhadas * 25));
                    break;
            }
        }
        public void Exercicio35()
        {
            int idade;
            Console.WriteLine("Digite a idade do nadador: ");
            idade = Utilities.validacaoIdade();

            if (idade >= 5 &&
                idade <= 7)
            {
                Console.WriteLine("O nadador é da categoria Infantil A.");
            }

            if (idade >= 8 &&
                idade <= 10)
            {
                Console.WriteLine("O nadador é da categoria Infantil B");
            }

            if (idade >= 11 &&
                idade <= 13)
            {
                Console.WriteLine("O nadador é da categoria Juvenil A");
            }

            if (idade >= 14 &&
                idade <= 17)
            {
                Console.WriteLine("O nadador é da categoria Juvenil B");
            }

            if (idade >= 18 &&
                idade <= 25)
            {
                Console.WriteLine("O nadador é da categoria Sênior");
            }

            else
            {
                Console.WriteLine("Idade fora da faixa etária.");
            }
        }
        public void Exercicio36()
        {
            decimal consumoEnergia;
            int tipoCliente;

            Console.WriteLine("Digite o consumo de energia em Kw/h: ");
            consumoEnergia = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite o tipo de cliente: \n" +
                              "1 - Residencia\n" +
                              "2 - Comércio\n" +
                              "3 - Indústria\n");
            tipoCliente = Convert.ToInt32(Console.ReadLine());
            while (tipoCliente != 1 && tipoCliente != 2 && tipoCliente != 3)
            {
                Console.WriteLine("Seleção inválida!");
                System.Threading.Thread.Sleep(2000);
                Console.Clear();
                Console.WriteLine("Digite o tipo de cliente: \n" +
                              "1 - Residencia\n" +
                              "2 - Comércio\n" +
                              "3 - Indústria\n");
                tipoCliente = Convert.ToInt32(Console.ReadLine());
                

            }

            switch (tipoCliente)
            {
                case 1:
                    Console.WriteLine("O valor da conta de luz será R$ " + consumoEnergia * 0.60M);
                    break;

                case 2:
                    Console.WriteLine("O valor da conta de luz será R$ " + consumoEnergia * 0.48M);
                    break;

                case 3:
                    Console.WriteLine("O valor da conta de luz será R$ " + consumoEnergia * 1.29M);
                    break;
            }


        }
        public void Exercicio37()
        {
            string nome;
            int idade;
            decimal altura,pesoIdeal;
            char sexo;

            Console.WriteLine("Digite o nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Digite a idade: ");
            idade= Utilities.validacaoIdade();
            sexo = Utilities.validacaoSexo();
            Console.WriteLine("Digite a altura: ");
            altura = Convert.ToDecimal(Console.ReadLine());

            if (sexo == 'M')
            {
                if (altura > 1.70M)
                {
                    if (idade <= 20)
                    {
                        pesoIdeal = (72.7M * altura)-58;
                    }
                    else if(idade <= 39)
                    {
                        pesoIdeal = (72.7M * altura) - 53;
                    }
                    else
                    {
                        pesoIdeal = (72.7M * altura) - 45;

                    }
                }
                else
                {
                    if (idade <= 40)
                    {
                        pesoIdeal = (72.7M * altura) - 50;
                    }
                    else
                    {
                        pesoIdeal = (72.7M * altura) - 58;
                    }

                }
            }
            else
            {
                if (altura > 1.50M)
                {
                    pesoIdeal = (62.1M * altura) - 44.7M;
                }
                else
                {
                    if (idade >= 35)
                    {
                        pesoIdeal = (62.1M * altura) - 45M;
                    }
                    else
                    {
                        pesoIdeal = (62.1M * altura) - 49M;
                    }

                }

            }

            Console.WriteLine("Seu peso ideal é " + pesoIdeal + "kgs.");
        }
        public decimal Exercicio38()
        {
            decimal notaTrabalho, notaAvaliacao, notaExame, media;
            Console.WriteLine("Digite a nota do trabalho de laboratório: ");
            notaTrabalho = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite a nota do trabalho da avaliação semestral: ");
            notaAvaliacao = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite a nota do exame final: ");
            notaExame = Convert.ToDecimal(Console.ReadLine());

            media = (notaTrabalho * 2 + notaAvaliacao * 3 + notaExame * 5) / 10;
            Console.WriteLine("A média do aluno foi: " + media);

            return media;
        }
        public void Exercicio39()
        {
            string nome, matricula;
            decimal media;

            Console.WriteLine("Digite o nome do aluno: ");
            nome = Console.ReadLine();

            Console.WriteLine("Digite a matricula do aluno: ");
            matricula = Console.ReadLine();

            media = Exercicio38();

            if (media >= 8.10M)
            {
                Console.WriteLine("Nome: " + nome + "\n" +
                                  "Matricula: " + matricula + "\n" +
                                  "Média: "+ media +"\n" +
                                  "Classificação: A");

            }
            else if (media >= 7.80M)
            {
                Console.WriteLine("Nome: " + nome + "\n" +
                                  "Matricula: " + matricula + "\n" +
                                  "Média: " + media + "\n" +
                                  "Classificação: B");

            }
            else if (media >= 6.70M)
            {
                Console.WriteLine("Nome: " + nome + "\n" +
                                  "Matricula: " + matricula + "\n" +
                                  "Média: " + media + "\n" +
                                  "Classificação: C");

            }
            else if (media >= 5.60M)
            {
                Console.WriteLine("Nome: " + nome + "\n" +
                                  "Matricula: " + matricula + "\n" +
                                  "Média: " + media + "\n" +
                                  "Classificação: D");

            }
            else
            {
                Console.WriteLine("Nome: " + nome + "\n" +
                                  "Matricula: " + matricula + "\n" +
                                  "Média: " + media + "\n" +
                                  "Classificação: R");

            }
            
        }
        public void Exercicio40()
        {
            string nome;
            int idade, grupoDeRisco;
            Console.WriteLine("Digite o nome do cliente: ");
            nome = Console.ReadLine();

            Console.WriteLine("Digite a idade do cliente: ");
            idade = Utilities.validacaoIdade();

            Console.WriteLine("Digite o grupo de risco do cliente: \n" +
                              "1 - Baixo\n" +
                              "2 - Médio\n" +
                              "3 - Alto");
            grupoDeRisco= Convert.ToInt32(Console.ReadLine());

            while (grupoDeRisco != 1 && grupoDeRisco != 2 && grupoDeRisco != 3)
            {
                Console.WriteLine("Opção inválida!");
                System.Threading.Thread.Sleep(2000);
                Console.Clear();
                Console.WriteLine("Digite o grupo de risco do cliente: \n" +
                              "1 - Baixo\n" +
                              "2 - Médio\n" +
                              "3 - Alto");
                grupoDeRisco = Convert.ToInt32(Console.ReadLine());

            }

            Console.WriteLine("Nome: " + nome + "\n" +
                              "Idade: " + idade);
            if (17 <= idade && idade <= 20)
            {
                if (grupoDeRisco == 1)
                {

                    Console.WriteLine("Categoria: 1");

                }
                else if (grupoDeRisco == 2)
                {

                    Console.WriteLine("Categoria: 2");

                }
                else
                {

                    Console.WriteLine("Categoria: 3");

                }
            }
            else if (21 <= idade && idade <= 24)
            {
                if (grupoDeRisco == 1)
                {

                    Console.WriteLine("Categoria: 2");

                }
                else if (grupoDeRisco == 2)
                {

                    Console.WriteLine("Categoria: 3");

                }
                else
                {

                    Console.WriteLine("Categoria: 4");

                }
            }
            else if (25 <= idade && idade <= 34)
            {
                if (grupoDeRisco == 1)
                {

                    Console.WriteLine("Categoria: 3");

                }
                else if (grupoDeRisco == 2)
                {

                    Console.WriteLine("Categoria: 4");

                }
                else
                {

                    Console.WriteLine("Categoria: 5");

                }
            }
            else if (35 <= idade && idade <= 64)
            {
                if (grupoDeRisco == 1)
                {

                    Console.WriteLine("Categoria: 4");

                }
                else if (grupoDeRisco == 2)
                {

                    Console.WriteLine("Categoria: 5");

                }
                else
                {

                    Console.WriteLine("Categoria: 6");

                }
            }
            else if (65 <= idade && idade <= 70)
            {
                if (grupoDeRisco == 1)
                {

                    Console.WriteLine("Categoria: 7");

                }
                else if (grupoDeRisco == 2)
                {

                    Console.WriteLine("Categoria: 8");

                }
                else
                {

                    Console.WriteLine("Categoria: 9");

                }
            }
            else
            {
                Console.WriteLine("Cliente não elegível para seguro.");
            }

        }
    }

}
