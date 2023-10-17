using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    //super basic singleton
    public static GameManager Instance;

    private void Awake()
    {
        Instance = this;
    }
    //----------------------

    [SerializeField] private TMP_Text scoreText;

    int totalPumpkins;
    int collectedPumpkins;

    void Start()
    {
        totalPumpkins = GameObject.FindGameObjectsWithTag("pumpkin").Length;
        collectedPumpkins = 0;
        scoreText.text = collectedPumpkins + "/" + totalPumpkins;
    }

    public void CollectPumpkin()
    {

        collectedPumpkins++;

        if(collectedPumpkins>=totalPumpkins)
        {
            GameWin();
        }

        scoreText.text = collectedPumpkins + "/" + totalPumpkins;
    }

    public void GameOver()
    {
        Debug.Log("Game Over");
    }

    public void GameWin()
    {
        Debug.Log("You Win!");
    }
}
