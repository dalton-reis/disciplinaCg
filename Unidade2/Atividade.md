<!-- [@]TODO:INICIO atualizar -->

[CG_Biblioteca]:                   https://github.com/dalton-reis/disciplinaCg_XXXX-X_not_equipe-XX/tree/master/CG_Biblioteca                           "CG_Biblioteca"  
[CG_Biblioteca_BBox]:              https://github.com/dalton-reis/disciplinaCg_XXXX-X_not_equipe-XX/tree/master/CG_Biblioteca/BBox.cs                   "BBox.cs"  
[CG_Biblioteca_CameraOrtho]:       https://github.com/dalton-reis/disciplinaCg_XXXX-X_not_equipe-XX/tree/master/CG_Biblioteca/CameraOrtho.cs            "CameraOrtho.cs"  
[CG_Biblioteca_Cor]:               https://github.com/dalton-reis/disciplinaCg_XXXX-X_not_equipe-XX/tree/master/CG_Biblioteca/Cor.cs                    "Cor.cs"  
[CG_Biblioteca_Matematica]:        https://github.com/dalton-reis/disciplinaCg_XXXX-X_not_equipe-XX/tree/master/CG_Biblioteca/Matematica.cs             "Matematica.cs"  
[CG_Biblioteca_Ponto4D]:           https://github.com/dalton-reis/disciplinaCg_XXXX-X_not_equipe-XX/tree/master/CG_Biblioteca/Ponto4D.cs                "Ponto4D.cs"  
[CG_Biblioteca_CameraPerspective]: https://github.com/dalton-reis/disciplinaCg_XXXX-X_not_equipe-XX/tree/master/CG_Biblioteca/CameraPerspective.cs      "CameraPerspective.cs"  
[CG_Biblioteca_Transformacao4D]:   https://github.com/dalton-reis/disciplinaCg_XXXX-X_not_equipe-XX/tree/master/CG_Biblioteca/Transformacao4D.cs        "Transformacao4D.cs"  

[CG_N2]:                   https://github.com/dalton-reis/disciplinaCg_XXXX-X_not_equipe-XX/tree/master/unidade_2/CG_N2                                 "CG_N2"  
[CG_N2_Mundo]:             https://github.com/dalton-reis/disciplinaCg_XXXX-X_not_equipe-XX/tree/master/unidade_2/CG_N2/Mundo.cs                        "Mundo.cs"  
[CG_N2_Objeto]:            https://github.com/dalton-reis/disciplinaCg_XXXX-X_not_equipe-XX/tree/master/unidade_2/CG_N2/Objeto.cs                       "Objeto.cs"  
[CG_N2_ObjetoGeometria]:   https://github.com/dalton-reis/disciplinaCg_XXXX-X_not_equipe-XX/tree/master/unidade_2/CG_N2/ObjetoGeometria.cs              "ObjetoGeometria.cs"  
[CG_N2_Retangulo]:         https://github.com/dalton-reis/disciplinaCg_XXXX-X_not_equipe-XX/tree/master/unidade_2/CG_N2/Retangulo.cs                    "Retangulo.cs"  
[CG_N2_Utilitario]:        https://github.com/dalton-reis/disciplinaCg_XXXX-X_not_equipe-XX/tree/master/unidade_2/CG_N2/Utilitario.cs                   "Utilitario.cs"  
[CG_N2_DC]:                https://github.com/dalton-reis/disciplinaCg_XXXX-X_not_equipe-XX/tree/master/unidade_2/CG_N2/svg/plantuml/CG_N2_Completo.svg "Diagrama de Classe CG_N2"  

# Unidade 2 - Atividade  

Lembretes:

- cada quest??o deste trabalho deve ser separada em novas pastas e projetos executados separadamente. Obrigatoriamente devem usar as classes dispon??vel no exemplo: [CG_N2]. Ent??o estude com muita **aten????o** as classes da [CG_Biblioteca]: [CG_Biblioteca_BBox], [CG_Biblioteca_CameraOrtho], [CG_Biblioteca_Cor], [CG_Biblioteca_Matematica], [CG_Biblioteca_Ponto4D]. E do exemplo [CG_N2]: [CG_N2_Mundo], [CG_N2_Objeto], [CG_N2_ObjetoGeometria], [CG_N2_Retangulo], [CG_N2_Utilitario]. As Classes [CG_Biblioteca_CameraPerspective] e [CG_Biblioteca_Transformacao4D] s?? ser??o usadas na Unidade 3, ent??o n??o use elas por enquanto.  
- olhem a especifica????o das classes em: [CG_N2_DC].  
- usem a pasta Unidade2 do GitHub da sua equipe para criar as novas pastas dos projetos e desenvolver/entregar o seu c??digo.  

