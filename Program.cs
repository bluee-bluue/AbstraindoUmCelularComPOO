using Abstraindo_um_Celular_com_POO.Models;

// Testes com as classes Samsung e Iphone
Console.WriteLine("Smartphone Samsung");
Smartphone samsung = new Samsung(numero: "11954228569", modelo: "Galaxy S21", imei: "111111111", memoria: 128);
samsung.Ligar();
samsung.InstalarAplicativo("Whatsapp");
samsung.ReceberLigacao();

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone");
Smartphone iphone = new Iphone(numero: "11975200247", modelo: "iPhone 11", imei: "222222222", memoria: 64);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");
iphone.ReceberLigacao();