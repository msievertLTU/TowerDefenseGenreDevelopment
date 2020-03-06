using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerScript : MonoBehaviour
{
    public static TimerScript timer;
    public float time = 0;
    Text textValue;

    // Start is called before the first frame update
    void Start()
    {
        timer = this;
        textValue = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        time += 1 * Time.deltaTime;
        textValue.text = "TIME: " + time;

        if (time >= 30)
        {
            SceneManager.LoadScene("Victory");
        }
    }
}
