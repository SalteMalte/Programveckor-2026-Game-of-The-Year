using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeBackToMapFromPuzzle : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Invoke("ChangeBackToMapFromPussel", 2f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ChangeBackToMapFromPussel()
    {
        SceneManager.LoadScene(ChangeBackToMap.PlayerScene);
    }
}
