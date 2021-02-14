using System;
using UnityEngine;

public class Trigger : MonoBehaviour
{

    public static event Action Goal;

    private void OnTriggerEnter(Collider other)
    {
        BallBehaviour ball;

        if (ball = other.GetComponent<BallBehaviour>()) {

            if (Goal != null) {

                Goal.Invoke();            
            }


            //if (ball.IsDestructible) {

            //    Destroy(ball.gameObject, 0.25f); 
            //}

            Debug.Log("GOAL!");        
        }


    }


}
