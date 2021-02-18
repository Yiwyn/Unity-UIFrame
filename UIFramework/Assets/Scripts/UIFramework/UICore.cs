using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// UI的核心类,用来操作UI的逻辑等操作
/// </summary>
public class UICore
{
    public static UICore Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new UICore();
            }
            return instance;
        }
        private set { }
    } //单例模式


    private static UICore instance;

    private UICore()//构造函数,整个过程仅仅执行一次
    {
        Init();
    }

    private void Init()
    {
        UIs = new Stack<BaseUI>();
        Debug.Log("UICore初始话完成...");
    }

    public Stack<BaseUI> UIs; //用来存放UI




    public void AddUI(BaseUI baseUI) //每添加一个UI,那么把前一个UI暂停使用
    {
        if (UIs.Contains(baseUI))
        {
            return;
        }

        if (UIs.Count > 0)
        {
            UIs.Peek().OnPause();
        }

        UIs.Push(baseUI);



        UIs.Peek().OnStart();
    }

    public void RemoveUI()
    {
        if (UIs.Count == 0)
        {
            return;
        }

        UIs.Pop().OnClose();

        Debug.Log("关闭了");

        if (UIs.Count > 0)
        {
            UIs.Peek().OnResume();
        }
    }

}
