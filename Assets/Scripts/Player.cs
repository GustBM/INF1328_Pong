using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private string _objectName;
    public float speed = 2.5f;
    public Rigidbody2D rigidbody2D;
    public Vector3 startPos;
    void Start()
    {
        _objectName = gameObject.name;
        startPos = transform.position;
    }

    void Update()
    {
        // Player Movement START
        float dt = Time.deltaTime;
        Vector2 pos = this.transform.position;
        pos.y += speed * Input.GetAxis(_objectName + "_Vertical") * dt;
        pos.x += speed * Input.GetAxis(_objectName + "_Horizontal") * dt;

        this.transform.position = pos;

        // Player Movement END
    }

    public void ResetPosition() {
        rigidbody2D.velocity = Vector2.zero;
        transform.position = startPos;
    }
}
