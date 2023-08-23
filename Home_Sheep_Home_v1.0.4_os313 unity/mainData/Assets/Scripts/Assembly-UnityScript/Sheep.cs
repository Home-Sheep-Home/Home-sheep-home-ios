using System;
using UnityEngine;

[Serializable]
public class Sheep : MonoBehaviour
{
	public float scale;
	public float impulseJump;
	public float impulseWalk;
	public float impulseAir;
	public float impulseTrampoline;
	public float maxWalk;
	public float maxAir;
	public Animation[] anims;
	public AnimPhase curAnim;
	public AnimDir curDir;
	public AnimPhase newAnim;
	public AnimDir srcDir;
	public bool canJump;
	public MeshRenderer arrow;
	public bool isOnGround;
	public bool jumpingOnTrampoline;
	public AudioClip[] alertSnd;
	public AudioClip[] bumpSnd;
	public AudioClip landSnd;
	public AudioClip walkSnd;
	public AudioClip jumpSnd;
}
