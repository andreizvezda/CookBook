//FormIngredients.cs
//Created: 2020-10-22 by Andrius Sukys
//Updated: 2020-10-30 by Andrius Sukys


using System;
using System.Windows.Forms;

namespace CookBook
{
    //class to add ingredients to the recipe
    public partial class FormIngrediens : Form
    {
        private Recipe m_recipe;
        private string[] ingredientsArray;


        public FormIngrediens(Recipe recipe, int maxNumOfIngredients)
        {
            InitializeComponent();
            m_recipe = recipe;
            ingredientsArray = new string[maxNumOfIngredients];
            DefaultValues();
            InitializeGUI();
        }

        //set inside ingredientsArray empty strings
        public void DefaultValues()
        {
            for (int i = 0; i < ingredientsArray.Length; i++)
                ingredientsArray[i] = string.Empty;
        }

        //Will return first empty position in the ingrediensArray
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

        //Saves ingredient to the ingrediensArray as long as there is space in the array
        public bool AddIngredient(string ingredient)
        {
            bool ok = true;
            int emptyIndex = FindVacantPosition();
            if (emptyIndex >= 0)
                ingredientsArray[emptyIndex] = ingredient;
            else
            {
                MessageBox.Show("Ingrediens's memory is full", "Error");
                ok = false;
            }

            return ok;
        }


        //Initialize GUI and default values
        public void InitializeGUI()
        {
            if (m_recipe.IngredientsArray == null)
                m_recipe.IngredientsArray = new string[m_recipe.MaxNumOfIngrediens];

            labelNo.Text = m_recipe.GetCurrentNumOfIngrediens().ToString();
            textBoxPutIngredient.Text = string.Empty;
        }

        //Verify if user entered the ingredients
        private bool ReadInputIngrediens()
        {
            bool ok = true;
            if (textBoxPutIngredient.Text.Trim() == string.Empty)
            {
                MessageBox.Show("You didn't add any ingrediens", "Error");
                ok = false;
            }
            return ok;
        }

        //When user press "Add" button, it will add ingrediens to the list of ingrediens
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (ReadInputIngrediens())
            {
                string ingredient = textBoxPutIngredient.Text.Trim();
                listBoxListOfIngrediens.Items.Add(ingredient);
                textBoxPutIngredient.Clear();
                AddIngredient(ingredient);
                m_recipe.IngredientsArray = ingredientsArray;
                labelNo.Text = m_recipe.GetCurrentNumOfIngrediens().ToString();
            }
        }

        //Show all ingredients
        public void ShowIngredients(Recipe recipe)
        {
            m_recipe = recipe;
            ingredientsArray = m_recipe.IngredientsArray;
            for (int i = 0; i < ingredientsArray.Length; i++)
                if (ingredientsArray[i] != string.Empty)
                    listBoxListOfIngrediens.Items.Add(ingredientsArray[i]);
            labelNo.Text = m_recipe.GetCurrentNumOfIngrediens().ToString();

        }


        //after user presses "Delete" button ingredient will be deleted 
        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBoxListOfIngrediens.SelectedIndex;

            if (selectedIndex != -1)
            {
                ingredientsArray[selectedIndex] = string.Empty;

                while (selectedIndex < ingredientsArray.Length)
                {
                    if (selectedIndex + 1 < ingredientsArray.Length && ingredientsArray[selectedIndex + 1] != string.Empty)
                    {
                        ingredientsArray[selectedIndex] = ingredientsArray[selectedIndex + 1];
                        ingredientsArray[selectedIndex + 1] = string.Empty;
                    }
                    else
                        break;

                    selectedIndex++;
                }

                m_recipe.IngredientsArray = ingredientsArray;
                PrintIngredients();
                InitializeGUI();
            }
        }

        //Show ingredients in the array
        public void PrintIngredients()
        {
            listBoxListOfIngrediens.Items.Clear();
            for (int i = 0; i < ingredientsArray.Length; i++)
                if (ingredientsArray[i] != string.Empty)
                    listBoxListOfIngrediens.Items.Add(ingredientsArray[i]);
        }

        //after user presses "Edit" button ingredient will be edited 
        private void ButtonEdit_Click(object sender, EventArgs e)
        {

            int selectedIndex = listBoxListOfIngrediens.SelectedIndex;

            if (selectedIndex != -1)
            {
                ingredientsArray[selectedIndex] = textBoxPutIngredient.Text;
                m_recipe.IngredientsArray = ingredientsArray;
                textBoxPutIngredient.Text = string.Empty;
                PrintIngredients();
            }

        }

        //after clicking on the ListBox with recipes, the details will be shown in the input fields
        private void ListBoxListOfIngrediens_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = listBoxListOfIngrediens.SelectedIndex;

            if (selectedIndex != -1)
            {
                textBoxPutIngredient.Text = ingredientsArray[selectedIndex];
            }

        }

        ////Unselect the current ingredients
        private void ButtonUnselect_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBoxListOfIngrediens.SelectedIndex;

            if (selectedIndex != -1)
            {
                listBoxListOfIngrediens.ClearSelected();
                textBoxPutIngredient.Text = string.Empty;
            }
        }
    }
}
