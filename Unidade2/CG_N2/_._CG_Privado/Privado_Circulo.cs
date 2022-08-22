/**
  Autor: Dalton Solano dos Reis
**/

#define CG_Debug
#define CG_OpenGL

using OpenTK.Graphics.OpenGL;
using CG_Biblioteca;

// ATENÇÃO: remover: "Privado_"
namespace gcgcg
{
  internal class Privado_Circulo : ObjetoGeometria
  {
    private double raio;

    public Privado_Circulo(char rotulo, Objeto paiRef, Ponto4D ptoCentro, double raio) : base(rotulo, paiRef)
    {
      this.raio = raio;
      Ponto4D pto = new Ponto4D();
      for (int angulo = 0; angulo < 360; angulo += 10)
      {
        pto = Matematica.GerarPtosCirculo(angulo, raio);
        pto += ptoCentro;
        base.PontosAdicionar(pto);
      }
    }

    protected override void DesenharObjeto()
    {
#if CG_OpenGL
      GL.Begin(base.PrimitivaTipo);
      foreach (Ponto4D pto in pontosLista)
      {
        GL.Vertex2(pto.X, pto.Y);
      }
      GL.End();
#endif
    }

#if CG_Debug
    //TODO: melhorar para exibir não só a lista de pontos (geometria), mas também a topologia ... poderia ser listado estilo OBJ da Wavefrom
    public override string ToString()
    {
      string retorno;
      retorno = "__ Objeto Privado_Circulo: " + base.rotulo + "\n";
      for (var i = 0; i < pontosLista.Count; i++)
      {
        retorno += "P" + i + "[" + pontosLista[i].X + "," + pontosLista[i].Y + "," + pontosLista[i].Z + "," + pontosLista[i].W + "]" + "\n";
      }
      return (retorno);
    }
#endif

  }
}