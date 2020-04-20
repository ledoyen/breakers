using System;
using UnityEngine;

public class PlayerBarBehavior : MonoBehaviour
    {
        public PlayerBar playerBar { get; set; }
        public bool initialized = false;

        void Update()
        {
            if (playerBar == null)
            {
                return;
            }

            Camera cam = Camera.main;
            float maxHeight = 2f * cam.orthographicSize;
            float maxWidth = maxHeight * cam.aspect;

            if (Input.GetKey("left"))
            {
                playerBar.position = Math.Max(playerBar.position - playerBar.speed, - maxWidth / 2 + playerBar.width / 2);
            }
            else if (Input.GetKey("right"))
            {
                playerBar.position = Math.Min(playerBar.position + playerBar.speed, maxWidth / 2 - + playerBar.width / 2);
            }

            playerBar.DrawLine();
        }
    }