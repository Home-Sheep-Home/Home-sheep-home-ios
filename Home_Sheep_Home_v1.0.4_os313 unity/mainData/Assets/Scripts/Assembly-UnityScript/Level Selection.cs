using System;
using UnityEngine;

[Serializable]
public class Level Selection : MonoBehaviour
{
	public int levelNumber;
	public TextMesh levelText;
	public MeshFilter levelLocked;
	public MeshFilter levelCompleted;
	public MeshFilter levelSelectionRing;
}
