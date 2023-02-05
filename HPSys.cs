using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPSys : MonoBehaviour
{
    public int i;
    public void Die()
    {
        if((i == 1)&&(GameData.Mage >= 1))
        {
            GameData.Mage -= 1;
        }
        if ((i == 2) && (GameData.Archer >= 1))
        {
            GameData.Archer -= 1;
        }
        if ((i == 3) && (GameData.Killer >= 1))
        {
            GameData.Killer -= 1;
        }
    }
}
