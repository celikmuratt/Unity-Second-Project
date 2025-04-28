using UnityEngine;

public class DeleteScripts : MonoBehaviour
{


    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
