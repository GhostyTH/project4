using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class retry : MonoBehaviour
{
    public void Retry()
    {
        SceneManager.LoadSceneAsync(2);
    }
}