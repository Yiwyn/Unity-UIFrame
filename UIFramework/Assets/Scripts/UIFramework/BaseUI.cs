using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
///  基本的UI类,用来存放UI的功能
/// </summary>
public class BaseUI : MonoBehaviour
{

    public GameObject UIObj;

    void Awake()
    {
        UIObj = this.gameObject;
    }

    public virtual void OnPause() //暂停这个UI的使用
    {

    }
    public virtual void OnResume() //继续使用这个UI 
    {

    }
    public virtual void OnStart()//开始这个UI的使用
    {

    }
    public virtual void OnClose()//结束这个UI的使用
    {
        print("这个界面关闭了");
        Destroy(UIObj);
        

    }
}
