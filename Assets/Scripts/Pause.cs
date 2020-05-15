using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    [SerializeField] private GameObject Game, Bear, Fish, IceBlock, Player;

    // Start is called before the first frame update
    private IEnumerator Start()
    {
        Game.GetComponent<GameMaster>().enabled = false;
        Bear.GetComponent<AttackMonster>().enabled = false;
        Fish.GetComponent<AttackMonster>().enabled = false;
        IceBlock.GetComponent<AttackMonster>().enabled = false;
        Player.GetComponent<Player>().enabled = false;
        yield return new WaitForSeconds(5);
        Game.GetComponent<GameMaster>().enabled = true;
        Bear.GetComponent<AttackMonster>().enabled = true;
        Fish.GetComponent<AttackMonster>().enabled = true;
        IceBlock.GetComponent<AttackMonster>().enabled = true;
        Player.GetComponent<Player>().enabled = true;
    }
}
