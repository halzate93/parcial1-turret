using UnityEngine;
using System.Collections;

public class Generator : MonoBehaviour 
{
	[SerializeField]
	private GameObject enemyPrefab;
	[SerializeField]
	private float spawnRate;
	[SerializeField]
	private float range;
	private float elapsedTime;

	private void Update ()
	{
		elapsedTime += Time.deltaTime;
		if (elapsedTime >= spawnRate) {
			elapsedTime = 0f;
			Spawn ();
		}
	}

	private void OnDrawGizmos ()
	{
		Gizmos.DrawWireSphere (transform.position, range);
	}

	private void Spawn ()
	{
		Vector3 position = Random.onUnitSphere;
		position.y = 0f;
		position *= Random.Range (1f, range);
		Instantiate (enemyPrefab, position, Quaternion.identity);
	}
}
