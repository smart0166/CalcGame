using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour {

    public Text text; 

	// Use this for initialization
	void Start () {
        int a = Random.Range(1, 10);
        int b = Random.Range(1, 10);

        text.text = a + " + " + b;
    }

    // Update is called once per frame
    void Update () {
		
	}
}
