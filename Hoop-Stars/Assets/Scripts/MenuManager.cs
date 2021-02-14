using UnityEngine;

public class MenuManager : MonoBehaviour
{

    public void LoadFirstLevel() {

        Application.LoadLevel(1); 
    }

    public void LoadSecondLevel()
    {
        Application.LoadLevel(2);
    }

    public void LoadBonusLevel()
    {
        Application.LoadLevel(3);
    }
}
