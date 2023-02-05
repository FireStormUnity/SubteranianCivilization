using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RootExtender : MonoBehaviour
{
        public float from;
        public float to;
        public GameObject prefab;
        private Transform spawnPoint;
        private float timeSinceLastInstantiation = 0f;

        private void Start()
        {
            spawnPoint = transform;
        }

        private void Update()
        {
        timeSinceLastInstantiation += Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Space))
            {

                if (timeSinceLastInstantiation >= 0.5f)
                {
                    float zRotation = Random.Range(from, to);
                    Quaternion rotation = Quaternion.Euler(0, 0, zRotation);

                    
                    GameObject newPrefab = Instantiate(prefab, spawnPoint.position, rotation);

                    
                    spawnPoint = newPrefab.transform.Find("SpawnPoint");

                    timeSinceLastInstantiation = 0f;
                }
            }
        }
    


}


