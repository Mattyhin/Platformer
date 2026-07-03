using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowZone : MonoBehaviour
{
    public float slowSpeed = 0.5f;
    public float slowJump = 2/3f;
    private float _normalSpeed;
    private float _normalJumpForce;
    public Move move;

    private void Start()
    {
        if (move != null)
        {
            _normalSpeed = move.speed;
            _normalJumpForce = move.jumpForce;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            move.speed = _normalSpeed * slowSpeed;
            move.jumpForce = _normalJumpForce * slowJump;
        }
    }
    
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            move.speed = _normalSpeed;
            move.jumpForce = _normalJumpForce;
        }
    }
}
