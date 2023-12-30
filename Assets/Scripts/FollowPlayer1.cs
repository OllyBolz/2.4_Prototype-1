using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer1 : MonoBehaviour
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
        if ((Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.F)) && thirdPersonView)
        {
            offset = new Vector3(0, 10, -10);
            thirdPersonView = false;
        }
        else if ((Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.T)) && !thirdPersonView)
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
