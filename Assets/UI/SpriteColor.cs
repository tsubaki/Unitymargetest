using UnityEngine;
using System.Collections;

public class SpriteColor : MonoBehaviour {

	public Color color{ get; set;}

	public enum ColorType{
		Red,
		Yellow
	}

	public ColorType type{get; set;}

	public void UpdateColor()
	{
		GetComponent<UnityEngine.UI.Image>().color = color;
	}
}
