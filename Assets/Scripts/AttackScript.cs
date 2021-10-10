using UnityEngine;

public class AttackScript : MonoBehaviour
{
    [SerializeField]private Animator anim;

    void OnTriggerEnter(Collider collider)
    {
        Debug.Log("TRIGGER");
        if (collider.CompareTag("Alien"))
        {
            anim.SetBool("alien", true);
        }
    }

    void OnTriggerExit(Collider collider)
    {
        if (collider.CompareTag("Alien"))
        {
            anim.SetBool("alien", false);
        }
    }
}
