using UnityEditor;
using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using TMPro;
using Ink.Runtime;
using UnityEditor.Search;
using UnityEngine.EventSystems;

public class DialogueManager : MonoBehaviour
{
    [Header("Dialogue Ui")]
    [SerializeField] private GameObject dialoguePanel;
    [SerializeField] private TextMeshProUGUI dialogText;

    [Header("Choice")]
    [SerializeField] private GameObject[] choices;
    private TextMeshProUGUI[] choicesText;

    private static DialogueManager instance;
    private Story currentStory;
    public bool dialogueIsPlaying { get; private set; }

    private void Awake()
    {
        if (instance != null)
        {
            Debug.Log("error");
        }
        instance = this;
    }

    public static DialogueManager GetInstance()
    {
        return instance;
    }

    private void Start()
    {
        dialogueIsPlaying = false;
        dialoguePanel.SetActive(false);


        choicesText = new TextMeshProUGUI[choices.Length];
        int index = 0;
        foreach (GameObject choice in choices)
        {
            choicesText[index] = choice.GetComponentInChildren<TextMeshProUGUI>();
            index++;
        }
    }

    private void Update()
    {
        if (!dialogueIsPlaying)
        {
            return;
        }

        if (InputManager.GetInstance().GetSubmitPressed())
        {
            ContinueStory();
        }
    }

    public void EnterDialogueMode(TextAsset inkJSON)
    {
        currentStory = new Story(inkJSON.text);
        dialogueIsPlaying = true;
        dialoguePanel.SetActive(true);

        ContinueStory();
    }

    private IEnumerator ExitDialogueMode()
    {
        yield return new WaitForSeconds(0.2f);
        dialogueIsPlaying = false;
        dialoguePanel.SetActive(false);
        dialogText.text = "";
    }

    private void ContinueStory()
    {
        if (currentStory.canContinue)
        {
            dialogText.text = currentStory.Continue();
            DisplayChoices();
        }
        else
        {
            StartCoroutine(ExitDialogueMode());
        }
    }

private void DisplayChoices()
{
    List<Choice> currentChoices = currentStory.currentChoices;

    if (currentChoices.Count > choices.Length)
    {
        Debug.LogError("Terlalu banyak pilihan: " + currentChoices.Count);
    }

    int index = 0; 

    foreach (Choice choice in currentChoices)
    {
        choices[index].gameObject.SetActive(true);
        choicesText[index].text = choice.text;
        index++; 
    }

    for (int i = index; i < choices.Length; i++) 
    {
        choices[i].gameObject.SetActive(false);
    }

    StartCoroutine(SelectFirstChoice());
}


    private IEnumerator SelectFirstChoice()
    {
        EventSystem.current.SetSelectedGameObject(null);
        yield return new WaitForEndOfFrame();
        EventSystem.current.SetSelectedGameObject(choices[0].gameObject);
    }

    public void MakeChoice(int choiceIndex)
    {
        currentStory.ChooseChoiceIndex(choiceIndex);
    }
}