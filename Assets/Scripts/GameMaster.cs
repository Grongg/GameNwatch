using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour
{
    public GameObject Player, Fish, Bear, IceBlock;
    public int StartSpeed;
    public int MaxSpeed;
    public int StartRandom;
    public int MaxRandom;
    public int LevelUpSpeed;
    private int Speed;
    private int Rand;
    private int Timer = 0;
    private int TickTimer = 0;
    private int Level = 1;
    private int Score = 0;
    // Start is called before the first frame update
    void Start()
    {
        Speed = StartSpeed;
        Rand = StartRandom;
        Fish.GetComponent<AttackMonster>().Rand = Rand;
        Bear.GetComponent<AttackMonster>().Rand = Rand;
        IceBlock.GetComponent<AttackMonster>().Rand = Rand;
        Fish.GetComponent<AttackMonster>().Speed = Speed;
        Bear.GetComponent<AttackMonster>().Speed = Speed;
        IceBlock.GetComponent<AttackMonster>().Speed = Speed;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Timer++;
        TickTimer++;
        if (TickTimer >= Speed)
        {
            Score += 10;
            TickTimer = 0;
        }
        if (Timer == LevelUpSpeed)
        {
            if (Speed > MaxSpeed)
            {
                Speed -= 2;
                Fish.GetComponent<AttackMonster>().Speed = Speed;
                Bear.GetComponent<AttackMonster>().Speed = Speed;
                IceBlock.GetComponent<AttackMonster>().Speed = Speed;
            }
            if (Rand > MaxRandom && Speed % 4 == 0)
            {
                Fish.GetComponent<AttackMonster>().Rand = Rand;
                Bear.GetComponent<AttackMonster>().Rand = Rand;
                IceBlock.GetComponent<AttackMonster>().Rand = Rand;
            }
            Score += 200;
            Level++;
            Timer = 0;
        }
    }
}
