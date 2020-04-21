using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    PlayerBar playerBar;

    void Start()
    {
        playerBar = new PlayerBar(1F);
        new Ball(playerBar, 0.25F);
    }
}
