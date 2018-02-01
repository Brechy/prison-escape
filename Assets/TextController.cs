using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {

	public Text text;
	
	private enum States {
		cell, mirror, sheets_0, lock_0, cell_mirror, sheets_1, lock_1, 
		corridor_0, stairs_0, closet_door, floor, stairs_1, corridor_1, 
		in_closet, corridor_2, stairs_2, corridor_3, courtyard};
	
	private States myState;
	
	// Use this for initialization
	void Start () {
		myState = States.cell;
		}
			
	// Update is called once per frame
	void Update () {
		print (myState);
		if 		(myState == States.cell) 			{cell();} 
		else if (myState == States.sheets_0) 		{sheets_0();}
		else if (myState == States.sheets_1)		{sheets_1();}
		else if (myState == States.lock_0)   		{lock_0();}
		else if (myState ==	States.lock_1)			{lock_1();}
		else if (myState == States.mirror)			{mirror();}
		else if (myState == States.cell_mirror) 	{cell_mirror();}
		else if (myState == States.corridor_0)		{corridor_0();}
		else if (myState == States.stairs_0) 		{stairs_0();}
		else if (myState == States.closet_door)		{closet_door();}
		else if (myState == States.floor)   		{floor();}
		else if (myState ==	States.stairs_1)		{stairs_1();}
		else if (myState == States.corridor_1)		{corridor_1();}
		else if (myState == States.in_closet) 		{in_closet();}
		else if (myState == States.corridor_2)		{corridor_2();}
		else if (myState == States.stairs_2) 		{stairs_2();}
		else if (myState == States.corridor_3)		{corridor_3();}
		else if (myState == States.courtyard)		{courtyard();}
		
		
		
	}
	#region State handler methods
	
	void cell (){
		text.text = "You awake to find yourself in a prison cell. " +
					"You hear the moans and screams of other prisoners. " +
					"There are some dirty sheets on the bed, a mirror " +
					"on the wall, and the door is locked from the outside.\n\n" +
					"Press S to view Sheets, M to view Mirror, and L to view Lock."; 
		if (Input.GetKeyDown(KeyCode.S))		{myState = States.sheets_0;}
		else  if (Input.GetKeyDown(KeyCode.M))	{myState = States.mirror;}
		else if  (Input.GetKeyDown (KeyCode.L)) {myState = States.lock_0;}
		
	}
	void sheets_0 (){
		text.text = "You look down at your filthy bed to examine the sheets. " +
					"You can't beleive they actually expect you to sleep in " +
					"these flea ridden rags. It's time they were " +
					"changed, or at least washed. Oh well!\n\n" +
					"Press R to Return to roaming your cell." ; 
		if (Input.GetKeyDown(KeyCode.R))		{myState = States.cell;}
	}
			
	void lock_0 (){
		text.text = "You examine the lock. It appears to be a button style lock. " +
					"You wish you could somehow see the lock better. Maybe then  " +
					"you could see where the dirty fingerprints are and perhaps " +
					"figure out the combination.\n\n" +
					"Press R to Return to roaming your cell." ; 
		if (Input.GetKeyDown(KeyCode.R))		{myState = States.cell;}
	}
	
	void mirror (){
		text.text = "You see the mirror on the wall. Why would they give " +
					"prisoners mirrors? Is it to encourage you to manage " +
					"your own prison populations with fights...or...suicide? " +
					"You have got to get out of here. The mirror might help you " +
					"see the lock better.\n\n" +
					"Press R to Return to roaming your cell or press T to Take the mirror"; 
		if (Input.GetKeyDown(KeyCode.R))		{myState = States.cell;}
		else  if (Input.GetKeyDown(KeyCode.T))	{myState = States.cell_mirror;}
	}
	
	void cell_mirror (){
		text.text = "You gently pull the mirror off the wall, careful not " +
					"to cut your hands. The mirror is grimy, but you manage " +
					"to remove the mirror from the wall. There are still dirty " +
					"sheets on the bed, a mark where the mirror was, and the " +
					"door is still locked.\n\n" +
					"Press S to view the Sheets or L to view the Lock."; 
		if (Input.GetKeyDown(KeyCode.S))			{myState = States.sheets_1;}
		else  if (Input.GetKeyDown(KeyCode.L))		{myState = States.lock_1;}
	}
	
	void sheets_1 (){
		text.text = "Holding a mirror in your hand doesn't make the " +
					"filthy sheets look any better. Did the sheets " +
					"just....move!? Gross! You have GOT to get out " +
					"of this place.\n\n" +
					"Press R to continue Roaming your cell or L to view the Lock."; 
		if (Input.GetKeyDown(KeyCode.R))			{myState = States.cell_mirror;}
		else  if (Input.GetKeyDown(KeyCode.L))		{myState = States.lock_1;}
	}
	
	void lock_1 (){
		text.text = "You carefully put the mirror through the bars and " +
					"turn it around so you can see the lock. You can " +
					"just make out the dirty fingerprints on the buttons " +
					"You spend a few minutes pressing buttons, trying to " +
					"find the right sequence. You try once more and hear " +
					"a click.\n\n" +
					"Press R to continue Roaming your cell or O to open the door."; 
		if (Input.GetKeyDown(KeyCode.R))			{myState = States.cell;}
		else  if (Input.GetKeyDown(KeyCode.O))		{myState = States.corridor_0;}
	}	
	
	void corridor_0 (){
		text.text = "You are in a corridor, you look down a long dark passageway " +
					"and see a stairway off to the right, a closet door down the " +
					"corridor to the left, and lots of debris all over the floor.\n\n" +
					"Press S to go up the Stairs, F to examine the Floor, or C to go in the Closet."; 
		if (Input.GetKeyDown(KeyCode.S))			{myState = States.stairs_0;}
		if (Input.GetKeyDown(KeyCode.F))			{myState = States.floor;}
		if (Input.GetKeyDown(KeyCode.C))			{myState = States.closet_door;}
		
	}
	
	void stairs_0 (){
		text.text = "You slowly and carefully make your way down the corridor " +
					"and up the stairs. Through the sounds and screams of other " +
					"prisoners you listen for guards. You reach the top of the " +
					"stairs. It is a lovely view of a courtyard, but there are " +
					"guard towers all the way to the exit gate. If you try and " +
					"walk out there, you'll be shot for sure. D.E.D. DEAD!\n\n" +
					"Press R to Return to the corridor."; 
		if (Input.GetKeyDown(KeyCode.R))			{myState = States.corridor_0;}
		
	}
	
	void closet_door (){
		text.text = "You make your way down corridor to the closet door. " +
					"You wiggle the grimy door knob, but it is locked. " +
					"If only you had something to pick the lock....\n\n" +
					"Press R to Return to the corridor."; 
		if (Input.GetKeyDown(KeyCode.R))			{myState = States.corridor_0;}
		
	}
	
	void floor (){
		text.text = "You examine the floor near the door to your cell. " +
					"Though the light is dim you can see some trash, a " +
					"used tissue...gross...and a small length of wire.. " +
					"perhaps the wire might help with the closet door lock.\n\n" +
					"Press T to Take the wire or R to Return to the corridor."; 
		if (Input.GetKeyDown(KeyCode.T))			{myState = States.corridor_1;}
		if (Input.GetKeyDown(KeyCode.R))			{myState = States.corridor_0;}
	}
	
	void corridor_1 (){
		text.text = "You are still in the corridor outside your cell. " +
					"But now you have pretty decent and sturdy length " +
					"of wire. The stairs are still to your left and the " +
					"locked closet to your right.\n\n" +
					"Press S to go up the Stairs or C to go in the Closet."; 
		if (Input.GetKeyDown(KeyCode.S))			{myState = States.stairs_1;}
		if (Input.GetKeyDown(KeyCode.C))			{myState = States.in_closet;}
   }
   
	void stairs_1 (){
		text.text = "You reach the top of the stairs again, but this time " +
					"you have got a decent length of sturdy wire. However, " +
					"unless it is a cloaking device, you don't think it is going " +
					"get you past the guard towers and out of this hell hole.\n\n" +
					"Press R to Return to the corridor."; 
		if (Input.GetKeyDown(KeyCode.R))			{myState = States.corridor_1;}
		
	}
	
	void in_closet (){
		text.text = "You take a deep breath and channel your inner MacGyver. " +
					"You wiggle the wire around in the lock until you hear a " +
					"click. Holy crap it worked!? You quietly slip inside and " +
					"find cleaning supplies and some filthy uniforms. Maybe the " +
					"uniform might help you sneak out of here.\n\n" +
					"Press R to Return to the corridor or D to Dress up in a uniform."; 
		if (Input.GetKeyDown(KeyCode.R))			{myState = States.corridor_2;}
		if (Input.GetKeyDown(KeyCode.D))			{myState = States.corridor_3;}
		
	}
	
	void corridor_2 (){
		text.text = "Well you are back in the corridor, but now your wire is " +
					"twisted in the lock of the closet door. You take stock of your " +
					"surroundings again. The stairs are still up the corridor and the " +
					"closet is still there, but now it is unlocked. Well now what?\n\n" +
					"Press S to go up the Stairs or C to go back in the Closet."; 
		if (Input.GetKeyDown(KeyCode.S))			{myState = States.stairs_2;}
		if (Input.GetKeyDown(KeyCode.C))			{myState = States.in_closet;}
		
	}
	
	void stairs_2 (){
		text.text = "You make your way up the stairs again, but this time " +
					"you MacGyver'd the hell out of the length of wire, so " +
					"it is sadly no longer with you. Still a beautiful view " +
					"of the courtyard and all guard towers...dang\n\n" +
					"Press R to Return to the Corridor."; 
		if (Input.GetKeyDown(KeyCode.R))			{myState = States.corridor_2;}
		
	}
	
	void corridor_3 (){
		text.text = "Your heart is racing as you quickly slip on a custodial " +
					"uniform. You slip out the door with a broom in hand. The " +
					"stairs are still to your left and the closet to your right. " +
					"Dressed like a cleaner you could just walk right out of here!\n\n" +
					"Press S to go up the Stairs or C to go back in the Closet."; 
		if (Input.GetKeyDown(KeyCode.S))			{myState = States.courtyard;}
		if (Input.GetKeyDown(KeyCode.C))			{myState = States.in_closet;}
		
	}
		
	void courtyard (){
		text.text = "You go up the stairs and through the courtyard with your broom. " +
					"A guard looks down at you from a tower as you stop and bend " +
					"down to pick up a peice of trash. You look up and give him " +
					"a wave, he nods at you and goes back to scanning the courtyard. " +
					"You have escaped! Why were you there anyway?\n\n" +
					"Press P to Play again.";                                                                                                          
		if (Input.GetKeyDown(KeyCode.P))			{myState = States.cell;}
		
		#endregion
	}
	
}
		
		
		