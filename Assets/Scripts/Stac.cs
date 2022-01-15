using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stac : MonoBehaviour
{
    private string StacAll;
    public TextMesh Stactxt;

    void Update()
    {
        StacAll = ProblemKinds.FailStac.ToString();
        Stactxt.text = StacAll;
    }
}
