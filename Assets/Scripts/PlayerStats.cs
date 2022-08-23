using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] private float score = 0;
    private ForwardMovement _forwardMovement = default;
    [SerializeField] private float lives = 3;
    [SerializeField] private GameObject gameOver = default;
    [SerializeField] private TextMeshProUGUI _score = default;
    [SerializeField] private TextMeshProUGUI _lives = default;
    [SerializeField] private TextMeshProUGUI _scoreText = default;
 
    private void Start()
    {
        _forwardMovement = GetComponent<ForwardMovement>();
        Time.timeScale = 1f;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Obstacle"))
        {
           ReduceHealth();
        }
    }

    private void ReduceHealth()
    {
        lives--;
        _lives.text = lives.ToString("0");
        if (lives <= 0)
        {
            gameOver.SetActive(true);
            Time.timeScale = 0f;
            _score.text = score.ToString("0");
        }
    }

    public void AddScore()
    {
        score++;
        _scoreText.text = score.ToString("0");
        if (score % 3 == 0)
        {
            _forwardMovement.addSpeed();
        }
    }

    public void RestartScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }
   
}
