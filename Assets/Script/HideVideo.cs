using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideVideo : MonoBehaviour
{
    private int working = 0;
    public GameObject objecttoswitch;
    public float speed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            if (working == 0)
            {
                objecttoswitch.SetActive(false);
                working = 1;
                float inc = 0;
                while (inc <= 1)
                {
                    inc += Time.deltaTime / speed;
                }
            }
            else
            {
                objecttoswitch.SetActive(true);
                working = 0;
                float inc = 0;
                while (inc <= 1)
                {
                    inc += Time.deltaTime / speed;
                }
            }
        }
    }
}
