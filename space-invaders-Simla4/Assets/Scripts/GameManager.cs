using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject gameScene;
    [SerializeField] private GameObject startScene;

    public void StartBtn()
    {
        gameScene.SetActive(true);
        gameScene.SetActive(false);
    }
}
