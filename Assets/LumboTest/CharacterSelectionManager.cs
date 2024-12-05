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

    private SelectionState state;
    private int currentPlayer = 0;

    public enum SelectionState
    {
        Ban,
        Select
    }
    private void Start()
    {
        state = SelectionState.Ban;
        player1.SetBanState(true);
    }
    public void SelectCharacter(CharacterSelectionItem character)
    {
        if (state != SelectionState.Ban) return;

        character.SetBanState(true);
        if (state == SelectionState.Ban && currentPlayer == 1)
        {
            player2.SetBanState(false);
            state = SelectionState.Select;
            player1.SetSelectionState(0);
        }
        else
        {
            StartCoroutine(Cor_SwitchToPlayer2());
        }
    }
    private IEnumerator Cor_SwitchToPlayer2()
    {
        currentPlayer++;
        player1.SetBanState(false);
        yield return new WaitForSeconds(1f);
        player2.SetBanState(true);
    }
    public void Reset()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
