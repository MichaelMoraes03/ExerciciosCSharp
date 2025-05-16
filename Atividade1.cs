using System;

class Atividade1
{
    static void Main()
    {

        int CapTotal = 10;
        int PartCad = 9;
        bool resultado;

        Console.WriteLine("Você deseja visualizar a capacidade total de ingressos? (y/n): ");
        string escolha = Console.ReadLine().ToLower();
        if (escolha == "y")
        {
            resultado = true;
            Console.WriteLine("A capacidade total é de " + CapTotal);
        }

        else if (escolha == "n")
        {
            resultado = false;
            Console.WriteLine("OK");
        }

        Console.WriteLine("Você deseja ver o número de participantes cadastrados? (y/n): ");
        escolha = Console.ReadLine().ToLower();
        if (escolha == "y")
        {
            Console.WriteLine("O número de participantes cadastrados é: " + PartCad);

        }
        else if (escolha == "n")
        {
            Console.WriteLine("OK");
        }


        Console.WriteLine("Deseja verificar se pode cadastrar novos usuários e cadastrar novos usuários? (y/n):");
        escolha = Console.ReadLine().ToLower();

        if (escolha == "y")
        {
            if (CapTotal > PartCad)
            {
                Console.WriteLine("Pode cadastrar mais");
            }

        }
        else if (escolha == "n")
        {
            Console.WriteLine("Usurário não pode ser cadastrado");
        }
    }
}