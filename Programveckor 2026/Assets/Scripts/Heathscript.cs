
using UnityEngine;
using UnityEngine.SceneManagement;

public class Heathscript : MonoBehaviour
{
    public ParticleSystem particles;
    public int maxHealth = 20;
    int currentHealth;
    public string Scene;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentHealth = maxHealth;
        Debug.Log("Current Health: " + currentHealth + "/" + maxHealth);
    }

    // Update is called once per frame
    void Update()
    {

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
            SceneManager.LoadScene(Scene);
        }
    }


}

