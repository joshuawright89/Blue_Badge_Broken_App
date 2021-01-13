using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Repository
{
    public class PokemonRepository
    {
        public List<Pokemon> _pokemonTeam = new List<Pokemon>();

        //add to list (limit pokemon to 6)
        public void AddPokemonToTeam(Pokemon pokemon)
        {
            _pokemonTeam.Add(pokemon);
        }
        //get list
        public List<Pokemon> GetPokemonTeam()
        {
            return _pokemonTeam;
        }
        //get one pokemon
        public Pokemon GetPokemonByTeamPosition(int teamPosition)
        {
            Pokemon pokemon = _pokemonTeam[teamPosition - 1];
            return pokemon;
        }

        //Alternative to ^^above?
        //Helper method (GetByTeamPosition)
        //public Pokemon GetPokemonByPosition(int teamPosition)
        //{
        //    foreach (Pokemon pokemon in _pokemonTeam)
        //    {
        //       if (pokemon.TeamPosition == teamPosition)
        //        {
        //            return pokemon;
        //        }
        //    }
        //    return null;
        //}




        //update pokemon
        public void UpdatePokemonByTeamPosition(int teamPosition, Pokemon newPokemon)
        {
            //Find
            Pokemon oldPokemon = GetPokemonByTeamPosition(teamPosition);

            //Update
            if (oldPokemon != null)
            {
                Pokemon pokemon = _pokemonTeam[teamPosition - 1];
                pokemon.PokemonSpeciesName = newPokemon.PokemonSpeciesName;
                pokemon.PokemonNickName = newPokemon.PokemonNickName;
                pokemon.Level = newPokemon.Level;
                pokemon.PokemonPrimaryType = newPokemon.PokemonPrimaryType;
                pokemon.PokemonSecondaryType = newPokemon.PokemonSecondaryType;
                pokemon.MoveOne = newPokemon.MoveOne;
                pokemon.MoveTwo = newPokemon.MoveTwo;
                pokemon.MoveThree = newPokemon.MoveThree;
                pokemon.MoveFour = newPokemon.MoveFour;
            }
        }

        public void UpdatePokemonByNickName(string nickName, Pokemon newPokemon)
        {
            foreach(Pokemon p in _pokemonTeam)
            {
                if(nickName == p.PokemonNickName)
                {
                    p.PokemonNickName = newPokemon.PokemonNickName;
                }
            }
        }

        //remove pokemon
        public void RemovePokemonFromTeam(int teamPosition)
        {
            Pokemon pokemon = _pokemonTeam[teamPosition - 1];
            _pokemonTeam.Remove(pokemon);
        }
    }
}
