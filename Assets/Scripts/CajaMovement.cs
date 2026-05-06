using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CajaMovement : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        transform.Translate(0, -speed * Time.deltaTime, 0);    
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Caja"))
        {
            Destroy(gameObject);
        }
    }
}