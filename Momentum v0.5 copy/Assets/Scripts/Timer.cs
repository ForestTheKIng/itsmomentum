using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour {

    public TMP_Text text;
    public float theTime;
    
    public float speed = 1;
    public bool playing;

 // Use this for initialization
 void Start () {
        text = GetComponent<TMPro.TextMeshProUGUI>();
        playing = true;
 }
 
 // Update is called once per frame
 void Update () {
        if (playing == true)
        {
            theTime += Time.deltaTime * speed;
            int minutes = (int) ((theTime % 3600) / 60);
            int seconds = (int) (theTime % 60);
            int milliseconds = (int) (100 * (theTime - minutes * 60 - seconds));

            text.text = minutes + ":" + seconds + "." + milliseconds;
        }
 }

}