using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject gameOverPanel;
    [SerializeField] private TextMeshProUGUI bestScoreText;
    [SerializeField] private TextMeshProUGUI coinsSumText;

    private SoundsManager soundsManager;
    private Score score = new Score();

    private void Start()
    {
        soundsManager = FindObjectOfType<SoundsManager>();

        if(SceneManager.GetActiveScene().buildIndex == 0)
            Cursor.visible = true;
        else
            Cursor.visible = false;
       
        Load();

        if(gameOverPanel != null)
            gameOverPanel.SetActive(false);
    }

    public void StartSounds()
    {
        soundsManager.PlaySounds(SoundsManager.Sounds.StartGame);
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }
    }
    public void LoadGame(int index)
    {
        Cursor.visible = false;
        SceneManager.LoadScene(index);
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void GameOver(ref int coinsSum, ref int bestScore)
    {
        Cursor.visible = true;
        score.coinsSum = coinsSum;
        score.bestScore = bestScore;
        Save();
        Load();
        gameOverPanel.SetActive(true);
    }

    public void Save()
    {
        string scoreData = JsonUtility.ToJson(score);
        string filePath = Application.persistentDataPath + "/scoreData.json";
        System.IO.File.WriteAllText(filePath, scoreData);
    }

    public void Load()
    {
        string filePath = Application.persistentDataPath + "/scoreData.json";

        if (File.Exists(filePath))
        {
            string fileContent = File.ReadAllText(filePath);

            if (!string.IsNullOrWhiteSpace(fileContent))
            {
                string scoreData = System.IO.File.ReadAllText(filePath);

                score = JsonUtility.FromJson<Score>(scoreData);
                bestScoreText.text = "BEST SCORE " + score.bestScore;
                coinsSumText.text = "COINS IN TOTAL " + score.coinsSum;
            }
            else
            {
                bestScoreText.text = "BEST SCORE 0";
                coinsSumText.text = "COINS IN TOTAL 0";
            }

        }
        else
        {
            bestScoreText.text = "BEST SCORE 0";
            coinsSumText.text = "COINS IN TOTAL 0";
        }
    }
}

[System.Serializable]
public class Score
{
    [SerializeField] private int _coinsSum = 0;

    public int coinsSum
    {
        get { return _coinsSum; }
        set { _coinsSum += value; }
    }

    [SerializeField] private int _bestScore = 0;

    public int bestScore
    {
        get { return _bestScore; }
        set 
        { 
            if (_bestScore < value)
                _bestScore = value; 
        }
    }   
}
