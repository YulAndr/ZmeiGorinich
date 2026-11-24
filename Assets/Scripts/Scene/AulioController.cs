using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AulioController : MonoBehaviour
{
    public AudioSource audio_;
    // Start is called before the first frame update
    private void Start()
    {
        if (!PlayerPrefs.HasKey("volume"))
            audio_.volume = 1;
    }

    // Update is called once per frame
    void Update()
    {
     audio_.volume = PlayerPrefs.GetFloat("volume");
    }
}
