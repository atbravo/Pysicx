using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Botonsitos : MonoBehaviour
{
    public void cambiarEscenaParabolica()
    {
        SceneManager.LoadScene("Parabolico");
    }
    public void cambiarEscenaColision()
    {
        SceneManager.LoadScene("Colision");
    }
}

