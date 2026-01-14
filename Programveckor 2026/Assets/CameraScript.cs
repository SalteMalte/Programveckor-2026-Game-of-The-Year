using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraScript : MonoBehaviour
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
        float positionx = trf.position.x;
        float positiony = trf.position.y;
        ChangeBackToMap.PlayerPosition = new Vector3(positionx, positiony, 0);
        ChangeBackToMap.PlayerScene = SceneManager.GetActiveScene().buildIndex;
        print("camera update" + ChangeBackToMap.PlayerScene);
        if (Input.GetKeyDown(KeyCode.E))
        {
            Invoke("scenechanger", 1.5f);
        }




    }
    public void scenechanger()
    {
        SceneManager.LoadScene(4);
    }
}
