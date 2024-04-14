using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpDownMove : MonoBehaviour
{
    public float endTime;
    public float Speed;
    public float end;

    public bool Enable = false;
    // Start is called before the first frame update
  

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Enable)
        {
            if (end < -endTime)
            {
                Enable = false;
            }

            transform.Translate(new Vector2(0, 1 * Speed * Time.deltaTime));

            end -= Time.deltaTime;
        }
        else if (!Enable)
        {
            if (end > endTime)
            {
                Enable = true;
            }

            transform.Translate(new Vector2(0, -1 * Speed * Time.deltaTime));

            end += Time.deltaTime;
        }
    }
}
