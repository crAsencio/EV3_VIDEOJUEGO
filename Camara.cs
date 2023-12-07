using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{
    public Transform target;
    public float distance = 5f;
    public float velocidadGiro = 10f;

    void Update()
    {
  
        transform.RotateAround(target.position, Vector3.up, velocidadGiro * Time.deltaTime);
    }
}
