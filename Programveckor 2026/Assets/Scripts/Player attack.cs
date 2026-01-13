using UnityEngine;
using UnityEngine.SceneManagement;

public class Playerattack : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    int bosshealth = 0;
    // Update is called once per frame
    void Update()
    {

    }
    public void scenechange()
    {
        bosshealth = +1;
        if (bosshealth == 5)
        {
            SceneManager.LoadScene(3);
        }

    }
}
