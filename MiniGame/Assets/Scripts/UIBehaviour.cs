using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIBehaviour : MonoBehaviour
{
    [SerializeField]
    GameObject StartCanvas;
    [SerializeField]
    GameObject GameCanvas;

    private void Start()
    {
        StartCanvas.SetActive(true);
        GameCanvas.SetActive(false);
    }

    private void Update()
    {
        if (StartCanvas == true && Input.anyKeyDown)
        {
            StartCanvas.SetActive(false);
            GameCanvas.SetActive(true);
        }
    }
}
