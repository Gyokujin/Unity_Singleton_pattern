using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    void Start()
    {
        GameManager.Instance.Game();
        DataManager.Instance.Save();
    }
}