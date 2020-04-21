using System;
using UnityEngine;

public class PlayerBarBehaviour : MonoBehaviour
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
                transform.position = Vector3.MoveTowards(
                    transform.position,
                    new Vector3(-maxWidth/ 2 + playerBar.width / 2, transform.position.y),
                    playerBar.speed * Time.deltaTime);
            }
            else if (Input.GetKey("right"))
            {
                transform.position = Vector3.MoveTowards(
                    transform.position,
                    new Vector3(maxWidth/ 2 - playerBar.width / 2, transform.position.y),
                    playerBar.speed * Time.deltaTime);
            }
        }
    }
