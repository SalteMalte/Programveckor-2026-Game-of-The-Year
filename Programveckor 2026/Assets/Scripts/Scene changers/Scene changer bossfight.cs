using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenechanger : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }
    public int x = 0;
    // Update is called once per frame
    void Update()
    {

    }
    public void scenechanger()
    {
        SceneManager.LoadScene(x);
    }
}
