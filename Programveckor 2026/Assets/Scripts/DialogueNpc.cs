using TMPro;
using UnityEngine;
public class DialogueNpc : MonoBehaviour

{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    bool isPlayerNearby = false;
    public GameObject DialogueNpcGame;
    public TMP_Text TMPgame;


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
        Debug.Log("Spelaren valde att prata med NPC:n!");
        Time.timeScale = 1f;
        //DialogueNpcGame.SetActive(false);
        if (step == 0)
        {
            step = 1;
            TMPgame.text = "Vill du hitta honom? Han gick åt den här riktningen --->  (tryck Ja)";

        }
        else if (step == 1)
        {
            TMPgame.text = "Spring!!";
            Invoke(nameof(EndDialogue), 2f);
        }




    }
    // forsätt här i från
    // Här kan du starta NPC-dialogen, t.ex. öppna ny textsekvens
    public void OnNoClicked()
    {
        Debug.Log("Spelaren valde att inte prata.");
        DialogueNpcGame.SetActive(false);
        Time.timeScale = 1f;
        if (step == 0)
        {
            EndDialogue();

        }
        else if (step == 1)
        {
            TMPgame.text = "Ok hejdå";
            Invoke(nameof(EndDialogue), 2f);
        }
    }

    void EndDialogue()
    {
        DialogueNpcGame.SetActive(false);
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