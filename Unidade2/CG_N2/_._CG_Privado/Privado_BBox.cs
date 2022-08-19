/**
  Autor: Dalton Solano dos Reis
**/

// ATENÇÃO: remover do método o atributo: bBox
namespace CG_Biblioteca
{
  public abstract class Privado_BBox
  {
    public static bool Dentro(BBox bBox, Ponto4D pto)
    {
      if ((pto.X >= bBox.obterMenorX && pto.X <= bBox.obterMaiorX) &&
          (pto.Y >= bBox.obterMenorY && pto.Y <= bBox.obterMaiorY) &&
          (pto.Z >= bBox.obterMenorZ && pto.Z <= bBox.obterMaiorZ))
      {
        return true;
      }
      return false;
    }
  }
}