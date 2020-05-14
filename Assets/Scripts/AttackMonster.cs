using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackMonster : MonoBehaviour
{
    public SpriteRenderer[] MonsterRight;
    public SpriteRenderer[] MonsterLeft;
    public SpriteRenderer[] IceBlock;
    private int StateLeft = 0;
    private int randleft = 0;
    private int StateRight = 0;
    private int randright = 0;
    private int StateIce = 0;
    private int randice = 0;

    int timer = 0; 
    void AttackinMonster()
    {
        if (StateRight == 0)
        {
            randright = Random.Range(0, 6);
            if (randright == 1)
            {
                MonsterRight[0].color = new Color (1f, 1f, 1f, 1f);
                MonsterRight[1].color = new Color (1f, 1f, 1f, 0.5f);
                StateRight = 1;
            }
        }
        else if (StateRight == 1)
        {
            MonsterRight[0].color = new Color (1f, 1f, 1f, 0.5f);
            MonsterRight[1].color = new Color (1f, 1f, 1f, 1f);
            StateRight = 2;
        }
        else if (StateRight == 2)
        {
            MonsterRight[0].color = new Color (1f, 1f, 1f, 0.5f);
            MonsterRight[1].color = new Color (1f, 1f, 1f, 0.5f);
            StateRight = 0;
        }
        if (StateLeft == 0)
        {
            randleft = Random.Range(0, 6);
            if (randleft == 1)
            {
                MonsterLeft[0].color = new Color (1f, 1f, 1f, 1f);
                MonsterLeft[1].color = new Color (1f, 1f, 1f, 0.5f);
                StateLeft = 1;
            }
        }
        else if (StateLeft == 1)
        {
            MonsterLeft[0].color = new Color (1f, 1f, 1f, 0.5f);
            MonsterLeft[1].color = new Color (1f, 1f, 1f, 1f);
            StateLeft = 2;
        }
        else if (StateLeft == 2)
        {
            MonsterLeft[0].color = new Color (1f, 1f, 1f, 0.5f);
            MonsterLeft[1].color = new Color (1f, 1f, 1f, 0.5f);
            StateLeft = 0;
        }
    }

    void AttackinIceBlock()
    {
        if (StateIce == 0)
        {
            randice = Random.Range(0, 6);
            if (randice == 1)
            {
                IceBlock[0].color = new Color (1f, 1f, 1f, 1f);
                IceBlock[1].color = new Color (1f, 1f, 1f, 0.5f);
                IceBlock[2].color = new Color (1f, 1f, 1f, 0.5f);
                StateIce = 1;   
            }
        }
        else if (StateIce == 1)
        {
            IceBlock[0].color = new Color (1f, 1f, 1f, 0.5f);
            IceBlock[1].color = new Color (1f, 1f, 1f, 1f);
            IceBlock[2].color = new Color (1f, 1f, 1f, 0.5f);
            StateIce = 2;
        }
        else if (StateIce == 2)
        {
            IceBlock[0].color = new Color (1f, 1f, 1f, 0.5f);
            IceBlock[1].color = new Color (1f, 1f, 1f, 0.5f);
            IceBlock[2].color = new Color (1f, 1f, 1f, 1f);
            StateIce = 3;
        }
        else if (StateIce == 3)
        {
            IceBlock[0].color = new Color (1f, 1f, 1f, 0.5f);
            IceBlock[1].color = new Color (1f, 1f, 1f, 0.5f);
            IceBlock[2].color = new Color (1f, 1f, 1f, 0.5f);
            StateIce = 0;
        }
    }
    void FixedUpdate()
    {
         timer++;
        if (timer == 20)
        {
            if (MonsterLeft.Length > 0 && MonsterRight.Length > 0)
                AttackinMonster();
            else
                AttackinIceBlock();
            timer = 0;
        }
    }
}
