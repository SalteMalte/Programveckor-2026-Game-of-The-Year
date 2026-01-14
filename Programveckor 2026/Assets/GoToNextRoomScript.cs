using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToNextRoomScript : MonoBehaviour
{
    Transform trf;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        trf = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Doorway"))
        {
            PlayerPrefs.SetFloat("posY", 0);
            SceneManager.LoadScene(3);
        }
    }
}
