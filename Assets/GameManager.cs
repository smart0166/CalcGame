using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour {

    public Text text; 
    public UnityEngine.UI.Text buttonText1;
    public UnityEngine.UI.Text buttonText2;
    public UnityEngine.UI.Text buttonText3;

    int answer;
    int answer1, answer2, answer3;
    // Use this for initialization
    void Start()
    {
        int a = Random.Range(1, 10);
        int b = Random.Range(1, 10);
        answer = a + b;

        answer1 = answer;
        buttonText1.text = answer.ToString();
        answer2 = answer + 1;
        buttonText2.text = (answer + 1).ToString();
        answer3 = answer - 1;
        buttonText3.text = (answer - 1).ToString();

        text.text = a + " + " + b;
    }

    public void ClickButton1()
    {
        if(answer == answer1)
            Debug.Log("정답");
        else
            Debug.Log("오답");
    }

    public void ClickButton2()
    {
        if (answer == answer2)
            Debug.Log("정답");
        else
            Debug.Log("오답");
    }

    public void ClickButton3()
    {
        if (answer == answer3)
            Debug.Log("정답");
        else
            Debug.Log("오답");
    }

    // Update is called once per frame
    void Update () {
		
	}
}
