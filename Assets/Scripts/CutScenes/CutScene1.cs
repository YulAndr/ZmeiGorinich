using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;

public class CutScene1 : MonoBehaviour
{   
    private Animator animator;
    [SerializeField] private TextMeshProUGUI textComponent;
    List<string> messages = new List<string>() { "Это Айлин, студент-лингвист второго курса. Она с научным руководителем собирались в экспедицию для изучения лингвокультуры малой нароности - удэге.", "Связавшись с местной жительницей Вайанкой, они получают ответ — письмо с загадочной запиской на удэгейском языке.", "Связавшись с местной жительницей Вайанкой, они получают ответ — письмо с загадочной запиской на удэгейском языке.", " Времени на подготовку почти нет: через пять дней у удэгейцев праздник \n Ва: кчай ни.", "Но накануне отъезда руководитель ломает ногу и просит её самой провести исследование и выяснить, кто и зачем приложил записку.", "Теперь всё зависит от неё." };
    private int currentIndex = 0;
    void Start()
    {
        textComponent.text = messages[currentIndex];
        animator = GetComponent<Animator>();
    }
    private void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            currentIndex++;
            if (currentIndex >= messages.Count)
            {
                SceneManager.LoadScene("Village");
                //currentIndex = 0; // или остановить показ, если нужно
            }
            textComponent.text = messages[currentIndex];
            animator.SetTrigger("spaceTriggered");
        }
    }

}
