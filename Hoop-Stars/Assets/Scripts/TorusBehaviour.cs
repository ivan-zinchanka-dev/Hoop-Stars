using UnityEngine;

public class TorusBehaviour : MonoBehaviour
{
    protected Rigidbody _body;
    [SerializeField] protected Vector2 _jumpPower = new Vector2(1.0f, 1.0f);

    private void Awake()
    {
        _body = GetComponent<Rigidbody>();
    }
}

public enum Direction : short
{
    LEFT = 1, RIGHT = -1
}