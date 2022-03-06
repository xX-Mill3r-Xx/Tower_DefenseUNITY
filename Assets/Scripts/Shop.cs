using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    BuildManeger buildManeger;

    private void Start()
    {
        buildManeger = BuildManeger.instance;
    }

    public void PurcheseStandartTurrent()
    {
        Debug.Log("Standart Turrent Selected");
        buildManeger.SetTurrentToBuild(buildManeger.standrdTurrentPrefab);
    }

    public void PurcheseAnoterTurrent()
    {
        Debug.Log("Super Turrent Selected");
        buildManeger.SetTurrentToBuild(buildManeger.anoterTurrentPrefab);
    }

    public void PurcheseMisseleLaucher()
    {
        Debug.Log("Missele Laucher Selected");
        buildManeger.SetTurrentToBuild(buildManeger.MisseleLaucherPrefab);
    }
}
