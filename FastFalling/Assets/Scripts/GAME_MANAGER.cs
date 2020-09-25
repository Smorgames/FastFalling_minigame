using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GAME_MANAGER : MonoBehaviour
{
    public static GAME_MANAGER instance;

    private void Awake()
    {
        instance = this;
    }

    private int _score;
    [SerializeField] private TextMeshProUGUI _scoreText;

    [SerializeField] private GameObject _losePanel;

    private void Start()
    {
        SetStartScore();
    }

    public void GameOver()
    {
        Time.timeScale = 0f;
        _losePanel.SetActive(true);
    }

    public int GetScore()
    {
        return _score;
    }

    public int GetBestScore()
    {
        return PlayerPrefs.GetInt("BestScore", 0);
    }

    public void SetBestScore(int amount)
    {
        PlayerPrefs.SetInt("BestScore", amount);
    }

    private void SetStartScore()
    {
        _score = 0;
        _scoreText.text = _score.ToString();
    }

    public void AddScore(int amount)
    {
        _score += amount;
        _scoreText.text = _score.ToString();
    }
}
