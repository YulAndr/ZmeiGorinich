using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Final_InfoTrigger : MonoBehaviour
{
    private bool isActivated;
    private bool isInRange;
    [SerializeField] private Final_InfoManager manager;
    // Start is called before the first frame update
    private void OnTriggerEnter2D (Collider2D other) {
        if (other.CompareTag("Player") && isActivated)
        {
            isInRange = true;
            manager.displayInfo();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            isActivated = true;
        }
    }
}
