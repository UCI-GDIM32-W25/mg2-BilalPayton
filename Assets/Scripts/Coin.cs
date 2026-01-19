using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private int _speed;
    private void Start()
    {
        
    }

    private void Update()
    {
        gameObject.transform.Translate(Vector3.left * _speed *  Time.deltaTime);

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "destroyer")
        {
            Destroy(gameObject);
        }
    }
}
