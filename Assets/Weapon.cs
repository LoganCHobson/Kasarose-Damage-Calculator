using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public static readonly Dictionary<PartNames, float> SlashingBonuses = new Dictionary<PartNames, float>()
    {
        { PartNames.HEAD, 1.5f },
        { PartNames.TORSO, 1f },
        { PartNames.PELVIS, 1.2f }
    };
    public static readonly Dictionary<PartNames, float> BludgeoningBonuses = new Dictionary<PartNames, float>()
    {
        { PartNames.HEAD, 2f },
        { PartNames.TORSO, 1f },
        { PartNames.PELVIS, 1f }
    };
    public static readonly Dictionary<PartNames, float> StabbingBonuses = new Dictionary<PartNames, float>()
    {
        { PartNames.HEAD, 1.5f },
        { PartNames.TORSO, 1f },
        { PartNames.PELVIS, .75f }
    };


    public static readonly Dictionary<PartNames, float> SmallWeightBonuses = new Dictionary<PartNames, float>()
    {
        { PartNames.HEAD, 1.5f },
        { PartNames.TORSO, 1f },
        { PartNames.PELVIS, 1.2f }
    };

    public static readonly Dictionary<PartNames, float> MediumWeightBonuses = new Dictionary<PartNames, float>()
    {
        { PartNames.HEAD, 2.3f },
        { PartNames.TORSO, 1f },
        { PartNames.PELVIS, .90f }
    };

    public static readonly Dictionary<PartNames, float> LargeWeightBonuses = new Dictionary<PartNames, float>()
    {
        { PartNames.HEAD, 2.3f },
        { PartNames.TORSO, 1f },
        { PartNames.PELVIS, .95f }
    };

    public static readonly Dictionary<PartNames, float> ExtraLargeWeightBonuses = new Dictionary<PartNames, float>()
    {
        { PartNames.HEAD, 2.5f },
        { PartNames.TORSO, 1f },
        { PartNames.PELVIS, .95f }
    };

}
public enum WeaponType
{
    SLASHING, 
    BLUDGEONING, 
    STABBING 
}

public enum WeaponWeights
{
    SMALL, //0.1-3lbs
    MEDIUM, //4-8lbs
    LARGE, //9-14lbs
    EXTRALARGE //15-20lbs
}


