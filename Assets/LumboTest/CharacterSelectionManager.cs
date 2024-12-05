using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class CharacterSelection : MonoBehaviour
{
    [SerializeField] private List<CharacterSelectionItem> characterItems;
    [SerializeField] private PlayerSelectionItem player1;
    [SerializeField] private PlayerSelectionItem player2;
    [SerializeField] private int banAmount = 1;
    [SerializeField] private int selectId = 0;

    private SelectionState state;
    private PlayerSelectionItem currentPlayer;

    public enum SelectionState
    {
        Ban,
        Select
    }
    private void Start()
    {
        state = SelectionState.Ban;
        player1.SetBanState(true);
        currentPlayer = player1;
    }
    public void SelectCharacter(CharacterSelectionItem character)
    {
        StartCoroutine(Cor_SelectCharacter(character));
    }
    public IEnumerator Cor_SelectCharacter(CharacterSelectionItem character)
    {
        if (state == SelectionState.Ban)
        {
            character.SetBanState(true);
            currentPlayer.SetBanState(false);
            currentPlayer.ShowBannedCharacter(character.Icon);

            ChangePlayer();
            if (currentPlayer == player1)
            {
                state = SelectionState.Select;
                currentPlayer.SetSelectionState(true);
                StopAllCoroutines();
            }
            yield return new WaitForSeconds(0.75f);

            currentPlayer.SetBanState(true);
        }
        else
        {
            selectId++;
            currentPlayer.SetSelectionState(false);
            yield return new WaitForSeconds(0.25f);
            currentPlayer.ShowPickCharacter(character.Icon);
            ChangePlayer();

            if (selectId == 6)
            {
                for (int i = 0; i < characterItems.Count; i++)
                {
                    characterItems[i].DisableInteraction();
                    player1.ShowTeam();
                    player2.ShowTeam();
                    StopAllCoroutines();
                }
            }
            yield return new WaitForSeconds(0.3f);
            currentPlayer.SetSelectionState(true);
        }
    }
    public void Reset()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    private void ChangePlayer()
    {
        currentPlayer = currentPlayer == player1 ? player2 : player1;
    }
}
