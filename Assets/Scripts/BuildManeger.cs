using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManeger : MonoBehaviour
{
    public static BuildManeger instance;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("More than one build maneger in scene!");
            return;
        }
        instance = this;
    }

    public GameObject standrdTurrentPrefab;

    public GameObject anoterTurrentPrefab;
    public GameObject MisseleLaucherPrefab;

    #region Colocar Torreta Manualmente
    //private void Start()
    //{
    //    turrentToBuild = standrdTurrentPrefab;
    //}
    #endregion

    private GameObject turrentToBuild;

    public GameObject GetTurrentToBuild()
    {
        return turrentToBuild;
    }

    public void SetTurrentToBuild(GameObject turret)
    {
        turrentToBuild = turret;
    }
}
