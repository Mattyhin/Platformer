using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class StartNPCDialogue : MonoBehaviour
{
    public NPCConversation dialogue;
    public bool isPlayerNear = false;
    
    public GameObject icon;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerNear = true;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerNear = false;

            if (icon != null)
            {
                icon.SetActive(true);
            }

            if (ConversationManager.Instance.IsConversationActive)
            {
                ConversationManager.Instance.EndConversation();
            }
        }
    }

    private void Update()
    {
        if (isPlayerNear && Input.GetKey(KeyCode.F))
        {
            ConversationManager.Instance.StartConversation(dialogue);
        }
    }
}
