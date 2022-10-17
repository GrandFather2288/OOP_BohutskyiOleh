using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba4
{
    internal class Dough
    {
        #region Fields
        string flourType;
        string bakingTechnique;
        float weight;
        #endregion

        #region Constructor
        public Dough(string flourType, string bakingTechnique, float weight)
        {
            if (flourType == "white" || flourType == "wholegrain")
            {
                this.flourType = flourType;
            }
            else
            {
                Console.WriteLine("Invalid flour type!");
            }

            if (bakingTechnique == "crispy" || bakingTechnique == "chewy" || bakingTechnique == "homemade")
            {
                this.bakingTechnique = bakingTechnique;
            }
            else
            {
                Console.WriteLine("Invalid baking technique!");
            }

            if (weight > 0 && weight <= 200)
            {
                this.weight = weight;
            }
            else
            {
                Console.WriteLine("Dough weight should be in the range [1..200].");
            }
        }
        #endregion

        #region Properties
        public string FlourType
        {
            get { return flourType; }
            set 
            {
                if (value == "white" || value == "wholegrain")
                {
                    flourType = value;
                }
                else
                {
                    Console.WriteLine("Invalid flour type!");
                }
            }
        }

        public string BakingTechnique
        {
            get { return bakingTechnique; }
            set
            {
                if (value == "crispy" || value == "chewy" || value == "homemade")
                {
                    bakingTechnique = value;
                }
                else
                {
                    Console.WriteLine("Invalid baking technique!");
                }
            }
        }

        public float Weight
        {
            get { return weight; }
            set
            {
                if(value > 0 && value <= 200)
                {
                    weight = value;
                }
                else
                {
                    Console.WriteLine("Dough weight should be in the range [1..200].");
                }
            }
        }

        public float TotalCalories
        {
            get { return DoughCalories(); }
        }
        #endregion

        #region Methods
        float DoughCalories()
        {
            float flourTypeCoef = 0;
            float bakingTechniqueCoef = 0; 

            if (flourType == "white")
            {
                flourTypeCoef = 1.5f;
            }
            else if(flourType == "wholegrain")
            {
                flourTypeCoef = 1.0f;
            }

            if (bakingTechnique == "crispy")
            {
                bakingTechniqueCoef = 0.9f;
            }
            else if (bakingTechnique == "chewy")
            {
                bakingTechniqueCoef = 1.1f;
            }
            else if (bakingTechnique == "homemade")
            {
                bakingTechniqueCoef = 1.0f;
            }

            return (2 * weight) * flourTypeCoef * bakingTechniqueCoef;
        }
        #endregion
    }
}
