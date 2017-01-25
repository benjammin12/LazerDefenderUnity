using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour {

	//public int[] enemyList;
	public GameObject Enemy;

	void Start () {
		int numEnemies = 0;

		foreach (Transform child in transform){ //for every child of the transform 
			Instantiate(Enemy, child.transform.position, transform.rotation);//enemy , of the child transform, is created at transform position w/ original rotation
			numEnemies++;
		}
		print (numEnemies);
		
	}
	

}
