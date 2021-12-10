using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ScoreScipt 
{
    private static int score ;

    private static int highScore;

    public static void IncreaseScore()
    {
        score += 1;
        if(score > highScore)
        {
            highScore += 1;
        }
    }

    public static void ResetScore()
    {
        score = 0;
    }

    public static void setHighScore()
    {
        PlayerPrefs.SetInt("HighScore", highScore);  
    }

    // public static void UpdateHighScore()
    // {
    //     if(score > highScore)
    //     {
    //         highScore = score;
    //     }
    // }

    public static int GetHighScore()
    {
        highScore = PlayerPrefs.GetInt("HighScore");
        return highScore;
    }

    public static int GetScore()
    {
        return score;
    }
}
