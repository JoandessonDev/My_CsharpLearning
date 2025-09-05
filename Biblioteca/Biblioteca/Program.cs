using System;
using System.Globalization;
using System.Reflection.Metadata;
using Biblioteca;

namespace Biblioteca
{
    class Program
    {
        static void Main(string[] args)
        {
            // Adicionando Usuario e Item ao Sistema
            User aluno = new User("Joandesson", 20, "Student", "joandesson.rocha@gmail.com", "jojo47");
            User prof = new User("Marcela", 35, "Teacher", "marcela.prof@gmail.com", "marcela47"); 
            Item item = new Item("Orgulho e Preconceito","Jane Austen","Saraiva",5);


            //Introduzindo o Programa
            Console.WriteLine("-------------_____________BIBLIOTECA______________-----------");
            Console.WriteLine("LOGIN:                 ");

            //Coletando dados do Usario:
            Console.Write("White Your Email:   ");
            string user_email = Console.ReadLine();

            Console.Write("Write your Password:    ");
            string user_sin = Console.ReadLine();

            
            //Validando dados do usuario
            if (aluno.ValidarUsuario(user_email, user_sin) || prof.ValidarUsuario(user_email, user_sin))
            {
                Console.WriteLine("Login Realizado com sucesso!\n");

                //Criando Casos de Uso do Estudante
                if(user_email == aluno.Email)
                {
                    Console.WriteLine("Menu:");
                    Console.WriteLine("SOLICITAR EMPRESTIMO [0]\nRENOVAR EMPRESTIMO [1]\nRESERVAR ITEM [2]\nDEVOLVER ITEM [3]");
                    int escolha = int.Parse(Console.ReadLine());
                    
                    // Logica para emprestimo  Item
                    if (escolha == 0)
                    {
                        //Coletando dados do Item
                        Console.Write("Titulo:   ");
                        string title = Console.ReadLine();

                        if (item.SolicitarEmprestimo(title) && aluno.VerificarStatus(aluno.Name)) 
                        {
                            Console.WriteLine("Emprestimo Realizado");
                            Console.WriteLine(item);
                        }
                        else
                        {
                            Console.WriteLine("Emprestimo Não autorizado");

                        }
                    }
                    else if (escolha == 3)
                    {
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Opção Invalida!");
                    }
                }

                // Casos de Uso Professor
                else
                {
                    Console.WriteLine("Menu:");
                    Console.WriteLine("CADASTRAR USUARIO [0]\n GERENCICAR USUARIO [1]\nAPLICAR ADIVERTENCIA [2]\nADCIONAR ITEM [3]");
                    int escolha = int.Parse(Console.ReadLine());

                    if(escolha == 0)
                    {
                        Console.WriteLine("Cadastrar usuario:");
                    }
                    else if (escolha == 1)
                    {
                        aluno.ManageUser();
                        Console.WriteLine($"Dados Atualizados:\n {aluno}");
                    }
                    /*else if (escolha == 2)
                    {
                        aluno.AplicarAdvertencia()
                    }*/
                    else if (escolha == 3)
                    {
                        Console.WriteLine("Adicionar Item");
                    }
                }

            }
            else
            {
                Console.WriteLine("Login ou senha Invalidos!");
            }






        }
    }
}