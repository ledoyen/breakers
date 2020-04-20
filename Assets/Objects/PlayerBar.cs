using UnityEngine;
public class PlayerBar {

    private GameObject playerBar = new GameObject("PlayerBar");

    public PlayerBar(float width) {
        LineRenderer line = playerBar.AddComponent<LineRenderer>();
        line.startWidth = 0.25F;
        line.SetPositions(new Vector3[]{
            new Vector3(- width / 2, -4.5F),
            new Vector3(width / 2, -4.5F)
        });
    }
}