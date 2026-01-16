using UnityEngine;

public class Playermovement : MonoBehaviour
{
    Transform trf;
    Rigidbody2D rb;
    public Animator anim;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        trf = GetComponent<Transform>();
        rb = GetComponent<Rigidbody2D>();
        float positionx = PlayerPrefs.GetFloat("posX", 0);
        float positiony = PlayerPrefs.GetFloat("posY", 0);
        trf.position = new Vector2(positionx, positiony);
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = 0;
        float y = 0;

        if (Input.GetKey(KeyCode.W))
        {
            y = 5;
            anim.Play("walk up");
        }

        if (Input.GetKey(KeyCode.S))
        {
            y = -5;
            anim.Play("walk down");
        }

        if (Input.GetKey(KeyCode.A))
        {
            x = -5;
            anim.Play("Left", 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            x = 5;
            anim.Play("walk right");
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            y = 5;
            anim.Play("Up");
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            y = -5;
            anim.Play("walk down");
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            x = -5;
            anim.Play("Left");
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            x = 5;
            anim.Play("walk right");
        }
        if (x == 0 && y == 0)
        {
            anim.Play("idle");
        }






        rb.linearVelocity = new Vector2(x, y);


    }

}


