string[,] cadastro = new string[5, 4];
int i;
int coluna = 0;
int menu;
string voltar = "S";
string voltar2 = "s";
string pesquisa = " ";

Console.WriteLine("  Ola! \n Cadastre os nomes, numeros de faltas e aulas dos alunos!  \n");

for (i = 0; i < 5; i++)
{
    Console.Clear();
    Console.WriteLine("Nome do aluno \n");
    cadastro[i, coluna++] = Console.ReadLine();
    Console.WriteLine("numero de faltas do aluno? \n");
    cadastro[i, coluna++] = Console.ReadLine();
    Console.WriteLine("Qual o numero de aulas dadas? \n");
    cadastro[i, coluna++] = Console.ReadLine();

    coluna = 0;
}

while (voltar == "S" || voltar == "s")
{
    Console.Clear();

    Console.WriteLine(" Oque gostaria de fazer agora? \n");
    Console.WriteLine();
    Console.WriteLine(" Digite: \n '1' para: lista de alunos. \n '2' para pesquisar alunos. ");

    menu = int.Parse(Console.ReadLine());

    switch (menu)
    {
        case 1:
            {
                Console.Clear();
                Console.WriteLine(" Lista de alunos... \n");
                Console.WriteLine();

                for (i = 0; i <= 4; i++)
                {
                    Console.Write(" Aluno: " + cadastro[i, 0] + " " + cadastro[i, 1] + ", numero de faltas: " + cadastro[i, 2] + ", numero de faltas do aluno: ");
                    Console.WriteLine();
                    Console.WriteLine();
                }
            }
                break;
            
        case 2:
            {
                while (voltar == "S" || voltar == "s")
                {
                    Console.Clear();
                    Console.WriteLine(" Informe o nome do aluno que deseja pesquisar: ");
                    pesquisa = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine();

                    for (i = 0; i <= 4; i++)
                    { }
                }

            }
            break;
    }
}