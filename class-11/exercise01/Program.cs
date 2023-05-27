using exercise01;

Console.WriteLine("");
Console.WriteLine("-----------------------------");
Console.WriteLine("-------Exercício 01----------");
Console.WriteLine("-----------------------------");

IPayment cartao = new CreditCard();
IPayment boleto = new BankSlip();

var cliente1 = new Costumer(cartao);
cliente1.Buy(50.0);

var cliente2 = new Costumer(boleto);
cliente2.Buy(1000);