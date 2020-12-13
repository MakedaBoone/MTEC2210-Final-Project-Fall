using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    float timer = 0;
    float move = 0.5f;
    int totalMoves = 0;
    float speed = 0.01f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime; 
            if (timer > move)
        {
            transform.Translate(new Vector3(speed, 0, 0));
            timer = 0;
            totalMoves++;
        }
            if(totalMoves == 5){
            transform.Translate(new Vector3(0, -0.05f, 0));
            totalMoves = 0;
            speed = -speed;
        }
    }
}
