﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseController78 : MonoBehaviour
{
    private Rigidbody2D BallRigidBody;
    public Camera MainCamera;

    [Header("Ball Movement")]
    public Vector2 ballAngle = new Vector2(100, 100);
    public float speed;
    public ScoreManager78 ScoreManager;
    

    private void Start()
    {
        BallRigidBody = GetComponent<Rigidbody2D>();
        
    }

    private void Update()
    {
        Vector3 target = MainCamera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1));
        Vector3 moveAngle = target - transform.position;

        if (Vector3.Distance(target, transform.position) > 0.5)
            transform.Translate(moveAngle.normalized * speed * Time.deltaTime);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Qube")


        {
            ScoreManager.IncrementScore();
           
            Destroy(col.gameObject);
        }



    }
}
