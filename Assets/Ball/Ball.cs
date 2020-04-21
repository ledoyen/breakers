using UnityEngine;

public class Ball
{
    public readonly GameObject gameObject;
    private readonly LineRenderer line;
    private readonly PlayerBar bar;

    public bool inMotion = false;
    private float size;
    public float speed = 9F;
    public Vector3 moveVector = new Vector3(0, 1);

    public Ball(PlayerBar bar, float size)
    {
        this.bar = bar;
        this.size = size;
        gameObject = new GameObject("Ball");

        line = gameObject.AddComponent<LineRenderer>();
        line.useWorldSpace = false;
        line.startWidth = size;
        line.SetPositions(new Vector3[]{
            new Vector3(- size / 2, 0),
            new Vector3(size / 2, 0)
        });
        gameObject.transform.position = bar.line.transform.position + new Vector3(0, size / 2 + bar.line.startWidth / 2);

        BallBehaviour ballBehaviour = gameObject.AddComponent<BallBehaviour>();
        ballBehaviour.ball = this;
    }

    public void Detach() {
        bar.Detach(this);
    }
}
