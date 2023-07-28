using System.Net.Http.Headers;
using tabuleiro;
using xadrez;


namespace chess_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Posicao P;

                //P = new Posicao(3,4);
                // Console.WriteLine("Posicao: "+P);                                      
                PartidaDeXadrez partida = new PartidaDeXadrez();
                while (!partida.terminada)
                {
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab);
                    Console.WriteLine();


                    Console.Write("Origem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                    Console.Write("Destino: ");
                    Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

                    partida.executaMovimento(origem, destino);


                }
                   
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}