using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimerTextUpdate : MonoBehaviour
{
    public void SetTimeText(float time)
    {
        GetComponent<TMP_Text>().text = "Time: " + Mathf.Round(time);
    }
}
