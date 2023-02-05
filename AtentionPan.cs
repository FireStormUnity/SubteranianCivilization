using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AtentionPan : MonoBehaviour
{
    public GameObject panelPrefab;
    public float waitTime = 5f;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Root"))
        {
            GameObject panel = Instantiate(panelPrefab, transform.position, transform.rotation);
            StartCoroutine(WaitAndDestroyPanel());
        }
    }

    IEnumerator WaitAndDestroyPanel()
    {
        yield return new WaitForSeconds(waitTime);
        Destroy(gameObject);
        SceneManager.LoadScene("FIGHT");
    }
}

