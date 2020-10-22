using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class TweenManage : MonoBehaviour
{
    //private Tween activeTween;
    private List<Tween> activeTweens;
    // Start is called before the first frame update
    void Start()
    {

    }
    public TweenManage()
    {
        activeTweens = new List<Tween>();
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < activeTweens.Count; i++)
        {
            if (Vector2.Distance(activeTweens[i].Target.position, activeTweens[i].EndPos) > 0.1f)
            {
                float timeFraction = ((Time.time - activeTweens[i].StartTime) / activeTweens[i].Duration);

                activeTweens[i].Target.position = Vector2.Lerp(activeTweens[i].Target.position, activeTweens[i].EndPos, timeFraction);

            }
            if (Vector2.Distance(activeTweens[i].Target.position, activeTweens[i].EndPos) <= 0.1f)
            {
                activeTweens[i].Target.position = activeTweens[i].EndPos;
                activeTweens.Remove(activeTweens[i]);
            }
        }

    }

    public bool AddTween(Transform targetObject, Vector2 startPos, Vector2 endPos, float duration)
    {
        if (TweenExists(targetObject) == false)
        {
            Tween activeTween = new Tween(targetObject, startPos, endPos, Time.time, duration);
            activeTweens.Add(activeTween);
            return true;
        }
        else
            return false;
    }

    public bool TweenExists(Transform target)
    {
        if (activeTweens.Exists(x => x.Target == target))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
