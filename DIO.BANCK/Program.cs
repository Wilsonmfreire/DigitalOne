using System;
using System.Collections.Generic;
namespace DIO.BANCK
{
    class Program
    {
        static List<Conta> listContas = new List<Conta>();
        static void Main(string[] args)
        {
           string opcaoUsuario = ObeterOpcaoUsuario();

           while (opcaoUsuario.ToUpper() != "x")
           {
               switch (opcaoUsuario)
               {
                   case "1":
                        ListarContas();
                        break;
                   case "2":
                        InserirConta();
                        break;
                   case "3":
                        Transferir(); 
                         break;
                   case "4":
                        Sacar();
                         break;
                   case "5":
                        Depositar();
                        break;
                   case "C":
                        Console.Clear();
                        break;

                   default:
                        throw new ArgumentOutOfRangeException();
               }
           }

       }

       private static void Transferir()
       {
           Console.Write("Digite o número da conta de origem: ");
           int indiceContaOrigem = int.Parse(Console.ReadLine());

           Console.Write("Digite o número da conta de destino: ");
           int indiceContaDestino = int.Parse(Console.ReadLine());

           Console.Write("Digite o número da conta de transferido: ");
           double ValorTransferencia = double.Parse(Console.ReadLine());

           listContas[indiceContaOrigem].Transferir(ValorTransferencia, listContas[indiceContaDestino]);

       }
       private static void Sacar()
       {
           Console.Write("Digite o número da conta: ");
           int indiceConta = int.Parse(Console.ReadLine());

           Console.Write("Digite o valor a ser sacado: ");
           double valorSaque = double.Parse(Console.ReadLine());

           listContas[indiceConta].Sacar(valorSaque);
       }

       private static void Depositar()
       {
           Console.Write("Digite o número da conta: ");
           int indiceConta = int.Parse(Console.ReadLine());

           Console.Write("Digite o valor a ser depositado: ");
           double valorDeposito = double.Parse(Console.ReadLine());

           listContas[indiceConta].Depositar(valorDeposito);
       }
        private static void InserirConta()
        {
            Console.WriteLine("Inserir nova conta");

            Console.WriteLine("Digite 1 para Conta Fisica ou 2 para Juridica: ");
            int entradaTipoConta = int.Parse(Console.ReadLine());//converter para inteiro

            Console.WriteLine("Digite o Nome do Cliente: ");
            string entradaNome = Console.ReadLine();

            Console.WriteLine("Digite o saldo inicial: ");
            double entradaSaldo = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o crédito: ");
            double entradaCredito = double.Parse(Console.ReadLine());

            Conta novaConta = new Conta(tipoConta: (TipoConta)entradaTipoConta,// pessoa fisica ou juritica
             /*criando um novo objeto*/ Saldo: entradaSaldo,
                                        Credito: entradaCredito,
                                        Nome: entradaNome); 

            listContas.Add(novaConta);
        }

        private static void ListarContas()
        {
            Console.WriteLine("Listar contas");

            if(listContas.Count == 0)
            {
                Console.WriteLine("Nenhuma conta cadastrada.");
                return;
            }
            for (int i = 0; i<ListarContas.Count; i++)
            {
                Conta conta = ListarContas[i];
                Console.Write("#{0} - ", i);
                Console.WriteLine(conta);
            }
        }

        private static string ObeterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Caramelo Bank a seu Dispor!!! ");
            Console.WriteLine("Informe a opção desejada:");

            Console.WriteLine("1- Listar contas");
            Console.WriteLine("2- Inserir nova conta");
            Console.WriteLine("3- Transferir");
            Console.WriteLine("4- Sacar");
            Console.WriteLine("5- Depositar");
            Console.WriteLine("C- Limpar Tela");
            Console.WriteLine("X- Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}
