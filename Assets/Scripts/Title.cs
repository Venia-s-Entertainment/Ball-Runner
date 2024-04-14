using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Title : MonoBehaviour
{
    [SerializeField] public GameObject main, credits, title;

    public float stopWatch;
    // Update is called once per frame
    private void Start()
    {
        Time.timeScale = 1;
    }
    void Update()
    {
        if (stopWatch > 100)
        {
            main.SetActive(true);
            credits.SetActive(false);
        }

        if (!credits.activeInHierarchy)
        {
            title.transform.position = gameObject.transform.position;

            stopWatch = 0;
        }
        else if (credits.activeInHierarchy)
        {
            title.transform.Translate(new Vector2(0, 1 * 55 * Time.deltaTime));

            stopWatch += Time.deltaTime;
        }


    }
}
