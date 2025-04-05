using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TipsManager : MonoBehaviour
{
    public static Action<string> displayTipEvent;
    public static Action disableTipEvent;

    [SerializeField] private TMP_Text messageText;

    private Animator anim;

    private int activeTips;

    void Start()
    {
     anim = GetComponent<Animator>();   
    }

    private void OnEnable () {
        displayTipEvent += displayTip;
        disableTipEvent += disableTip;
    }

    private void OnDisable () {
        displayTipEvent -= displayTip;
        disableTipEvent -= disableTip;
    }

    private void displayTip (string tipMessage) {
        messageText.text = tipMessage;
        anim.SetBool("toShow", true);
    }

    private void disableTip () {
        anim.SetBool("toShow", false);
    }
}
