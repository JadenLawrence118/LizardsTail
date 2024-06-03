using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FollowCam : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private float followLag = 0.2f;
    [SerializeField] private float offsetX = 0.0f;
    [SerializeField] private float offsetY = 1.0f;
    private Vector3 playerLocation;

    void Update()
    {
        playerLocation = player.transform.position;
        StartCoroutine(Wait(playerLocation));
    }

    IEnumerator Wait(Vector3 camPos)
    {
        yield return new WaitForSecondsRealtime(followLag);
        GetComponent<Transform>().position = new Vector3(camPos.x + offsetX, camPos.y + offsetY, -10);
    }
}
