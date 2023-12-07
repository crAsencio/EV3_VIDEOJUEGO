using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class ControladorJuego : MonoBehaviour
{
    public Text txtTiempo;
    public Text txtContador;

    // solo se permite 1 controlador de juego (singleton)
    private static ControladorJuego cdj = null;
    public static ControladorJuego GetInstance() { return cdj; }

    void Awake()
    {
        // solo se permite 1 controlador de juego (singleton)
        if (cdj != null && cdj != this)
            Destroy(this.gameObject);
        else
            cdj = this;
    }

    void Update()
    {
        txtTiempo.text = Time.time.ToString("f3");
    }
    
    public void SetContador( int contador )
    {
        txtContador.text = "" + contador;
    }
}
