using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {


    private Rigidbody2D _rigidbody;
    private Animator _animatorController;
    public float speed = 5;
    public Vector3 move = Vector3.zero;
    
    public void movePlayer()
    {
        transform.position = Vector3.MoveTowards (transform.position, transform.position + move, speed * Time.deltaTime);
        MoveAnimation();
    }

    private void Idle()
    {
        _animatorController.Play("Idle");
    }
    
    private void MoveAnimation()
    {
        _animatorController.Play("main_character_walk_anim");
    }

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _animatorController = GetComponent<Animator>();
    }

    private void Update()
    {
        if (move == Vector3.zero)
            Idle();
    }


}