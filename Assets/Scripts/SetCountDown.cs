using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SetCountDown : MonoBehaviour
{

    private GameManagerScript GMS;

    public void SetCountDownNow()
    {
        GMS = GameObject.Find("GameManager").GetComponent<GameManagerScript>();
        GMS.counterDownDone = true;


    }



    //public int countdownTime;
    //public Text countdownDisplay;

    //private void Start()
    //{
    //    StartCoroutine(CountdownToStart());
    //}

    //IEnumerator CountdownToStart()
    //{
    //    while(countdownTime > 0)
    //    {
    //        countdownDisplay.text = countdownTime.ToString();

    //        yield return WaitForSeconds(1f);

    //        countdownTime--;
    //    }

    //    countdownDisplay.text = "Go!";

    //    GameController.Instance.BeginGame();

    //    yield return new WaitForSeconds(1f);

    //    countdownDisplay.gameObject.SetActive(false);
    //}
}
