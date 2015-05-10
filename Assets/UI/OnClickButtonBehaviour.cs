using UnityEngine;
using System.Collections;

public class OnClickButtonBehaviour : MonoBehaviour {

	[SerializeField]
	SpriteColor spriteColor;

	void Awake()
	{
		var button = GetComponent<UnityEngine.UI.Button>();
		button.onClick.AddListener( ()=>
       {
			spriteColor.color = GetComponent<UnityEngine.UI.Image>().color;
			spriteColor.GetComponent<Animator>().Play("Play");
		});
	}
}
