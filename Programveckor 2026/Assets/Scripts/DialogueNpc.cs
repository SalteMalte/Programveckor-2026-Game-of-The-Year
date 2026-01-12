using UnityEngine;


public class DialogueNpc : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    bool isPlayerNearby = false;
    public GameObject dialogueUI;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && isPlayerNearby == true)
        {
            print("Spelaren vill prata med Npc");
            dialogueUI.SetActive(true);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("NPC i närheten");
        isPlayerNearby = true;
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        isPlayerNearby = false;
        dialogueUI.SetActive(false);
    }


}