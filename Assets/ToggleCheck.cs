using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using TMPro;
public class ToggleCheck : MonoBehaviour
{

    public bool toggle = true;
    
    public void toggleCheck()
    {
        toggle = !toggle;
        if (toggle)
        {
            gameObject.GetComponent<TMP_Text>().text = "✓";
        }
        else
        {
            gameObject.GetComponent<TMP_Text>().text = " ";
        }
    }
}
