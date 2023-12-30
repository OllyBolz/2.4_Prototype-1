using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer2 : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 10, -10);
    private bool thirdPersonView = true;

    void Start()
    {
        transform.position = player.transform.position + offset;
    }

    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.Z) || Input.GetKeyDown(KeyCode.Q)) && thirdPersonView)
        {
            offset = new Vector3(0, 10, -10);
            thirdPersonView = false;
        }
        else if ((Input.GetKeyDown(KeyCode.Z) || Input.GetKeyDown(KeyCode.E)) && !thirdPersonView)
        {
            offset = new Vector3(0, 5, 0);
            thirdPersonView = true;
        }
    }

    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
