using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotralManager
{
    public GameObject m_potralMain;
    public List<GameObject> m_potralList=new List<GameObject>();

    public void Init()
    {
        var objs = GameObject.FindGameObjectsWithTag("Potral");

        for (int i = 0,n=objs.Length; i < n; i++)
        {
            var unit = objs[i];
            var potral = objs[i].GetComponent<Portal>();
            if (potral.m_isMain)
            {
                m_potralMain = unit;
            }
            else
            {
                m_potralList.Add(unit);
            }
        }
    }

    public GameObject GetRandPortal()
    {
        var count = m_potralList.Count;
        if (count < 0)
            return null;
        var rand = Random.Range(0, count);
        return m_potralList[rand];
    }

    public GameObject GetMainPortal()
    {
        return m_potralMain;
    }

}
