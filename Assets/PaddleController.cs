using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public float speed = 10f;
    public bool isPlayer1;
    private float yBound = 4.5f;

    void Update()
    {
        // Get input
        float movement = Input.GetAxis(isPlayer1 ? "Vertical" : "Vertical2") * speed;
        
        // Move paddle
        transform.Translate(Vector3.up * movement * Time.deltaTime);
        
        // Enforce boundaries
        if (transform.position.y > yBound) transform.position = new Vector3(transform.position.x, yBound, 0);
        if (transform.position.y < -yBound) transform.position = new Vector3(transform.position.x, -yBound, 0);
    }
}