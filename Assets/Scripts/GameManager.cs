using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private TMP_Text endOfTurnText;

    public int Score
    {
        get { return score; }
        set
        {
            score = value;
            scoreText.text = $"Score: {score}";
        }
    }

    private int score;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        HideEndOfTurnText();
    }

    public void ShowEndOfTurnText()
    {
        endOfTurnText.text = $"You scored {score} points";

        endOfTurnText.gameObject.SetActive(true);
    }
    public void HideEndOfTurnText()
    {
        endOfTurnText.gameObject.SetActive(false);
    }
}
