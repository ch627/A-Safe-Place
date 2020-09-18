using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditsController : MonoBehaviour
{
    public CanvasGroup Christian; // stores a refrence to Christian's contribution
    public CanvasGroup Credits; // stores a refrence to the credits menu

    public void Start()
    {
        //Credits = this.GetComponent<CanvasGroup>(); // store the credits menu canvas group
    }

    // load Christian's contribution
    public void christianContribution()
    {
        Christian.alpha = 1;
        Christian.interactable = true;
        Christian.blocksRaycasts = true;
        Credits.alpha = 0;
        Credits.interactable = false;
        Credits.blocksRaycasts = false;
    }
    // go back to the credits menu
    public void Back()
    {
        Christian.alpha = 0;
        Christian.interactable = false;
        Christian.blocksRaycasts = false;
        Credits.alpha = 1;
        Credits.interactable = true;
        Credits.blocksRaycasts = true;
    }
}
