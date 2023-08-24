using System;
using UnityEngine;

[Serializable]
public class Animation
{
	public int width;
	public int height;
	public int loopStart;
	public int fps;
	public Texture2D[] textures;
	public int offset;
}
