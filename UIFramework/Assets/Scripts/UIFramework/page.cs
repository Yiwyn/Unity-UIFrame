using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class page : BaseUI, IDragHandler
{

    public Button[] btns;


    public void OnDrag(PointerEventData eventData)
    {
        UIObj.transform.position = Input.mousePosition;
    }

    public override void OnPause()
    {
        base.OnPause();
        for (int i = 0; i < btns.Length; i++)
        {
            btns[i].enabled = false;
        }
    }

    public override void OnResume()
    {
        base.OnResume();
        for (int i = 0; i < btns.Length; i++)
        {
            btns[i].enabled = true;
        }
    }


    public override void OnStart()
    {
        base.OnStart();
        print("执行开始程序");
        transform.GetComponent<Image>().color = new Color(Random.value, Random.value, Random.value);
    }



}
