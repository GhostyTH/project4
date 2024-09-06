using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Retry_2 : MonoBehaviour
{
    public void retry_2()
    {
        SceneManager.LoadSceneAsync(4);
    }
}