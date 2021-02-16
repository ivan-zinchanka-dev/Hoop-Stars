using UnityEngine;

public class BallsManager : MonoBehaviour
{
    [SerializeField] private Vector2 OldBallPosition = new Vector2(0,0);
    [SerializeField] private FloatingObject _ball;
    private ObjectsPool _ballsPool;

    private void Start()
    {
        _ballsPool = new ObjectsPool(1, _ball);

        Hoop.Goal += delegate (){
            
            Vector2 NewBallPosition = new Vector2(Random.Range(-15, 15), Random.Range(-10, 18));

            while (NewBallPosition == OldBallPosition) {

                NewBallPosition = new Vector2(Random.Range(-15, 15), Random.Range(-10, 18));
            }

            _ball.ReturnToPool();
            _ball = _ballsPool.GetObject();
            _ball.GetComponent<BallBehaviour>().SetBall(NewBallPosition);
            OldBallPosition = NewBallPosition;
        };
    }

}
