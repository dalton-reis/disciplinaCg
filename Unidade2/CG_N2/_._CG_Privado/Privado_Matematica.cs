/**
  Autor: Dalton Solano dos Reis
**/

using System;

// ATENÇÃO: remover: "Privado_"
namespace CG_Biblioteca
{
  /// <summary>
  /// Classe com funções matemáticas.
  /// </summary>
  public abstract class Privado_Matematica
  {
    public static double DistanciaEuclidiana(Ponto4D pto1, Ponto4D pto2)
    {
      return (Math.Sqrt(DistanciaEuclidianaSemRaiz(pto1, pto2)));
    }

    public static double DistanciaEuclidianaSemRaiz(Ponto4D pto1, Ponto4D pto2)
    {
      return (Math.Pow((pto2.X - pto1.X), 2) + Math.Pow((pto2.Y - pto1.Y), 2));
    }

    public static double ScanLineInterseccao(double yi, double y1, double y2)
    {
      return ((yi - y1) / (y2 - y1));
    }

    public static double ScanLineCalculaXi(double x1, double x2, double ti)
    {
      return (x1 + (x2 - x1) * ti);
    }

    //FIXME: não implementado os casos especiais
    public static bool ScanLine(Ponto4D ptoClique, Ponto4D ptoIni, Ponto4D ptoFim)
    {
      double ti = Privado_Matematica.ScanLineInterseccao(ptoClique.Y, ptoIni.Y, ptoFim.Y);
      if (ti >= 0 && ti <= 1)    // lado do polígono (segmento) Interesecciona a ScanLine
      {
        double xi = Privado_Matematica.ScanLineCalculaXi(ptoIni.X, ptoFim.X, ti);
        if (xi > ptoClique.X)
          return true;
      }
      return false;
    }
  }
}