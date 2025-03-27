using UnityEngine;

public class HitInimigo : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("AtaquePlayer")) 
        {
            gameObject.SetActive(false);
        }
    }
}
