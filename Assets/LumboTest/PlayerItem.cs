using UnityEngine;
public class PlayerItem : MonoBehaviour
{
    [SerializeField] private Animator animator;
    public void SetBanState(bool state)
    {
        animator.SetInteger("BanState", 1);
    }
    public void HasBan()
    {
        animator.SetInteger("BanState", 2);
    }
}
