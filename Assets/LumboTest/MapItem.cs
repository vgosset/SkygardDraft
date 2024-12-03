using UnityEngine;

public class MapItem : MonoBehaviour
{
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    public void SetState(MapSelection.SelectionState state)
    {
        if (state == MapSelection.SelectionState.Ban)
        {
            animator.SetBool("Ban", true);
        }
    }
    public void SetSelected()
    {
        animator.SetTrigger("Selected");
    }
}
