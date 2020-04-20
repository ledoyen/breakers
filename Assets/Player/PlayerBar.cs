using UnityEngine;
public class PlayerBar
{

    private readonly GameObject playerBar;
    private readonly LineRenderer line;

    public float width = 1;
    public float speed = 0.1F;
    public float position
    {
        get; set;
    } = 0;

    public PlayerBar(float width)
    {
        playerBar = new GameObject("PlayerBar");
        line = playerBar.AddComponent<LineRenderer>();
        PlayerBarBehavior playerBarBehaviour = playerBar.AddComponent<PlayerBarBehavior>();
        playerBarBehaviour.playerBar = this;
        this.width = width;

        line.startWidth = 0.25F;
    }

    public void DrawLine()
    {
        line.SetPositions(new Vector3[]{
            new Vector3(position - width / 2, -4.5F),
            new Vector3(position + width / 2, -4.5F)
        });
    }

    
}