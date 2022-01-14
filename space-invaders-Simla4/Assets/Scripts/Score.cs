using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] private Bullet bullet;
    [SerializeField] private Text scoreTxt;

    private int score = 0;

    // Update is called once per frame
    void Update()
    {
        if(bullet.isActive == false)
        {
            ScoreText();
        }
    }

    private void ScoreText()
    {
        if (bullet.State == Bullet.GameState.Invader01)
        {
            score += 30;
        }
        else if (bullet.State == Bullet.GameState.Invader02)
        {
            score += 20;
        }
        else if (bullet.State == Bullet.GameState.Invader03)
        {
            score += 10;
        }
        else if (bullet.State == Bullet.GameState.Mystery)
        {
            score += 40;
        }

        scoreTxt.text = score.ToString();
        bullet.isActive = true;
    }
}
