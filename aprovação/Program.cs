string[,] cadastro = new string[5, 7];
int i;
int coluna = 0;
int menu;
double[] notas = new double[5];
double[] faltas = new double[5];
string voltar = "S";
string voltar2 = "s";
string pesquisa = " ";
string decisao = "";

Console.WriteLine("  Ola! \n Cadastre os nomes, numeros de faltas e aulas dos alunos!  \n");

for (i = 0; i < 5; i++)
{
    coluna = 0;
    Console.Clear();
    Console.WriteLine("Nome do aluno \n");
    cadastro[i, coluna++] = Console.ReadLine();
    Console.WriteLine("numero de faltas do aluno? \n");
    cadastro[i, coluna++] = Console.ReadLine();
    Console.WriteLine("Qual o numero de aulas dadas? \n");
    cadastro[i, coluna++] = Console.ReadLine();
    Console.WriteLine("Qual a nota da 1° prova? \n");
    cadastro[i, coluna++] = Console.ReadLine();
    Console.WriteLine("Qual a nota da 2º prova? \n");
    cadastro[i, coluna++] = Console.ReadLine();
    Console.WriteLine("Qual a nota da 3º prova? \n");
    cadastro[i, coluna++] = Console.ReadLine();
    Console.WriteLine("Qual a nota do trabalho? \n");
    cadastro[i, coluna++] = Console.ReadLine();
}

Console.Clear();

for (i = 0; i < 5; i++)
{
    notas[i] = (double.Parse(cadastro[i, 3]) * 30 / 100) + (double.Parse(cadastro[i, 4]) * 25 / 100) + (double.Parse(cadastro[i, 5]) * 30 / 100);
    if (double.Parse(cadastro[i, 6]) >= 6)
    {
        notas[i]++;
    }
    faltas[i] = double.Parse(cadastro[i, 2]) * 25 / 100;
}

for (i = 0; i < 5; i++)

{
    if (notas[i] >= 6 && double.Parse(cadastro[i, 1]) <= faltas[i])
    {
        decisao = " APROVADO!  \n";
    }
    if (notas[i] >= 6 && double.Parse(cadastro[i, 1]) > faltas[i])
    {
        decisao = " REPROVADO POR FALTAS!  \n";
    }
    if (notas[i] >= 6 && double.Parse(cadastro[i, 1]) <= faltas[i])
    {
        decisao = " REPROVADO POR NOTAS!  \n";
    }
    if (notas[i] >= 6 && double.Parse(cadastro[i, 1]) > faltas[i])
    {
        decisao = " REPROVADO EM AMBAS INSTÂNCIAS!  \n";
    }

    Console.Write(" Aluno: " + cadastro[i, 0] + ", foi: " + decisao);
    Console.WriteLine("");
    Console.WriteLine("");
}
