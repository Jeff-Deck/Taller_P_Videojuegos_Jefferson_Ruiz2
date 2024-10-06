using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    // Start is called before the first frame update
    public float rotationSpeed=20f;
    void Start()
    {
        Debug.Log("El juego empezó");
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up*rotationSpeed*Time.deltaTime);
    }
}
