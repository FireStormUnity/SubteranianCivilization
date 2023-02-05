using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmyController : MonoBehaviour
{
    public GameObject soldierType1Prefab;
    public GameObject soldierType2Prefab;
    public GameObject soldierType3Prefab;
    public List<GameObject> soldierType1 = new List<GameObject>();
    public List<GameObject> soldierType2 = new List<GameObject>();
    public List<GameObject> soldierType3 = new List<GameObject>();
    private int selectedType = 0; // 0 for no selection, 1 for soldier type 1, 2 for soldier type 2, and 3 for soldier type 3
    private List<GameObject> selectedSoldiers = new List<GameObject>();

    void Start()
    {
        // Instantiate soldiers
        for (int i = 1; i <= GameData.Killer; i++)
        {
            Vector3 position = new Vector3((-8 +i* 1.4f), 0, 0);
            GameObject soldierType1Instance = Instantiate(soldierType1Prefab, position, Quaternion.identity);
            soldierType1.Add(soldierType1Instance);
        }

        for (int i = 1; i <= GameData.Mage; i++)
        {
            Vector3 position = new Vector3((-9 + i * 1.4f), 2, 0);
            GameObject soldierType2Instance = Instantiate(soldierType2Prefab, position, Quaternion.identity);
            soldierType2.Add(soldierType2Instance);
        }

        for (int i = 1; i <= GameData.Archer; i++)
        {
            Vector3 position = new Vector3((-9 + i * 1.4f), -2, 0);
            GameObject soldierType3Instance = Instantiate(soldierType3Prefab, position, Quaternion.identity);
            soldierType3.Add(soldierType3Instance);
        }
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                GameObject clickedObject = hit.transform.gameObject;
                if (soldierType1.Contains(clickedObject))
                {
                    selectedType = 1;
                    selectedSoldiers = soldierType1;
                }
                else if (soldierType2.Contains(clickedObject))
                {
                    selectedType = 2;
                    selectedSoldiers = soldierType2;
                }
                else if (soldierType3.Contains(clickedObject))
                {
                    selectedType = 3;
                    selectedSoldiers = soldierType3;
                }
                else
                {
                    selectedType = 0;
                    selectedSoldiers.Clear();
                }
            }
        }
        else if (Input.GetMouseButtonDown(1) && selectedType != 0)
        {
            Vector3 destination = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            destination.z = 0;
            foreach (GameObject soldier in selectedSoldiers)
            {
                soldier.GetComponent<SoldierAI>().SetDestination(destination);
            }
        }
    }
}