using UnityEngine;
using System.Collections;

public class DogControl : MonoBehaviour {

	Animator anim;

	void Start()
	{

		//use getcomponent to get animator
		GameManager.OnDuckDeath += PlayDuck;
		GameManager.OnDuckFlyAway += PlayLaugh;
	}



	public void SpawnDucks()
	{
		GameManager.OnSpawnDucks ();
	}

	public void PlayLaugh()
	{
		anim.Play ("DogLaughAnim");
	}


	public void PlayDuck()
	{
		anim.Play ("DogDuckAnim");
	}

}
