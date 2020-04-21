using UnityEngine;
public class PlayerBar
{

    private readonly GameObject playerBar;
    public readonly LineRenderer line;

    public readonly float height = 0.25F;
    public float width = 1;
    public float speed = 3F;

    public PlayerBar(float width)
    {
        playerBar = new GameObject("PlayerBar");
        line = playerBar.AddComponent<LineRenderer>();
        line.useWorldSpace = false;
        PlayerBarBehaviour playerBarBehaviour = playerBar.AddComponent<PlayerBarBehaviour>();
        playerBarBehaviour.playerBar = this;
        this.width = width;
        playerBar.transform.position += new Vector3(0, -4.5F);

        line.startWidth = height;
        line.SetPositions(new Vector3[]{
            new Vector3(- width / 2, 0),
            new Vector3(width / 2, 0)
        });
    }
}
