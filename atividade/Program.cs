
Console.Clear();
double result = 0;
Console.WriteLine("Olá, bom dia, bem-vindo ao Foodtruck do Sr. Elpidio.");

Console.WriteLine("gostaria de realizar o pedido?"); //solicita a vontade do usuário
string s = Console.ReadLine().ToLower();

if(s == "sim"||s=="s")//verifica a resposta do usuário
{   
    double[] a = {14, 13, 11}; //array para armazenar os valores dos produtos
    retorno: //retorna caso a resposta seja "false"
    Console.WriteLine($"\nCardápio:\n\n1-Sanduíche R${a[0]}\n2-Hamburguer  R${a[1]}\n3-Macarrão na chapa R${a[2]}\n");
    Console.ForegroundColor = ConsoleColor.Yellow;
    string refeicao = Console.ReadLine().ToLower();//soliita qual refeição o usario irá querer
    Console.ResetColor();
   
    if(refeicao == "sanduíche"|| refeicao == "sanduiche")//verifica a resposta do usuário
    {
        Console.WriteLine($"\nÓtimo pedido! valor R${a[0]}");
        result = a[0]; //armazena o valor do lanche
    }
    else if(refeicao == "hamburguer")//verifica a resposta do usuário
    {
        Console.WriteLine($"\nÓtimo pedido! valor R${a[1]}");
        result = a[1]; //armazena o valor do lanche
    }
    else if(refeicao == "macarrão"|| refeicao == "macarrão na chapa" || refeicao == "macarrao na chapa" || refeicao =="macarrao") //verifica a resposta do usuário
    {
        Console.WriteLine($"\nÓtimo pedido! valor R${a[2]}");
        result = a[2]; //armazena o valor do lanche
    }
    else
    {
        Console.Clear();
        Console.WriteLine("\nO sistema não compreendeu seu pedido, faça novamente\n"); //mensagem caso o lanche inserido pelo usuário não esteja no cardápio
        goto retorno;//goto para retornar caso a resposta não exita
    }
    
}
else
{
    Console.WriteLine("\nOk! Agradecemos pelo contato!"); //caso o usuário não queira realizar o pedido
}


    Console.WriteLine("gostaria de bebida?");//solicita a vontade do usuário
string n = Console.ReadLine().ToLower();

 
if(n == "sim"||n=="s")//verifica a resposta do usuário
{   
    double[] b = {12, 5, 6};//array para armazenar os valores dos produtos
    retorn://retorna caso a resposta seja "false"
    Console.WriteLine($"\nCardápio:\n\n1-Coca-Cola 1L R${b[0]}\n2-Água  R${b[1]}\n3-Água com gás R${b[2]}");
    Console.ForegroundColor = ConsoleColor.Yellow;
    string bebida = Console.ReadLine().ToLower();//soliita qual refeição o usario irá querer
    Console.ResetColor();
    
    if(bebida == "água"|| bebida == "agua")//verifica a resposta do usuário
    {
        Console.WriteLine($"\nÓtimo pedido! valor R${b[1]}");
        result += b[1];//armazena o valor do lanche
    }
    else if(bebida == "coca cola"|| bebida == "coca")//verifica a resposta do usuário
    {
        Console.WriteLine($"\nÓtimo pedido! valor R${b[0]}");
        result += b[0];//armazena o valor do lanche
    }
    else if(bebida == "água com gás"|| bebida == "agua com gas"|| bebida == "agua com gás" ||  bebida == "água com gas")//verifica a resposta do usuário
    {
        Console.WriteLine($"\nÓtimo pedido! valor R${b[2]}");
        result += b[2];//armazena o valor do lanche
    }
    else
    {
        Console.Clear();
        Console.WriteLine("\nO sistema não compreendeu seu pedido, faça novamente\n"); //mensagem caso o lanche inserido pelo usuário não esteja no cardápio
        goto retorn;//goto para retornar caso a resposta não exita
    }
    
}
else
{
    Console.WriteLine("\nOk! Agradecemos pelo contato!");//caso o usuário não queira realizar o pedido
}
if(result!=0)//verifica se o pedido tem valor
{
Console.WriteLine($"\nO valor TOTAL do pedido deu R${result}\n");//immprime o valor total do pedido
pag://retorna caso a resposta seja "false"
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"Qual seria a forma de pagamento?(PIX, Cartão, Dinheiro)\n");
Console.ResetColor();
string pay = Console.ReadLine().ToLower();//verifica a resposta do usuário

if(pay == "pix")//solicita a vontade do usuário
{
    Console.WriteLine($"Deseja pagar na entrega ou pelo telefone?");
    string payment = Console.ReadLine().ToLower();
    if(payment == "telefone" || payment == "agora")//verifica se o usuário quer exercer a compra em sua residência ou local em que reside
    {
        Console.WriteLine("\nAqui está o pix da loja : XX. XXX. XXX/0001-XX\t | Favor enviar o comprovante para confirmação do pedido!");
    }
    else
    {
        Console.WriteLine("Ok, o pedido ja está sendo preparado.");
    }
}
else if(pay == "cartao" || pay == "cartão")//solicita a vontade do usuário
{
   Console.WriteLine("Ok, o pedido ja está sendo preparado.");
}
else if(pay == "dinheiro")//solicita a vontade do usuário
{
   Console.WriteLine("Ok, o pedido ja está sendo preparado.");
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("\nSelecione uma forma de pagamento válida, para conclusão do pedido\n");//mensagem de erro, caso a forma de pagamento seja inválida
    Console.ResetColor();
    goto pag;//goto para repetir a pergunta, caso a forma de pagamento seja inválida
}
}




