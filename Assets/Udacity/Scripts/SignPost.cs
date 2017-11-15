using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SignPost : MonoBehaviour
{	
	
	public void onSignPostClicked(){
		Scene maze = SceneManager.GetActiveScene ();
		SceneManager.LoadScene (maze.name);
	}
        // Reset the scene when the user clicks the sign post
		
}