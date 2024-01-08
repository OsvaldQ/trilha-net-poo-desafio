using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "98765432", modelo: "Modelo 1", imei: "12345678910", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Facebook");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "12345678", modelo: "Modelo 2", imei: "9876543210", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");