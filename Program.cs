using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "11205220", modelo: "Modelo 1", imei:"21515112", memoria: 25);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "6654962", modelo: "Modelo 2", imei:"26201", memoria: 64);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Facebook");