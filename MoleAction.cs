using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoleAction : MonoBehaviour
{
    
        public GameObject prefab;
        private int randX;
        private List<Rigidbody2D> _rigidbody2Ds = new List<Rigidbody2D>();

        void Start()
        {
            InvokeRepeating("CreatePrefab", 0f, 18f);
        }

        void CreatePrefab()
        {
            Vector3 spawnPosition = new Vector3();

        int randomX = -1;

            spawnPosition.x = randomX * 90;
            spawnPosition.y = Random.Range(-120, -20);

            GameObject spawnedObject = Instantiate(prefab, spawnPosition, Quaternion.identity);

            if (spawnPosition.x == -90)
            {
                spawnedObject.transform.eulerAngles = new Vector3(0, 110, 0);
            }
        Rigidbody2D rigidbody2D = spawnedObject.GetComponent<Rigidbody2D>();
        _rigidbody2Ds.Add(rigidbody2D);
    }

        private void FixedUpdate()
        {
            foreach (Rigidbody2D rigidbody2D in _rigidbody2Ds)
            {
                
                
                    rigidbody2D.AddForce(Vector2.right * 1, ForceMode2D.Impulse);
                
            }

        }
    

}
