using System;
using UnityEngine;

[Serializable]
public class Switch : MonoBehaviour
{
	public GameObject gate;
	public Collider gateCollider;
	public GameObject bridge;
	public GameObject bridgeHinge;
	public Texture2D[] textures;
	public bool closeOnExit;
	public float gateMove;
}
