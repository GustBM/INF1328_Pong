using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 3f;
    public float speedAdjust = 1f;
    public Rigidbody2D rigidbody2D;
    public Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
        Launch();
    }

    private void Launch() {
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;

        rigidbody2D.velocity = new Vector2(speed * x, speed * y);
    }

    public void ResetPosition() {
        rigidbody2D.velocity = Vector2.zero;
        transform.position = startPos;
        Launch();
    }

    void OnCollisionEnter2D(Collision2D col) {
        rigidbody2D.velocity += new Vector2(speedAdjust, speedAdjust);
    }
}
