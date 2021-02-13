using UnityEngine;

public class Trigger : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        BallBehaviour ball;

        if (ball = other.GetComponent<BallBehaviour>()) {

            if (ball.IsDestructible) {

                Destroy(ball.gameObject, 0.25f); 
            }

            Debug.Log("GOAL!");        
        }


    }


}
