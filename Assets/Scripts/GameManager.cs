using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Ball")]
    public GameObject ball;

    [Header("Player 1")]
    public GameObject player1Body;
    public GameObject player1Goal;

    [Header("Player 2")]
    public GameObject player2Body;
    public GameObject player2Goal;

    [Header("UI")]
    public GameObject player1ScoreText;
    public GameObject player2ScoreText;

    [Header("Victory")]
    public int winningScore;
    public GameObject victoryScreen;

    private int _player1Score;
    private int _player2Score;

    public void PlayerScored(int player) {
        if(player == 1) {
            _player1Score++;
            player1ScoreText.GetComponent<TextMeshProUGUI>().text = "Player 1: " +_player1Score.ToString();
        } else if (player == 2){
            _player2Score++;
            player2ScoreText.GetComponent<TextMeshProUGUI>().text = "Player 2: " + _player2Score.ToString();
        }
        _checkVictory();
        _ResetPositions();
    }
    private void _ResetPositions() {
        ball.GetComponent<Ball>().ResetPosition();
        player1Body.GetComponent<Player>().ResetPosition();
        player2Body.GetComponent<Player>().ResetPosition();
    }

    private void _checkVictory() {
        if (_player1Score >= winningScore)
        {
            victoryScreen.SetActive(true);
            ball.SetActive(false);
            player1Body.SetActive(false);
            player2Body.SetActive(false);
            victoryScreen.GetComponent<TextMeshProUGUI>().text = "Player 1 WINS!";
        } else if (_player2Score >= winningScore) {
            victoryScreen.SetActive(true);
            ball.SetActive(false);
            player1Body.SetActive(false);
            player2Body.SetActive(false);
            victoryScreen.GetComponent<TextMeshProUGUI>().text = "Player 2 WINS!";
        }
    }
}
