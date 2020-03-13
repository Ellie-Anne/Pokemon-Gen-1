using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Gen_1
{
    class Pokemon
    {
        private string name;
        private string pokemonName;
        private int level;
        private int effortValue;
        private int xp;
        private int hp;
        private int maxHP;
        private int attack;
        private int defence;
        private int specialAttack;
        private int specialDefence;
        private int speed;
        

        public Pokemon (string _name, string _pokemonName, int _level, int _effortValue, int _xp, int _hp, int _maxHP, int _attack, int _defence, int _specialAttack, int _specialDefence, int _speed)
        {
            name = _name;
            pokemonName = _pokemonName;
            level = _level;
            effortValue = _effortValue;
            xp = _xp;
            hp = _hp;
            maxHP = _maxHP;
            attack = _attack;
            defence = _defence;
            specialAttack = _specialAttack;
            specialDefence = _specialDefence;
            speed = _speed;
        }
    }
}
