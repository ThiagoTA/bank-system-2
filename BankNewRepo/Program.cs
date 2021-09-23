using System;
using System.Collections.Generic;
using controleContas.Model;

namespace controleContas
{
    class Program
    {
        static Repositorio repositorio = new Repositorio();

        static IRepositorio rep = new Repositorio();

        static void Main(string[] args)
        {
   
            bool sair = false;
            String opc;
            try
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("Informe a ação a ser realizada: ");
                    Console.WriteLine("[1] Cadastrar Banco");
                    Console.WriteLine("[2] Cadastrar Agencia");
                    Console.WriteLine("[3] Cadastrar Cliente");
                    Console.WriteLine("[4] Criar Conta");
                    Console.WriteLine("[5] Listar Bancos");
                    Console.WriteLine("[6] Listar Agencias");
                    Console.WriteLine("[7] Listar Clientes");
                    Console.WriteLine("[8] Listar Contas");
                    Console.WriteLine("[9] Sacar");
                    Console.WriteLine("[10] Depositar");
                    Console.WriteLine("[11] Transferir");
                    Console.WriteLine("[12] Saldo Geral");
                    Console.WriteLine("[13] Encerrar aplicação\n");
                    opc = Console.ReadLine();

                    if (opc.Equals("1"))
                    {
                        Console.Clear();
                        Console.WriteLine("\n-Cadastrar Banco-\n");
                        repositorio.CriarBanco();
                    }
                    else if(opc.Equals("2"))
                    { 
                            Console.Clear();
                            Console.WriteLine("\n-Cadastrar Agência-\n");
                            repositorio.CriarAgencia();
                    }
                    else if (opc.Equals("3"))
                    {
                        Console.Clear();
                        Console.WriteLine("\n-Cadastrar Cliente-\n");
                        repositorio.CriarCliente();
                    }
                    else if (opc.Equals("4"))
                    {
                        Console.Clear();
                        Console.WriteLine("\n-Cadastrar Conta-\n");
                        repositorio.CriarConta();
                    }
                    else if (opc.Equals("5"))
                    {
                        Console.Clear();
                        Console.WriteLine("\n-Listar Bancos -\n");
                        repositorio.ListarBancos();
                    }
                    else if (opc.Equals("6"))
                    {
                        Console.Clear();
                        Console.WriteLine("\n-Listar Agências-\n");
                        repositorio.ListarAgencias();
                    }
                    else if (opc.Equals("7"))
                    {
                        Console.Clear();
                        Console.WriteLine("\n-Listar Clientes-\n");
                        repositorio.ListarClientes();
                    }
                    else if (opc.Equals("8"))
                    {
                        Console.Clear();
                        Console.WriteLine("\n-Listar Contas-\n");
                        repositorio.ListarContas();
                    }
                    else if (opc.Equals("9"))
                    {
                        Console.Clear();
                        Console.WriteLine("\n-Sacar-\n");
                        repositorio.Sacar();
                    }
                    else if (opc.Equals("10"))
                    {
                        Console.Clear();
                        Console.WriteLine("\n-Depositar-\n");
                        repositorio.Depositar();
                    }
                    else if (opc.Equals("11"))
                    {
                        Console.Clear();
                        Console.WriteLine("\n-Transferir-\n");
                        repositorio.Transferir();
                    }
                    else if (opc.Equals("12"))
                    {
                        Console.Clear();
                        Console.WriteLine("\n-Saldo Total-\n");
                        repositorio.SaldoGeral();
                    }
                    else if (opc.Equals("13"))
                    {
                        Console.Clear();
                        Console.WriteLine("\n-Saindo-\n");
                        sair = true;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Você escolheu uma opção inválida!");
                        sair = true;
                    }
                    Console.WriteLine("\nPressione uma tecla para continuar...");
                    Console.ReadLine();
                } while (!sair);
                Console.WriteLine("Fim do programa! Obrigado por utilizar!");
            }
            
            
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("\nPressione uma tecla para continuar...");
                Main(null);
            }
        }

        
    }
}
