using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameManager : MonoBehaviour 
{

	private static GameManager instance;

	public static GameManager Instance
	{
		get
		{ 
			return instance;
		}
	}
		
	private int score;

	[SerializeField]
	private Text scoreLabel;
	[SerializeField]
	private string scorePattern;


	private void Awake () 
	{
		if (instance != null)
			Destroy (gameObject);
		else
			instance = this;
	}
	
	public void AddScore ()
	{
		score++;
		string update = string.Format (scorePattern, score);
		Debug.Log (update);
		scoreLabel.text = update;
	}
}
