using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class prefabs_spawner : MonoBehaviour {

	private float nextSpawn = 0;
	public Transform prefabToSpawn;
	public float spawnRate = 1;
	public float randomDelay = 1;
	public Text nama;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time > nextSpawn)
		{
			Instantiate(prefabToSpawn, transform.position, Quaternion.identity);
			nextSpawn = Time.time + spawnRate + Random.Range(0, randomDelay);
		}

		string loadNama = PlayerPrefs.GetString("Name");
		nama.text = "" + loadNama;
	}
}
