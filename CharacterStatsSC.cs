using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using UnityEngine;

namespace EnvisionCoding.CharacterStats
{
    public enum ModiferType
    {
        Flat,
        AddPercent,
        MultPercent
    }


    [Serializable]
    public class CharacterStatsSC
    {
        public float Amount;


        public CharacterStatsSC(float amount)
        {
            this.Amount = amount;
        }

        public virtual void UpdateAmount(float amount, bool increase)
        {
            if (increase)
                Amount += amount;
            else
            {
                if ((Amount - amount) >= 0)
                    Amount -= amount;
                else
                    Amount = 0;
            }
                
        }

        public virtual void UpdateAmount(float amount, bool increase, ModiferType type)
        {
            float finalAmount = Amount;
            float sumPercentAdd = 0;

            if (increase)
            {
                if(type == ModiferType.Flat)
                {
                    Amount += amount;
                }
                    
                else if(type == ModiferType.AddPercent)
                {
                    sumPercentAdd += amount;

                    finalAmount *= 1 + sumPercentAdd;

                    sumPercentAdd = 0;

                    Amount = finalAmount;
                }
                else if(type == ModiferType.MultPercent)
                {
                    finalAmount *= 1 + amount;
                    Amount = finalAmount;
                }
            }
            else
            {
                if ((Amount - amount) >= 0)
                    Amount -= amount;
                else
                    Amount = 0;
            }
        }

        
    }
}


