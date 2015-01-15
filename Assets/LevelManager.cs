using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public GameObject[] groundPrefabs;

	float currentHeight = 0f;

	public float levelSpeed = 1f;
	
	float timer = 0;

	void Start () {
//		SpawnGround ();	
	}

	void Update () {
		levelSpeed += Time.deltaTime * 0.3f;
//		timer += Time.deltaTime / levelSpeed;
//		if(timer > 1.0f) {
//			SpawnGround();
//			timer = 0f;
//		}
	}

	public void SpawnGround() {
		currentHeight += Random.Range (-3.0f, 3.0f);
		currentHeight = Mathf.Clamp (currentHeight, -5.0f, 3.0f);

		int rand = Random.Range (0, groundPrefabs.Length);
		Instantiate (groundPrefabs [rand], new Vector2 (24f, currentHeight), Quaternion.identity);
	}
}
