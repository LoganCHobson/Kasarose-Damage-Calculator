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
        #region weight
        float weight = int.Parse(weaponWeightField.text);

        if (weight >= 0.1 && weight <= 3) //Small
        {
            if ((int)bodySelection == 0 || (int)bodySelection == 1) //Head
            {
                if (Weapon.SmallWeightBonuses.TryGetValue(PartNames.HEAD, out float bonus))
                {
                    weightBonus = bonus;
                }
            }
            if ((int)bodySelection >= 2 && (int)bodySelection <= 12) //Torso
            {
                if (Weapon.SlashingBonuses.TryGetValue(PartNames.TORSO, out float bonus))
                {
                    weightBonus = bonus;
                }
            }
            if ((int)bodySelection >= 13 && (int)bodySelection <= 17) //Legs
            {
                if (Weapon.SlashingBonuses.TryGetValue(PartNames.PELVIS, out float bonus3))
                {
                    weightBonus = bonus3;
                }
            }
        }

        if (weight >= 4 && weight <= 8) //Medium
        {
            if ((int)bodySelection == 0 || (int)bodySelection == 1) //Head
            {
                if (Weapon.MediumWeightBonuses.TryGetValue(PartNames.HEAD, out float bonus))
                {
                    weightBonus = bonus;
                }
            }
            if ((int)bodySelection >= 2 && (int)bodySelection <= 12) //Torso
            {
                if (Weapon.MediumWeightBonuses.TryGetValue(PartNames.TORSO, out float bonus2))
                {
                    weightBonus = bonus2;
                }
            }
            if ((int)bodySelection >= 13 && (int)bodySelection <= 17) //Legs
            {
                if (Weapon.MediumWeightBonuses.TryGetValue(PartNames.PELVIS, out float bonus3))
                {
                    weightBonus = bonus3;
                }
            }
        }

        if (weight >= 9 && weight <= 14) //Large
        {
            if ((int)bodySelection == 0 || (int)bodySelection == 1) //Head
            {
                if (Weapon.LargeWeightBonuses.TryGetValue(PartNames.HEAD, out float bonus))
                {
                    weightBonus = bonus;
                }
            }
            if ((int)bodySelection >= 2 && (int)bodySelection <= 12) //Torso
            {
                if (Weapon.LargeWeightBonuses.TryGetValue(PartNames.TORSO, out float bonus2))
                {
                    weightBonus = bonus2;
                }
            }
            if ((int)bodySelection >= 13 && (int)bodySelection <= 17) //Legs
            {
                if (Weapon.LargeWeightBonuses.TryGetValue(PartNames.PELVIS, out float bonus3))
                {
                    weightBonus = bonus3;
                }
            }
        }

        if (weight >= 15 && weight <= 20) //XL
        {
            if ((int)bodySelection == 0 || (int)bodySelection == 1) //Head
            {
                if (Weapon.ExtraLargeWeightBonuses.TryGetValue(PartNames.HEAD, out float bonus))
                {
                    weightBonus = bonus;
                }
            }
            if ((int)bodySelection >= 2 && (int)bodySelection <= 12) //Torso
            {
                if (Weapon.ExtraLargeWeightBonuses.TryGetValue(PartNames.TORSO, out float bonus2))
                {
                    weightBonus = bonus2;
                }
            }
            if ((int)bodySelection >= 13 && (int)bodySelection <= 17) //Legs
            {
                if (Weapon.ExtraLargeWeightBonuses.TryGetValue(PartNames.PELVIS, out float bonus3))
                {
                    weightBonus = bonus3;
                }
            }
        }

        #endregion


        #region weaponBonuses

        if (weaponType == WeaponType.SLASHING)
        {
            if ((int)bodySelection == 0 || (int)bodySelection == 1) //Head
            {

                if (Weapon.SlashingBonuses.TryGetValue(PartNames.HEAD, out float bonus))
                {
                    weaponBonus = bonus;
                }
            }

            if ((int)bodySelection >= 2 && (int)bodySelection <= 12) //Torso
            {
                if (Weapon.SlashingBonuses.TryGetValue(PartNames.TORSO, out float bonus))
                {
                    weaponBonus = bonus;
                }
            }

            if ((int)bodySelection >= 13 && (int)bodySelection <= 17) //Legs
            {
                if (Weapon.SlashingBonuses.TryGetValue(PartNames.PELVIS, out float bonus))
                {
                    weaponBonus = bonus;
                }
            }
        }
        if (weaponType == WeaponType.BLUDGEONING)
        {
            if ((int)bodySelection == 0 || (int)bodySelection == 1) //Head
            {
                if (Weapon.BludgeoningBonuses.TryGetValue(PartNames.HEAD, out float bonus))
                {
                    weaponBonus = bonus;
                }
            }
            if ((int)bodySelection >= 2 && (int)bodySelection <= 12) //Torso
            {
                if (Weapon.BludgeoningBonuses.TryGetValue(PartNames.TORSO, out float bonus))
                {
                    weaponBonus = bonus;
                }
            }
            if ((int)bodySelection >= 13 && (int)bodySelection <= 17) //Legs
            {
                if (Weapon.BludgeoningBonuses.TryGetValue(PartNames.PELVIS, out float bonus))
                {
                    weaponBonus = bonus;
                }
            }
        }

        if (weaponType == WeaponType.STABBING)
        {
            if ((int)bodySelection == 0 || (int)bodySelection == 1) //Head
            {
                if (Weapon.StabbingBonuses.TryGetValue(PartNames.HEAD, out float bonus))
                {
                    weaponBonus = bonus;
                }
            }
            if ((int)bodySelection >= 2 && (int)bodySelection <= 12) //Torso
            {
                if (Weapon.StabbingBonuses.TryGetValue(PartNames.TORSO, out float bonus))
                {
                    weaponBonus = bonus;
                }
            }
            if ((int)bodySelection >= 13 && (int)bodySelection <= 17) //Legs
            {
                if (Weapon.StabbingBonuses.TryGetValue(PartNames.PELVIS, out float bonus))
                {
                    weaponBonus = bonus;
                }
            }
        }


        #endregion



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

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
