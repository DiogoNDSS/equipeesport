using System;
using Struct;

namespace EQUIPEESPORT
{
  class Program
  {

    static void Main(string[] args)
    {
      //Struct
      Esports esports1 = new();
      esports1.verificarjogo = "League of legends";
      esports1.verificarnomejogador = "kalec";
      esports1.verificarcampeaoprincipal = "gangplank";
      esports1.registrarNumerosFirstBlood = "3";
      esports1.registrarNumeroPentakill = "5";
      esports1.verificarVinculoClube = "Artics";
      esports1.verificartreinoconcluido = "72";
      esports1.verificarvitoriacampeonato = "5";
      esports1.verificarposicao = "top";
      esports1.anodeestreia = "2016";
      esports1.valorcampeonato(1000.0f);
      esports1.valorcampeonato(2000.0f);


      Console.WriteLine(esports1.imprimir());
    }

  }
}