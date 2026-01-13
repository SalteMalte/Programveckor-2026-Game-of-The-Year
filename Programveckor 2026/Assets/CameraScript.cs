using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraScript : MonoBehaviour
{
    public static float playerpositionx;
    public static float playerpositiony;
    public static float playerpositionz;
    Transform trf;





    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        trf = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            Invoke("scenechanger", 0.5f);
        }

        playerpositionx = trf.position.x;
        playerpositiony = trf.position.y;
        playerpositionz = trf.position.z;
        ChangeBackToMap.PlayerPosition = new Vector3(playerpositionx, playerpositiony, playerpositionz);
        Scene CurrentScene = SceneManager.GetActiveScene();
        ChangeBackToMap.PlayerScene = CurrentScene.buildIndex;


    }
    public void scenechanger()
    {
        SceneManager.LoadScene(4);
    }
}
