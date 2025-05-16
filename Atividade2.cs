        int IngVen;
        double ValIng, RecTotal;

        Console.WriteLine("Digite a quantidade de ingressos vendidos");
        IngVen = int.Parse(Console.ReadLine());

        Console.Write("Digite o valor do ingresso R$");
        ValIng = double.Parse(Console.ReadLine());

        RecTotal = IngVen * ValIng;

        Console.Write("O total vendido foi R$" +RecTotal);
    
