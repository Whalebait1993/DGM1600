using UnityEngine;
using System.Collections;

public class DuckSpawner : MonoBehaviour 

{
	void Start()
	{
		GameManager.OnSpawnDucks += SpawnDuck;

	}




	//creating a variable to work with for the duck.
	public GameObject duck;



	public void SpawnDuck()
	{
		Debug.Log ("Spawn Duck.");
		//Instantiate is a special function in unity for creating objects.
		// Breakdown of Instantiate=Create( Object, Position, rotation) Quaternion = transform.rotation
		Instantiate(duck, transform.position, Quaternion.identity);


	}








	// Use this for initialization
	//void Start () {
	
	//}
	
	// Update is called once per frame
	//void Update () {
	
	//}




}
