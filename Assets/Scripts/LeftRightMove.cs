using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftRightMove : MonoBehaviour
{
    public float endTime;
    public float Speed;
    public float end;

    public bool Enable = false;

    // Update is called once per frame
    void Update()
    {
        if (Enable)
        {
            if (end < -endTime)
            {
                Enable = false;
            }

            transform.Translate(new Vector2(1 * Speed * Time.deltaTime, 0));

            end -= Time.deltaTime;
        }
        else if (!Enable)
        {
            if (end > endTime)
            {
                Enable = true;
            }

            transform.Translate(new Vector2(-1 * Speed * Time.deltaTime, 0));

            end += Time.deltaTime;
        }
    }
}
