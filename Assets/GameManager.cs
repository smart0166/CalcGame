using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour {

    public Text text; 
    public UnityEngine.UI.Text buttonText1;
    public UnityEngine.UI.Text buttonText2;
    public UnityEngine.UI.Text buttonText3;

	// Use this for initialization
	void Start () {
        int a = Random.Range(1, 10);
        int b = Random.Range(1, 10);
        int answer = a + b;

        buttonText1.text = answer.ToString();
        buttonText2.text = (answer + 1).ToString();
        buttonText3.text = (answer - 1).ToString();

        text.text = a + " + " + b;
    }

    // Update is called once per frame
    void Update () {
		
	}
}
