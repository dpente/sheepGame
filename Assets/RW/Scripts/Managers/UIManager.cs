using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;

    public Text sheepSavedText;
    public Text sheepDroppedText;
    public Text highScoreText;
    public GameObject gameOverWindow;

    // Start is called before the first frame update
    private void Start()
    {
        highScoreUpdate();
    }
    void Awake()
    {
        Instance = this;
    }

    //updates sheep saved text 
    public void UpdateSheepSaved()
    {
        sheepSavedText.text = GameStateManager.Instance.sheepSaved.ToString();
    }

    //updates sheep dropped text
    public void UpdateSheepDropped()
    {
        sheepDroppedText.text = GameStateManager.Instance.sheepDropped.ToString();
    }

    //calls for the game over screen when loose condition is meet
    public void ShowGameOverWindow()
    {
        gameOverWindow.SetActive(true);
    }

    public void highScoreUpdate()
    {
        highScoreText.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }
}

