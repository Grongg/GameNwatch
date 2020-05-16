using TMPro;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameMaster : MonoBehaviour
{
    public GameObject Player, Fish, Bear, IceBlock;
    public GameObject SoundManager;
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
    public TextMeshProUGUI scoretxt;
    public TextMeshProUGUI lvltxt;

    void Start()
    {
        SoundManager.GetComponent<SoundManager>().PlaySound(SoundManager.GetComponent<SoundManager>().Start);
        SoundManager.GetComponent<SoundManager>().PlayMusic();
        Speed = StartSpeed;
        Rand = StartRandom;
        Fish.GetComponent<AttackMonster>().Rand = Rand;
        Bear.GetComponent<AttackMonster>().Rand = Rand;
        IceBlock.GetComponent<AttackMonster>().Rand = Rand;
        Fish.GetComponent<AttackMonster>().Speed = Speed;
        Bear.GetComponent<AttackMonster>().Speed = Speed;
        IceBlock.GetComponent<AttackMonster>().Speed = Speed;
    }

    void Pause()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void DeathManager()
    {
        if (Player.GetComponent<Player>().currentPinguin == 1 
            && Bear.GetComponent<AttackMonster>().StateLeft == 2)
        {
            Player.GetComponent<Player>().State = false;
        }
        if (Player.GetComponent<Player>().currentPinguin == 5 
            && Bear.GetComponent<AttackMonster>().StateRight == 2)
        {
            Player.GetComponent<Player>().State = false;
        }
        if (Player.GetComponent<Player>().currentPinguin == 2 
            && Fish.GetComponent<AttackMonster>().StateLeft == 2)
        {
            Player.GetComponent<Player>().State = false;
        }
        if (Player.GetComponent<Player>().currentPinguin == 4 
            && Fish.GetComponent<AttackMonster>().StateRight == 2)
        {
            Player.GetComponent<Player>().State = false;
        }
         if (Player.GetComponent<Player>().currentPinguin == 3 
            && IceBlock.GetComponent<AttackMonster>().StateIce == 3)
        {
            Player.GetComponent<Player>().State = false;
        }
        if (Player.GetComponent<Player>().State == false)
        {
            SoundManager.GetComponent<SoundManager>().PlaySound(SoundManager.GetComponent<SoundManager>().Death);
            this.GetComponent<GameMaster>().enabled = false;
            Bear.GetComponent<AttackMonster>().enabled = false;
            Fish.GetComponent<AttackMonster>().enabled = false;
            IceBlock.GetComponent<AttackMonster>().enabled = false;
            Player.GetComponent<Player>().enabled = false;
            Invoke("Pause", 2);
        }
    }

    void FixedUpdate()
    {
        Timer++;
        TickTimer++;
        if (TickTimer >= Speed)
        {
            Score += 10;
            scoretxt.text = "Score: " + Score.ToString();
            lvltxt.text = "Level: " + Level.ToString();
            DeathManager();
            SoundManager.GetComponent<SoundManager>().PlaySound(SoundManager.GetComponent<SoundManager>().timeTick);
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
            SoundManager.GetComponent<SoundManager>().PlaySound(SoundManager.GetComponent<SoundManager>().speedUp);
        }
    }
}
