using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {

	public GameObject playerReference;
	private float playerDistance;
	void Update () 
	{
		playerDistance = (Camera.main.WorldToScreenPoint(new Vector3(playerReference.transform.position.x,0,0)) - 
		                             Camera.main.WorldToScreenPoint(new Vector3(this.transform.position.x,0,0))).x;	

		if(Mathf.Abs(playerDistance) > 200)
			this.transform.position += new Vector3(playerReference.GetComponent<PlayerMovement>().direction/10,0,0);
	}
}
