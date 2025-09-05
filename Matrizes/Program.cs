Console.Write("Digite a quantidade de linhas e colunas (x y): ");
string[] quantidadeLinhasColunas = Console.ReadLine().Split(" ");

int quantidadeLinhas = int.Parse(quantidadeLinhasColunas[0]);
int quantidadeColunas = int.Parse(quantidadeLinhasColunas[1]);

int[,] matriz = new int[quantidadeLinhas, quantidadeColunas];

Console.WriteLine("Digite o conteúdo da matriz: ");
for (int linha = 0; linha < quantidadeLinhas; linha++)
{
  string[] conteudoLinha = Console.ReadLine().Split(" ");

  for (int coluna = 0; coluna < quantidadeColunas; coluna++)
  {
    matriz[linha, coluna] = int.Parse(conteudoLinha[coluna]);
  }
}

Console.Write("Digite o número que deseja procurar: ");
int numeroPesquisa = int.Parse(Console.ReadLine());

for (int linha = 0; linha < quantidadeLinhas; linha++)
{
  for (int coluna = 0; coluna < quantidadeColunas; coluna++)
  {
    int? up = null;
    int? down = null;
    int? left = null;
    int? right = null;
    
    if (matriz[linha, coluna] == numeroPesquisa)
    {
      if (linha > 0) up = matriz[linha - 1, coluna];// Se NÃO for a 1ª linha, preenche o up
      if (linha != quantidadeLinhas - 1) down = matriz[linha + 1, coluna];// Se NÃO for a última linha, preenche o down
      if (coluna != 0) left = matriz[linha, coluna - 1];// Se NÃO for a 1ª coluna, preeenche o left
      if (coluna != (quantidadeColunas - 1)) right = matriz[linha, coluna + 1];// Se NÃO for última coluna, preenche o right

      Console.WriteLine($"Position ({linha},{coluna}):");

      if (left != null) Console.WriteLine($"Left: {left}");
      if (right != null) Console.WriteLine($"Right: {right}");
      if (up != null) Console.WriteLine($"Up: {up}");
      if (down != null) Console.WriteLine($"Down: {down}");
      Console.WriteLine();
    }
  }
}