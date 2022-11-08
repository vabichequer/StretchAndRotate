using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stretch : MonoBehaviour
{
    public enum Mode
    {
        X,
        Y,
        Z
    }

    /*
     * Allows for the selection of a stretch dimension through the Mode enumeration.
     * It will be available as a public variable in the editor in the form of a dropdown menu.
     */
    public Mode Dimension;

    // Target will be the object in which these modifications will be performed
    public GameObject Target;
    
    // Mod/IPSize are vectors that control the speed at which the stretching occurs.
    // Mod will be for the target
    // IPSize will be for the interaction points, so they don't get swallowed
    private Vector3 Mod, IPSize;

    /* Start will define which type of Mod array will be used, according to the selected dimension.
     * This makes sure that this selection is made only one time, instead of doing it at every update.
     */

    void Start()
    {
        float Amount = 0.001f;

        IPSize = new Vector3(0, 0, Amount);

        switch (Dimension)
        {
            case Mode.X:
                Mod = new Vector3(Amount, 0, 0);
                break;
            case Mode.Y:
                Mod = new Vector3(0, Amount, 0);
                break;
            case Mode.Z:
                Mod = new Vector3(0, 0, Amount);
                break;
            default:
                break;
        }
    }

    // Stretches the target and the interaction point through Mod and IPsize
    void StretchIt()
    {
        Target.transform.localScale += Mod;
        gameObject.transform.localScale += IPSize;
    }

    // Stretches the target and the interaction point through Mod and IPsize
    void ShrinkIt()
    {
        Target.transform.localScale -= Mod;
        gameObject.transform.localScale -= IPSize;
    }

    /*
     * Update will check, through raycasting, if the collider that was hit has a Stretch component.
     * If it does, than it calls the function to stretch it in the correct dimension.
     */
    void Update()
    {
       if (Input.GetMouseButton(0))
       {
            Vector3 mousePosition = Input.mousePosition;
            Ray ray = Camera.main.ScreenPointToRay(mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                if (hit.collider.gameObject.TryGetComponent(typeof(Stretch), out Component comp))
                {
                    comp.GetComponent<Stretch>().StretchIt();
                }
            }
       }

        if (Input.GetMouseButton(1))
        {
            Vector3 mousePosition = Input.mousePosition;
            Ray ray = Camera.main.ScreenPointToRay(mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                if (hit.collider.gameObject.TryGetComponent(typeof(Stretch), out Component comp))
                {
                    comp.GetComponent<Stretch>().ShrinkIt();
                }
            }
        }
    }
}
