using TMPro;
using UnityEngine;

public class PlayerSelectionItem : MonoBehaviour
{
    [SerializeField] private GameObject waitingFeedback;
    [SerializeField] private TMP_Text turnDescription;
    public void SetBanState(bool state)
    {
        waitingFeedback.SetActive(state);
        turnDescription.gameObject.SetActive(state);
        turnDescription.text = "Ban !";
    }
    public void SetSelectionState(int id)
    {

    }
}
