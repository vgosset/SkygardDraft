using UnityEngine;
using UnityEngine.UI;

public class CharacterSelectionItem : MonoBehaviour
{
    public Sprite Icon { get; private set; }
    [field: SerializeField] public Button button;
    [field: SerializeField] public Image image;
    private Animator animator;
    private void Start()
    {
        Icon = image.sprite;
        animator = GetComponent<Animator>();
    }
    public void SetBanState(bool state)
    {
        animator.SetBool("Ban", true);
        button.interactable = false;
    }
    public void DisableInteraction()
    {
        button.interactable = false;
    }
}
