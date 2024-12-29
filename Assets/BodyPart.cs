using UnityEngine;

[SerializeField]
public class BodyPart : MonoBehaviour
{
    public PartNames name;
    public float areaMultiplier = .1f;

}

public enum PartNames
{ 
    HEAD = 0,
    NECK = 1,

    CHEST = 2,
    TORSO = 3,
    BELLY = 4,
    LEFTSHOULDER = 5,
    RIGHTSHOULDER = 6,
    LEFTUPPERARM = 7,
    RIGHTUPPERARM = 8,
    LEFTFOREARM = 9,
    RIGHTFOREARM = 10,
    LEFTHAND = 11,
    RIGHTHAND = 12,

    PELVIS = 13,
    LEFTLEG = 14,
    RIGHTLEG = 15,
    LEFTFOOT = 16,
    RIGHTFOOT = 17
}
