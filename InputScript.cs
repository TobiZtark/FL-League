using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class InputScript : MonoBehaviour
{
	EventSystem system;

	// Use this for initialization
	void Start ()
	{

		system = EventSystem.current;

	}

	// Update is called once per frame
	public void Update()
	{

		if (Input.GetKeyDown(KeyCode.Tab))
		{
			Selectable next = null;
			if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
			{
				next = system.currentSelectedGameObject.GetComponent<Selectable>().FindSelectableOnUp();
				if (next == null)
					next = system.lastSelectedGameObject.GetComponent<Selectable>();
			}
			else
			{
				next = system.currentSelectedGameObject.GetComponent<Selectable>().FindSelectableOnDown();
				if (next == null)
					next = system.firstSelectedGameObject.GetComponent<Selectable>();
			}

			if (next != null)
			{

				InputField inputfield = next.GetComponent<InputField>();
				if (inputfield != null) inputfield.OnPointerClick(new PointerEventData(system));  //if it's an input field, also set the text caret

				system.SetSelectedGameObject(next.gameObject, new BaseEventData(system));
			}
			//else Debug.Log("next nagivation element not found");

		}
	}
}