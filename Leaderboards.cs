using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leaderboards : MonoBehaviour
{
    public void SavePlayerScore(string playerName, int score)
    {
        PlayerPrefs.SetInt(playerName, score);
        PlayerPrefs.Save();
    }
    public int LoadPlayerScore (string playerName)
    {
        return PlayerPrefs.GetInt(playerName,0);
    }
    // // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    // // Update is called once per frame
    // void Update()
    // {
        
    // }
}
