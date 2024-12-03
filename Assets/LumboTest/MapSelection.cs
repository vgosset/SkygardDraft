using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MapSelection : MonoBehaviour
{
    [SerializeField] private List<MapItem> maps;
    [SerializeField] private GameObject randomButton;
    [SerializeField] private PlayerItem player1;
    [SerializeField] private PlayerItem player2;
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
    public void SelectMap(MapItem map)
    {
        if (state != SelectionState.Ban) return;

        map.SetState(state);
        maps.Remove(map);
        if (state == SelectionState.Ban && currentPlayer == 1)
        {
            player2.HasBan();
            randomButton.SetActive(true);
            state = SelectionState.Select;
        }
        else
        {
            StartCoroutine(Cor_SwitchToPlayer2());
        }
    }
    private IEnumerator Cor_SwitchToPlayer2()
    {
        currentPlayer++;
        player1.HasBan();
        yield return new WaitForSeconds(1f);
        player2.SetBanState(true);
    }
    public void SelectRandomMap()
    {
        int rdmRemove = Random.Range(0, maps.Count);
        maps[rdmRemove].SetState(state);
        maps.RemoveAt(rdmRemove);
        maps[0].SetSelected();
    }
    public void Reset()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
