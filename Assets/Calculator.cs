using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Calculator : MonoBehaviour
{
    public TMP_Dropdown weaponTypeDropDown;
    public TMP_InputField weaponWeightField;

    private PartNames bodySelection;
    private float areaMultiplier;

    private WeaponType weaponType;
    private float weaponBonus;

    private Dictionary<WeaponType, Func<PartNames, float>> weaponBonusCalculators;

    private float weightBonus;

    public void BodySelection(BodyPart _part)
    {
        bodySelection = _part.name;
        areaMultiplier = _part.areaMultiplier;
    }

    public void Calculate()
    {
        float weight = float.Parse(weaponWeightField.text);

        CalculateWeightBonus(weight);
       
        if (weaponBonusCalculators.ContainsKey(weaponType))
        {
            weaponBonus = weaponBonusCalculators[weaponType](bodySelection);
        }
        
        float damage = areaMultiplier * (weaponBonus + weightBonus);

        Debug.Log("Used " + weaponType + " which weighs " + weight + " on " + bodySelection + " for " + damage + " Calc: " + areaMultiplier + "*(" + weaponBonus + " + " + weightBonus + ")");
    }

    public void TypeSelection(TMP_Dropdown _dropdown)
    {
        switch (_dropdown.value)
        {
            case 0:
                weaponType = WeaponType.SLASHING;
                break;
            case 1:
                weaponType = WeaponType.BLUDGEONING;
                break;
            case 2:
                weaponType = WeaponType.STABBING;
                break;
        }
    }
    
    void Start()
    {
        weaponBonusCalculators = new Dictionary<WeaponType, Func<PartNames, float>>()
        {
            { WeaponType.SLASHING, GetSlashingBonus },
            { WeaponType.BLUDGEONING, GetBludgeoningBonus },
            { WeaponType.STABBING, GetStabbingBonus }
        };
    }
    
    private void CalculateWeightBonus(float weight)
    {
        if (weight >= 0.1 && weight <= 3) //Small
        {
            weightBonus = GetWeightBonus(Weapon.SmallWeightBonuses);
        }
        else if (weight >= 4 && weight <= 8) //Medium
        {
            weightBonus = GetWeightBonus(Weapon.MediumWeightBonuses);
        }
        else if (weight >= 9 && weight <= 14) //Large
        {
            weightBonus = GetWeightBonus(Weapon.LargeWeightBonuses);
        }
        else if (weight >= 15 && weight <= 20) //XL
        {
            weightBonus = GetWeightBonus(Weapon.ExtraLargeWeightBonuses);
        }
    }
  
    private float GetWeightBonus(Dictionary<PartNames, float> weightBonuses)
    {
        if (weightBonuses.TryGetValue(bodySelection, out float bonus))
        {
            return bonus;
        }
        return 0f; 
    }
    
    private float GetSlashingBonus(PartNames part)
    {
        if (Weapon.SlashingBonuses.TryGetValue(part, out float bonus))
        {
            return bonus;
        }
        return 0f;
    }

    private float GetBludgeoningBonus(PartNames part)
    {
        if (Weapon.BludgeoningBonuses.TryGetValue(part, out float bonus))
        {
            return bonus;
        }
        return 0f;
    }

    private float GetStabbingBonus(PartNames part)
    {
        if (Weapon.StabbingBonuses.TryGetValue(part, out float bonus))
        {
            return bonus;
        }
        return 0f;
    }
}
