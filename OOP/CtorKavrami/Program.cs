// See https://aka.ms/new-console-template for more information

using CtorKavrami;

//Console.WriteLine("Hello World");

Siparis s1 = new Siparis();
s1.Adet = 2;
s1.SiparisID = 1;
s1.Tarih = DateTime.Now;

s1.Test();

Siparis s2 = new Siparis();
s2.Adet = 2;
s2.SiparisID = 1;
s2.Tarih = DateTime.Now.AddDays(1);
s2.Adres = "Üsküdar";
s2.Test();

