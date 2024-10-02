


double result = 0;
Console.WriteLine("Olá, bom dia, bem-vindo ao Foodtruck do Sr. Elpidio.");
Console.WriteLine("gostaria de realizar o pedido?");
string s = Console.ReadLine();

if(s == "SIM".ToLower()||s=="S".ToLower())
{   
    double[] a = {14, 13, 11};
    retorno:
    Console.WriteLine($"Cardápio:\n1-Sanduíche R${a[0]}\n2-Hamburguer  R${a[1]}\n3-Macarrão na chapa R${a[2]}");
    Console.ForegroundColor = ConsoleColor.Red;
    string refeicao = Console.ReadLine().ToLower();
    Console.ResetColor();
   
    if(refeicao == "SANDUÍCHE".ToLower()|| refeicao == "SANDUICHE".ToLower())
    {
        Console.WriteLine($"Ótimo pedido! valor R${a[0]}");
        result = a[0];
    }
    else if(refeicao == "HAMBURGUER".ToLower())
    {
        Console.WriteLine($"Ótimo pedido! valor R${a[1]}");
        result = a[1];
    }
    else if(refeicao == "MACARRÃO".ToLower()|| refeicao == "Macarrão na chapa".ToLower() || refeicao == "Macarrao na chapa".ToLower())
    {
        Console.WriteLine($"Ótimo pedido! valor R${a[2]}");
        result = a[2];
    }
    else
    {
        Console.Clear();
        Console.WriteLine("O sistema não compreendeu seu pedido, faça novamente\n");
        goto retorno;
    }
    
}
else
{
    Console.WriteLine("Ok! Agradecemos pelo contato!");
}


    Console.WriteLine("gostaria de bebida?");
string n = Console.ReadLine();

 
if(n == "SIM".ToLower()||n=="S".ToLower())
{   
    double[] b = {12, 5, 6};
    retorn:
    Console.WriteLine($"Cardápio:\n1-Coca-Cola 1L R${b[0]}\n2-Água  R${b[1]}\n3-Água com gás R${b[2]}");
    Console.ForegroundColor = ConsoleColor.Red;
    string bebida = Console.ReadLine().ToLower();
    Console.ResetColor();
    
    if(bebida == "Água".ToLower()|| bebida == "Agua".ToLower())
    {
        Console.WriteLine($"Ótimo pedido! valor R${b[1]}");
        result += b[1];
    }
    else if(bebida == "COCA COLA".ToLower()|| bebida == "Coca".ToLower())
    {
        Console.WriteLine($"Ótimo pedido! valor R${b[0]}");
        result += b[0];
    }
    else if(bebida == "Água com gás".ToLower()|| bebida == "Agua com gas".ToLower()|| bebida == "Agua com gás".ToLower() ||  bebida == "Água com gas".ToLower())
    {
        Console.WriteLine($"Ótimo pedido! valor R${b[2]}");
        result += b[2];
    }
    else
    {
        Console.Clear();
        Console.WriteLine("O sistema não compreendeu seu pedido, faça novamente\n");
        goto retorn;
    }
    
}
else
{
    Console.WriteLine("Ok! Agradecemos pelo contato!");
}
Console.WriteLine($"O valor do pedido deu R${result}\n");
pag:
Console.WriteLine($"Qual seria a forma de pagamento?(PIX, Cartão, Dinheiro)\n");
string pay = Console.ReadLine().ToLower();

if(pay == "pix")
{
    Console.WriteLine($"Deseja pagar na entrega ou pelo telefone?");
    string payment = Console.ReadLine().ToLower();
    if(payment == "telefone" || payment == "agora")
    {
        Console.WriteLine("Aqui está o pix da loja : XX. XXX. XXX/0001-XX\t Favor enviar o comprovante para confirmação do pedido");
    }
    else
    {
        Console.WriteLine("Ok, o pedido ja está sendo preparado.");
    }
}
else if(pay == "cartao" || pay == "cartão")
{
   Console.WriteLine("Ok, o pedido ja está sendo preparado.");
}
else if(pay == "dinheiro")
{
   Console.WriteLine("Ok, o pedido ja está sendo preparado.");
}
else
{
    Console.WriteLine("Selecione uma forma de pagamento para conclusão do pedido");
    goto pag;
}



