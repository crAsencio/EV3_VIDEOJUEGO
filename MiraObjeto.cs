using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiraObjeto : MonoBehaviour
{
    public Transform target;
    public float distance = 5f; //agregue


    void LateUpdate()
    {
        transform.LookAt( target.position );
    }
}
