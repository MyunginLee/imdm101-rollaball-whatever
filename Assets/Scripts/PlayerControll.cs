using System.Drawing;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class PlayerControl : MonoBehaviour
{
    private Rigidbody rb;
    float movementX, movementY;
    public float speed = 3f;
    private int count = 0;
    public TextMeshProUGUI textinput;
    public GameObject winText;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        winText = GameObject.Find("win");
        winText.SetActive(false);
    }

    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();
        movementX = movementVector.x;
        movementY = movementVector.y;
    }

    //// Update is called once per frame
    //void Update()
    //{
    //    Debug.Log("Update: " + Time.deltaTime);
    //}
    private void FixedUpdate()
    {
        //Debug.Log("Fixed: " + Time.deltaTime);
        Vector3 movement = new Vector3(movementX, 0, movementY);           


        //// Apply force to the Rigidbody to move the player.
        rb.AddForce(movement * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("Collide!!!");
        if (other.gameObject.CompareTag("Collectibles")){
            other.gameObject.SetActive(false);
            count = count + 1;
            Debug.Log(count);
            textinput.text = count.ToString();

            if(count > 30)
            {
                winText.SetActive(true);
            }

        }
    }


}
