using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HintText : MonoBehaviour
{
    public GameObject Collider;
    public CanvasGroup hintText;
    [SerializeField] private List<GameObject> pickupCount;

    private void Start()
    {
        hintText.alpha = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && (pickupCount.Count <= 7))
        {
            hintText.alpha = 1;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player") hintText.alpha = 0;
    }
}
