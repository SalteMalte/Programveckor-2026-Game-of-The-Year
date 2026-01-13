using UnityEngine;

public class Buttonappearance : MonoBehaviour
{
    [SerializeField]
    Transform spawnLocation;
    [SerializeField]
    GameObject prefab;
    public Renderer myrenderer2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }
    public float timer = 0;
    bool squareVisible = false;
    // Update is called once per frame
    void Update()
    {
        myrenderer2.enabled = false;

        timer -= Time.deltaTime;

        Vector2 pos = transform.position;
        if (spawnLocation != null)
        {
            pos = spawnLocation.position;
        }
        if (timer < 0 && !squareVisible)
        {
            GameObject spawnedObject = Instantiate(prefab, pos, Quaternion.identity);
            squareVisible = true;
        }

    }
}
