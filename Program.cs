using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero:"77774444", modelo:"Modelo 1", imei:"123456789", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Nokia:");
Smartphone iphone = new Iphone(numero:"88882222", modelo:"Modelo 2", imei:"987654321", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");