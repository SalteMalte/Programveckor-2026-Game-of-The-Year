using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeBackToMap : MonoBehaviour
{
    public static Vector3 PlayerPosition;
    public static int PlayerScene;
    float x = 3;
    float y = 4;

    private string SceneToGo;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Invoke("scenechangerbacktomap", 0.5f);
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            print(x + " " + y);
            if (PlayerPosition.y < y + 1 && PlayerPosition.y > y - 1 && PlayerPosition.x < x + 1 && PlayerPosition.x > x - 1 && ChangeBackToMap.PlayerScene == 3)
            {
                Invoke("scenechangetopuzzle1", 0.5f);
            }
        }
    }
    public void scenechangerbacktomap()
    {
        //spara position
        PlayerPrefs.SetFloat("posX", PlayerPosition.x);
        PlayerPrefs.SetFloat("posY", PlayerPosition.y);
        SceneManager.LoadScene(ChangeBackToMap.PlayerScene);
    }
    public void scenechangetopuzzle1()
    {
        PlayerPrefs.SetFloat("posX", PlayerPosition.x);
        PlayerPrefs.SetFloat("posY", PlayerPosition.y);
        SceneManager.LoadScene(1);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        try
        {
            SceneToGo = collision.gameObject.GetComponent<PuzzleObject>().SceneName;
        }
        catch { }
    }
}
