using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] float _jumpspeed;

    Rigidbody2D _rigidbody;
    Animator _animator;
    CapsuleCollider2D _collider;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
        _collider = GetComponent<CapsuleCollider2D>();
    }

    void Update()
    {
        Jump();

    }

    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Z) == false)
            return;

        _animator.SetBool("isJumping", true);
        _rigidbody.velocity += Vector2.up * _jumpspeed;
    }



}
