using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextColorChange : MonoBehaviour
{
    public float ID;
    private Text text;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Time.time >= ID) 
        {
            float timeFraction = Time.deltaTime / 5f;
            text.color = Color.Lerp(new Color(0f, 0.227f, 0.45f), new Color(0f, 0.6f, 0.8f), Mathf.PingPong(Time.time/ID, 1));
           
        }
      
    }
}
