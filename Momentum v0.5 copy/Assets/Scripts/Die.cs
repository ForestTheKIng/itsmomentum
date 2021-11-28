using UnityEngine;
using UnityEngine.SceneManagement;

public class Die : MonoBehaviour {

	public GameObject lavaCheck;

	public Timer timer;

	public EndTrigger end;
	


	// This function runs when we hit another object.
	// We get information about the collision and call it "collisionInfo".
	void Update() 
	{
		if (Input.GetKeyDown("r"))
		{
			
 			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
			

		}
		if (transform.position.y < lavaCheck.transform.position.y)
		{
			 SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
			 transform.position = end.spawnCoords;

		}
	}


}
