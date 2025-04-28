using UnityEngine;

public class Player : MonoBehaviour
{
    private float horizontal;
    private float xRange = 17f;
    private float speed = 35f;
    public GameObject mermi;

    private void Update()
    {

        horizontal = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * horizontal * speed * Time.deltaTime);



        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);

        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);

        }


        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(mermi,transform.position,mermi.transform.rotation);
        }
    }
}