## 1. Explorar o uso da primitiva gr??fica ponto no SRU  

Implemente uma aplica????o para desenhar um c??rculo no centro do Sistema de Refer??ncia do Universo (SRU), com raio de valor 100. Utilize 72 pontos simetricamente distribu??dos sobre o per??metro do c??rculo e defina as dimens??es da janela do espa??o gr??fico com valores entre -300 a 300, de forma que o resultado final seja o mais parecido com a figura a baixo. Neste caso crie uma nova classe com o nome ```Circulo``` em ```Circulo.cs```.  

![CG-N2_1](./imgs/CG-N2_1.png "CG-N2_1")  

Observa????es:  

- desenhe somente os eixos positivos x e y, cada um com comprimento igual a 200;  
- experimente mudar a cor de fundo da tela para cinza e a cor de desenho dos pontos para amarelo;  
- utilize as fun????es sin(ang) e cos(ang) da Classe [CG_Biblioteca_Matematica] fornecida;  
- n??o ?? permitido usar o comando circle do OpenGL e nem outra implementa????o que n??o use as fun????es da classe [CG_Biblioteca_Matematica].  

## 2. Fun????es de Pan e Zoom  

Crie uma nova aplica????o (ver v??deo abaixo) usando como base o exerc??cio anterior (neste caso o fundo de cor branca e desenho preto) para implementar as fun????es de Pan e Zoom. Para isso implemente uma fun????o de callback de teclado que leia as teclas e os par??metros necess??rios para a fun????o Ortho. Tais par??metros dever??o (se j?? n??o est??o) ser armazenados em uma classe [CG_Biblioteca_CameraOrtho].  

Observa????es:  

- tecla Pan (deslocar para esquerda): E;  
- tecla Pan (deslocar para direita): D;  
- tecla Pan (deslocar para cima): C;  
- tecla Pan (deslocar para baixo): B;  
- tecla Zoom in (aproximar): I;  
- tecla Zoom out (afastar): O.  

N??o esque??a de ???tratar??? os limites de zoom m??nimo e m??ximo sen??o poder?? ocorrer erros de execu????o, ou at?? a invers??o horizontal/vertical do desenho na tela. Geralmente estes ???problemas??? ocorrem devido ao tipo de vari??vel declarada para armazenar o ???passo??? do zoom atual. Lembre de usar a classe ```Circulo``` criada no exerc??cio anterior.  

![CG-N2_2.mov](./imgs/CG-N2_2.mov "CG-N2_2.mov")  

## 3. Desenhando objetos gr??ficos iguais  

Crie uma outra aplica????o para fazer o desenho da imagem abaixo. Os c??rculos tem raio com valor 100. Aqui utilize a classe ```Circulo``` j?? criada e crie uma nova classe com o nome ```SegReta``` em  ```SegReta.cs``` para desenhar o tri??ngulo definido por tr??s segmentos de reta. Utilize a opera????o soma para deslocar o centro das circunfer??ncias para as posi????es apresentadas na imagem abaixo. Esta soma n??o deve ser feita na classe [CG_Biblioteca_Matematica], e sim ser informada no momento que for criado o novo objeto do tipo ```Circulo```, passando um [CG_Biblioteca_Ponto4D] de deslocamento (ptoCentro).  

![CG-N2_3.png](./imgs/CG-N2_3.png "CG-N2_3.png")  

## 4. Primitivas Geom??tricas  

Nesta aplica????o a ideia ?? explorar a utiliza????o das ???primitivas geom??tricas???. As dimens??es da janela do espa??o gr??fico deve ter valores entre -400 a 400. J?? os pontos s??o valores de 200 negativo e positivo de forma que o resultado final seja o mais parecido com o v??deo a baixo.  

No caso a intera????o deve ser:  

- para alternar entre as ???primitivas geom??tricas??? use a tecla de ???barra de espa??o???;  
- as ???primitivas geom??tricas??? que devem ser utilizadas s??o: Points, Lines,  LineLoop,  LineStrip,  Triangles,  TriangleStrip, TriangleFan,  Quads, QuadStrip e Polygon.  

**Aten????o**: s?? deve aparecer em todo o c??digo UM ??NICO ```glBegin``` e ```glEnd``` para informar as primitivas geom??tricas. As imagens abaixo s??o meramente ilustrativas de s?? algumas das ???primitivas???, e n??o precisam aparecer na mesma sequ??ncia.  

