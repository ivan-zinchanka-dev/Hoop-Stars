using System.Collections;
using UnityEngine;
using TMPro;

public class Announcer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _leftText;
    [SerializeField] private TextMeshProUGUI _rightText;
    [SerializeField] private float _maxRotationAngle = 30.0f;
    [SerializeField] private float _duration = 1.0f;
    [SerializeField] private string[] _words;

    private RectTransform _leftRect;
    private RectTransform _rightRect;  

    private void SetText() {

        if (Random.Range(0, 2) == 0)
        {
            StartCoroutine(Display(_leftText, _leftRect, Direction.LEFT));
        }
        else {

            StartCoroutine(Display(_rightText, _rightRect, Direction.RIGHT));
        } 
    }

    private IEnumerator Display(TextMeshProUGUI text, RectTransform rect, Direction direction) { 
    
        text.text = _words[Random.Range(0, _words.Length)] + '!';
        rect.rotation = Quaternion.Euler(0.0f, 0.0f, Random.Range(0.0f, _maxRotationAngle * (int)direction));
        
        yield return new WaitForSeconds(_duration);
        text.text = string.Empty;
    }

    private void Start()
    {
        _leftRect = _leftText.GetComponent<RectTransform>();
        _rightRect = _rightText.GetComponent<RectTransform>();

        Hoop.Goal += SetText;
    }


}
