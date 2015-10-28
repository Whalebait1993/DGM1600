using UnityEngine;
using System.Collections;

public class Loops : MonoBehaviour 
{

	//int masterSword = 0;



	// Use this for initialization  I UNDERSTOOD THIS AND WROTE THIS MYSELF!!!!!!!!!!!  YEAH!!!!!!

	/// <summary>
	/// I passed off the DO-while loop and the While loop
	/// </summary>



	/*While looks
	void Start () 
	{
	
		do 
		{
			Debug.Log ("Great Warrior!");
			masterSword++;
		} while(masterSword < 15);




	
	} 
	*/

	//For 

	void Start () 
	{
		/*
		for (bool jacket = false; jacket==false; jacket=true) 
		{
			Debug.Log ("The statement: 'your Jacket is now dry' is " + jacket);
		}
		
		for (int jacket = 0; jacket < 5; jacket++) 
		{
			Debug.Log ("You have " + jacket +" Jackets");
		}
	*/
		
		int[] hoverBoards = new int[5];
		
		hoverBoards[0] = 1;
		hoverBoards[1] = 2;
		hoverBoards[2] = 3;
		hoverBoards[3] = 4;
		hoverBoards[4] = 5;


		foreach(int wheel in hoverBoards)
		{
			print ("Wheel Number " + wheel);
		}
		
		
		
		
		
	}
	
	
	
	
	
	
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}

