using UnityEngine;

public class CameraPosition : MonoBehaviour
{
    Vector3 cameraPosition, distance;
    GameObject player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.Find("Player");
        cameraPosition = transform.position;
        distance = cameraPosition - player.transform.position;
        Debug.Log(distance);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = distance + player.transform.position;
    }
}
