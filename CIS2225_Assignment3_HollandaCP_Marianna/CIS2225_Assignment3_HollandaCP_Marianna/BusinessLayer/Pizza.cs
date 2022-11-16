/*
 * Author: Marianna Hollanda Campos Pedroso
 * Date: October 21, 2021
 * Class: CIS-2225
 * Description: Assignment 3 - Pizza Class
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS2225_Assignment3_HollandaCP_Marianna.BusinessLayer
{
    public class Pizza
    {
        //Global variables
        private string size;
        private string sauceType;
        private List<string> ingredients;
        private double ingredientsCost = 0.75;
        private double cost = 0;

        //Global array to store the cost of each pizza size 
        double[] gCost = { 5, 8, 12 };

        //List of Ingredients
        public static string[] ingredientsList = {"Pepperoni", "Mushroom", "Sausage", "Onion", "Tomato", "Black Olives", "Garlic", "Green Pepper"};

        //Getters and Setters 
        public string Size { get => size; set => size = value; }
        public string SauceType { get => sauceType; set => sauceType = value; }
        public List<string> Ingredients { get => ingredients; set => ingredients = value; }
        public double IngredientsCost { get => ingredientsCost; set => ingredientsCost = value; }
        public double Cost { get => cost; set => cost = value; }

        public static List<Pizza> pizza = new List<Pizza>();

        //CalculateCost that calculates and set the cost 
        private double CalculateCost()
        {
            if (Size == "10\"")
            {
                Cost = gCost[0] + (Ingredients.Count * IngredientsCost);
            }
            if (Size == "12\"")
            {
                Cost = gCost[1] + (Ingredients.Count * IngredientsCost);
            }
            if (Size == "14\"")
            {
                Cost = gCost[2] + (Ingredients.Count * IngredientsCost);
            }
            return cost;
            
        }

        //CostTotal to calculate all the pizzas
        public static double CostTotal()
        {
            double totalCost = 0;
            if (pizza.Count <= 0)
            {
                return totalCost;
            }
            foreach (Pizza p in pizza)
            {
                totalCost += p.Cost;
            }
            return totalCost;
        }

        private String DisplayIngredients()
        {
            string display= " ";

            foreach (string i in Ingredients)
            {
                display += i + ", ";

            }
            return display;
    }

        //ToString method Overrided
        public override string ToString()
        {

            CalculateCost();

            return "\nYour Pizza Order: " +
                   "\n---------------------------" +
                   "\nSize: " + Size +
                   "\nSauce: " + SauceType +
                   "\nIngredients: " + DisplayIngredients() +
                   " " +
                   "\nCost: $" + Cost +
                   "\n-------------------------- - ";
        }
    }
}
