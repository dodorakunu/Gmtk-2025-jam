using UnityEngine;

public class LandingController : MonoBehaviour
{
    public LandingFlag child1;
    public LandingFlag child2;

    public bool allFlagsTrue = false;

    void Update()
    {
        if (child1.hasBallLanded && child2.hasBallLanded)
        {
            allFlagsTrue = true;

        }
        else
        {
            allFlagsTrue = false;
        }
    }
}

