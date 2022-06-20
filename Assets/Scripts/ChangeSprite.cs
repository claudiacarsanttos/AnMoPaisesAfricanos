using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeSprite : MonoBehaviour
{
    public Button buttonOn, buttonOff;

    void Start()
    {
        buttonOff.onClick = new Button.ButtonClickedEvent();
        buttonOff.onClick.AddListener(() => SpriteChange());
    }

    public void SpriteChange()
    {
        buttonOff.gameObject.SetActive(!buttonOff.gameObject.activeInHierarchy);
    }
}
