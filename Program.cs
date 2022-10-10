using System;

namespace crud
{
    internal class Program
    {
        static public int aux=0;
        static public string[,] contatos = new string[100, 1];
        static public bool rep = true;
        static void Main(string[] args)
        {
            // testando clone
            while (rep)
            {
                Menu();
                try
                {
                    Controlador(char.Parse(Console.ReadLine()));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }

        }
        static public void Menu()
        {
            Console.WriteLine("1 - Cadastrar");
            Console.WriteLine("2 - Consultar");
            Console.WriteLine("3 - Atualizar");
            Console.WriteLine("4 - Deletar");
            Console.WriteLine("0 - SAIR");
        }
        public static void Controlador(char escolhido)
        {
            switch (escolhido)
            {
                case '1':
                    //CADASTRAR
                    Console.Clear();
                    Console.WriteLine("\tCADASTRAR\n");
                    Cadastrar();
                    break;
                case '2':
                    //CONSULTAR
                    if (contatos[0, 0] == null)
                    {
                        Console.WriteLine("NENHUM CONTATO CADASTRADO!");
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("\tCONSULTA\n");
                        Consultar();
                    }
                    break;
                case '3':
                    //ATUALIZAR

                    if (contatos[0,0] == null)
                    {
                        Console.WriteLine("NENHUM CONTATO CADASTRADO!");
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("\tATUALIZAR\n");
                        Atualizar();
                    }
                    break;
                case '4':
                    //DELETAR

                    if (contatos[0, 0] == null)
                    {
                        Console.WriteLine("NENHUM CONTATO CADASTRADO!");
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("\n\tDELETAR\n");
                        Deletar();
                    }
                    break;
                case '0':
                    //SAIR
                    Console.WriteLine("SAIR");
                    rep = false;
                    break;
                default:
                    Console.WriteLine("\n\tOPÇÂO INCORRETA!");
                    break;
            }
            Console.ReadLine();
            Console.Clear();
        }
        static public void Cadastrar()
        {
            Console.WriteLine("Nome: ");
            contatos[aux, 0] = Console.ReadLine();
            aux++;

            Console.WriteLine("\n\t CADASTRADO COM SUCESSO!");
        }
        static public void Consultar()
        {
            for(int i=0;i<aux;i++)
            {
                Console.WriteLine(i+1 + " - " + contatos[i,0]);
            }
            Console.WriteLine();
        }
        static public void Atualizar()
        {
            Consultar();
            Console.WriteLine("Digite o ID do usário: ");
            
            int i = Convert.ToInt32(Console.ReadLine());
            string nome;
            Console.WriteLine("nome: ");
            nome = Console.ReadLine();
            contatos[i - 1, 0] = nome;


            Console.WriteLine("\n\t ATUALIZADO COM SUCESSO!");
        }
        static public void Deletar()
        {
            Consultar();
            Console.WriteLine("Digite o ID que deseja deletar: ");
            int i = Convert.ToInt32(Console.ReadLine());

            contatos[i - 1, 0] = null;
            aux--;
            for(int j = i - 1; j < contatos.Length - 1; j++)
            {
                contatos[j, 0] = contatos[j + 1, 0];
            }


            Console.WriteLine("\n\t APAGADO COM SUCESSO!");
        }
    }
}
