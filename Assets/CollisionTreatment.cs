using UnityEngine;
using System.Collections;

public class CollisionTreatment : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D col)
	{

		if(LayerMask.LayerToName(col.gameObject.layer) == "Player")
		{
			PlayerStatus.maxGems++;
			Destroy(this.gameObject);

		}
		else if(LayerMask.LayerToName(col.gameObject.layer) == "Enemy")
		{
			Destroy(col.gameObject);
			
		}





	}

}
