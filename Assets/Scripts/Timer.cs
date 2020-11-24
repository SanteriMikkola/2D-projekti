using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timeText;
    public float TimeStart = 0.00f;

    private void Start()
    {
        timeText.text = TimeStart.ToString();
    }

    private void Update()
    {
        TimeStart += Time.deltaTime;
        timeText.text = Mathf.Round(TimeStart).ToString();
    }
}
