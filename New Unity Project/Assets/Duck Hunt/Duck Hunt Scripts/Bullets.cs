using UnityEngine;
using System.Collections;

public class Bullets : MonoBehaviour {

	public GameObject[] bullets;


	// Use this for initialization
	void Start () 
	{
		GameManager2.OnSpawnDucks = ResetBullets;



	}


	public void DisableBullet(int index)
	{

		Bullets [index].SetActive (false);

	}








	// Update is called once per frame
	void Update () {
	
	}
}
