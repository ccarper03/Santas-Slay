using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
/*
[CustomEditor (typeof (SantaScript_NN))]
public class SantaEditorScript_NN : Editor {
	
	public override void OnInspectorGUI(){

		SantaScript_NN myTarget = (SantaScript_NN)target;

		GUIStyle myStyle;
		myStyle = new GUIStyle("Label");
		myStyle.normal.textColor = Color.blue;
		myStyle.alignment = TextAnchor.MiddleCenter;
		myStyle.fontStyle = FontStyle.Bold;

		//The Player.
		EditorGUILayout.BeginVertical ("box");
		EditorGUIUtility.labelWidth = 120;
		EditorGUILayout.LabelField ("Drag the player gameobject here!", myStyle);	
		myTarget.thePlayer = EditorGUILayout.ObjectField ("The Player", myTarget.thePlayer, typeof (GameObject), false) as GameObject;
		EditorGUILayout.EndVertical ();

		if (myTarget.thePlayer != null) {
			//Distance.
			EditorGUILayout.BeginVertical ("box");
			EditorGUIUtility.labelWidth = 120;
			EditorGUILayout.LabelField ("The distance between the player and how long to decide either idle or walk!", myStyle);
			myTarget.actionTimer = EditorGUILayout.FloatField ("Walk or Idle Timer", myTarget.actionTimer);
			myTarget.idleOrWalkDistance = EditorGUILayout.FloatField ("Idle or Walk Distance", myTarget.idleOrWalkDistance);
			myTarget.areWeChasing = EditorGUILayout.Toggle ("Are We Using Chase?", myTarget.areWeChasing);
			myTarget.chaseDistance = EditorGUILayout.FloatField ("Chase Distance", myTarget.chaseDistance);
			myTarget.attackDistance = EditorGUILayout.FloatField ("Stop distance", myTarget.attackDistance);
			EditorGUILayout.HelpBox ("Note: The Idle and Walk is a distance between Santa and the player. We decide whether to idle or walk when we are at that distance. If we want to chase the player, toggle it on and set at what distance we should start to chase, and what distance should we stop in front of the player. If not, just set the Chasing distan ce to half of the Idle or Walk distance.", MessageType.Info); 
			EditorGUILayout.EndVertical ();

			//Speed
			EditorGUILayout.BeginVertical ("box");
			EditorGUIUtility.labelWidth = 120;
			EditorGUILayout.LabelField ("Set the speed for Santa!", myStyle);
			myTarget.walkSpeed = EditorGUILayout.FloatField ("Walk Speed", myTarget.walkSpeed);
			myTarget.runSpeed = EditorGUILayout.FloatField ("Run Speed", myTarget.runSpeed);
			EditorGUILayout.EndVertical ();

			//Santa Roaming Area.
			GUILayout.Space (10);
			EditorGUIUtility.labelWidth = 40;
			EditorGUILayout.BeginVertical ("box");
			EditorGUIUtility.labelWidth = 120;
			EditorGUILayout.LabelField ("Where do we want Santa to randomly roaming?", myStyle);
			EditorGUILayout.BeginHorizontal ("box");
			myTarget.xMin = EditorGUILayout.FloatField ("Min X", myTarget.xMin);
			myTarget.xMax = EditorGUILayout.FloatField ("Max X", myTarget.xMax);
			EditorGUILayout.EndHorizontal ();
			EditorGUILayout.BeginHorizontal ("box");
			myTarget.yMin = EditorGUILayout.FloatField ("Min Y", myTarget.yMin);
			myTarget.yMax = EditorGUILayout.FloatField ("Max Y", myTarget.yMax);
			EditorGUILayout.EndHorizontal ();
			EditorGUILayout.BeginHorizontal ("box");
			myTarget.zMin = EditorGUILayout.FloatField ("Min Z", myTarget.zMin);
			myTarget.zMax = EditorGUILayout.FloatField ("Max Z", myTarget.zMax);
			EditorGUILayout.EndHorizontal ();
			EditorGUILayout.HelpBox ("Note: Recommend to have the X and Z the size of the terrain, and Y at 0 if it is a 3D game. If it is a 2D game, then recommend to make Z 0.", MessageType.Info); 
			EditorGUILayout.EndVertical ();

		}
	}

}
*/
