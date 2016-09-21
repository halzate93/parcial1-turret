using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	[SerializeField]
	private int damagePerHit;

	[SerializeField]
	private int lifePoints;

	[SerializeField]
	private string bulletTag;

	private void OnCollisionEnter (Collision info)
	{
		if (info.transform.tag == bulletTag) 
		{
			ApplyDamage ();
			GameManager.Instance.AddScore ();
			Destroy (info.transform.gameObject);
		}
	}

	private void ApplyDamage ()
	{
		Debug.Log ("An enemy was hit");
		lifePoints -= damagePerHit;
		if (lifePoints <= 0) 
		{
			Destroy (gameObject);
			Debug.Log ("An enemy died");
		}
	}
}
