using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class SpriteButtonScript : MonoBehaviour, IPointerClickHandler // IBeginDragHandler, IEndDragHandler, IDragHandler, 
{

    public GameObject TargetObject;
    public string AnimationTriggerName;



    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log(TargetObject.name + " : " + AnimationTriggerName);

        TargetObject.GetComponent<TriceratopsScript>().CallAnimation(AnimationTriggerName);
    }

}


