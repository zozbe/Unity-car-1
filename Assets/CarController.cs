using UnityEngine;

public class CarController : MonoBehaviour
{
    public float speed = 10f;               
    public float rotationSpeed = 100f;     
    public Transform[] wheels;            

    void Update()
    {
        
        float move = Input.GetAxis("Vertical") * speed * Time.deltaTime;  
        float rotate = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime; 
        
        transform.Translate(0, 0, move);
        transform.Rotate(0, rotate, 0);

     
        RotateWheels(move);
    }

    void RotateWheels(float move)
    {
        foreach (Transform wheel in wheels)
        {
           
            wheel.Rotate(Vector3.right, move * 360);
        }
    }
}
