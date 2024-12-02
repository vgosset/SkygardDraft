using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;
using TMPro;
public class MapSelection : MonoBehaviour
{
    [SerializeField] private List<MapItem> maps;
    [SerializeField] private TextMeshPro playerTxt;
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
        playerTxt.text = "Player 1 : Ban !";
    }
    public void SelectMap(MapItem map, int id)
    {
        map.SetState(state);
        if (state == SelectionState.Ban && currentPlayer == 1)
        {
            state = SelectionState.Select;
        }
        else
        {
            playerTxt.text = "Player 2 : Ban !";
        }
    }
}
