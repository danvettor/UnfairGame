using UnityEngine;
using System.Collections;

public class PlayerBehaviour : MonoBehaviour {
	[SerializeField]
	private GameObject gemPrefab;
	private GameObject gem;

	public GameObject spot;

	public float gemSpeed;

	private PlayerMovement playerMovement;
	void Start () 
	{
		playerMovement = GetComponent<PlayerMovement>();

	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKeyDown(KeyCode.LeftAlt))
		{
			Shoot ();
		}
	}
	void Shoot()
	{
		if(PlayerStatus.maxGems > 0)
		{
			gem = (GameObject) Instantiate(gemPrefab, spot.transform.position, gemPrefab.transform.rotation);
			gem.GetComponent<Rigidbody2D>().velocity = Vector2.right * playerMovement.direction * gemSpeed;
			PlayerStatus.maxGems--;
		}

	}
}
