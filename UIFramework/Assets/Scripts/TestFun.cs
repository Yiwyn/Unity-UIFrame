using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestFun : MonoBehaviour
{
    public GameObject uiprefab;

    public void AddUI()
    {
        GameObject go = Instantiate(uiprefab, transform.parent) as GameObject;
        UICore.Instance.AddUI(go.GetComponent<page>());
    }

    public void CloseUI()
    {
        UICore.Instance.RemoveUI();
    }

}
