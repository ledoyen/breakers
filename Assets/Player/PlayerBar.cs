using System.Collections.Generic;
using UnityEngine;

public class PlayerBar
{
    private readonly GameObject gameObject;
    public readonly LineRenderer line;
    public readonly List<Ball> attachedBalls = new List<Ball>();

    public readonly float height = 0.25F;
    public float width = 1;
    public float speed = 7F;

    public PlayerBar(float width)
    {
        gameObject = new GameObject("PlayerBar");
        line = gameObject.AddComponent<LineRenderer>();
        line.useWorldSpace = false;
        PlayerBarBehaviour playerBarBehaviour = gameObject.AddComponent<PlayerBarBehaviour>();
        playerBarBehaviour.playerBar = this;
        this.width = width;
        gameObject.transform.position += new Vector3(0, -4.5F);

        line.startWidth = height;
        line.SetPositions(new Vector3[]{
            new Vector3(- width / 2, 0),
            new Vector3(width / 2, 0)
        });
    }

    public void Attach(Ball ball) {
        attachedBalls.Add(ball);
    }

    public void Detach(Ball ball) {
        attachedBalls.Remove(ball);
    }
}
