using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selection : MonoBehaviour
{
    [SerializeField] private Material highlighted;
    [SerializeField] private Material defaultMaterial;
    [SerializeField] private string selectibleTag = "Platform";
    [SerializeField] private string selectibleTag2 = "EnemyA";
    [SerializeField] private string selectibleTag3 = "EnemyB";

    private Transform underSelection;

    public GameObject Turrent;
    public Enemy TypeA;
    public Enemy TypeB;

    void Update()
    {
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (underSelection != null)
        {
            var selectionRenderer = underSelection.GetComponent<Renderer>();
            selectionRenderer.material = defaultMaterial;
            underSelection = null;
        }

        if (Physics.Raycast(ray, out hit))
        {

            var selection = hit.transform;
            Debug.Log(selection.tag);
            if (selection.CompareTag(selectibleTag) || selection.CompareTag(selectibleTag2) || selection.CompareTag(selectibleTag2))
            {
                var selectionRenderer = selection.GetComponent<Renderer>();

                if (selectionRenderer != null)
                {
                    selectionRenderer.material = highlighted;
                    Debug.Log(selectionRenderer.tag);
                    if (Input.GetKeyDown(KeyCode.Mouse0) && selection.CompareTag(selectibleTag))
                    {

                        Instantiate(Turrent, underSelection);
                        Debug.Log("HIT! POG!");
                    }

                    else if (Input.GetKeyDown(KeyCode.Mouse0) && selection.CompareTag(selectibleTag2))
                    {
                        TypeA.takeDamage(3);
                    }

                    else if (Input.GetKeyDown(KeyCode.Mouse0) && selection.CompareTag(selectibleTag3))
                    {
                        TypeB.takeDamage(3);
                    }
                }

                underSelection = selection;
            }

        }
    }
}


