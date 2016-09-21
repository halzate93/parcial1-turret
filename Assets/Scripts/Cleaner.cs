using UnityEngine;
using System.Collections;

public class Cleaner : MonoBehaviour {

	private void OnTriggerExit (Collider other)
	{
		Destroy (other.gameObject);
	}
}
