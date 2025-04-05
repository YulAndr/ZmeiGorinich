using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HintManager : MonoBehaviour
{
    public static Action<string> displayHintEvent;
    public static Action disableHintEvent;

    [SerializeField] private TMP_Text messageText;

    private Animator anim;

    private int activeHints;

    void Start () 
    {
        anim = GetComponent<Animator>();
    }

    private void OnEnable () {
        displayHintEvent += displayHint;
        disableHintEvent += disableHint;
    }

    private void OnDisable () {
        displayHintEvent -= displayHint;
        disableHintEvent -= disableHint;
    }

    private void displayHint (string hintMessage) {
        messageText.text = hintMessage;
        anim.SetBool("toShow", true);
    }

    private void disableHint () {
        Debug.Log("disableHint is activated");
        anim.SetBool("toShow", false);
    }
}
