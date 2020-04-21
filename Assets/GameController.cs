using UnityEngine;

public class GameController : MonoBehaviour
{
    PlayerBar playerBar;

    void Start()
    {
        playerBar = new PlayerBar(1F);
        playerBar.Attach(new Ball(playerBar, 0.25F));
    }
}
