using TMPro;
using UnityEngine;
public class DialogueNpc : MonoBehaviour

{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    bool isPlayerNearby = false;
    public GameObject DialogueNpcGame;
    public TMP_Text TMPgame;
    [SerializeField]
    Transform spawnLocation;
    [SerializeField]
    GameObject prefab;
    [SerializeField]
    Canvas canvas;
    public Renderer myrenderer2;
    public float timer = 0;
    bool squareVisible = false;

    int step = 0;
    void Start()
    {

    }


    private bool Dopen = false;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && isPlayerNearby == true)
        {
            ShowDialogue();
            timer -= Time.deltaTime;
        }


    }
    void ShowDialogue()
    {
        if (Dopen) return;
        Dopen = true;
        // Dopen = Dialogue open

        DialogueNpcGame.SetActive(true);
    }


    public void OnYesClicked()
    {
        Debug.Log("The Player Chose To Speak To The NPC!");
        Time.timeScale = 1f;
        //DialogueNpcGame.SetActive(false);
        if (step == 0)
        {
            step = 1;
            TMPgame.text = "If You Want To Find Your Brother Turn Right ---> ";

        }
        else if (step == 1)
        {
            TMPgame.text = "RUN!";
            myrenderer2.enabled = false;



            Vector2 pos = transform.position;
            if (spawnLocation != null)
            {
                pos = spawnLocation.position;
            }
            if (timer < 0 && !squareVisible)
            {
                GameObject spawnedObject = Instantiate(prefab, pos, Quaternion.identity);
                spawnedObject.transform.parent = canvas.transform;
                squareVisible = true;
            }
        }




    }
    // forsätt här i från
    // Här kan du starta NPC-dialogen, t.ex. öppna ny textsekvens
    public void OnNoClicked()
    {
        Debug.Log("The Player Chose Not To Speak To The NPC!");
        DialogueNpcGame.SetActive(false);
        Time.timeScale = 1f;
        if (step == 0)
        {
            EndDialogue();

        }
        else if (step == 1)
        {
            TMPgame.text = "Ok Goodbye";
            Invoke(nameof(EndDialogue), 2f);
        }
    }

    void EndDialogue()
    {
        DialogueNpcGame.SetActive(false);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("NPC Is Close");
        isPlayerNearby = true;
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        isPlayerNearby = false;
        DialogueNpcGame.SetActive(false);
    }


}