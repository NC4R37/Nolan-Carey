using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision2D)
    {
       
        Destroy(gameObject);
        
    }
}
