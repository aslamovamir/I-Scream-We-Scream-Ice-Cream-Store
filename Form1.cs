using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //let's store the initial storage amounts as static
        //cone types
        static int regular_cones = 50;
        static int sugar_cones = 25;
        static int waffle_cones = 10;

        //ice-cream types with initial amounts in ounces
        static int vanilla = 6400;
        static int chocolate = 2560;

        //toppings wit initial amounts in ounces
        static int chocolate_topping = 640;
        static int caramel_topping = 256;

        //sprinkles with initial amounts in ounces
        static int chocolate_sprinkles = 16;
        static int coloured_sprinkles = 16;
        static int marshmallows_sprinkles = 16;


        //a helper method to take one cone out of the storage amount to make an ice-cream cone
        public void Cones(string cone_type)
        {
            //let's check which type of cone was selected
            //then we respectively update the storage amount
            if (cone_type == "regular")
            {
                regular_cones--;
            }
            else if (cone_type == "sugar")
            {
                sugar_cones--;
            }
            else
            {
                waffle_cones--;
            }
        }


        //a helper method to take 8 ounces of ice-cream to make an ice-cream cone
        public void Ice_cream(string cream_type)
        {
            //let's check which type of ice-cream was selected
            //then we respectively update the storage amount
            if (cream_type == "vanilla")
            {
                vanilla -= 8;
            }
            else
            {
                chocolate -= 8;
            }
        }


        //a helper method to take 4 ounces of topping to make an ice-cream cone
        public void Topping(string topping_type)
        {
            //let's check which type of topping was selected
            //then we respectively update the storage amount
            if (topping_type == "chocolate")
            {
                chocolate_topping -= 4;
            }
            else
            {
                caramel_topping -= 4;
            }
        }


        //a helper method to take 2 ounces of sprinkles to make an ice-cream cone
        public void Sprinkles(string sprinkles_type)
        {
            //let's check which type of sprinkles was selected
            //then we respectively update the storage amount
            if (sprinkles_type == "chocolate chip")
            {
                chocolate_sprinkles -= 2;
            }
            else if (sprinkles_type == "colored")
            {
                coloured_sprinkles -= 2;
            }
            else
            {
                marshmallows_sprinkles -= 2;
            }
        }


        //helper function to validate the inputs
        public bool validate(string cone_type, string cream_type, string topping_type, string sprinkles_type)
        {

            //first let's check the cones
            if (cone_type.ToLower() == "regular")
            {
                //check if the left amount of the storage amount is less than 0
                if (regular_cones - 1 < 0)
                {
                    //if it is less than 0, we know we don't have anough cones to make the order
                    //we show a message box explaing the situation and cycle to another order
                    MessageBox.Show("Sorry, we have run out of REGULAR cones, this order is cancelled. Please make a new order...");
                    return false;
                }
            }
            else if (cone_type.ToLower() == "sugar")
            {
                //check if the left amount of the storage amount is less than 0
                if (sugar_cones - 1 < 0)
                {
                    //if it is less than 0, we know we don't have anough cones to make the order
                    //we show a message box explaing the situation and cycle to another order
                    MessageBox.Show("Sorry, we have run out of SUGAR cones, this order is cancelled. Please make a new order...");
                    return false;
                }
            }
            else if (cone_type.ToLower() == "waffle")
            {
                //check if the left amount of the storage amount is less than 0
                if (waffle_cones - 1 < 0)
                {
                    //if it is less than 0, we know we don't have anough cones to make the order
                    //we show a message box explaing the situation and cycle to another order
                    MessageBox.Show("Sorry, we have run out of WAFFLE cones, this order is cancelled. Please make a new order...");
                    return false;
                }
            }
            else
            {
                //show a message box indicating that there has been an invalid input by the user for the cones type
                MessageBox.Show("ERROR! Input for the CONES type is INVALID! Try again...");
                return false;
            }

            //now let's check the ice-cream type
            if (cream_type.ToLower() == "vanilla")
            {
                //check if the left amount of the storage amount is less than 0
                if (vanilla - 8 < 0)
                {
                    //if it is less than 0, we know we don't have anough ice-cream to make the order
                    //we show a message box explaing the situation and cycle to another order
                    MessageBox.Show("Sorry, we have run out of VANILLA ice-cream, this order is cancelled. Please make a new order...");
                    return false;
                }
            }
            else if (cream_type.ToLower() == "chocolate")
            {
                //check if the left amount of the storage amount is less than 0
                if (chocolate - 8 < 0)
                {
                    //if it is less than 0, we know we don't have anough ice-cream to make the order
                    //we show a message box explaing the situation and cycle to another order
                    MessageBox.Show("Sorry, we have run out of CHOCOLATE ice-cream, this order is cancelled. Please make a new order...");
                    return false;
                }
            }
            else
            {
                //show a message box indicating that there has been an invalid input by the user for the ice-cream type
                MessageBox.Show("ERROR! Input for the ICE-CREAM type is INVALID! Try again...");
                return false;
            }

            //now let's check the topping
            if (topping_type.ToLower() == "chocolate")
            {
                //check if the left amount of the storage amount is less than 0
                if (chocolate_topping - 4 < 0)
                {
                    //if it is less than 0, we know we don't have anough topping to make the order
                    //we show a message box explaing the situation and cycle to another order
                    MessageBox.Show("Sorry, we have run out of CHOCOLATE topping, this order is cancelled. Please make a new order...");
                    return false;
                }
            }
            else if (topping_type.ToLower() == "caramel")
            {
                //check if the left amount of the storage amount is less than 0
                if (caramel_topping - 4 < 0)
                {
                    //if it is less than 0, we know we don't have anough topping to make the order
                    //we show a message box explaing the situation and cycle to another order
                    MessageBox.Show("Sorry, we have run out of CARAMEL topping, this order is cancelled. Please make a new order...");
                    return false;
                }
            }
            else
            {
                //show a message box indicating that there has been an invalid input by the user for the topping type
                MessageBox.Show("ERROR! Input for the TOPPING type is INVALID! Try again...");
                return false;
            }

            //now let's check the sprinkles
            if (sprinkles_type.ToLower() == "chocolate chip")
            {
                //check if the left amount of the storage amount is less than 0
                if (chocolate_sprinkles - 2 < 0)
                {
                    //if it is less than 0, we know we don't have anough sprinkles to make the order
                    //we show a message box explaing the situation and cycle to another order
                    MessageBox.Show("Sorry, we have run out of CHOCOLATE CHIP sprinkles, this order is cancelled. Please make a new order...");
                    return false;
                }
            }
            else if (sprinkles_type.ToLower() == "colored")
            {
                //check if the left amount of the storage amount is less than 0
                if (coloured_sprinkles - 2 < 0)
                {
                    //if it is less than 0, we know we don't have anough sprinkles to make the order
                    //we show a message box explaing the situation and cycle to another order
                    MessageBox.Show("Sorry, we have run out of COLORED sprinkles, this order is cancelled. Please make a new order...");
                    return false;
                }
            }
            else if (sprinkles_type.ToLower() == "marshmallows")
            {
                //check if the left amount of the storage amount is less than 0
                if (marshmallows_sprinkles - 2 < 0)
                {
                    //if it is less than 0, we know we don't have anough sprinkles to make the order
                    //we show a message box explaing the situation and cycle to another order
                    MessageBox.Show("Sorry, we have run out of MARSHMALLOWS sprinkles, this order is cancelled. Please make a new order...");
                    return false;
                }
            }
            else
            {
                //show a message box indicating that there has been an invalid input by the user for the sprinkles type
                MessageBox.Show("ERROR! Input for the SPRINKLES type is INVALID! Try again...");
                return false;
            }

            return true;
        }


        //main method for the button to handle the event of making an ice-cream cone
        private void button1_Click(object sender, EventArgs e)
        {

            //now let's get the user inputs
            //we will declare them first
            string cone_type, cream_type, topping_type, sprinkles_type;

         
            //let's get the cone type selected by the user
            cone_type = Cones_TB.Text;

            //let's now get the ice-cream type selected by the user
            cream_type = Ice_Cream_TB.Text;

            //let's now get the topping type selected by the user
            topping_type = Toppings_TB.Text;

            //let's now get the sprinkles type selected by the user
            sprinkles_type = Sprinkles_TB.Text;

            //now let's validate the user input and see if we have enough of each ingredient to make the ice-cream cone
            bool success = validate(cone_type, cream_type, topping_type, sprinkles_type);

            //if the input for all the ingredients above are valid and we have enough storage amount to make the ice-cream cone,
            //we will show a message box confirming the order is successful and update the storage accordingly
            if (success)
            {
                MessageBox.Show("SUCCESS! Making the ice-cream cone!");
                Cones(cone_type);
                Ice_cream(cream_type);
                Topping(topping_type);
                Sprinkles(sprinkles_type);
            }
            //we empty the textboxes for the next order
            Cones_TB.Text = "";
            Ice_Cream_TB.Text = "";
            Toppings_TB.Text = "";
            Sprinkles_TB.Text = "";
        }


        //button event handler for the status report
        private void Status_BTN_Click(object sender, EventArgs e)
        {
            MessageBox.Show("RUGULAR cones: " + regular_cones + "\nSUGAR cones: " + sugar_cones + "\nWAFFLE cones: " + waffle_cones + 
                "\n\nVANILLA ice-cream: " + vanilla + "\nCHOCOLATE ice-cream: " + chocolate + "\n\nCHOCOLATE topping: " + chocolate_topping +
                "\nCARAMEL topping: " + caramel_topping + "\n\nCHOCOLATE CHIP sprinkles: " + chocolate_sprinkles + "\nCOLOURED sprinkles: " + 
                coloured_sprinkles + "\nMARSHMALLOWS: " + marshmallows_sprinkles);
        }

        //button event handler for the menu
        private void Menu_BTN_Click(object sender, EventArgs e)
        {
            //show the menu in a message box
            MessageBox.Show("CONES:\n   1. Regular\n   2. Sugar\n   3. Waffle\n\nICE-CREAM:\n   1. Vanilla\n   2. Chocolate\n\nTOPPING:\n " +
                "  1. Chocolate\n   2. Caramel\n\nSPRINKLES:\n   1. Chocolate Chip\n   2. Coloured\n   3. Marshmallows");
        }
    }
}
