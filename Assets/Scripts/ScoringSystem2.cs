using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoringSystem2 : MonoBehaviour
{ 

        public GameObject scoreText2;

        public static int theScore2;


        void Update()
        {
            scoreText2.GetComponent<Text>().text = "" + theScore2;

        }
    
}