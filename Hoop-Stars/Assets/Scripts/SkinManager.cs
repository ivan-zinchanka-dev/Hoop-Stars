using UnityEngine;

public class SkinManager : MonoBehaviour
{

    [SerializeField] private TorusBehaviour player;
    [SerializeField] private Material[] skins;
    private Material selectedMaterial;

    private void Start()
    {
        selectedMaterial = skins[(int)MenuManager.HoopSkin];
        player.GetComponentInChildren<Renderer>().material = selectedMaterial;
    }


}
