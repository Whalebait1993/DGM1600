using UnityEngine;
using System.Collections;

public class DuckDirectionChanger : MonoBehaviour {


	public enum Changer {Horizontal, Verticle};

	public Changer changer;

	void Start()
	{
		GameManager.OnDuckShot += TurnOn;
		GameManager.OnDuckMiss += TurnOff;



	}


	void OnCollisionEnter(Collision hit)
	{
		//Debug.Log ("HIT");
		//if the hit object is has the tag of duck
		if (hit.transform.tag == "Duck") 
		{

			//Creates a variable named movement based on the script DuckMovement to hold the value of the script for use in THIS script.

			//THis is kind of strange.  Its like you create a special variable of the class DuckMovement to to contain the imported Script DuckMovement
			DuckMovement movement = hit.gameObject.GetComponent<DuckMovement>();

			if(changer == Changer.Horizontal)
			{
				movement.DirectionChanger( new Vector3(-1,1,0) );
			}
			else 
			if (changer == Changer.Verticle)
			{
				movement.DirectionChanger(new Vector3(1,-1,0));
			}


		}
	}
	//these effect the borders
	public void TurnOff()
	{
		gameObject.SetActive (false);


	}
	public void TurnOn()
	{
		gameObject.SetActive (true);
		
		
	}



}
