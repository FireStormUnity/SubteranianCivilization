using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteOnPress : MonoBehaviour
{
    private void OnMouseDown()
    {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Collider2D hitCollider = Physics2D.OverlapPoint(mousePosition);

        if (hitCollider && hitCollider.gameObject == gameObject)
        {
            Destroy(gameObject);
        }
    }


}


