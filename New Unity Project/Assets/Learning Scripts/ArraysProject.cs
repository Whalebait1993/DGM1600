using UnityEngine;
using System.Collections;

public class ArraysProject : MonoBehaviour 



{


	public string[] Candies = new string[4];



	void Start () 
	{
		Candies[0] = "Chocolate Bar";
		Candies[1] = "Vanilla Ice Cream";
		Candies[2] = "Ritz Cracker";
		Candies[3] = "Bread";


		for(int i=0;i<Candies.Length;i++)
		{
			Debug.Log ("I Love to eat " + Candies[i] +"'s");

		}


	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
