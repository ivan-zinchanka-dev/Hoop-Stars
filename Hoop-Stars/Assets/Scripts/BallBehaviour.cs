using UnityEngine;

public class BallBehaviour : MonoBehaviour
{
    //[SerializeField] private bool isDestructable = false;

    //public bool IsDestructible {

    //    get {

    //        return isDestructable;        
    //    }

    //    private set {

    //        isDestructable = value;
    //    }       
    //}

    public void SetBall(Vector2 position) {

        transform.position = new Vector3(position.x, position.y, transform.position.z);      
    }


    //public void Start()
    //{
    //    Trigger.Goal += delegate () { if (IsDestructible) { Destroy(this.gameObject, 0.25f); } };
    //}

}
