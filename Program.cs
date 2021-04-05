using System;
using System.Collections.Generic;

namespace DIO.Bank
{
    class Program
    {
        static list<Conta> ListContas = new list<Conta>();
        private static object listContas;

        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpçãoUsuario();// chamando minha função menu de escolha

            // looping para executar os serviços de acordo com o que o usuario desejar até ser digitado "X"
            while (opcaoUsuario.ToUpper() != "X")
            {
                // Validar a lista de serviços com as funçoes 
                switch(opcaoUsuario) 
                {
                    case "1":
                        ListarContas();
                        break;

                    case "2":
                        InserirConta();
                        break;

                    case "3":
                        //Transferir();
                        break;

                    case "4":
                       // Sacar();
                        break;

                    case "5":
                        //Depositar();
                        break;

                    case "C":
                        Console.Clear(); // comando de limpar tela
                        break;

                    default:
                        throw new ArgumentOutOfRangeException(); // jogar(Throw) novo (new)  argumento esta fora do intervalo de exceção (ArgumentOutOfRangeException)

                }

                opcaoUsuario = ObterOpçãoUsuario(); // chamando de novo minha função menu 

            }

            Console.WriteLine("Obrigado por utilizar nossos serviços");
        }

        private static void ListarContas()
        {
            Console.WriteLine("Listar contas");

            if (listContas.Count == 0)
            {
                Console.WriteLine("Nenhuma conta cadastrada.");
                return;
            }

            for (int i = 0; i < list.Contas; i++)
            {
                Conta conta = list.Contas[i];
                Console.WriteLine("#{0} - ", i);
                Console.WriteLine(conta);
            }
        }

        private static void InserirConta()
        {
            Console.WriteLine(" inserir nova conta");

            Console.WriteLine("Digite 1 para conta fisica ou 2 para conta juridica: ");
            int entradaTipoConta = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o nome do cliente: ");
            string entradaNome = Console.ReadLine();

            Console.WriteLine("Digite o saldo inicial: ");
            double entradaSaldo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o credito: ");
            double entradaCredito = Convert.ToDouble(Console.ReadLine());

            Conta novaConta = new Conta(tipoConta: (TipoConta)entradaTipoConta, saldo: entradaSaldo, credito: entradaCredito, nome: entradaNome);

            ListContas.Add(novaConta);
        }

        // criação do meu menu de escolha 
        private static string ObterOpçãoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("DIO Bank a seu dispor!");
            Console.WriteLine("Informe a opção desejada");

            Console.WriteLine("1 - Listar Conta");
            Console.WriteLine("2 - Inserir nova conta");
            Console.WriteLine("3 - Transferir");
            Console.WriteLine("4 - Sacar");
            Console.WriteLine("5 - Depositar");
            Console.WriteLine("C - Limpar Tela");
            Console.WriteLine("X - Sair");

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;

        }
       
    }
}
