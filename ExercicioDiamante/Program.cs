using System.Reflection.PortableExecutable;
using System.Runtime.Intrinsics.X86;
using static System.Net.Mime.MediaTypeNames;

namespace ExercicioDiamanteR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opm;
            while(true)
            {
                Cabecalho();

                decimal cor = EscolherCor();
                Cabecalho();

                decimal tamanho = LerInt("\nDigite um valor impar para definir o tamanho da imagem a ser gerada em formato de diamante: ");
                tamanho = CheckImpar(tamanho);

                Cabecalho();
                AplicarCor(cor);
                Equacao(tamanho);

                opm = Rexit();

                if(opm == 1)
                {
                    continue;
                }
                break;
            }
            Exit();
        }
        static void Cabecalho()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Clear();
            Console.WriteLine("######################################################################################");
            Console.WriteLine("###                                                                                ###");
            Console.WriteLine("###                          Academia do programador 2024                          ###");
            Console.WriteLine("###                                                                                ###");
            Console.WriteLine("###                                 Diamante Impar                                 ###");
            Console.WriteLine("###                                                                                ###");
            Console.WriteLine("######################################################################################\n\n");
        }
        static decimal EscolherCor()
        {
            decimal cor;
            while (true)
            {
                 cor = LerInt("\nDigite sua opção de qual cor você quer a imagem.\n\n1. Amarelo\n2. Amarelo Escuro \n3. Azul\n4. Azul Escuro\n5. Branco\n6. Ciano \n7. Ciano Escuro\n8. Verde\n9. Verde Escuro\n10. Magenta\n11. Magenta Escuro\n12. Vermelho\n13. Vermelho Escuro\n\nSua opção: ");
                if(cor != 1 && cor != 2 && cor != 3 && cor != 4 && cor != 5 && cor != 6 && cor != 7 && cor != 8 && cor != 9 && cor != 10 && cor != 11 && cor != 12 && cor != 13)
                {
                    Console.Write("\nO numero digitado não é reconhecido pelo menu, por favor digite um numero válido.\n\nPrecione qualquer tecla para continuar.");
                    continue;
                }
                break;
            }
            return cor;
        }
        static int LerInt(string texto)
        {
            while (true)
            {
                Console.Write(texto);
                var digitouNumero = int.TryParse(Console.ReadLine(), out var numero);

                if (digitouNumero)
                {
                    return numero;
                }

                Console.Write("\nPor favor digite um numero.\n\nPrecione qualquer tecla para continuar.");
                Console.ReadLine();
                Cabecalho();
            }
        }
        static decimal CheckImpar(decimal aux)
        {
            while (true)
            {
                decimal aux2 = aux % 2;
                if (aux2 == 0)
                {
                    aux = LerInt("\nO numero digitado não é impar, por favor digite outro numero impar: ");
                    continue;
                }
                break;
            }
            return aux;
        }
        static void AplicarCor(decimal cor)
        {
            switch (cor)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;

                case 2:
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    break;

                case 3:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;

                case 4:
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    break;

                case 5:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;

                case 6:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    break;

                case 7:
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    break;

                case 8:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;

                case 9:
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    break;

                case 10:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;

                case 11:
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    break;

                case 12:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;

                case 13:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    break;
            }
        }
        private static void Equacao(decimal tamanho)
        {
            decimal espaco = (tamanho / 2) - 0.5m;
            int espaco2 = Convert.ToInt32(espaco);
            int cont = 0;
            int cont2 = espaco2;
            decimal aux = espaco;
            for (int y = 0; y <= aux; y++)
            {
                for (int x = 0; x <= cont2; x++)
                {
                    if (tamanho < 10)
                    {
                        Console.Write(" ");
                    }
                    else if (tamanho < 100)
                    {
                        Console.Write("  ");
                    }
                    else if (tamanho < 1000)
                    {
                        Console.Write("   ");
                    }

                }
                for (int z = 0; z <= cont; z++)
                {
                    Console.Write(tamanho);
                }
                cont = cont + 2;

                Console.Write("\n");
                cont2--;
            }

            int cont3 = 2;
            cont--;
            for (int y = 0; y < aux; y++)
            {
                for (int x = 0; x < cont3; x++)
                {
                    if (tamanho < 10)
                    {
                        Console.Write(" ");
                    }
                    else if (tamanho < 100)
                    {
                        Console.Write("  ");
                    }
                    else if (tamanho < 1000)
                    {
                        Console.Write("   ");
                    }
                }
                cont3++;
                cont = cont - 2;
                for (int z = 0; z < cont; z++)
                {
                    Console.Write(tamanho);
                }
                Console.Write("\n");
            }
            Console.Write("\nPrecione qualquer tecla para continuar.");
            Console.ReadLine();
        }
        static int Rexit() //Rexit = Restart or Exit
        {
            int opm;
            while (true)
            {
                Cabecalho();
                opm = LerInt("\nEscolha sua opção.\n\n1. Desenhar outro diamante\n2. Sair\n\nDigite sua opção: ");
                if (opm != 1 && opm != 2)
                {
                    Console.Write("\nPor favor escolha uma opção valida do menu.\n\nPrecione qualquer tecla para continuar.");
                    Console.ReadLine();
                    continue;
                }
                break;
            }
            return opm;
        }
        static void Exit()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Clear();
            Console.WriteLine("######################################################################################");
            Console.WriteLine("###                                                                                ###");
            Console.WriteLine("###                          Academia do programador 2024                          ###");
            Console.WriteLine("###                                                                                ###");
            Console.WriteLine("###                                 Diamante Impar                                 ###");
            Console.WriteLine("###                                                                                ###");
            Console.WriteLine("###                                    Obrigado                                    ###");
            Console.WriteLine("###                  Até mais. Precione qualquer tecla para sair.                  ###");
            Console.WriteLine("###                                                                                ###");
            Console.WriteLine("######################################################################################");
            Console.ReadLine();
        }
    }
}
