using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDownScript : MonoBehaviour
{
    [SerializeField]
    private int starCountDown = 60;
    [SerializeField]
    Text TxtCountDown;

    void Start()
    {
        TxtCountDown.text = "TimeLeft : " + starCountDown;
        StartCoroutine(Pause());
    }
    IEnumerator Pause()
    {
        while(starCountDown >0 )
        {
            yield return new WaitForSeconds(1f);
            starCountDown--;
            TxtCountDown.text = "TimeLeft : " + starCountDown;
        }

        GameObject.Find("Player").GetComponent<PlayerController>().GameOver();
    }
    
}
