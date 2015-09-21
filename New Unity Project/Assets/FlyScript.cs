



using UnityEngine;
using System.Collections;
/*
public class FlyScript : MonoBehaviour 
{
	private float heightTest = 3f;
	void Start ()
	{
		Debug.Log(transform.position.y);

		Car jeep = new Car ();
		jeep.Go ();

		if(transform.position.y <= heightTest)
		{
			Debug.Log("I'm about to hit the ground!");
			FlyAway();
		}

		else if (transform.position.y >= heightTest)
		{
			Debug.Log("I'm flying!");
		}
	}

	private void FlyAway()
	{
		Debug.Log("Fly Away!");
		Vector3 newPosition = new Vector3(0,7,0);
		transform.position = newPosition;//  Transform.position is asking for all 3 coordinate.  Transform.position.y would be asking for only one.
	}
}*/

public class Car : MonoBehaviour 
{
	//a bunch of variables and functions
	//public int year = 1999;




	public void Go(int year)
	{
		if (year <= 1993) 
		{
			Debug.Log ("Oh Snap!  I was not born yet!");
		} 

		else if (year == 1999) 
		{
			Debug.Log ("I am Six years old!");

		} 
		else 
		{
			Debug.Log ("Im Forgetful.");
		}
	}
}


//PASSING OFF BELOW



//sdlkfja;lskdfj
































































//using UnityEngine;
//using System.Collections;

public class FlyScript : MonoBehaviour 
{
	private float heightTest = 3f;

	public int year = 0;

	Car myCar = new Car();
	void Start ()
	{
		Debug.Log (transform.position.y);



		if(transform.position.y <= heightTest)
		{
			Debug.Log("I'm about to hit the ground!");
				FlyAway();
		}

		else if(transform.position.y >= heightTest)
		{
			Debug.Log("I'm flying!");
		}

	}

	private void FlyAway()
	{
		Debug.Log("Fly Away!");
		Vector3 newPosition = new Vector3(0,7,0);
		transform.position = newPosition;
	}

	void Update()
	{
		myCar.Go (year);






	}






}

























