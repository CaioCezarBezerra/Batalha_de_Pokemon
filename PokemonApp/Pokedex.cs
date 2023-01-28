using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooPokemonApp
{
    public class Pokedex
    {
        public Pokedex()
        {
            this.InicializaLista();
        }
        private List<PokemonPlus> pokemons;

        public List<PokemonPlus> Pokemons
        {
            get { return pokemons; }
        }

        private void InicializaLista()
        {
            this.pokemons = new List<PokemonPlus>();
            PokemonPlus p = new PokemonPlus("Bulbasauro", "pokemon tipo planta", 70);
            this.pokemons.Add(p);
            /* 1*/
            p = new PokemonPlus("Pikachu", "pokemon tipo raio", 100);
            this.pokemons.Add(p);
            /* 2*/
            p = new PokemonPlus("Mew", "lendario psiquico", 50);
            this.pokemons.Add(p);
            /* 3*/
            p = new PokemonPlus("Mewtow", "lendario psiquico", 40);
            this.pokemons.Add(p);
            /* 4*/
            p = new PokemonPlus("Giratina", "lendario fantasma", 40);
            this.pokemons.Add(p);
            /* 5*/
            p = new PokemonPlus("Flygon", "pokemon dragão", 40);
            this.pokemons.Add(p);
            /* 6*/
            p = new PokemonPlus("Metagron", "pokemon tipo metal", 40);
            this.pokemons.Add(p);
            /* 7*/
            p = new PokemonPlus("Muk", "pokemon tipo metal", 40);
            this.pokemons.Add(p);
            /* 8*/
            p = new PokemonPlus("Metagross", "pokemon tipo toxico", 40);
            this.pokemons.Add(p);
            /* 9*/
            p = new PokemonPlus("Charizard", "pokemon dragao de fogo", 90);
            this.pokemons.Add(p);
            /* 10*/
            p = new PokemonPlus("Squirtle", "pokemon tipo Agua", 60);
            this.pokemons.Add(p);






        }

        public void ListarPokemons()
        {
            for (int i = 0; i < this.Pokemons.Count; i++)
            {
                Console.WriteLine("Código  do pokémon: " + i);
                this.Pokemons[i].ExibirDadosPokemon();

            }
        }




    }
}
