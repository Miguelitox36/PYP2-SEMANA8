using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    public string Name { get; set; }
    public int Force { get; set; }
    public int Skill { get; set; }
    public int Vida { get; set; }

    public Jugador(string name, int force, int skill, int life)
    {
        Name = name;
        Fuerza = force;
        Skill = skill;
        Life = life;
    }
}
