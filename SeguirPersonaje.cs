using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguirPersonaje : MonoBehaviour
{
    public float rangoDeAlerta;

    public LayerMask capaDelJugador; 
    public Transform jugador; 
    bool estarAlerta; 
    public float velocidad; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        estarAlerta =     Physics.CheckSphere(transform.position, rangoDeAlerta,capaDelJugador);    
    if (estarAlerta == true)
    {
        transform.LookAt(new Vector3 (jugador.position.x, jugador.position.y,jugador.position.z));
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(jugador.position.x, jugador.position.y,jugador.position.z), velocidad* Time.deltaTime);
    }
    }

    private void OnDrawGizmos(){
        Gizmos.DrawWireSphere(transform.position, rangoDeAlerta);
    }

}

