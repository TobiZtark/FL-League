using UnityEngine;
using System.Collections.Generic;
using System.Linq;

public class RandomShii : MonoBehaviour {
	
	public GameObject cardPrefab;
	public int cardOffset;
	public Vector3 start;

	float a = 12.1f;
	float b = 14.2f;
	float c = 14.3f;
	float d = 13.4f;
	float e = 14.5f;


	void Start()
	{
        var arrange = new Dictionary<float, int>();
        int cardCount = 0;

        arrange.Add(a, 2);
        arrange.Add(b, 4);
        arrange.Add(c, 0);
        arrange.Add(d, 3);
        arrange.Add(e, 1);



        var list = arrange.Keys.ToList();
        list.Sort ();
        list.Reverse();


        foreach (var key in list)
        //foreach (KeyValuePair<string, int> pair in arrange.OrderBy(key => key.Value))
        //foreach (KeyValuePair<string, int> author in arrange.OrderBy(key => key.Value))
        {
            

            float co = cardOffset * cardCount;
            GameObject cardCopy = (GameObject)Instantiate(cardPrefab);
            Vector3 temp = start + new Vector3(0f, co);
            cardCopy.transform.position = temp;

            CardModel cardModel = cardCopy.GetComponent<CardModel>();
            cardModel.cardIndex = arrange[key];
            cardModel.Show(true);
            cardCount++;

            //Debug.Log ( key+ " "+ arrange[key]);
            
        }

        
    }
}


