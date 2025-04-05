using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TipsTrigger : MonoBehaviour
{
    [Header("Текст подсказки")]
    [TextArea(3, 10)]
    [SerializeField] private string tipMessage;
    [SerializeField] private string hintMessage;

    public bool isInRange;
    public bool canBeShownAgain;
    //как только игрок коснется коллайдера предмета, нужно нажать на клавишу взаимодействия, чтобы появилась подсказка
    private void Update () {
        if (Input.GetKeyDown(KeyCode.F) && isInRange)
        {
            Debug.Log("F is pressed");
            HintManager.disableHintEvent?.Invoke();
            TipsManager.displayTipEvent?.Invoke(tipMessage);
            canBeShownAgain = true;
        }
    }

    private void OnTriggerEnter2D (Collider2D other) {
        print("Trigger Entered");

        if (other.tag == "Player")
        {
            isInRange = true;
            HintManager.displayHintEvent?.Invoke(hintMessage);
        }
    }

    private void OnTriggerExit2D (Collider2D other) {
        if (other.tag == "Player")
        {
            isInRange = false;
            TipsManager.disableTipEvent?.Invoke();
            HintManager.disableHintEvent?.Invoke();
        }
    }
    //private void OnTriggerEnter2D (Collider2D other) {
    //    if (other.CompareTag("Player"))
    //    {
    //        Debug.Log("Is triggered");
    //        TipsManager.displayTipEvent?.Invoke(message);
    //    }
    //}
    //private void OnTriggerExit2D (Collider2D other) {
    //    if (other.CompareTag("Player"))
    //    {
    //        TipsManager.disableTipEvent?.Invoke();
    //    }
    //}

}
