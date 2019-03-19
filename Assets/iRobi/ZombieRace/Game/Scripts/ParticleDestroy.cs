using UnityEngine;
using System.Collections;

public class ParticleDestroy : MonoBehaviour {

	public float lifeTime;
	float t;

	// Update is called once per frame
	void Update () {
		t += Time.deltaTime;
		if (t > lifeTime) {
			Destroy (gameObject);
		}
	}
}
