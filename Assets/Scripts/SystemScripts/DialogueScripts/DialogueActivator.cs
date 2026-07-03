using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class DialogueActivator : MonoBehaviour
{
    void Start()
    {
        NPCConversation dialogue = GetComponent<NPCConversation>();
        ConversationManager.Instance.StartConversation(dialogue);
    }
}
