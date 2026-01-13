using UnityEngine;

public class Playermovement : MonoBehaviour
{
    Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        float hämtadX = PlayerPrefs.GetFloat("posX", 0);
        float hämtadY = PlayerPrefs.GetFloat("posY", 0);
        transform.position = new Vector2(hämtadX, hämtadY);

    }

    // Update is called once per frame
    void Update()
    {
        float x = 0;
        float y = 0;

        if (Input.GetKey(KeyCode.W))
        {
            y = 5;
        }

        if (Input.GetKey(KeyCode.S))
        {
            y = -5;
        }

        if (Input.GetKey(KeyCode.A))
        {
            x = -5;
        }

        if (Input.GetKey(KeyCode.D))
        {
            x = 5;
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            y = 5;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            y = -5;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            x = -5;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            x = 5;
        }


        rb.linearVelocity = new Vector2(x, y);











    }
}


