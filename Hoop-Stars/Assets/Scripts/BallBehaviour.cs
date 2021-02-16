using UnityEngine;

public class BallBehaviour : MonoBehaviour
{
    public void SetBall(Vector2 position) {

        transform.position = new Vector3(position.x, position.y, transform.position.z);      
    }

}
