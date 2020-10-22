using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextColorChange : MonoBehaviour
{
    public int ID;
    private Text text;
    public Color color1;
    public Color color2;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
        color1 = new Color(0, 58, 115);
        color2 = new Color(0, 154, 204);
    }

    // Update is called once per frame
    void Update()
    {
       text.color = Color.Lerp(new Color(0f, 0.227f, 0.45f), new Color(0f, 0.6f, 0.8f), Mathf.PingPong(Time.time, 1));
        Debug.Log(text.color);
    }
}
