using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

public class DropDown : MonoBehaviour, IPointerClickHandler, IPointerExitHandler {

	public RectTransform container;
	public bool isOpen= false;

	void Awake () {
		container = transform.FindChild ("Container").GetComponent<RectTransform>();
		isOpen = false;
	}
	

	void Update () {
		Vector3 scale = container.localScale;
		scale.y = Mathf.Lerp (scale.y, isOpen ? 1 : 0, Time.deltaTime * 12);
		container.localScale = scale; 
	}

	#region IPointerClickHandler implementation

	public void OnPointerClick (PointerEventData eventData)
	{
        if (isOpen == false)
        {
            isOpen = true;
        }
        else
        {
            isOpen = false;
        }
	}

	#endregion

	#region IPointerExitHandler implementation

	public void OnPointerExit (PointerEventData eventData)
	{
        if (isOpen == false)
        {
            isOpen = false;
        }
        else
        {
            isOpen = true;
        }
    }

	#endregion

}
