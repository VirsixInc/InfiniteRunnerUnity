using UnityEngine;
using System.Collections;

public class Ground : MonoBehaviour {

	LevelManager manager;

	bool dying = false;

	void Start () {
		manager = GameObject.Find ("LevelManager").GetComponent<LevelManager>();
	}

	void Update () {
		transform.position -= Vector3.right * manager.levelSpeed * Time.deltaTime;
		if(!dying) {
			if(transform.position.x < -13f) {
				manager.SpawnGround();
				Destroy(gameObject, 2f);
				dying = true;
			}
		}
	}
}
