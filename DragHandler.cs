using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragHandler : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler {
	//public static GameObject itemBeingDragged;
	//Vector3 startPosition;
	public Transform startParent=null;
   // Transform placeholderParent;
    GameObject placeholder = null;

	#region IBeginDragHandler implementation
	
	public void OnBeginDrag (PointerEventData eventData)
	{
        
        placeholder = new GameObject();
        placeholder.transform.SetParent(this.transform.parent);
        //RectTransform re = placeholder.GetComponent<RectTransform>();
       // re.height = this.GetComponent<Rect>().height;
       // re.width = this.GetComponent<Rect>().width;
        LayoutElement le = placeholder.AddComponent<LayoutElement>();
        le.preferredWidth = this.GetComponent<LayoutElement>().preferredWidth;
        le.preferredHeight = this.GetComponent<LayoutElement>().preferredHeight;
        le.flexibleWidth = 0;
        le.flexibleHeight = 0;
        placeholder.transform.SetSiblingIndex(this.transform.GetSiblingIndex());
        
       // itemBeingDragged = gameObject;
       // startPosition = this.transform.position;
        startParent = this.transform.parent;
        this.transform.SetParent(this.transform.parent.parent);
		GetComponent<CanvasGroup> ().blocksRaycasts = false;
	}
	
	#endregion

	#region IDragHandler implementation

	public void OnDrag (PointerEventData eventData)
	{
		//this.transform.position = Input.mousePosition;
        this.transform.position = eventData.position;

       // if (placeholder.transform.parent != placeholderParent)
        //    placeholder.transform.SetParent(placeholderParent);
        int newSiblingIndex = placeholder.transform.GetSiblingIndex();

        for (int i = 0; i < startParent.childCount; i++)
      {
          if (this.transform.position.y > startParent.GetChild(i).position.y)
          {
               newSiblingIndex = i;
             if (placeholder.transform.GetSiblingIndex() < newSiblingIndex)
                  newSiblingIndex--;
                placeholder.transform.SetSiblingIndex(i);
               break;
          }

        }
      //  placeholder.transform.SetSiblingIndex(newSiblingIndex);
    }

	#endregion



	#region IEndDragHandler implementation
	
	public void OnEndDrag (PointerEventData eventData)
	{
		//itemBeingDragged = null;
        this.transform.SetParent(startParent);
        this.transform.SetSiblingIndex(placeholder.transform.GetSiblingIndex());
        GetComponent<CanvasGroup>().blocksRaycasts = true;
        /*
                if (transform.parent == startParent) {
                    transform.position = startPosition;
                }*/
        Destroy(placeholder);
    }
	
	#endregion


}
