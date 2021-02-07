//Recipe.cs
//Created: 2020-10-22 by Andrius Sukys
//Updated: 2020-10-30 by Andrius Sukys


using System;

namespace CookBook
{
    //class is creating Recipe object which is responsible for name of recipe, ingredients and description
    public class Recipe
    {
        private string[] ingredientsArray;
        private string recipeName;
        private FoodCategory foodCategory;
        private string description;


        //Class constructor
        public Recipe(int maxNumOfIngrediens)
        {
            ingredientsArray = new string[maxNumOfIngrediens];
            DefaultValues();
        }


        //Get and Set properties to the objects of recipe class
        public string[] IngredientsArray

        {
            get { return ingredientsArray; }
            set { ingredientsArray = value; }
        }

        public string RecipeName
        {
            get { return recipeName; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    recipeName = value;
            }
        }

        public FoodCategory FoodCategory
        {
            get { return foodCategory; }
            set { foodCategory = value; }
        }

        public string Description
        {
            get { return description; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    description = value;
            }
        }

        public int MaxNumOfIngrediens
        {
            get { return ingredientsArray.Length; }
        }


        //Sets to default values
        public void DefaultValues()
        {
            for (int i = 0; i < ingredientsArray.Length; i++)
                ingredientsArray[i] = string.Empty;

            recipeName = string.Empty;
            foodCategory = FoodCategory.Meat;
            description = string.Empty;
        }


        //Returns 1st vaccant position in the array
        public int FindVacantPosition()
        {
            int emptySpace = -1;

            for (int i = 0; i < ingredientsArray.Length; i++)
                if (ingredientsArray[i] == string.Empty)
                {
                    emptySpace = i;
                    break;
                }
            return emptySpace;
        }

        //Add ingredient to free space in the array if its available
        public bool AddIngredient(string ingredient)
        {
            bool ok = true;
            int emptyIndex = FindVacantPosition();

            if (emptyIndex >= 0)
                ingredientsArray[emptyIndex] = ingredient;
            else
                ok = false;

            return ok;
        }

        //Check that index is in the array
        public bool CheckIndex(int index)
        {
            if (index >= 0 && index < ingredientsArray.Length)
                return true;
            else
                return false;
        }


        //Counts how many ingredients are in the array
        public int GetCurrentNumOfIngrediens()
        {
            int count = 0;
            for (int i = 0; i < ingredientsArray.Length; i++)
                if (!string.IsNullOrEmpty(ingredientsArray[i]))
                    count++;
            return count;
        }

        //Prints out recipe name, number of ingredients, food category and description
        public override string ToString()
        {
            int chars = Math.Min(description.Length, 30);
            string descriptionText = description.Substring(0, chars);

            int chars2 = Math.Min(recipeName.Length, 30);
            string nameText = recipeName.Substring(0, chars2);

            int chars3 = Math.Min(foodCategory.ToString().Length, 30);
            string categoryText = (foodCategory.ToString().Substring(0, chars3));

            int chars4 = Math.Min(GetCurrentNumOfIngrediens().ToString().Length, 30);
            string noText = (GetCurrentNumOfIngrediens().ToString().Substring(0, chars4));

            if (string.IsNullOrEmpty(descriptionText))
                descriptionText = "No description";

            string textOut = string.Format("{0, -30} {1, 30} {2, 30} {3, 30}", nameText, noText, categoryText, descriptionText);
            return textOut;
        }
    }
}
