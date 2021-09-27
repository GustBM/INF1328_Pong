using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public int player;

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.CompareTag("Ball")) {
            GameObject.Find("GameManager").GetComponent<GameManager>().PlayerScored(player);
        }
    } 
}
