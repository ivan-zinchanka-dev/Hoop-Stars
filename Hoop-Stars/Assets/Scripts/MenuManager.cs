using UnityEngine;

public class MenuManager : MonoBehaviour
{
    //public Material[] materials;

    public static LevelType LevelMode { get; private set;}
    public static Skin BallSkin { get; private set; } = Skin.YELLOW;
    public static Skin HoopSkin { get; private set; } = Skin.PURPLE;

    public void LoadFirstLevel() {

        LevelMode = LevelType.INDESTRUCTIBLE_BALLS;
        Application.LoadLevel(1); 
    }

    public void LoadSecondLevel()
    {
        LevelMode = LevelType.DESTRUCTIBLE_BALLS;
        Application.LoadLevel(1);
    }

    public void LoadBonusLevel()
    {
        LevelMode = LevelType.DESTRUCTIBLE_BALLS;
        Application.LoadLevel(2);
    }

    public void SetSkin(int skin) {

        HoopSkin = (Skin)skin;    
    }


}

public enum Skin : byte { 

    PURPLE, ORANGE, YELLOW
}

public enum LevelType : byte {

    DESTRUCTIBLE_BALLS, INDESTRUCTIBLE_BALLS
}

