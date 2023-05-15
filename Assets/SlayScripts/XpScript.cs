using UnityEngine;
using System.Collections;

public class XPSystem : MonoBehaviour {

    public int xp = 0;
    public int level = 1;
    public int xpToLevelUp = 100;

    void Start () {
        xp = PlayerPrefs.GetInt("xp", 0);
        level = PlayerPrefs.GetInt("level", 1);
        xpToLevelUp = PlayerPrefs.GetInt("xpToLevelUp", 100);
    }

    void AddXP(int amount) {
        xp += amount;
        if (xp >= xpToLevelUp) {
            LevelUp();
        }
    }

    void LevelUp() {
        level++;
        xp -= xpToLevelUp;
        xpToLevelUp = Mathf.RoundToInt(xpToLevelUp * 1.5f);
    }

    void SavePlayerPrefs() {
        PlayerPrefs.SetInt("xp", xp);
        PlayerPrefs.SetInt("level", level);
        PlayerPrefs.SetInt("xpToLevelUp", xpToLevelUp);
    }

    void OnDestroy() {
        SavePlayerPrefs();
    }
}