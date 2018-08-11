using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour {

	// TODO: Create variables to reference the game objects we need access to
	// Declare a GameObject named 'keyPoofPrefab' and assign the 'KeyPoof' prefab to the field in Unity
	// Declare a Door named 'door' and assign the top level 'Door' game object to the field in Unity

	public GameObject keyPoofPrefab;
	public float destroyTime = .05f;
	public float turnSpeed = 100;
	public int coins = 0;

	//Collect coins to make key appear
	void Start () {
		gameObject.SetActive (false);
	}

	void Update () {
		// OPTIONAL-CHALLENGE: Animate the key rotating
		// TIP: You could use a method from the Transform class
		gameObject.transform.Rotate(Vector3.down, turnSpeed * Time.deltaTime);
	}

	public void addCoin() {
		coins += 1;
		if (coins == 5) {
			gameObject.SetActive (true);
		}
	}

	public void OnKeyClicked () {
		/// Called when the 'Key' game object is clicked
		/// - Unlocks the door (handled by the Door class)
		/// - Displays a poof effect (handled by the 'KeyPoof' prefab)
		/// - Plays an audio clip (handled by the 'KeyPoof' prefab)
		/// - Removes the key from the scene

		// Prints to the console when the method is called
		Debug.Log ("'Key.OnKeyClicked()' was called");

		// TODO: Unlock the door, display the poof effect, and remove the key from the scene
		// Use 'door' to call the Door.Unlock() method
		// Use Instantiate() to create a clone of the 'KeyPoof' prefab at this coin's position and with the 'KeyPoof' prefab's rotation
		// Use Destroy() to delete the key after for example 0.5 seconds

		GameObject keyPoof = Instantiate (keyPoofPrefab);
		//move instance of prefab to coin location
		keyPoof.transform.position = gameObject.transform.position;

		Destroy (gameObject, destroyTime);


	}
}
