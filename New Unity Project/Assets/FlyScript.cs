

/*

using UnityEngine;
using System.Collections;

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
}

public class Car : MonoBehaviour 
{
	//a bunch of variables and functions
	int year = 1999;

	public void Go()
	{

	}
}


//PASSING OFF BELOW



//sdlkfja;lskdfj



 * 
 * 
 * Line
 * 
 * 
 * 
 * COmmmmememehtaldosufhalsdioufh
 * 
 * 
 * */
































































using UnityEngine;
using System.Collections;

public class FlyScript : MonoBehaviour 
{
	private float heightTest = 3f;
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
}

























