using UnityEngine;
using System.Collections;

public class CardModel : MonoBehaviour
{
	SpriteRenderer spriterend;
	public Sprite[] faces;
	//public Sprite cardBack;

	public int cardIndex;

	public void Show(bool showface)
	{
		if (showface) {
			spriterend.sprite = faces [cardIndex];
		} else {
			spriterend.sprite = faces [5];
		}
	}
	void Awake()
	{
		spriterend = GetComponent<SpriteRenderer> ();
	}
}
