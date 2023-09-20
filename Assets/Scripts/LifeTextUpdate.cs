using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LifeTextUpdate : MonoBehaviour
{
    public void SetLifesText(float lifes)
    {
        GetComponent<TMP_Text>().text = "Lifes: " + lifes;
    }
}
