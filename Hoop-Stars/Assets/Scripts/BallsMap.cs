using System.Collections; 
using UnityEngine;

public class BallsMap : MonoBehaviour
{
    //private byte _targetScore;
    private GameManager _gameManager;
    [SerializeField] private BallBehaviour _ball;

    [SerializeField] private Vector2 OldBallPosition = new Vector2(0,0);  

    private void Start()
    {
        _gameManager = GetComponent<GameManager>();

        //_targetScore = (byte)(_gameManager.TargetScore * 2);
        //InitPositionsArray(_targetScore);

        Trigger.Goal += delegate (){
            
            Vector2 NewBallPosition = new Vector2(Random.Range(-15, 15), Random.Range(-10, 18));

            while (NewBallPosition == OldBallPosition) {

                NewBallPosition = new Vector2(Random.Range(-15, 15), Random.Range(-10, 18));
            }
            
            _ball.SetBall(NewBallPosition);

            OldBallPosition = NewBallPosition;

        };

    }



}
