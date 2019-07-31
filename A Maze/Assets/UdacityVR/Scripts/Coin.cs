using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {
	public GameObject coin;
	public GameObject coinPoofPrefab;
	public GameObject coinPoofPrefabLocation;
	public static int coinsCollected = 0;


	// TODO: Create variables to reference the game objects we need access to
	// Declare a GameObject named 'coinPoofPrefab' and assign the 'CoinPoof' prefab to the field in Unity


	void Update () {
		// OPTIONAL-CHALLENGE: Animate the coin rotating
		coin.transform.Rotate(0 , 90f * Time.deltaTime  , 0 );
		// TIP: You could use a method from the Transform class
	}
		
	public void OnCoinClicked () {
		/// Called when the 'Coin' game object is clicked
		/// - Displays a poof effect (handled by the 'CoinPoof' prefab)
		/// - Plays an audio clip (handled by the 'CoinPoof' prefab)
		Instantiate(coinPoofPrefab,coinPoofPrefabLocation.transform.position, coinPoofPrefabLocation.transform.rotation );
		/// - Removes the coin from the scene
		Destroy(coin);
		// Prints to the console when the method is called
		Debug.Log ("'Coin.OnCoinClicked()' was called");
		coinsCollected = coinsCollected + 1;
		Debug.Log ("Coins Collected : " + coinsCollected);
		// TODO: Display the poof effect and remove the coin from the scene
		// Use Instantiate() to create a clone of the 'CoinPoof' prefab at this coin's position and with the 'CoinPoof' prefab's rotation
		// Use Destroy() to delete the coin after for example 0.5 seconds
	}
}
