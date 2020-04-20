using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    PlayerBar playerBar;

    void Start()
    {
        playerBar = new PlayerBar(1F);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
