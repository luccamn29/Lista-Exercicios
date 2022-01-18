using System;

namespace ListaDeExercicios
{
    static class Program
    {
        static void Main(string[] args)
        {
            Exercicios exercicios = new Exercicios();
            // Valor exercicio -1 pois em caso de exception vai cair em opcao invalida sem encerrar o programa.
            int exercicio = -1;

            while (exercicio != 0)
            {
                Console.WriteLine("Digite o exercício desejado ou 0 para sair");

                try
                {
                    exercicio = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    //Não foi necessario escrever mensagem pois com exercicio = -1 ja retorna opção inváldia.
                }
                
                Console.Clear();
                switch (exercicio)
                {
                    //encerramento do programa
                    case 0:
                        break;

                    case 1:
                        exercicios.Exercicio01();
                        break;

                    case 2:
                        exercicios.Exercicio02();
                        break;

                    case 3:
                        exercicios.Exercicio03();
                        break;

                    case 4:
                        exercicios.Exercicio04();
                        break;

                    case 5:
                        exercicios.Exercicio05();
                        break;

                    case 6:
                        exercicios.Exercicio06();
                        break;

                    case 7:
                        exercicios.Exercicio07();
                        break;

                    case 8:
                        exercicios.Exercicio08();
                        break;

                    case 9:
                        exercicios.Exercicio09();
                        break;

                    case 10:
                        exercicios.Exercicio10();
                        break;

                    case 11:
                        exercicios.Exercicio11();
                        break;

                    case 12:
                        exercicios.Exercicio12();
                        break;

                    case 13:
                        exercicios.Exercicio13();
                        break;

                    case 14:
                        exercicios.Exercicio14();
                        break;

                    case 15:
                        exercicios.Exercicio15();
                        break;

                    case 16:
                        exercicios.Exercicio16();
                        break;

                    case 17:
                        exercicios.Exercicio17();
                        break;

                    case 18:
                        exercicios.Exercicio18();
                        break;

                    case 19:
                        exercicios.Exercicio19();
                        break;

                    case 20:
                        exercicios.Exercicio20();
                        break;

                    case 21:
                        exercicios.Exercicio21();
                        break;

                    case 22:
                        exercicios.Exercicio22();
                        break;

                    case 23:
                        exercicios.Exercicio23();
                        break;

                    case 24:
                        exercicios.Exercicio24();
                        break;

                    case 25:
                        exercicios.Exercicio25();
                        break;

                    case 26:
                        exercicios.Exercicio26();
                        break;

                    case 27:
                        exercicios.Exercicio27();
                        break;

                    case 28:
                        exercicios.Exercicio28();
                        break;

                    case 29:
                        exercicios.Exercicio29();
                        break;

                    case 30:
                        exercicios.Exercicio30();
                        break;

                    case 31:
                        exercicios.Exercicio31();
                        break;

                    case 32:
                        exercicios.Exercicio32();
                        break;

                    case 33:
                        exercicios.Exercicio33();
                        break;

                    case 34:
                        exercicios.Exercicio34();
                        break;

                    case 35:
                        exercicios.Exercicio35();
                        break;

                    case 36:
                        exercicios.Exercicio36();
                        break;

                    case 37:
                        exercicios.Exercicio37();
                        break;

                    case 38:
                        exercicios.Exercicio38();
                        break;

                    case 39:
                        exercicios.Exercicio39();
                        break;

                    case 40:
                        exercicios.Exercicio40();
                        break;

                        // qualquer opcao nao existente retornara opcao invalida
                    default:
                        Console.WriteLine("Opção Inválida");
                        break;
                }

                // Após a seleção da opção e execução do respectivo exercicio, aguarda input do usuario para limpar a tela,
                // evitando que limpe antes da leitura do resultado pelo usuario.
                // Caso a opcao de exercicio seja 0 o usuario deseja encerrar o programa, e isso se torna desnecessario.
                if (exercicio != 0)
                {
                    
                    Console.WriteLine("Pressione qualquer tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
    }
}
