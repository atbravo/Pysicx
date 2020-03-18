using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Bolas : MonoBehaviour
{
public GameObject bola;
public GameObject bolaHierro0G;
public GameObject bolaCaucho0G;
 public InputField velocidadX;
 public InputField velocidadY;
 public InputField posicionX;
 public InputField posicionY;
 public void caida()
 {
    GameObject copia = Instantiate(bola);
    copia.transform.position = new Vector2(float.Parse(posicionX.text),float.Parse(posicionY.text));
    Rigidbody2D rigidBody = copia.GetComponent<Rigidbody2D>();
    rigidBody.mass = float.Parse("" + 1.0);
    rigidBody.velocity = new Vector2(float.Parse(velocidadX.text), float.Parse(velocidadY.text));
 }
 public void cambiarEscenaPrincipal()
    {
        SceneManager.LoadScene("a");
    }
}
