using UnityEngine;
using System.Collections;

public class DuckMovement : MonoBehaviour {


	//Public meaning that you can edit this float variable 'speed' in the unity interface
	public float speed;

	private int bounce;
	public int bounceMax;

	//This creates a public variable to hold the direcion's x, y, and z.  Public means that you can edit this in Unity Interface.
	//D
	public Vector3 direction;

	//bool facingDirectionleft = false;


	void Start () 
	{
		//Running Function below
		RandomDirection();
		GameManager.OnDuckShot += StopMovement;
		GameManager.OnDuckMiss += FlyAway;

		//This is my own code.  Not Roberts.  I am experimenting with changing the xscale of the duck to mirror based on its direction.
		/*	if (direction.x < 0f && facingDirectionleft == false) 
		{
			Debug.Log ("Left");
			transform.localScale =  transform.localScale*-1;
			facingDirectionleft = true;
		} 
		else 
		{
			Debug.Log ("Right");
			transform.localScale =  new Vector3(29,transform.localScale.y, transform.localScale.z);
			facingDirectionleft = false;
			
		}
		*/

	}

	//fixedupdate is a special function.
	void FixedUpdate () 
	{
		//Possition      Equals           Current position(x,y,z) + Variable Direction(x,y,z) Multiplied by variable speed.
		transform.position = transform.position + (direction * speed);
	}

	//creating the function
	public void RandomDirection()
	{
		//Variable direction is equal to.  Basically these will be added to the fixed update to determine a number for each x, y, and z, to be continually 
		//added to the current position creating direction.
		direction = new Vector3(/* x Vector*/Random.Range (-1f, 1f),/* Y Vector*/ Random.Range (-.5f, 1f),/*Z Vector*/ 0) ;
		
	}


	public void DirectionChanger(Vector3 _dir)
	{
		direction = new Vector3(direction.x * _dir.x, direction.y * _dir.y, 0) ;

		bounce ++;

		if (bounce >= bounceMax) 
		{
			direction = new Vector3(0,1,0);
			GameManager.OnDuckMiss();
		}

	}


	public void StopMovement()
	{
		direction = new Vector3 (0,0,0);
	}

	public void StartFall()
	{
		direction = new Vector3 (0, -1, 0);
	}

	public void FlyAway()
	{
		direction = new Vector3 (0, 1, 0);

	}

}
