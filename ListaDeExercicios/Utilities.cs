using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeExercicios
{
    // Classe utilidade com metodos que foram usados repetidas vezes em varios exercicios
    public static class Utilities
    {
        // Método que converte para maiuscula e trata o erro caso o input seja uma string de mais de um caracter.
        public static char validacaoSexo()
        {
            char sexo;
            string linha="" ;
            Console.WriteLine("Digite o sexo: \nM para masculino\nF para feminino");
            do
            {
                linha = Console.ReadLine();
                try
                {

                    sexo = Convert.ToChar(linha);
                }
                catch (Exception)
                {
                    sexo = linha[0];
                }
                sexo = char.ToUpper(sexo);
                Console.Clear();
                if (!(sexo.Equals('M') || sexo.Equals('F')))
                {
                    Console.WriteLine("OPÇÃO INVÁLIDA!\n" +
                                      "Digite o sexo: \nM para masculino\nF para feminino");
                }

            } while (!(sexo.Equals('M') || sexo.Equals('F')));


            
            return sexo;
        }
        // Valida se a idade é maior ou igual a 0 e trata erro de conversão.
        public static int validacaoIdade()
        {
            int idade=-1;

            do
            {
                try
                {
                    idade = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    //Dessa forma já enviara mensagem de erro para o usuario, o try cath seria so para o programa nao parar de rodar.
                }
                Console.Clear();
                if (idade < 0)
                {
                    Console.WriteLine("Idade inválida! Digite a idade novamente:");
                }
                
            } while (idade < 0);

            return idade;
        }
    }
}
