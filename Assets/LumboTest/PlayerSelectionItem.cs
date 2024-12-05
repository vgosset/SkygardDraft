using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
public class PlayerSelectionItem : MonoBehaviour
{
    [SerializeField] private GameObject banChamp;
    [SerializeField] private Image banChampIcon;
    [SerializeField] private GameObject waitingFeedback;
    [SerializeField] private TMP_Text turnDescription;
    [SerializeField] private GameObject[] pickedCharacters;
    private List<Image> pickedCharactersIcons;
    private int currentPickId = 0;
    private Animator animator;
    private void Start()
    {
        animator = GetComponent<Animator>();
        pickedCharactersIcons = new();
        for (int i = 0; i < pickedCharacters.Length; i++)
        {
            pickedCharactersIcons.Add(pickedCharacters[i].transform.GetChild(0).GetComponent<Image>());
        }
    }
    public void SetBanState(bool state)
    {
        SetWaitingAction("Ban !", state);
    }
    public void SetSelectionState(bool state)
    {
        SetWaitingAction("Pick !", state);
    }
    private void SetWaitingAction(string str, bool state)
    {
        waitingFeedback.SetActive(state);
        turnDescription.gameObject.SetActive(state);
        turnDescription.text = str;
    }
    public void ShowBannedCharacter(Sprite icon)
    {
        banChamp.SetActive(true);
        banChampIcon.sprite = icon;
    }
    public void ShowPickCharacter(Sprite icon)
    {
        pickedCharactersIcons[currentPickId].sprite = icon;
        pickedCharacters[currentPickId].SetActive(true);
        currentPickId++;
    }
    public void ShowTeam()
    {
        animator.SetTrigger("ShowTeam");
    }
}
