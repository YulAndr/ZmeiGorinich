using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasManager : MonoBehaviour
{
    [SerializeField] private GameObject InventoryUI;
    [SerializeField] private GameObject ExitConfirmationWindow;
    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(KeyCode.I) && !InventoryUI.activeSelf)
        {
            Debug.Log("Activating Inventory UI");
            InventoryUI.SetActive(true);
        } else if (Input.GetKeyDown(KeyCode.I) && InventoryUI.activeSelf)
        {
            Debug.Log("Deactivating Inventory UI");
            InventoryUI.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Escape) && !ExitConfirmationWindow.activeSelf)
        {
            Debug.Log("Activating ConfirmationWindow");
            ExitConfirmationWindow.SetActive(true);
        } else if (Input.GetKeyDown(KeyCode.Escape) && ExitConfirmationWindow.activeSelf)
        {
            Debug.Log("Deactivating Exit Confirmation");
            ExitConfirmationWindow.SetActive(false);
        }
    }

}
