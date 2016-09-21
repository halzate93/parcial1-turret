using UnityEngine;
using System.Collections;

public class Turret : MonoBehaviour 
{
	[SerializeField]
	private Rigidbody bullet;

	[SerializeField]
	private float force = 10f;

	[SerializeField]
	private string fireButton;

	private void Update () 
	{
		UpdateRotation ();
		if (Input.GetButtonDown (fireButton))
			Shoot ();
	}

	private void OnDrawGizmos ()
	{
		Debug.DrawRay (transform.position, transform.forward);
	}

	private void Shoot ()
	{
		Rigidbody newBullet = Instantiate(bullet, transform.position, Quaternion.identity) as Rigidbody;
		newBullet.velocity = transform.forward * force;
	}

	private void UpdateRotation ()
	{
		Vector3 direction = (Vector2)Input.mousePosition - new Vector2 (Screen.width / 2f, Screen.height / 2f);
		direction.z = direction.y;
		direction.y = 0f;
		Quaternion newRotation = Quaternion.LookRotation (direction);
		transform.rotation = newRotation;
	}
}
