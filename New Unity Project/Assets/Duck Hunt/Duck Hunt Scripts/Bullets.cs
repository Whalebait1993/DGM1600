using UnityEngine;
using System.Collections;

public class Bullets : MonoBehaviour {

	public GameObject[] bullets;


	// Use this for initialization
	void Start () 
	{
		//GameManager2.OnSpawnDucks = ResetBullets;



	}


	public void DisableBullet(int index)
	{

		bullets[index].SetActive (false);

	}


	void ResetBullets()
	{

		foreach(GameObject bul in bullets);




	}





	// Update is called once per frame
	void Update () {
	
	}
}
