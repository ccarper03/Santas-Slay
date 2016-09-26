﻿using UnityEngine;
using System.Collections;

public class SantaScript_NN : MonoBehaviour {

	public Transform target;
	public NavMeshAgent agent;

	public float walkSpeed;

	private float startTimer;
	public float delayTimer;
	private float distance;

	public float walkIdleRange;

	public float xMin;
	public float xMax;
	public float yMin;
	public float yMax;
	public float zMin;
	public float zMax;
	private float x;
	private float y;
	private float z;
	private Vector3 direction;

	public AudioSource audioSource;
	public AudioClip[] audioClips;


	public enum SantaStates {WalkIdle, Chase, TooFar};
	public SantaStates santaStates;


	void Update(){

		distance = Vector3.Distance (target.position, transform.position);

		if (distance <= walkIdleRange) {
			santaStates = SantaStates.WalkIdle;
		}
		if (santaStates == SantaStates.WalkIdle) {
			startTimer += Time.deltaTime;
			if (startTimer >= delayTimer) {
				int rand = Random.Range (1, 101);
				startTimer = 0;
				if (rand <= 35) {
					agent.Stop ();
				}
				if (rand > 35) {
					x = Random.Range (xMin, xMax);
					y = Random.Range (yMin, yMax);
					z = Random.Range (zMin, zMax);
					direction = new Vector3 (x, y, z);
					agent.Resume ();
					agent.SetDestination (direction);
					if (transform.position != direction) {
						PlaySound ();
					}
				}
			}
		}

		if (distance > walkIdleRange) {
			startTimer = delayTimer;
			santaStates = SantaStates.TooFar;
		}
		if (santaStates == SantaStates.TooFar) {
			agent.Resume();
			agent.SetDestination (target.position);
			if (transform.position != target.position) {
				PlaySound ();
			}
		}

		//This part will depend on the player's script.
		/*
		if (theplayer state == state)
			santaStates = SantaStates.Chase
		if (santaStates == SantaStates.Chase)
			agent.SetDestination (target.position);
			//Do your stuff here.

		*/
	}

	void PlaySound(){


	}
}
