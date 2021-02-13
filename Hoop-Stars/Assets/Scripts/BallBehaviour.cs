using UnityEngine;

public class BallBehaviour : MonoBehaviour
{

    [SerializeField] private bool isDestructable = false;
    public bool IsDestructible {

        get {

            return isDestructable;        
        }

        private set {

            isDestructable = value;
        }       
    }



}
