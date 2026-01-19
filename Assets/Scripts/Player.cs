using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private GameController _gameController;
    [SerializeField] private float _jump;

    private bool _isGrounded = true;
    private int _points;

    private void Start()
    {
        _points = 0;
    }

    private void Update()
    {

        if (Input.GetKey(KeyCode.Space) && _isGrounded == true)
        {
            _rigidbody.velocity = new Vector2(_rigidbody.velocity.x, _jump);
            _isGrounded = false;

        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ground")
        {
            _isGrounded = true;
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "coin")
        {
            Destroy(collision.gameObject);
            _points++;
            _gameController.UpdatePoints(_points);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        _isGrounded = false;
    }
}
