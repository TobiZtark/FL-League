using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Slot : MonoBehaviour, IDropHandler{

    #region IDropHandler implementation
    public void OnDrop (PointerEventData eventData)
	{
        
        DragHandler d = eventData.pointerDrag.GetComponent<DragHandler>();
		if (d!= null) {
            d.startParent = this.transform;
			//DragHandler.itemBeingDragged.transform.SetParent (transform);
		}
	}
	#endregion

}
