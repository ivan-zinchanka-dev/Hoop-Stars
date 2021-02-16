using System;
using UnityEngine;

public class Hoop : MonoBehaviour
{
    private BoxCollider _collider;
    public static event Action Goal;

    private void Awake()
    {
        Goal = null;
    }

    private void Start()
    {
        _collider = GetComponent<BoxCollider>();
        GameManager.StopSession += delegate () { _collider.enabled = false; };

    }

    private void OnTriggerEnter(Collider other)
    {
        BallBehaviour ball;

        if (ball = other.GetComponent<BallBehaviour>()) {

            if (Goal != null) {

                Goal.Invoke();            
            }     
        }
    }


}
