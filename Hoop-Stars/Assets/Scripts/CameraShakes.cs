using UnityEngine;
using DG.Tweening;

public class CameraShakes : MonoBehaviour
{
    [SerializeField] private float _force = 1.0f;
    [SerializeField] private float _duration = 0.5f;

    private void Start()
    {
        Hoop.Goal += delegate ()
        {
            transform.DOShakePosition(_duration, Vector3.up * _force, 0, 0, false, false);
        };
    }

}
