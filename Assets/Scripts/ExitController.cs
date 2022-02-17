using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ExitController : MonoBehaviour
{
    [SerializeField] private PlayerController pickupCount;
   

    // Update is called once per frame
    void Update()
    {
        if (pickupCount.count >= 7 )
        {
            Destroy(gameObject);
        }
    }
}
