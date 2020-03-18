using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Colision : MonoBehaviour
{
public GameObject bolaHierro0G;
public GameObject bolaCaucho0G;
 public InputField velocidadX1;
 public InputField velocidadY1;
 public InputField posicionX1;
 public InputField posicionY1;
  public InputField velocidadX2;
 public InputField velocidadY2;
 public InputField posicionX2;
 public InputField posicionY2;
 public InputField masa1;
 public InputField masa2;

 public void elastica()
 {
   GameObject copia = Instantiate(bolaCaucho0G);
    copia.transform.position = new Vector2(float.Parse(posicionX1.text) + 15,float.Parse(posicionY1.text));
    Rigidbody2D rigidBody = copia.GetComponent<Rigidbody2D>();
    rigidBody.mass = float.Parse(masa1.text);
    rigidBody.velocity = new Vector2(float.Parse(velocidadX1.text), float.Parse(velocidadY1.text));
    GameObject copia2 = Instantiate(bolaCaucho0G);
    copia2.transform.position = new Vector2(float.Parse(posicionX2.text) + 15,float.Parse(posicionY2.text));
    Rigidbody2D rigidBody2 = copia2.GetComponent<Rigidbody2D>();
    rigidBody2.mass = float.Parse(masa2.text);
    rigidBody2.velocity = new Vector2(float.Parse(velocidadX2.text), float.Parse(velocidadY2.text));
 }
 public void inElastica()
 {
   GameObject copia = Instantiate(bolaHierro0G);
    copia.transform.position = new Vector2(float.Parse(posicionX1.text) +15,float.Parse(posicionY1.text));
    Rigidbody2D rigidBody = copia.GetComponent<Rigidbody2D>();
    rigidBody.mass = float.Parse(masa1.text);
    rigidBody.velocity = new Vector2(float.Parse(velocidadX1.text), float.Parse(velocidadY1.text));
    GameObject copia2 = Instantiate(bolaHierro0G);
    copia2.transform.position = new Vector2(float.Parse(posicionX2.text) + 15,float.Parse(posicionY2.text));
    Rigidbody2D rigidBody2 = copia2.GetComponent<Rigidbody2D>();
    rigidBody2.mass = float.Parse(masa2.text);
    rigidBody2.velocity = new Vector2(float.Parse(velocidadX2.text),float.Parse(velocidadY2.text));
 }
   public void cambiarEscenaPrincipal()
    {
        SceneManager.LoadScene("a");
    }
}
