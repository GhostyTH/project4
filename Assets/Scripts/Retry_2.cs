using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class retry_2 : MonoBehaviour
{
    public void Retry_2()
    {
        SceneManager.LoadSceneAsync(4);
    }
}