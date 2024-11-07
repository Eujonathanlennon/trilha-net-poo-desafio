using DesafioPOO.Models;

Iphone celular = new Iphone ("(00)1234-5678", "Ïphone 15 Promax", "001", 32)
Console.WriteLine(celular.numero);
celular.Ligar();
celular.ReceberLigacao();
celular.Numero = "(62)985730248";
Console.WriteLine(celular.numero);
celular.InstalarAplicativo("whatsapp");


Nokia celular2 = new nokia  ("(00)1234-5678", "Promanokia camera", "002", 16)
Console.WriteLine(celular2.numero);
celular2.Ligar();
celular2.ReceberLigacao();
celular2.Numero = "(62)993417924";
Console.WriteLine(celular2.numero);
celular.InstalarAplicativo("telegram");

