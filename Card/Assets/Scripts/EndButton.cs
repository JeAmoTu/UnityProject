using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndButton : MonoBehaviour
{
    private UILabel mLabel;

    private void Awake()
    {
        mLabel = transform.Find("Label").GetComponent<UILabel>();
    }
    public void onButtonClick()
    {
        mLabel.text = "对方回合";
    }
}
