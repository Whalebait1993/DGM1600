using UnityEngine;
using System.Collections;

public class ClassesAndConstructs : MonoBehaviour 
{


	public class computer
	{

		public int ram;
		public int storage;
		public int cpu;


		public computer(int r, int s, int c)
		{
			ram=r;
			storage=s;
			cpu=c;
		}




	}

	public computer lenovo = new computer(8,500,4);







	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () 
	{



	}

}





//he he


//hello






















































/*
	 public class CandyBar
	{
		public int nuts;
		public int chips;
		public int fish;


		public CandyBar(int n, int c, int f)
		{
			nuts = n;
			chips = c;
			fish = f;
		}
	}



	public CandyBar Twix = new CandyBar(0,15,0);






	// Use this for initialization
	void Start () 
	{
		//Twix.nuts = Twix.chips;

		//Twix.chips = 200;
	}
	
	// Update is called once per frame
	void Update () 
	{

		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			Twix.nuts++;

		}

		Debug.Log ("Nuts "+Twix.nuts);

	}
*/