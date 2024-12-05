using UnityEngine;

public class CharacterSelectionItem : MonoBehaviour
{
    private Animator animator;
    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    public void SetBanState(bool state)
    {
        animator.SetBool("Ban", true);
    }
}
