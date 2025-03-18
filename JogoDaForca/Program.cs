using System.Reflection.Metadata;

namespace JogoDaForca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                int quantidadeErros = 0;
                bool enforcou = false;
                bool ganhou = false;
                string[] palavras = {
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


                int indiceEscolhido = GerardorNumericoAleatorio(palavras);
                string palavraEscolhida = palavras[indiceEscolhido];
                char[] letrasEncontradas = new char[palavraEscolhida.Length];

                for (int caractereAtual = 0; caractereAtual < letrasEncontradas.Length; caractereAtual++)
                {
                    letrasEncontradas[caractereAtual] = '_';
                }
                do
                {

                    Forca(quantidadeErros, letrasEncontradas);

                    char chute = Chute();

                    bool letraFoiEncontrada = false;
                    for (int contador = 0; contador < palavraEscolhida.Length; contador++)
                    {
                        char caracterAtual = palavraEscolhida[contador];

                        if (chute == caracterAtual)
                        {
                            letrasEncontradas[contador] = caracterAtual;
                            letraFoiEncontrada = true;
                        }
                    }
                    if (letraFoiEncontrada == false)
                    {
                        quantidadeErros++;
                    }

                    ganhou = Ganhouu(ganhou, palavraEscolhida, letrasEncontradas);
                    enforcou = Enforcouu(enforcou, quantidadeErros, palavraEscolhida);

                } while (enforcou == false && ganhou == false);
                break;
            } while (true);
        }
        static void Forca(int quantidadeErros, char[] letraEncontradas)
        {
            string cabecaDoDesenho = quantidadeErros >= 1 ? " o " : " ";
            string troncoDoDesenho = quantidadeErros >= 2 ? "X" : " ";
            string troncoInferiorDoDesenho = quantidadeErros >= 2 ? " X " : " ";
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
            Console.WriteLine("Palavra escolhida: " + String.Join(" ", letraEncontradas));
            Console.WriteLine("---------------------------------");
        }
        static int GerardorNumericoAleatorio(string[] palavras)
        {
            Random random = new Random();
            int numeroSelecionado = random.Next(palavras.Length);
            return numeroSelecionado;
        }
        static bool Ganhouu(bool ganhou, string palavraEscolhida, char[] letraEncontradas)
        {
            string palavraGanha = String.Join("", letraEncontradas);
            ganhou = palavraGanha == palavraEscolhida;


            if (ganhou)
            {
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine($"Você acertou a palavra secreta {palavraEscolhida}, parabéns!");
                Console.WriteLine("----------------------------------------------");
            }

            return ganhou;
        }
        static bool Enforcouu(bool enforcouu, int quantidadeErros, string palavraEscolhida)
        {
            enforcouu = quantidadeErros > 6;
            if (enforcouu)
            {
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("Que azar! Tente novamente! A palavar era: " + palavraEscolhida);
                Console.WriteLine("----------------------------------------------");
            }
            return enforcouu;
        }
        static char Chute()
        {
            Console.Write("Digite uma letra: ");
            char chute = Console.ReadLine()!.ToUpper()[0];
            return chute;
        }
    }
}