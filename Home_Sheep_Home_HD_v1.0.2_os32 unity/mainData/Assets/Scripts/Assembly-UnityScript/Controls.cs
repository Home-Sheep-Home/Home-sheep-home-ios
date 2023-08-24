using System;
using UnityEngine;

[Serializable]
public class Controls : MonoBehaviour
{
	public int currentSheep;
	public Collider[] faces;
	public Collider[] buttons;
	public MeshFilter[] selectionRings;
	public AudioClip[] startMusic;
	public AudioClip[] restartMusic;
	public AudioClip timedMusic;
}
