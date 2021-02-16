using UnityEngine;

public class BallBehaviour : MonoBehaviour
{
    private Renderer render;

    private void Awake()
    {
        render = GetComponent<Renderer>();
    }

    public void SetBall(Vector2 position) {

        render.material = SkinManager.selectedBallMaterial;
        transform.position = new Vector3(position.x, position.y, transform.position.z);      
    }

}
