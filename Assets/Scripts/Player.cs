using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private CapsuleCollider2D _collider;
    [SerializeField] private float _jump;

    bool _isGrounded = true;

    public void Start()
    {
        
    }

    public void Update()
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

    private void OnCollisionExit2D(Collision2D collision)
    {
        _isGrounded = false;
    }
}
