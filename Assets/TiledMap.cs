using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TiledMap : MonoBehaviour {

	int[,] tiledMap;
	int mapWidth, mapHeight;
	int tileWidth, tileHeight;

	public List<Transform> tiles = new List<Transform>();

	// Use this for initialization
	void Start () {
	
		mapWidth = 10;
		mapHeight = 3;

		float tileWidth = 54f;
		float tileHeight = 51f;

		tiledMap = new int[,] {
			{ 0,0,0,0,0,1,0,0,0,1 },
			{ 1,0,0,0,0,0,0,0,0,0 },
			{ 0,0,0,1,1,1,1,0,0,0 }
		};

		// Initiate tiled map
		for(int y = 0 ; y < mapHeight; y++){
			for(int x = 0 ; x < mapWidth; x++){
//				Vector3 pos = GameObject.Find ("Main Camera").camera.WorldToViewportPoint(new Vector3(x * tileWidth, y * tileHeight, 0));
//				Vector3 pos = new Vector3(x * (tileWidth/(tileWidth/0.55f)), y * (tileHeight/(tileHeight/0.55f)), 0);
				Vector3 pos = new Vector3(x, y, 0);
				Instantiate(tiles[tiledMap[y,x]], pos, Quaternion.identity);
			}
		}
	}
	
	// Update is called once per frame
	void Update () {

	}
}
