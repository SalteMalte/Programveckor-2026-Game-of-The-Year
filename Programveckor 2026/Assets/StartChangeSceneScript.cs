using UnityEngine;
using UnityEngine.SceneManagement;

public class StartChangeSceneScript : MonoBehaviour
{
    public int x = 3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PlayerPrefs.SetFloat("posX", 0);
        PlayerPrefs.SetFloat("posY", 0);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PressStartButtonChangeScene()
    {
        SceneManager.LoadScene(x);
    }
}
