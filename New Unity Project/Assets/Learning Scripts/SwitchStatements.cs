using UnityEngine;
using System.Collections;

public class SwitchStatements : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
		int day = 5;

		switch (day) 
		{
		case 1: print ("Dawn of the First Day.");
			break;
		case 2: print ("Night of the First Day.");
			break;
		case 3: print ("Dawn of the Second Day.");
			break;
		case 4: print ("Night of the Second Day.");
			break;
		case 5: print ("Dawn of the Third Day.");
			break;
		case 6: print ("Night of the Third Day.");
			break; 
		default: print ("Game Over.");
			break;






		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
