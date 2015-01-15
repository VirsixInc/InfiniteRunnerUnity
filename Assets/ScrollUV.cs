using UnityEngine;
using System.Collections;

public class ScrollUV : MonoBehaviour {

	public float speedMod = 2f;

	LevelManager manager;

	void Start () {
		manager = GameObject.Find ("LevelManager").GetComponent<LevelManager> ();
	}

	void Update () {
		Vector2 offset = renderer.material.mainTextureOffset;
		offset.x += manager.levelSpeed/speedMod * Time.deltaTime;
		renderer.material.mainTextureOffset = offset;
	}
}
