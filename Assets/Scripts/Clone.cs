using UnityEngine;
// This code find a GO with a specific name and clone multiple times and reposition them
public class Clone : MonoBehaviour
{
    public GameObject mother; // the GO to clone 
    GameObject[] clones;
    float time;
    int numberofCollectibles = 200;
    //GameObject[] Clones; // array of GOs to be cloned
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        clones = new GameObject[numberofCollectibles]; // declare the size of the clones
        // for loop to clone and reposition them

        for (int i = 0; i < numberofCollectibles; i++)
        {
            clones[i] = GameObject.Instantiate(mother);
            clones[i].transform.position = new Vector3(0, 2, i); // x, y, z
        }
    }

    private void FixedUpdate()
    {
        time = time + Time.fixedDeltaTime;
        Debug.Log(time);
        for (int i = 0; i < numberofCollectibles; i++)
        {
            float x = 0.05f * Mathf.Sin(time + i);
            clones[i].transform.position += new Vector3(x, 0, 0.1f); 
        }
    }


}
