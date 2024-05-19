using System;
using System.ComponentModel;
using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone]
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia("37652411");
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");


Console.WriteLine("\n");

Console.WriteLine("Smartphone Nokia:");
Smartphone iphone = new Iphone("75716938");
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Facebook");

Console.ReadLine();