using System.Collections;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    [SerializeField] private byte _targetScore = 5;

    public byte TargetScore
    {
        get
        {
            return _targetScore;
        }

        private set
        {
            _targetScore = value;
        }
    }

    [SerializeField] private TextMeshProUGUI _playerScoreText;
    [SerializeField] private TextMeshProUGUI _timerText;
    private byte _playerScore;

    private float _currentTime;                             // time in seconds
    [SerializeField] private float _leftTime = 5.0f;

    

    private string ViewTime(float time)
    {
        float minutes = 0.0f, seconds = time;

        while (seconds > 59)
        {
            seconds -= 60;
            minutes++;
        }

        return string.Format("{0:D2}:{1:D2}", (int)minutes, (int)seconds);
    }

    private void Awake()
    {
        _playerScore = 0;
        Trigger.Goal += delegate () {

            if (_playerScore >= _targetScore) { return;}
            _playerScore++; _playerScoreText.text = "Your score: " + _playerScore;
            if (_playerScore == _targetScore) { StartCoroutine(EndOfSession(true)); }  
        };
    }

    private void Start()
    {
        _currentTime = 0.0f;
    }

    private IEnumerator EndOfSession(bool isVictory) {

        if (isVictory)
        {
            Debug.Log("VICTORY!");
        }
        else {

            Debug.Log("DISMISS!");
        }

        yield return new WaitForSeconds(3);
    }


    private void Update()
    {



        if (_leftTime <= 0) {


            StartCoroutine(EndOfSession(false));

            return;        
        }

        _timerText.text = ViewTime(_leftTime);
        _currentTime += Time.deltaTime;

        if (_currentTime >= 1)
        {
            _leftTime--;
            _currentTime = 0;
        }

    }


}
