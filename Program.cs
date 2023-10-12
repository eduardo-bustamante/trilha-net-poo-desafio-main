using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "1234", modelo: "modelo 1", imei: "1234LL", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("");
Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "9874", modelo: "iphone 13", imei: "kk25", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Firefox");