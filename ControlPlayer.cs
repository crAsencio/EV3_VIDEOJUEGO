using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPlayer : MonoBehaviour
{
    float speed = 5.0f;
    float angle = 5.0f;
    private Animator anim;


    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        float horizontal = Input.GetAxis( "Horizontal" );
        float vertical = Input.GetAxis( "Vertical" );

        transform.Rotate( 0, horizontal*angle, 0, Space.Self );

        Vector3 moveDirection = new Vector3( 0, 0, vertical );
        moveDirection = transform.rotation * moveDirection;
        transform.position += ( moveDirection * speed * Time.deltaTime );

        anim.SetFloat("VelH", horizontal);
        anim.SetFloat("VelV", vertical);


    }
}
