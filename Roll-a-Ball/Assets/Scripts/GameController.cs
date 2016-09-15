using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public float numObjects;
	public GameObject origin;
	public GameObject prefab;

	private float spot = 0;

	void Start() {
		Vector3 center = origin.transform.position;
		for (int i = 0; i < numObjects; i++){
			Vector3 pos = RandomCircle(center, 5.0f, spot);
			Quaternion rot = Quaternion.FromToRotation(Vector3.forward, center-pos);
			Instantiate(prefab, pos, rot);
			spot = spot + 1/numObjects;
		}
	}

	Vector3 RandomCircle ( Vector3 center ,   float radius , float spot ){
		float ang = spot * 360;
		Vector3 pos;
		pos.x = center.x + radius * Mathf.Sin(ang * Mathf.Deg2Rad);
		pos.y = center.y;
		pos.z = center.z + radius * Mathf.Cos(ang * Mathf.Deg2Rad);
		return pos;
	}
}
