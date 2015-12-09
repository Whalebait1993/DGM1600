using UnityEngine;
using System.Collections;

public class Shooter : MonoBehaviour 
{

	RaycastHit hit;

	private int bulletAmt;
	public int maxBullets;


	// Use this for initialization
	void Start () 
	{
		//this is adding the reset bullets function to the Deligate.
		GameManager.OnSpawnDucks += ResetBullets;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetMouseButtonDown (0)) 
		{
			bulletAmt --;
			if(bulletAmt <=0)
			{
				GameManager.OnDuckMiss();
			}
			Vector3 mousePos = Input.mousePosition;
			mousePos.z = Camera.main.transform.position.z;
			if(Physics.Raycast(Camera.main.ScreenToWorldPoint(mousePos),Camera.main.transform.forward, out hit, Mathf.Infinity))
			{
				if (hit.transform.tag =="Duck")
				{
					//kill the duck here.  use getcomponunt in hit to get the duck health script.  Using that call the killduck funciton in duc health script.  
				}
			}
		}
	}

	public void ResetBullets()
	{
		bulletAmt = maxBullets;

	}








}
