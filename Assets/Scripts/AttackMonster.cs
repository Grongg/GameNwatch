using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackMonster : MonoBehaviour
{
    public SpriteRenderer[] MonsterRight;
    public SpriteRenderer[] MonsterLeft;
    public SpriteRenderer[] IceBlock;
    private int StateLeft = 0;
    private int StateRight = 0;
    private int StateIce = 0;
    public int Speed;
    public int Rand;

    private int timer = 0;
    void AttackinMonster()
    {
        // Use switch + separate Right and Left in 2 functions to make it cleaner
        if (StateRight == 0 && Random.Range(0, Rand) == 1)
        {
            MonsterRight[0].color = new Color (1f, 1f, 1f, 1f);
            MonsterRight[1].color = new Color (1f, 1f, 1f, 0.1f);
            StateRight = 1;
        }
        else if (StateRight == 1)
        {
            MonsterRight[0].color = new Color (1f, 1f, 1f, 0.1f);
            MonsterRight[1].color = new Color (1f, 1f, 1f, 1f);
            StateRight = 2;
        }
        else if (StateRight == 2)
        {
            MonsterRight[0].color = new Color (1f, 1f, 1f, 0.1f);
            MonsterRight[1].color = new Color (1f, 1f, 1f, 0.1f);
            StateRight = 0;
        }
        if (StateLeft == 0 && Random.Range(0, Rand) == 1)
        {
            MonsterLeft[0].color = new Color (1f, 1f, 1f, 1f);
            MonsterLeft[1].color = new Color (1f, 1f, 1f, 0.1f);
            StateLeft = 1;
        }
        else if (StateLeft == 1)
        {
            MonsterLeft[0].color = new Color (1f, 1f, 1f, 0.1f);
            MonsterLeft[1].color = new Color (1f, 1f, 1f, 1f);
            StateLeft = 2;
        }
        else if (StateLeft == 2)
        {
            MonsterLeft[0].color = new Color (1f, 1f, 1f, 0.1f);
            MonsterLeft[1].color = new Color (1f, 1f, 1f, 0.1f);
            StateLeft = 0;
        }
    }

    void AttackinIceBlock()
    {
        // Use switch to make it cleaner
        if (StateIce == 0 && Random.Range(0, Rand) == 1)
        {
            IceBlock[0].color = new Color (1f, 1f, 1f, 1f);
            IceBlock[1].color = new Color (1f, 1f, 1f, 0.1f);
            IceBlock[2].color = new Color (1f, 1f, 1f, 0.1f);
            StateIce = 1;   
        }
        else if (StateIce == 1)
        {
            IceBlock[0].color = new Color (1f, 1f, 1f, 0.1f);
            IceBlock[1].color = new Color (1f, 1f, 1f, 1f);
            IceBlock[2].color = new Color (1f, 1f, 1f, 0.1f);
            StateIce = 2;
        }
        else if (StateIce == 2)
        {
            IceBlock[0].color = new Color (1f, 1f, 1f, 0.1f);
            IceBlock[1].color = new Color (1f, 1f, 1f, 0.1f);
            IceBlock[2].color = new Color (1f, 1f, 1f, 1f);
            StateIce = 3;
        }
        else if (StateIce == 3)
        {
            IceBlock[0].color = new Color (1f, 1f, 1f, 0.1f);
            IceBlock[1].color = new Color (1f, 1f, 1f, 0.1f);
            IceBlock[2].color = new Color (1f, 1f, 1f, 0.1f);
            StateIce = 0;
        }
    }
    void FixedUpdate()
    {
        timer++;
        if (timer >= Speed)
        {
            if (MonsterLeft.Length > 0 && MonsterRight.Length > 0)
                AttackinMonster();
            else
                AttackinIceBlock();
            timer = 0;
        }
    }
}
