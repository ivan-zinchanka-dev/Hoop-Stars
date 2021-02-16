using UnityEngine;

public class Player : TorusBehaviour
{

    private Renderer render;

    private void Start()
    {
        //render = GetComponentInChildren<Renderer>();
        //render.material.color = Color.blue;
    }


    public void Jump(Direction direction) {

        float factor = (direction == Direction.LEFT)? -1:1;
        _body.velocity = Vector3.zero;
        _body.AddForce(new Vector3(factor, 1, 0) * _jumpPower, ForceMode.Impulse); 
    }

}

