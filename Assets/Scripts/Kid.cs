﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kid : MonoBehaviour
{
    [SerializeField]
    private float _speed = 3;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //make kid travel down lanes
        transform.Translate(Vector3.down * _speed * Time.deltaTime);
        if (transform.position.y <= -5.75f) 
        {
            Destroy(this.gameObject);
        }
    }
}
