using UnityEngine;
using System.Collections;

public class Enums : MonoBehaviour {


	 enum Cellphone {Screen, Case , Power , Battery , Ram};



	void Start () 
	{
		Cellphone iPhone;

		iPhone = Cellphone.Screen;

		iPhone = phonetest(iPhone);

		Debug.Log (iPhone);

	}
	
	Cellphone phonetest (Cellphone piece)
	{

		if (piece == Cellphone.Screen)
			piece = Cellphone.Case;
		else if (piece == Cellphone.Power)
			piece = Cellphone.Ram;
	

			return piece;
	}






	void Update () 
	{
	
	}
}
