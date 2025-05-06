using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 20.0f;
    private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float fowardInput;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Mover o veículo para frente
        horizontalInput = Input.GetAxis("Horizontal");
        fowardInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * fowardInput);
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime );
      //  transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
        
    }

    void OntriggerEnter(Collider other)
    {
        if (other.CompareTag("Obstacle"))
        {
            Debug.Log("Colidiu com o obstáculo");
        }
    }
}
