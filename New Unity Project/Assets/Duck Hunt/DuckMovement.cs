using UnityEngine;
using System.Collections;

public class DuckMovement : MonoBehaviour {



	public float speed;

	public Vector3 direction;



	void Start () 
	
	{
	//Running Function below
		RandomDirection();

	}

	//fixedupdate is a special function.
	void FixedUpdate () 
	{
		//Possition      Equals           Current position + Variable Direction Multiplied by variable speed.
		transform.position = transform.position + (direction * speed);
	}


	public void RandomDirection()
	{
		
		
		
		//Variable direction is equal to 
		direction = new Vector3(/* x Vector*/Random.Range (-1f, 1f),/* Y Vector*/ Random.Range (-.5f, 1f),/*Z Vector*/ 0) ;
		
	}


	public void DirectionChanger(Vector3 _dir)
	{
		direction = new Vector3(direction.x * _dir.x, direction.y * _dir.y, 0) ;
	}





}
