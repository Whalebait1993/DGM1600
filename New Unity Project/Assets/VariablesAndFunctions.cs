using UnityEngine;
using System.Collections;

public class VariablesAndFunctions : MonoBehaviour 
{


	int theInt = 5;


	// Use this for initialization
	void Start () 
	{
		theInt = MultiplyByTwo (theInt);
		Debug.Log (theInt);
	}


	int MultiplyByTwo (int number)
	{
		int ret;
		ret = number * 2;
		return ret;
	}



	
	// Update is called once per frame
	void Update () {
	
	}
}