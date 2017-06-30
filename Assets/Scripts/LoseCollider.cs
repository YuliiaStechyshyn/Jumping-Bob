using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseCollider : MonoBehaviour {
	
	private void OnTriggerEnter(Collider other)
	{
		if (other.GetComponent<Frog>())
		{
			Lose();
		}
	}

	private void Lose()
	{
		// here load game over screen
		Debug.Log("You lost!");
		SceneManager.LoadScene("Jumping Bob");
	}
}