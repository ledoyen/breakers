using UnityEngine;

public class BallBehaviour : MonoBehaviour
{

    public Ball ball;

    void Update()
    {
        if (Input.GetKey("space"))
        {
            ball.inMotion = true;
            ball.Detach();
        }
        if (ball.inMotion)
        {
            transform.position += ball.moveVector * ball.speed * Time.deltaTime;
        }
    }
}
