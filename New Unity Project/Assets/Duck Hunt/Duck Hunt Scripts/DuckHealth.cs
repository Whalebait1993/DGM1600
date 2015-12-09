using UnityEngine;
using System.Collections;

public class DuckHealth : MonoBehaviour {

	Animator anim;


	bool isInvincible;

	void Start()
	{
		//get component to get the animator and assign to anim
		GameManager.OnDuckMiss += MakeInvincible;
		GameManager.OnDuckShot += MakeInvincible;


	}


	void OnTriggerEnter(Collider hit)
	{
		if (hit.tag == "KillZone") 
		{
			Destroy(this.gameObject);

		}
		if (hit.tag == "FlyAwayZone") 
		{
			GameManager.OnDuckFlyAway();
			//then destroy the duck
			Destroy(this.gameObject);
		}

	}
	public void KillDuck()
	{
		if (isInvincible == false) 
		{
			//This will need to be adjusted to fit my names.
			anim.Play("DuckDead");


		}
	}

	public void MakeInvincible()
	{
		isInvincible = true;
	}



}
