using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeBackToMapFromPuzzle : MonoBehaviour
{
    public static bool CompletedPuzzleOne;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CompletedPuzzleOne = true;
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
