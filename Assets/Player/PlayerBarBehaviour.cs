using System.Collections.Generic;
using System.Linq;
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

        Vector3? otarget = null;
        if (Input.GetKey("left"))
        {
            otarget = new Vector3(-maxWidth / 2 + playerBar.width / 2, transform.position.y);
        }
        else if (Input.GetKey("right"))
        {
            otarget = new Vector3(maxWidth / 2 - playerBar.width / 2, transform.position.y);
        }

        if (otarget != null)
        {
            var target = otarget.Value;
            var transforms = new List<Transform>();
            transforms.Add(transform);
            transforms.AddRange(playerBar.attachedBalls.Select(ab => ab.gameObject.transform));

            foreach (var t in transforms)
            {
                target.y = t.position.y;
                t.position = Vector3.MoveTowards(
                                t.position,
                                target,
                                playerBar.speed * Time.deltaTime);
            }
        }
    }
}
