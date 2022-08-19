# OpenGL (C#.OpenTK)

Para o desenvolvimento do nosso código gráfico iremos usar a biblioteca OpenGL com a ajuda do OpenTK. E com a linguagem C# com exemplo demonstrados no VSCode.  

## Ambiente de Desenvolvimento  

O primeiro passo é ter um ambiente de desenvolvimento com o OpenTK (biblioteca gráfica), SDK do .NET Core (linguagem de programação C#) e a IDE VSCode. Bom, olhe as instruções em [OpenTK SDK - Core VSCode](./README.md#opentk-sdk---core-vscode).  

### OpenTK SDK - Core VSCode

Como executar aplicações utilizando o OpenTK no Visual Studio Code.  

#### Pré-requisitos _________________  

1) ter o SDK do .NET Core (<https://www.microsoft.com/net/download>)  
2) ter o Visual Studio Code (<https://code.visualstudio.com/>)  
3) instalar as extensões do VSCode (disponível no site ou pelo próprio editor - <https://code.visualstudio.com/docs/editor/extension-gallery>):  

- C# (<https://marketplace.visualstudio.com/items?itemName=ms-vscode.csharp>)  
- NuGet Package Manager (<https://marketplace.visualstudio.com/items?itemName=jmrog.vscode-nuget-package-manager>)  

#### Passo a passo

Para os passos a seguir é possível utilizar o prompt do Windows (cmd) ou o terminal do VSCode.  
Crie uma nova pasta que será o diretório do projeto OpenTK no VSCode e navegue até ela. Nesse exemplo o nome da pasta será 'OlaMundo':  

  $ mkdir OlaMundo
  $ cd OlaMundo  

Em seguida crie um Console Application nessa pasta:  

 $ dotnet new console  

Nesse ponto um novo arquivo Program.cs contendo um método main é criado automaticamente. Para executar o projeto digite:  

  $ dotnet run  

Se o projeto foi criado corretamente a mensagem 'Hello World' aparecer no terminal.  
Agora para incluir o OpenTK e os outros pacotes necessários no projeto digite:  

  $ dotnet add package OpenTK --version 3.0.1  
  $ dotnet add package Microsoft.Win32.SystemEvents --version 4.5.0  
  $ dotnet add package System.Drawing.Common --version 4.5.0  

Esses comandos estão disponíveis, respectivamente, em:  

- <https://www.nuget.org/packages/OpenTK/3.0.1>  
- <https://www.nuget.org/packages/Microsoft.Win32.SystemEvents/>  
- <https://www.nuget.org/packages/System.Drawing.Common/>  

Nesse ponto, para testar se o OpenTK está funcionando, acrescente as duas linhas de código a seguir no método main e re-execute o projeto (não se esqueça de adicionar a linha 'using OpenTK;' no cabeçalho da classe):  

  using OpenTK;  
  ...  
  GameWindow window = new GameWindow(600, 600);  
  window.Run(1.0/60.0);  

Uma nova janela em branco deverá aparecer após a execução.  
Caso ocorra algum erro de 'undefined command' tente executar o comando 'dotnet restore' no terminal para recarregar o projeto.  

OBS: Caso apareça algum erro do tipo:  
  'System.IO.FileNotFoundException: Could not load file or assembly...'  
simplesmente pesquise o nome do arquivo que está faltando no site <https://www.nuget.org/> e execute a versão do comando .NET CLI no diretório do projeto pelo terminal.  

##### Para executar projetos OpenTK no Linux _________________  

Se estiver usando o Linux e não funcionou a execução do projeto usando os passos acima, mude no arquivo do projeto (extensão .csproj) da linha:  

  PackageReference Include="OpenTK" Version="3.0.1" /  

para:  

  PackageReference Include="OpenTK.NETCore" Version="*" /  

##### Para criar Class library _________________  

Se caso for preciso criar uma biblioteca - Class library (não esqueça de criar uma nova pasta para este projeto):  

  $ dotnet new classlib  

Nesse ponto um novo arquivo Class1.cs contendo a definição de uma classe é criada automaticamente.  

### CG_N2_OpenTK_NAO_Usar

O segundo passo é olhar o exemplo de código em [CG_N2_OpenTK_NAO_Usar](./CG_N2_OpenTK_NAO_Usar/ "CG_N2_OpenTK_NAO_Usar").  

Este é um exemplo simples usando o OpenTK e sobre-escrevendo os principais métodos usados no Render Gráfico.  

- As classes utilizadas são:  
  
![[erro](https://github.com/dalton-reis/disciplina-cg/blob/master/CG_N2_OpenTK_NAO_Usar/docs/CG_N2_OpenTK_NAO_Usar_Classes.png)](https://github.com/dalton-reis/disciplina-cg/blob/master/CG_N2_OpenTK_NAO_Usar/docs/CG_N2_OpenTK_NAO_Usar_Classes.png "Classes")

- E os métodos do ciclo de Render são:  

![https://github.com/dalton-reis/disciplina-cg/blob/master/CG_N2_OpenTK_NAO_Usar/docs/CG_N2_OpenTK_NAO_Usar_Sequencia.png](https://github.com/dalton-reis/disciplina-cg/blob/master/CG_N2_OpenTK_NAO_Usar/docs/CG_N2_OpenTK_NAO_Usar_Sequencia.png "Sequência")
