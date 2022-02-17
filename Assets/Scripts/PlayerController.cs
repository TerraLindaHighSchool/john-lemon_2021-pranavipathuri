using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public TextMeshProUGUI countText;
    public GameObject winTextObject;

    public int count { get; private set; }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
           //SetCountText();
        }

    }
    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= 7)
        {
            
        }
    }
}
