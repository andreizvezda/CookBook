//ManageRecipes.cs
//Created: 2020-10-22 by Andrius Sukys
//Updated: 2020-10-30 by Andrius Sukys

using System.Windows.Forms;

namespace CookBook
{
    //class will store all the recipes send by Recipe class
    class ManageRecipes
    {
        private readonly Recipe[] RecipeList;


        public ManageRecipes(int maxNumOfElements)
        {
            RecipeList = new Recipe[maxNumOfElements];
        }


        //Will return first empty position in the RecipeList array
        private int FindVacantPosition()
        {
            for (int i = 0; i < RecipeList.Length; i++)
            {
                if (RecipeList[i] == null)
                    return i;
            }
            return -1;
        }

        //will save recipe object into RecipeList array if there is free space, and return true/false
        public bool Add(Recipe newRecipe)
        {
            bool ok = true;
            int emptyIndex = FindVacantPosition();

            if (emptyIndex >= 0 && newRecipe != null)
            {

                RecipeList[emptyIndex] = newRecipe;
            }
            else
            {
                MessageBox.Show("Recipe's memory is full", "Error");
                ok = false;
            }

            return ok;

        }

        //overloaded Add method 
        public bool Add(Recipe newRecipe, int index)
        {
            bool ok = true;

            if (newRecipe != null)
            {

                RecipeList[index] = newRecipe;
            }
            else
                ok = false;
            return ok;

        }

        //giving current number of items in the array
        public int CurrentNumberOfItems()
        {
            int count = 0;
            for (int i = 0; i < RecipeList.Length; i++)
                if (RecipeList[i] != null)
                    count++;
            return count;
        }

        //checking in index is not out of bound
        public bool CheckIndex(int index)
        {
            if (index < RecipeList.Length)
                return true;
            else
                return false;

        }

        //Gets recipe with a selected index from the array
        public Recipe GetRecipeAt(int index)
        {
            if (CheckIndex(index))
                return RecipeList[index];
            else
                return null;
        }



        //Removes item from the recipe list
        public void DeleteItem(int selectedIndex, int maxNumOfElements)
        {
            if (selectedIndex >= 0)
            {
                RecipeList[selectedIndex] = null;

                while (selectedIndex < maxNumOfElements)
                {
                    if (selectedIndex + 1 < maxNumOfElements && RecipeList[selectedIndex + 1] != null)
                    {
                        RecipeList[selectedIndex] = RecipeList[selectedIndex + 1];
                        RecipeList[selectedIndex + 1] = null;
                    }
                    else
                        break;

                    selectedIndex++;
                }
            }
        }

        //edits recipe in the list
        public void EditItem(int selectedIndex, int numOfIngrediens, FoodCategory foodCategory, string recipeName, string description)
        {

            if (selectedIndex >= 0)
            {
                Recipe currentRecipe = new Recipe(numOfIngrediens)
                {
                    FoodCategory = foodCategory,
                    RecipeName = recipeName,
                    Description = description,
                    IngredientsArray = RecipeList[selectedIndex].IngredientsArray
                };

                Add(currentRecipe, selectedIndex);
            }


        }
    }
}
