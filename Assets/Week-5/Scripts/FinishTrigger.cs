using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FinishTrigger : MonoBehaviour
{
    [SerializeField] GameObject Guy;
    [SerializeField] TextMeshProUGUI YWTMP;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        YWTMP.gameObject.SetActive(true);
        Guy.SetActive(false);
    }
}
