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
  internal class Privado_SegReta : ObjetoGeometria
  {
    public Privado_SegReta(char rotulo, Objeto paiRef, Ponto4D ptoIni, Ponto4D ptoFim) : base(rotulo, paiRef)
    {
      base.PontosAdicionar(ptoIni);
      base.PontosAdicionar(ptoFim);
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

    //TODO: melhorar para exibir não só a lista de pontos (geometria), mas também a topologia ... poderia ser listado estilo OBJ da Wavefrom
#if CG_Debug
    public override string ToString()
    {
      string retorno;
      retorno = "__ Objeto SegReta: " + base.rotulo + "\n";
      for (var i = 0; i < pontosLista.Count; i++)
      {
        retorno += "P" + i + "[" + pontosLista[i].X + "," + pontosLista[i].Y + "," + pontosLista[i].Z + "," + pontosLista[i].W + "]" + "\n";
      }
      return (retorno);
    }
#endif

  }
}