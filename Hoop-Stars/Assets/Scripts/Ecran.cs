using UnityEngine;

public class Ecran : MonoBehaviour
{
    [SerializeField] private Player _agent;

    private void OnMouseDown()
    {
        Vector3 tapPosition = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, 
            Input.mousePosition.y, Camera.main.transform.position.z));

        if (tapPosition.x > 0.0f)
        {
            _agent.Jump(Direction.LEFT);          
        }
        else {

            _agent.Jump(Direction.RIGHT);
        }   
    }

}
