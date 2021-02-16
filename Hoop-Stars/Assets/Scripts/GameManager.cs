using System;
using System.Collections;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] private int _targetScore = 5;
    [SerializeField] private int _ballPrice = 1;
    [SerializeField] private float _slowingValue = 0.5f;
    [SerializeField] private float _slowingDuration = 1.0f;
    [SerializeField] private float _leftTime = 5.0f;
    [SerializeField] private TextMeshProUGUI _playerScoreText;
    [SerializeField] private TextMeshProUGUI _timerText;
    [SerializeField] private Color _textBacklightColor = Color.yellow;
    [SerializeField] private float _textBacklightDuration = 0.5f;

    private int _playerScore;
    private bool _exitFromSession = false;
    private float _currentTime;                             // time in seconds
    public static event Action StopSession;

    public int TargetScore
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
        StopSession = null;

        if (MenuManager.LevelMode == LevelType.INDESTRUCTIBLE_BALLS) {

            FindObjectOfType<BallsMap>().GetComponent<BallsMap>().enabled = false;        
        }

        _playerScore = 0;
        _currentTime = 0.0f;
    }

    private IEnumerator HighlightText(TextMeshProUGUI text, Color backlightColor) {

        Color standartColor = text.color;
        text.color = backlightColor;
        yield return new WaitForSeconds(_textBacklightDuration);
        text.color = standartColor;
    }

    private void IncreasePlayerScore() {

        if (_playerScore >= _targetScore) return;
        
        _playerScore += _ballPrice; 
        _playerScoreText.text = "Your score: " + _playerScore; 
        StartCoroutine(HighlightText(_playerScoreText, _textBacklightColor));
        
        if (_playerScore == _targetScore) { 
            
            StartCoroutine(EndOfSession()); 
            StopSession(); 
        }
    }

    private void Start()
    {
        Hoop.Goal += IncreasePlayerScore;
    }

    private IEnumerator EndOfSession() {

        float originalTimeScale = Time.timeScale; 
        Time.timeScale *= _slowingValue;
        
        yield return new WaitForSeconds(_slowingDuration);
        
        Time.timeScale = originalTimeScale;
        Application.LoadLevel(0);
    }


    private void Update()
    {

        if (_leftTime <= 0) {

            if (!_exitFromSession) {
              
                StartCoroutine(EndOfSession());
                StopSession();
                _exitFromSession = true;
            }
                             
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
