using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorPosition : MonoBehaviour
{
    public Transform cur;
    public Vector3 displacement;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        Cursor.visible = false;

        cur.position = Input.mousePosition + displacement;
    }
}
