using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sceneloader : MonoBehaviour
{
    public void LoadScene(string asceneName)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(asceneName);

    }
}
