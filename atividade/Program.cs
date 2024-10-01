// See https://aka.ms/new-console-template for more information
double result = 0;
Console.WriteLine("Olá, bom dia, nós somos do foodtruck.");
Console.WriteLine("gostaria de realizar o pedido?");
string s = Console.ReadLine();
double[] a = {14, 13, 11};
if(s == "SIM".ToLower()||s=="S".ToLower())
{   
    retorno:
    Console.WriteLine($"Cardápio:\n1-Sanduíche R${a[0]}\n2-Hamburguer  R${a[1]}\n3-Macarrão na chapa R${a[2]}");
    string refeicao = Console.ReadLine();
    if(refeicao == "SANDUÍCHE".ToLower()|| refeicao == "SANDUICHE".ToLower())
    {
        Console.WriteLine($"Ótimo pedido! valor {a[0]}");
        result = a[0];
    }
    else if(refeicao == "HAMBURGUER".ToLower())
    {
        Console.WriteLine($"Ótimo pedido! valor {a[1]}");
        result = a[1];
    }
    else if(refeicao == "MACARRÃO".ToLower()|| refeicao == "Macarrão na chapa")
    {
        Console.WriteLine($"Ótimo pedido! valor {a[2]}");
        result = a[2];
    }
    else
    {
        Console.Clear();
        Console.WriteLine("O sistema não compreendeu seu pedido, faça novamente\n");
        goto retorno;
    }
   
}