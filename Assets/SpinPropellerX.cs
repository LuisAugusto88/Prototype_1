using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    public float rotationSpeed = 100f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate(new Vector3(0,0,1) * rotationSpeed * Time.deltaTime);
  
    }
}
