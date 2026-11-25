using TMPro;
using UnityEngine;
using System.Collections;
public class Dialogue : MonoBehaviour
{
    public TextMeshProUGUI dialogueText;
    public string[] dialogues =
    {
        "Hey Fig! You lost or something?",
        "My compass? Think I dropped near the graveyard upstairs.",
        "I think maybe Wig got hers still, so we're good!"
    };

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(ShowDialogue());
        }
    }

    IEnumerator ShowDialogue()
    {
        for (int i = 0; i < dialogues.Length; i++)
        {
            dialogueText.text = dialogues[i];
            //dialogueText.text = dialogues[0];
            //dialogueText.text = "Hey Fig! You lost or something?!";
            //second time
            //dialogueText.text = dialogues[1];
            //dialogueText.text = "My compass? Think I dropped near the graveyard upstairs!";
            //third time
            //dialogueText.text = dialogues[2];
            //dialogueText.text = "I think maybe Wig got hers still, so we're good!";
            yield return new WaitForSeconds(3f);
        }
        
        dialogueText.text = "";
    }
}
