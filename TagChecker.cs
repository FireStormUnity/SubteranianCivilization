using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TagChecker : MonoBehaviour
{
    public GameObject winPanel;
    public GameObject losePanel;

    void Update()
    {
        if (GameObject.FindWithTag("Soldier") == null)
        {
            losePanel.SetActive(true);
        }
        else if (GameObject.FindWithTag("Enemy") == null)
        {
            winPanel.SetActive(true);
        }
    }
}
