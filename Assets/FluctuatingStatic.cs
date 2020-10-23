using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FluctuatingStatic : MonoBehaviour
{
    public Sprite[] tvstatic;
    private Image visuals;
    // Start is called before the first frame update
    void Start()
    {
        visuals = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        visuals.color = Color.Lerp(new Color(visuals.color.r, visuals.color.g, visuals.color.b, 0.05f), new Color(visuals.color.r, visuals.color.g, visuals.color.b, 0.15f), Mathf.PingPong(Time.time, 4));
        visuals.sprite = tvstatic[Mathf.RoundToInt(Random.Range(0f, tvstatic.Length-1))];
    }
}
