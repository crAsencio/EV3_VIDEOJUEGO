using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Temporizador : MonoBehaviour
{
   public bool pasarNivel;
   public int indiceNivel; 
//________________________________________________________

 public float tiempo_start; //Los segundos por los quales comienza i la variable que utilizaremos para que vaya contando segundos.
 public float tiempo_end;//Segundos que queremos que pasen para que cambie de escena
 // Update is called once per frame


//________________________________________________________
   void Start () {}

   void Update ()
   {

       if (Input.GetKeyDown(KeyCode.Space)){
      CambiarNivel(indiceNivel);
       }
      // if (pasarNivel){
         // CambiarNivel(indiceNivel);
      // }
//________________________________________________________
      
   tiempo_start += Time.deltaTime;//Función para que la variable tiempo_start vaya contando segundos.
  if (tiempo_start >= tiempo_end) //Si pasan los segundos que hemos puesto antes...
  {
   SceneManager.LoadScene ("Escena2");
  }

        //________________________________________________________
   }

    public void CambiarNivel (int indice)
    {
        SceneManager.LoadScene(indice);
    }



}
