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

        List<int> answers = new List<int>();
        answers.Add(answer);
        answers.Add(answer + 1);
        answers.Add(answer - 1);

        Shuffle(answers);

        buttonText1.text = answers[0].ToString();
        buttonText2.text = answers[1].ToString();
        buttonText3.text = answers[2].ToString();

        text.text = a + " + " + b;
    }

    // Update is called once per frame
    void Update () {
		
	}

    private System.Random rng = new System.Random();  

    public void Shuffle(IList<int> list)  
    {  
        int n = list.Count;  
        while (n > 1) {  
            n--;  
            int k = rng.Next(n + 1);  
            int value = list[k];  
            list[k] = list[n];  
            list[n] = value;  
        }  
    }
}
