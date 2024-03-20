using MoreMountains.Tools;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cambioEscena : MonoBehaviour
{
    int actualScene;
    public void Start()
    {
        actualScene = SceneManager.GetActiveScene().buildIndex;
    }

    public void OnCambiarDeNivel()
    {
        if (actualScene == 75)
        {
            MMSceneLoadingManager.LoadScene("Nivel2");
        }

        if (actualScene == 76)
        {
            MMSceneLoadingManager.LoadScene("Nivel3");
        }

    }
}
