using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerScript : MonoBehaviour
{
    public static TimerScript timer;
    public float time;
    float endGameAtTime = 111f;
    Text textValue;

    // Start is called before the first frame update
    void Start()
    {
        timer = this;
        time = 0;
        textValue = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        endGameAtTime -= Time.deltaTime;
        textValue.text = endGameAtTime.ToString();

        if (endGameAtTime <= 0)
        {
            SceneManager.LoadScene("Victory");
        }
    }
}
