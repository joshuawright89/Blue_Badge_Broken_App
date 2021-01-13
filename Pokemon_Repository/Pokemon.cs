using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Repository
{
    public enum PokemonType
    {
        Normal = 1,
        Grass,
        Fire,
        Water,
        Electric = 5,
        Ice,
        Bug,
        Ground,
        Rock,
        Fighting = 10,
        Psychic,
        Ghost,
        Dark,
        Fairy,
        Dragon = 15,
        None = 16
    }
    public class Pokemon
    {
        public string PokemonSpeciesName { get; set; }
        public string PokemonNickName { get; set; }
        public int Level { get; set; }
        public PokemonType PokemonPrimaryType { get; set; }
        public PokemonType PokemonSecondaryType { get; set; }
        public string MoveOne { get; set; }
        public string MoveTwo { get; set; }
        public string MoveThree { get; set; }
        public string MoveFour { get; set; }

        public Pokemon(string pokemonSpeciesName, string pokemonNickName, int level, PokemonType pokemonPrimaryType, PokemonType pokemonSecondaryType, string moveOne, string moveTwo, string moveThree, string moveFour)
        {
            //TeamPosition = teamPosition;
            PokemonSpeciesName = pokemonSpeciesName;
            PokemonNickName = pokemonNickName;
            Level = level;
            PokemonPrimaryType = pokemonPrimaryType;
            PokemonSecondaryType = pokemonSecondaryType;
            MoveOne = moveOne;
            MoveTwo = moveTwo;
            MoveThree = moveThree;
            MoveFour = moveFour;
        }

        public Pokemon() { }
    }
}
