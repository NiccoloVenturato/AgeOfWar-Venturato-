// See https://aka.ms/new-console-template for more information
using AgeOfWar.Personaggi_del_gioco;

Console.WriteLine("BENVENUTO SU AGE OF WAR");
Cavaliere CavaliereCapo = new Cavaliere(75);
Cavaliere[] SquadraRossa = new Cavaliere[100];
for (int i = 0;i< SquadraRossa.Length;i++)
{
   SquadraRossa[i] = new Cavaliere(50);
    SquadraRossa[i].Squadra = "Squadra Rossa";

}





















