using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Character
{
    public string Name { get; private set; }
    public int Health {get; private set;}
    public int Attack {get; private set;}
    public int Speed {get; private set;}
    public int Coin {get; private set;}

    // 생성자
    public Character(string name, int health, int attack, int speed, int coin)
    {
        this.Name = name;
        this.Health = health;
        this.Attack = attack;
        this.Speed = speed;
        this.Coin = coin;
    }
}
