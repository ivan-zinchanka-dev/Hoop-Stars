using UnityEngine;
using DG.Tweening;

public class Test : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private float _duration;

    private void Start()
    {
        transform.DOMove(_target.position, _duration, false);
        transform.DORotate(_target.rotation.eulerAngles, _duration, RotateMode.Fast);
       
        
        
    }

}
