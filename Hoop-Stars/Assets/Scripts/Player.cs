using UnityEngine;
using DG.Tweening;


public class Player : MonoBehaviour
{
    private Rigidbody _body;
    [SerializeField] private float _jumpPower = 1.0f;
    [SerializeField] private int _jumpsNumber = 1;
    [SerializeField] private float duration = 1.0f;
    [SerializeField] private Vector2 addend = new Vector2(0.0f, 0.0f);

    

    private void Awake()
    {
        _body = GetComponent<Rigidbody>();
    }

    public void AddForce(Direction direction) {

        float factor = (direction == Direction.LEFT)? -1:1;      
        Vector3 targetLocation = new Vector3(transform.position.x + addend.x * factor, transform.position.y + addend.y, transform.position.z);

        _body.DOJump(targetLocation, _jumpPower, _jumpsNumber, duration, false);
    
   
    }


    private void FixedUpdate()
    {
        
        


    }


}

public enum Direction : byte
{
    LEFT, RIGHT
}