using System;

namespace Trabalho1509
{
    class Program
    {
        static void Main(string[] args)
        {
            Vendedores osVendedores = new Vendedores(10);


            Console.WriteLine("BEM VINDO, DIGITE O NUMERO CORRESPONDENTE");
            Console.WriteLine("0. Sair");
            Console.WriteLine("1. Cadastrar Vendedor");
            Console.WriteLine("2. Consultar Vendedor");
            Console.WriteLine("3. Excluir Vendedor");
            Console.WriteLine("4. Registrar Venda");
            Console.WriteLine("5. Listar Vendedores");
            int op = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case 1:
                    int id;
                    id = 1;
                    Console.WriteLine("Digite o nome do vendedor: ");
                    string nomeVend = Console.ReadLine();
                    Console.WriteLine("Digite a comissão: ");
                    double comissao = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(osVendedores.addVendedor(new Vendedor(id,nomeVend, comissao)) ? "Cadastrado com sucesso!" : "Erro Inesperado!");

                    break;

                case 3:
                    if(osVendedores.valorVendas() != 0  ){
                        Console.WriteLine("Digite o nome do vendedor que deseja excluir: ");
                        string nomezin = Console.ReadLine();
                        Console.WriteLine(osVendedores.delVendedor(new Vendedor(0, nomezin, 0.0)) ? "Excluído com sucesso!" : "Erro inesperado!");
                    }

                    break;


                case 2:
                        
                    
                    break;


            }




            ;
          /* Console.Write(osVendedores.listaVendedores());*/

            Console.ReadKey();
        }
    }
}
