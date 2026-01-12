using UnityEngine;
public class DialogueNpc : MonoBehaviour

{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    bool isPlayerNearby = false;
    public GameObject DialogueNpcGame;



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
        }


    }
    void ShowDialogue()
    {
        if (Dopen) return;
        Dopen = true;
        // Dopen = Dialogue open

        DialogueNpcGame.SetActive(true);
    }

    void OnYesClicked()
    {
        Debug.Log("Spelaren valde att prata med NPC:n!");
        DialogueNpcGame.SetActive(false);

        // forsätt här i från


        Time.timeScale = 1f;
        // Här kan du starta NPC-dialogen, t.ex. öppna ny textsekvens
    }

    void OnNoClicked()
    {
        Debug.Log("Spelaren valde att inte prata.");
        DialogueNpcGame.SetActive(false);
        Time.timeScale = 1f;
    }




    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("NPC i närheten");
        isPlayerNearby = true;
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        isPlayerNearby = false;
        DialogueNpcGame.SetActive(false);
    }


}