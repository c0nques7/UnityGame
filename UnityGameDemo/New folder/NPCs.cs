using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCs : Interactable {
    public string[] dialogue;
    public new string name;

    public override void Interact()
    {
        DialogueSystem.Instance.AddNewDialogue(dialogue, name);
        Debug.Log("interacting with npcs");
    }
}
