using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    private void Start()
    {
        Collider2D[] colliders = transform.GetComponentsInChildren<Collider2D>();
        

        for (int i = 0; i < colliders.Length; i++)
        {
            for(int k = i + 1; k < colliders.Length; k++)
            {
                Physics2D.IgnoreCollision(colliders[i], colliders[k]);
            }
        }
    }

    private void Update()
    {
        Collider2D[] colliders = transform.GetComponentsInChildren<Collider2D>();

        if (colliders.Length == 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
