using UnityEngine;

public class Ball
{
    private readonly GameObject ball;
    private readonly LineRenderer line;

    public bool inMotion = false;
    private Vector3 position;
    private float size;
    public float speed = 4F;
    public Vector3 moveVector = new Vector3(0, 1);

    public Ball(PlayerBar bar, float size)
    {
        this.position = bar.line.transform.position + new Vector3(0, size / 2 + bar.line.startWidth / 2);
        this.size = size;
        ball = new GameObject("Ball");

        line = ball.AddComponent<LineRenderer>();
        line.useWorldSpace = false;
        line.startWidth = size;
        line.SetPositions(new Vector3[]{
            new Vector3(- size / 2, position.y),
            new Vector3(size / 2, position.y)
        });

        BallBehaviour ballBehaviour = ball.AddComponent<BallBehaviour>();
        ballBehaviour.ball = this;
    }
}
