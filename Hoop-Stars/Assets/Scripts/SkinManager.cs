using UnityEngine;

public class SkinManager : MonoBehaviour
{
    [SerializeField] private TorusBehaviour _player;
    [SerializeField] private BallBehaviour _ball;
    [SerializeField] private Material _topaz;
    [SerializeField] private Material[] _skins;

    public static Material selectedBallMaterial; 

    private void Start()
    {
        Material selectedTorusMaterial = _skins[(int)MenuManager.HoopSkin];
        _player.GetComponentInChildren<Renderer>().material = selectedTorusMaterial;

        selectedBallMaterial = (MenuManager.LevelMode == LevelType.BONUS) ? _topaz : _skins[(int)MenuManager.BallSkin];
        _ball.GetComponentInChildren<Renderer>().material = selectedBallMaterial;
    }


}
