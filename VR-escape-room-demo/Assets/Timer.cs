using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    bool start = false;
    float time = 0;
    public TMP_Text timeText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(start) {
            time += Time.deltaTime;
            timeText.text = time.ToString();
        }
    }

    public void StartTime(){
        start = true;
    }
}
