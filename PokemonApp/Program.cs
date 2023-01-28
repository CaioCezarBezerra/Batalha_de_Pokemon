using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace pooPokemonApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pokedex pokedex = new Pokedex();
            int resp = 100;
            while (resp != 0)
            {
                resp = Menu();
                if (resp == 1)
                {
                    pokedex.ListarPokemons();

                }
                if (resp == 2)
                {
                    pokedex.ListarPokemons();
                    Console.Write("Digite o codigo do pokémon: ");
                    int codigo = Convert.ToInt32(Console.ReadLine());
                    //pegar o pokemon do player

                    PokemonPlus pPlayer = pokedex.Pokemons[codigo];

                    Random r = new Random();
                    codigo = r.Next(0, pokedex.Pokemons.Count);
                    PokemonPlus pPC = pokedex.Pokemons[codigo];


                    Console.WriteLine("Dados do Pokemon que irão Lutar");
                    Console.WriteLine("Dados do seu Pokemon");
                    pPlayer.ExibirDadosPokemonPlus();

                    Console.WriteLine("Dados do Pokemon do PC");
                    pPC.ExibirDadosPokemonPlus();

                    if (pPlayer.Poder >= pPC.Poder)
                    {
                        Console.WriteLine("Parabéns !!!!!  Você galhou ");

                    }
                    else
                    {
                        Console.WriteLine("Que pena!! Você Perdeu.. ");
                    }

                }
                Console.ReadKey();
                Console.Clear();

            }
        }

        static int Menu()
        {
            Console.WriteLine("POKEMON......JOGO DE BATALHA");
            Console.WriteLine("0 - Sair do Jogo");
            Console.WriteLine("1 - Lista Todos os Pokemon");
            Console.WriteLine("2 - Batalhar");
            Console.Write("O que deseja fazer: ");
            int resp = Convert.ToInt32(Console.ReadLine());
            return resp;
        }
    }
}
