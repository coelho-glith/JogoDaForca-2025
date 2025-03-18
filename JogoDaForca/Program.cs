namespace JogoDaForca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string[] palavras =
            {
             "ABACATE",
             "ABACAXI",
             "ACEROLA",
             "ACAI",
             "ARACA",
             "ABACATE",
             "BACABA",
             "BACURI",
             "BANANA",
             "CAJA",
             "CAJU",
             "CARAMBOLA",
             "CUPUACU",
             "GRAVIOLA",
             "GOIABA",
             "JABUTICABA",
             "JENIPAPO",
             "MACA",
             "MANGABA",
             "MANGA",
             "MARACUJA",
             "MURICI",
             "PEQUI",
             "PITANGA",
             "PITAYA",
             "SAPOTI",
             "TANGERINA",
             "UMBU",
             "UVA",
             "UVAIA"
         };

            Random geradorDeNumeros = new Random();

            int indiceEscolhido = geradorDeNumeros.Next(palavras.Length);

            string palavraEscolhida = palavras[indiceEscolhido];

            char[] letrasEncontradas = new char[palavraEscolhida.Length];

            for (int caractereAtual = 0; caractereAtual < letrasEncontradas.Length; caractereAtual++)
                letrasEncontradas[caractereAtual] = '_';


            int quantidadeErros = 0;
            bool jogadorGanhou = false;
            bool jogadorPerdeu = false;

            do
            {
                string letrasEncontradasCompleta = String.Join(" ", letrasEncontradas);

                string cabecaDoDesenho = quantidadeErros >= 1 ? " o " : " ";
                string troncoDoDesenho = quantidadeErros >= 2 ? "x" : " ";
                string troncoInferiorDoDesenho = quantidadeErros >= 2 ? " x " : " ";
                string bracoEsquerdoDoDesenho = quantidadeErros >= 3 ? "/" : " ";
                string bracoDireitoDoDesenho = quantidadeErros >= 4 ? "\\\\" : " ";
                string pernasDoDesenho = quantidadeErros >= 5 ? "/ \\\\" : " ";

                Console.Clear();
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Jogo da Forca");
                Console.WriteLine("---------------------------------");
                Console.WriteLine(" ___________                     ");
                Console.WriteLine(" |/        |                     ");
                Console.WriteLine(" |        {0}                    ", cabecaDoDesenho);
                Console.WriteLine(" |        {0}{1}{2}              ", bracoEsquerdoDoDesenho, troncoDoDesenho, bracoDireitoDoDesenho);
                Console.WriteLine(" |        {0}                    ", troncoInferiorDoDesenho);
                Console.WriteLine(" |        {0}                    ", pernasDoDesenho);
                Console.WriteLine(" |                               ");
                Console.WriteLine(" |                               ");
                Console.WriteLine(" |                               ");
                Console.WriteLine(" |                               ");
                Console.WriteLine("_|____                           ");
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Erros do jogador: " + quantidadeErros);
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Palavra escolhida: " + String.Join(" ", letrasEncontradasCompleta));
                Console.WriteLine("---------------------------------");


                Console.Write("Digite uma letra válida: ");
                string entradaInicial = Console.ReadLine()!.ToUpper();

                if (entradaInicial.Length > 1)
                {
                    Console.WriteLine("Informe apenas um caractere.");
                    continue;
                }

                char chute = entradaInicial[0];

                bool letraFoiEncontrada = false;

                for (int contadorCaracteres = 0; contadorCaracteres < palavraEscolhida.Length; contadorCaracteres++)
                {
                    char caracterAtual = (palavraEscolhida[contadorCaracteres]);

                    if (chute == caracterAtual)
                    {
                        letrasEncontradas[contadorCaracteres] = caracterAtual;
                        letraFoiEncontrada = true;
                    }
                }

                if (letraFoiEncontrada == false)
                    quantidadeErros++;

                string palavraEncontradaCompleta = String.Join("", letrasEncontradas);

                jogadorGanhou = palavraEncontradaCompleta == palavraEscolhida;

                if (jogadorGanhou)
                {
                    Console.WriteLine("-----------------------------------------------------------");
                    Console.WriteLine($"Você acertou a palavra {palavraEscolhida}, Parabéns!");
                    Console.WriteLine("-----------------------------------------------------------");
                }

                jogadorPerdeu = quantidadeErros > 5;

                if (jogadorPerdeu)
                {
                    Console.WriteLine("-----------------------------------------------------------");
                    Console.WriteLine($"Que azar! Tente novamente!");
                    Console.WriteLine("-----------------------------------------------------------");
                }

            } while (jogadorGanhou == false && jogadorPerdeu == false);

            Console.ReadLine();
        }
    }
}
