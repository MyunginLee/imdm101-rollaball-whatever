using UnityEngine;

public class CollectibleControl : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(35f, 10f, 34f) * Time.deltaTime);
        //Debug.Log(Time.deltaTime);
    }
}
