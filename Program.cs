using DesafioPOO.Models;

// Implementado!!!

Console.WriteLine("Smartphone Iphone");
Smartphone iphoneXR = new Iphone("11972395229", "xr-1105", "555-333-444-222", 128);
iphoneXR.ReceberLigacao();
iphoneXR.InstalarAplicativo("VerboFM");
iphoneXR.Ligar();

Console.WriteLine("-----------------");

Console.WriteLine("Smartphone Iphone");
Smartphone nokia_1000 = new Nokia("11972395229", "nokia-1105", "666-333-222-333", 256);
nokia_1000.ReceberLigacao();
nokia_1000.InstalarAplicativo("Dtel Telecom");
nokia_1000.Ligar();