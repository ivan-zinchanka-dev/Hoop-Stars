using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public static LevelType LevelMode { get; private set;}
    public static Skin BallSkin { get; private set; } = Skin.YELLOW;
    public static Skin HoopSkin { get; private set; } = Skin.PURPLE;

    public void LoadFirstLevel() {

        LevelMode = LevelType.INDESTRUCTIBLE_BALLS;
        Application.LoadLevel(2); 
    }

    public void LoadSecondLevel()
    {
        LevelMode = LevelType.DESTRUCTIBLE_BALLS;
        Application.LoadLevel(2);
    }

    public void LoadBonusLevel()
    {
        LevelMode = LevelType.BONUS;
        Application.LoadLevel(3);
    }

    public void SetHoopSkin(int skin) {

        HoopSkin = (Skin)skin;    
    }

    public void SetBallSkin(int skin) {

        BallSkin = (Skin)skin;
    }

}

public enum Skin : byte { 

    PURPLE, ORANGE, YELLOW
}

public enum LevelType : byte {

    DESTRUCTIBLE_BALLS, INDESTRUCTIBLE_BALLS, BONUS
}

