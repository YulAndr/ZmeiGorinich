using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitConfirmation : MonoBehaviour
{
    public void PlayGame () {
        SceneManager.LoadScene(0);
    }
}
