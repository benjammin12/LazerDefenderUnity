using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour {

	//public int[] enemyList;
	public GameObject Enemy;

	void Start () {
		Instantiate(Enemy, new Vector3(0,0,0), transform.rotation);
		//Enemy.transform.rotation;
		print("Enemy spawned");
	}
	

}
