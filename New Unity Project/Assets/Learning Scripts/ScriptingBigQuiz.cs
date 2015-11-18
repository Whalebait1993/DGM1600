//Here are my comments.



//JONAH ATHERLEY


//These are in front of every Unity Script.  They Basically let you know that this script is in Unity.
using UnityEngine;
using System.Collections;



//Here we are declaring a class.  This Class is Basically holding the entire Script in it!
public class MidTerm : MonoBehaviour {

	///This is a Variable.  Basically.  A veriable is like a place holder or a box for information.  
	/// Basically, this is a text declaring the variable. 
	/// 'public' Is an Access Modifiers which means that this variable is able to be accesed in multiple scripts and in the unity window.  
	/// 'int' is the type of variable, or basically decalring what type of information this box can hold.  In this Case, 'int' is a number such as 6 or 5.
	/// 'myInt' is the name of the variable.
	/// '= 6' is the current value of the variable, or what is put into the box.
	/// Always put a ';' at the end of any declared action for a script.
	public int myInt = 6;

	// This is also a Variable.  It is a Float Variable.  Not Public.  It is Private, or exclusive only to this script.  
	// Its type is a Float.  Floats are numbers with decimals such as 85.0f<--include the f at the end of a float.
	//coffeeTemperature is the name of the variable.
	float coffeeTemperature = 85.0f;

	//  Another example.  Private Access Modifiers.  FLoat type of variable that holds decimals.  That is equal to 70.0f
	private float hotLimitTemperature = 70.0f;
	public float coldLimitTemperature = 40.0f;
	int numEnemies = 3;

	//THis is a getcomponant Variable.  Private as in the access modifier, MidTerm is the type and myMidterm is the naame
	private MidTerm myMidterm;

	//THis is an Array Variable.  You can tell because it is declaring the type as a GameObject with '[]' Brackets at the end of the type.  :)
	//Arrays contain multiple variables.  THink about it as a box with compartments.
	public GameObject[] players;



	//THis is a FUnction.  A funciton is like a machine that does something for you in the script. 
	//Void is the type of funciton.  Machines or FUncitons usually give you things.  Void spot explaind that this machine is giving you nothing.  
	//If it was going to give you something, it would specify the "return Type"  Or call it something like 'int' therefore specifying that an Int would be returned out of the script.
	//THis is a Special Function called Start.  it starts at the begining of the script.
	void Start ()//open brachets are what will happen in this function.
	{
		//This is the function that is created and explained below being called into use now.
		TemperatureTest();

		//This is displaying to the console the value of the variable 'myInt'
		Debug.Log (myInt);

		//THis is a For loop.  Basically, until the conditions are met, it will keep doing what is between the brachets.
		//there are 3 stages of declaring a for loop each seperated by a semi colan.
		//int i = 0 is declaring a variable to use in the statement which is only contained in the loop.  hense usually it is not very creativly named.
		//i < numEnemies is the condition that the loop is waiting to meat.  Basically if the created 'i' is less then numEnemies created at the start of the script.
		//i++ happens after the loop.  In this case it increases the number of i so that the loop has something to work with.
		for(int i = 0; i < numEnemies; i++)
		{
			//The loop is in the brachets and is basically displaying "Creating enemy number:" Plus the value of i so it could display "Creating enemy number: 1"
			Debug.Log("Creating enemy number: " + i);
		}

		//THis is a Getcomponunt script.  We are taking componunts from another script called MidTerm and placing them into the value of myMidTerm
		myMidterm = GetComponent<MidTerm>();

		//another for loop.  This is checkinf if the variable created 'i' is less then the number of game objects stored in the array 'players'.
		//if it is less then the following action will take place in the brachets.
		for(int i = 0; i < players.Length; i++)
		{
			//Displaying to the consol the number of players as the player number and the name.  An example of what it could say would be
			//"Player Number 1 is named 1"
			Debug.Log("Player Number "+i+" is named "+players[i].name);
		}

		//this is creating an enum variable for the enum Direction.  Called myDirection.
		Direction myDirection;
		//myDirection is equal to the value of the Enums North option
		myDirection = Direction.North;
		//RUn the FUnction ReverseDirection with the veriable myDirection plugged into it.  See below for explanation 
		ReverseDirection (myDirection);
		
	}

	//this is a function that is called every frame of the game.  IS is always watching for this funciton to happen.
	void Update ()
	{
		//if the space bar is pressed down then run the function TemperatureTest.
		if(Input.GetKeyDown(KeyCode.Space))
			TemperatureTest();
		//the variable of coffeTemperature -= is subrtracting the value of Time.deltaTime and multiplying it by 5f.  SO it must be a float.
		coffeeTemperature -= Time.deltaTime * 5f;
	}

	//This is a void funciton or action.  It returns no values, but acts instead.  
	void TemperatureTest ()
	{
		//A String is a type of variable that holds text.  Strings must be placed between Quotation marks.  The name of this variable is tooHot.
		string tooHot = "Coffee is too hot.";

		//Here we go with an if statement.  This is a condition that says if the coffee temperature(coffeeTemperature)
		//is hotter then the the desired temperature limit(hotLimitTemperature) then do the following between the brachets.
		if(coffeeTemperature > hotLimitTemperature)
		{
			//Displays to the Consol the the value of the previously stated string  of tooHot.
			print(tooHot);
		}
	}


	//This is an Enumerator or Enum.  Enums are cool.  They are like creating your own type and filling it with what you want.  It is a way 
	//to create constants in your game.  This code is badically creating an enum named 'Direction' and giving it its constants or the only variable types 
	//it can ever hold.  North.  East.  South.  West.
	enum Direction{North, East, South, West};

	//THis is a Void Function to actually ust the Enum in.  We see that The variable for this Function is dir, with the variable type being our enum.  SO basically
	// dir can only be: North, East, South, Or West.  Nothing else.
	void ReverseDirection (Direction dir)
	{
		//If dir is equal to the value of the enum's North possible value, then change it to the South Value
		if(dir == Direction.North)
			dir = Direction.South;
		
		
	}



	//ANother void funciton that returns nothing
	void Greet()
	{
		//This is a Switch Statement.  BAsically.  WE give it a variable up top.  'myInt'  and then list cases or options.  Basically saying
		//IF this cariable is equal to this for this value.  
		switch (myInt)
		{
			//This is the case spoken above.
		case 5:
			//THis is the action.  THis action displays text into the console window.
			print ("Why hello there good sir! Let me teach you about Trigonometry!");
			//This line breaks the case so that you can move on to another case.
			break;
		case 4:
			print ("Hello and good day!");
			break;
		case 3:
			print ("Whadya want?");
			break;
		case 2:
			print ("Grog SMASH!");
			break;
		case 1:
			print ("Ulg, glib, Pblblblblb");
			break;
		default:
			print ("Incorrect intelligence level.");
			break;
		}
	}
}