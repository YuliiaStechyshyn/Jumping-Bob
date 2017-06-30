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

	private static void Lose()
	{
		SceneManager.LoadScene("Game Over");
	}
}