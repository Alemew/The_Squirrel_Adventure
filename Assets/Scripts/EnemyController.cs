using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class EnemyController : MonoBehaviour
{
    public static EnemyController sharedInstance;
    
    private Rigidbody2D _rigidbody2D;
    public float runningSpeed = -2.0f;//velocidad
    private Vector3 startPosition;

    private void FixedUpdate()
    {
        if (GameManager.sharedInstance.currentGameState==GameState.inTheGame)
        {
            if (_rigidbody2D.velocity.x<runningSpeed)
            {
                _rigidbody2D.velocity = new Vector2(-runningSpeed, _rigidbody2D.velocity.y);
                //_rigidbody2D.velocity = Vector2.right * runningSpeed;
            }
        }
        
    }

    private void Awake()
    {
        startPosition = this.transform.position;
        this._rigidbody2D = GetComponent<Rigidbody2D>();
        sharedInstance = this;

    }

    // Start is called before the first frame update
    public void StartGame()
    {
       
        this.transform.position = startPosition;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
   
}
