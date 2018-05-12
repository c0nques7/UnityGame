using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueSystem : MonoBehaviour {
    public static DialogueSystem Instance { get; set; }
    public GameObject dialoguePanel;
    public string npcName;
    public List<string> dialogueLines = new List<string>();

    Button continueButton;
    Text dialogueText, nameText;
    int dialogueIndex;
    
    // use this for initialization
    private void Awake() {
        continueButton = dialoguePanel.transform.FindChild("Continue").GetComponent<Button>();
        dialogueText = dialoguePanel.transform.FindChild("Text").GetComponent<Text>();
        nameText = dialoguePanel.transform.FindChild("Name").GetChild(0).GetComponent<Text>();
        dialoguePanel.SetActive(false);

        continueButton.onClick.AddListener(delegate { ContinueDialoge(); } );

        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
            
    }

    public void AddNewDialogue(string[] lines, string npcName)
    {
        dialogueLines = new List<string>();
        foreach(string line in lines)
        {
            dialogueLines.Add(line);
        }
        this.npcName = npcName;

        Debug.Log(dialogueLines.Count);
        CreateDialogue();
    }

    public void CreateDialogue()
    {
        dialogueText.text = dialogueLines[dialogueIndex];
        nameText.text = npcName;
        dialoguePanel.SetActive(true);
    }

    public void ContinueDialoge()
    {
        if (dialogueIndex < dialogueLines.Count - 1)
        {
            dialogueIndex++;
            dialogueText.text = dialogueLines[dialogueIndex];
        }
        else
        {
            dialoguePanel.SetActive(false);
        }
        }
}