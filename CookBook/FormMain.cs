//FormMain.cs
//Created: 2020-10-22 by Andrius Sukys
//Updated: 2020-10-30 by Andrius Sukys


using System;
using System.Windows.Forms;

namespace CookBook
{
    //Manage recipes
    public partial class FormMain : Form
    {
        private const int numberOfIngrediens = 50;
        private const int maxNumOfElements = 200;
        Recipe currentRecipe = new Recipe(numberOfIngrediens);
        readonly ManageRecipes recipeManager = new ManageRecipes(maxNumOfElements);


        public FormMain()
        {
            InitializeComponent();
            InitializeGUI();
        }

        //Initialize GUI with default empty values values
        public void InitializeGUI()
        {
            textBoxNameOfRecipe.Text = string.Empty;
            comboBoxCategory.SelectedIndex = 0;
            textBoxRecipe.Text = string.Empty;
            listBoxRecipes.Text = string.Empty;
        }


        //Check if input is valid
        private bool CheckInput()
        {
            bool ok = false;
            bool nameOfRecipe = ReadInputNameOfRecipe();
            bool descriptionOfRecipe = ReadInputDescriptionOfRecipe();
            if (nameOfRecipe && descriptionOfRecipe)
                ok = true;
            return ok;
        }

        //Asks user to add name of the recipe if the field is left empty
        private bool ReadInputNameOfRecipe()
        {
            bool ok = true;
            string NameOfRecipe = textBoxNameOfRecipe.Text;
            NameOfRecipe = NameOfRecipe.Trim();

            if (NameOfRecipe == string.Empty)
            {
                MessageBox.Show("Add name of the recipe", "Error");
                ok = false;
            }
            return ok;
        }

        //Asks user to add description of the recipe if the field is left empty
        private bool ReadInputDescriptionOfRecipe()
        {
            bool ok = true;
            string DescriptionOfRecipe = textBoxRecipe.Text;
            DescriptionOfRecipe = DescriptionOfRecipe.Trim();

            if (DescriptionOfRecipe == string.Empty)
            {
                MessageBox.Show("Add description of the recipe", "Error");
                ok = false;
            }
            return ok;
        }

        //Allows user to add new recipe
        private void ButtonAddRecipe_Click(object sender, EventArgs e)
        {
            if (!CheckInput())
                return;

            currentRecipe.FoodCategory = (FoodCategory)comboBoxCategory.SelectedIndex;
            currentRecipe.RecipeName = textBoxNameOfRecipe.Text.Trim();
            currentRecipe.Description = textBoxRecipe.Text.Trim();

            recipeManager.Add(currentRecipe);
            ShowAllRecipes();
            currentRecipe = new Recipe(numberOfIngrediens);
            currentRecipe.DefaultValues();
            InitializeGUI();
        }

        //Print out all stored recipes
        private void ShowAllRecipes()
        {
            int numberOfItems = recipeManager.CurrentNumberOfItems();

            listBoxRecipes.Items.Clear();
            for (int i = 0; i < numberOfItems; i++)
            {
                listBoxRecipes.Items.Add(recipeManager.GetRecipeAt(i).ToString());
            }
        }

        //Open new window to add ingredients to recipe
        private void ButtonAddIngrediens_Click(object sender, EventArgs e)
        {
            FormIngrediens dlg = new FormIngrediens(currentRecipe, numberOfIngrediens);

            int selectedIndex = listBoxRecipes.SelectedIndex;

            if (selectedIndex >= 0)
            {
                Recipe editingRecipe = recipeManager.GetRecipeAt(selectedIndex);
                dlg.ShowIngredients(editingRecipe);
            }

            _ = dlg.ShowDialog();
            ShowAllRecipes();
        }


        //Show recipe details
        private void ListBoxRecipes_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = listBoxRecipes.SelectedIndex;
            
            if (selectedIndex != -1)
            {
                textBoxNameOfRecipe.Text = recipeManager.GetRecipeAt(selectedIndex).RecipeName;
                textBoxRecipe.Text = recipeManager.GetRecipeAt(selectedIndex).Description;
                comboBoxCategory.SelectedIndex = (int)recipeManager.GetRecipeAt(selectedIndex).FoodCategory;
            }
        }

        //Change recipe with edit button
        //Edit button allows user to edit recipe
        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            if (!CheckInput())
                return;
            int selectedIndex = listBoxRecipes.SelectedIndex;
            if (selectedIndex != -1)
            {
                FoodCategory foodCategory = (FoodCategory)comboBoxCategory.SelectedIndex;
                string recipeName = textBoxNameOfRecipe.Text.Trim();
                string description = textBoxRecipe.Text.Trim();

                recipeManager.EditItem(selectedIndex, numberOfIngrediens, foodCategory, recipeName, description);
                ShowAllRecipes();
                InitializeGUI();
            }
        }

        //Lets user to delete recipe
        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBoxRecipes.SelectedIndex;

            if (selectedIndex != -1)
            {
                recipeManager.DeleteItem(selectedIndex, maxNumOfElements);
                ShowAllRecipes();
                InitializeGUI();
            }
        }

        //Lets user to unselect selected recipe
        private void ButtonUnselect_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBoxRecipes.SelectedIndex;

            if (selectedIndex != -1)
            {
                listBoxRecipes.ClearSelected();
                textBoxNameOfRecipe.Text = string.Empty;
                textBoxRecipe.Clear();
            }
        }


    }
}
