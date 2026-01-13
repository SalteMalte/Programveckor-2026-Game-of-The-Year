using UnityEngine;

public class Heathscript : MonoBehaviour
{
    Rigidbody2D rb;
    public ParticleSystem particles;
    public int maxHealth = 20;
    int currentHealth;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        currentHealth = maxHealth;
        Debug.Log("Current Health: " + currentHealth + "/" + maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        //radera denna ->
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
        rb.linearVelocity = new Vector2(x, y);
        //<--void update behöver vara tom 
    }

    //här är health script
    void OnCollisionEnter2D(Collision2D collision)
    {
        //attacken måste ha ett tag som heter "Tag11"
        if (collision.gameObject.CompareTag("Tag11"))
        {
            //Här kan man lägga hur mycket ska health gå ner med. till exempel -1
            currentHealth = Mathf.Max(currentHealth - 1, 0);
            Debug.Log("Current Health: " + currentHealth + "/" + maxHealth);
            particles.Play();
        }
        
        if (currentHealth <= 0)
        {
            Debug.Log("Dead");
        }
    }
}
