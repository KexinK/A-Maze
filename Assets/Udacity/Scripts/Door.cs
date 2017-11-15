using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 

{
	public AudioSource doorAudioSource;
	public AudioClip doorOpened;
	public AudioClip doorClosed;
	public bool locked = true;
	bool closed = true;
    public GameManager gameManager;
    public Animator animationController;
    public Collider boxCollider;


	public void OnKeyClicked(){
		if(gameManager.hasKey == true){
            doorAudioSource.clip = doorOpened;
            doorAudioSource.Play();
            boxCollider.enabled = false;
            animationController.SetTrigger("Open Door");
		} else
        {
            doorAudioSource.clip = doorClosed;
            doorAudioSource.Play();
        }
	}





	// Create a boolean value called "locked" that can be checked in OnDoorClicked()
	//public bool locked;
	//public bool closed;

    // Create a boolean value called "opening" that can be checked in Update() 

   void Update() {
		if(!locked && !closed && transform.position.y<23.2f){
			transform.Translate(0,2.5f*Time.deltaTime,0,Space.World);
		}}
		// If the door is opening and it is not fully raised
		// Animate the door raising up
	
				//if(transform.position.y>=11.5)
			//public void OnDoorClicked() {
			// If the door is clicked and unlocked

            // Set the "opening" boolean to true
        // (optionally) Else
            // Play a sound to indicate the door is locked
   

    public void Unlock()
    {
		doorAudioSource.clip = doorOpened;
		doorAudioSource.Play();
		locked=!locked;
	}

	//locked = false;
//}
//public static implicit operator Gameobject(Door v)
//{
	//throw new NotImplementedException();

	public void openDoor()
{
		if (!closed) {
			closed = !closed;
		}
	else{
			doorAudioSource.clip = doorClosed;
			doorAudioSource.Play();
        // You'll need to set "locked" to false here
     }
  }
}