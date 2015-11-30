using UnityEngine;
using System.Collections;

public class DuckSpawner : MonoBehaviour 

{



	//creating a variable to work with for the duck.
	public GameObject duck;



	public void SpawnDuck()
	{
		Debug.Log ("Spawn Duck.");

		Instantiate(duck, transform.position, Quaternion.identity);


	}








	// Use this for initialization
	//void Start () {
	
	//}
	
	// Update is called once per frame
	//void Update () {
	
	//}




}
