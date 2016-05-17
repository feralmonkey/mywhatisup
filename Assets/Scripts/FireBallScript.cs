using UnityEngine;
using System.Collections;

public class FireBallScript: MonoBehaviour {
	
	void Start()
	{
		print ("Testing");

		int x; 
		x = TakeDamageFromFireball ();
		x = TakeDamageFromFireball(25);
		x = TakeDamageFromFireball (30, 50);
		print ("Player health: " + x);


	}
	
	int TakeDamageFromFireball()
	{
	    int playerHealth = 100 ;
	    return playerHealth - 5 ;
	}
	
	int TakeDamageFromFireball(int damage)
	{
	    int playerHealth = 100 ;
	    return playerHealth - damage ;
	}
	
	int TakeDamageFromFireball(int damage, int playerHealth)
	{
	    return playerHealth - damage ;
	}
}
