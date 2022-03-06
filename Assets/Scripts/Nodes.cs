using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Nodes : MonoBehaviour
{
    public Color houverColor;
    public Vector3 positionOffSet;

    private GameObject turrent;

    private Renderer rend;
    private Color startColor;

    BuildManeger buildManeger;

    private void Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;
        buildManeger = BuildManeger.instance;
    }

    private void OnMouseDown()
    {
        if (EventSystem.current.IsPointerOverGameObject())
        {
            return;
        }

        if (buildManeger.GetTurrentToBuild() == null)
        {
            return;
        }

        if(turrent != null)
        {
            Debug.Log("Can't Build there! - TODO: Display on screen.");
            return;
        }

        GameObject turrentToBuild = buildManeger.GetTurrentToBuild();
        turrent = (GameObject)Instantiate(turrentToBuild, transform.position + positionOffSet, transform.rotation);
    }

    void OnMouseEnter()
    {
        if (EventSystem.current.IsPointerOverGameObject())
        {
            return;
        }

        if(buildManeger.GetTurrentToBuild() == null)
        {
            return;
        }
        rend.material.color = houverColor;
    }

    private void OnMouseExit()
    {
        rend.material.color = startColor;
    }
}
