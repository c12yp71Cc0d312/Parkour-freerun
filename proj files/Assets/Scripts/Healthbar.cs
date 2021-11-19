using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour
{
    [Range(0,1)]
    [SerializeField] float healthValue = 1f;
    [SerializeField] Image foreground = null;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            healthValue -= 0.1f;
        }

        foreground.fillAmount = healthValue;
    }
}