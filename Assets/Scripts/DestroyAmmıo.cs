using UnityEngine;

public class DestroyAmmıo : MonoBehaviour
{

    private float topbound = 30f;
    private float lowerbound  = -15f;


    private void Update()
    {
        
        if(transform.position.z > topbound)
        {
            Destroy(gameObject);
        }

        if (transform.position.z < lowerbound)
        {
            Debug.Log("Oyun Bitti !!!");
            Destroy(gameObject);    
        }
    }



}
