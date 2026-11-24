using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Rendering.BoolParameter;

public class Final_InfoManager: MonoBehaviour
{
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }
    public void displayInfo () {
        animator.SetTrigger("Appear");
    }

    // Update is called once per frame
    void Update()
    {

    }
    

}