![CG-N2_4.mov](./imgs/CG-N2_4.mov "CG-N2_4.mov")  

## 5. Sr. Palito, dando seus primeiros passos  

Agora, crie uma nova aplica????o com o objetivo de poder mover um Segmento de Reta (SR), aqui conhecido com Sr. "Palito", lateralmente usando as teclas Q (esquerda) e W (Direita). Ao iniciar a aplica????o um dos pontos do Sr. Palito est?? na origem. O segundo ponto do Sr. Palito ser?? definido com raio de valor 100 e ??ngulo 45??. Ainda ?? poss??vel usar as teclas A (diminuir) e S (aumentar) para mudar  o tamanho (raio), e as teclas Z (diminuir) e X (aumentar) para girar (??ngulo) do Sr. Palito. Olhe o exemplo no v??deo a baixo. Lembre de usar a classe ```SegReta``` j?? definida no exerc??cio anterior para desenhar o Sr. Palito.  

Ah ... o Sr. Palito n??o se parece muito com o "desenho" do segmento de reta que representa um raio de uma circunfer??ncia !!  

![CG-N2_5.mov](./imgs/CG-N2_5.mov "CG-N2_5.mov")  

## 6. Spline  

J?? esta aplica????o o seu objetivo ?? poder desenhar uma spline (curva polinomial) que permita alterar a posi????o (x,y) dos pontos de controle dinamicamente utilizando o teclado. As dimens??es da janela com valores (xMin: -400, xMax: 400, yMin: -400, yMax: 400) e os pontos s??o valores de 100 negativo e positivo de forma que o resultado final seja o mais parecido com o v??deo a baixo.  

No caso a intera????o deve ser:  

??? para mudar entre o ponto de controle selecionado (em cor vermelha) usar as teclas ???1, 2, 3 e 4???;  
??? para mover o ponto selecionado (um dos pontos de controle) usar as teclas C (cima), B (baixo), E (esquerda) e D (direita);  
??? as teclas do sinal de mais (+) e menos (-) podem aumentar e diminui a quantidade de pontos calculados na spline;  
??? ao pressionar a tecla R os pontos de controle devem voltar aos valores iniciais;  
??? a spline deve ser desenha usando linhas de cor amarela;  
??? o poliedro de controle deve ser desenhado usando uma linha de cor ciano.  

**ATEN????O**: n??o ?? permitido usar o comando spline do OpenGL, sendo s?? permitido usar UMA das formas de splines ???demonstradas em aula???. Ao mover um dos pontos de controle, o poliedro e a spline deve se ajustar aos novos valores deste ponto.  
Veja o exemplo no v??deo a baixo.  

Use a classe ```SegReta``` para desenhar o poliedro de controle e crie uma nova classe para representar o objeto gr??fico Spline em ```Spline.cs```.  

![CG-N2_6.mov](./imgs/CG-N2_6.mov "CG-N2_6.mov")  

## 7. BBox dos c??rculos

E por fim, esta aplica????o tem o objetivo de fazer um joystick virtual. Basicamente deve-se desenhar dois c??rculos (um menor e outro maior) e poder usar o mouse para mover o c??rculo menor, mas sem deixar ele (o centro do c??rculo menor) sair dos limites do c??rculo maior.  

Para controlar o movimento do centro do c??rculo menor deve ser usado:  

??? um teste inicial pela BBox interna do c??rculo maior;  
??? seguido do c??lculo da dist??ncia (euclidiana, sem raiz).  

  ![\normalsize&space;distancia=\sqrt{(x_{2}-x_{1})^2+(y_{2}-y_{1})^2}](https://latex.codecogs.com/svg.latex?\normalsize&space;distancia=\sqrt{(x_{2}-x_{1})^2+(y_{2}-y_{1})^2})  

Exemplo, v??deo a baixo.  

Aqui s?? use as classes [CG_N2_Retangulo] e ```Circulo``` para fazer as representa????es dos objetos abaixo. E n??o esque??a de usar o c??digo da classe [CG_Biblioteca_BBox].  

![CG-N2_7.mov](./imgs/CG-N2_7.mov "CG-N2_7.mov")  

## Aten????o

A avalia????o da atividade envolve o desenvolvimento das quest??es acima apresentadas, mas o mais importante ?? o integrante da equipe demonstrar conhecimento al??m do c??digo desenvolvido, tamb??m os conceitos apresentados em aula relacionados com a atividade em si.

## Gabarito

![Gabarito](AtividadeGabarito_N2.png "Gabarito")  
