using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public float rotationSpeed = 100.5f;
    
    // Update is called once per frame
    void Update()
    {
        // //Ca c'est le mal, parce que Unity parcourt tout le code pour retrouver notre component Transform()
        // GetComponent<Transform>().Rotate(0f, rotationSpeed * Time.deltaTime, 0f);
        transform.Rotate(0f, rotationSpeed * Time.deltaTime, 0f);
    }
}
