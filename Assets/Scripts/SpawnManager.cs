using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;

    private float startDelay = 2;
    private float endDelay = 1.5f;




    private void Start()
    {
        InvokeRepeating("animalSpawn",startDelay,endDelay);
    }

    private void Update()
    {
        
    }

   
    
    
    private void animalSpawn()
    {
       
            int animalIndex = Random.Range(0, animalPrefabs.Length);
            int randomX = Random.Range(-16, 16);
        Instantiate(animalPrefabs[animalIndex], new Vector3(randomX, 0, 25), animalPrefabs[animalIndex].transform.rotation);
    }
}
