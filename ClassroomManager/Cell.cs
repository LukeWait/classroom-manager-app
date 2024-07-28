/**************************************************************************************
File name: Cell.cs
Description: Represents a classroom cell, encapsulating cell data with public methods, 
             supporting comparisons and string representations, and enabling CSV formatting.
Version: 1.0.0
Author: ┬  ┬ ┬┬┌─┌─┐┬ ┬┌─┐╦╔╦╗
        │  │ │├┴┐├┤ │││├─┤║ ║
        ┴─┘└─┘┴ ┴└─┘└┴┘┴ ┴╩ ╩
Date: November 05, 2022
License: MIT License

Dependencies:
.NET 5.0
Visual Studio 2019 (v16.8+)/Visual Studio 2022

GitHub Repository: https://github.com/LukeWait/classroom-manager-app
**************************************************************************************/
using System;

namespace ClassroomManager
{

    /// <summary>
    /// Cell class
    /// Purpose:    Provide class template for cell data
    /// Implements: IComparable interface and CompareTo() method
    /// </summary>
    /// <remarks>Luke Wait
    ///          30.10.22
    ///          Version 1.0</remarks>
    class Cell : IComparable<Cell>
    {
        // private variables with public get and set methods
        /// <summary>
        /// Public property: Col (column of the cell)
        /// </summary>
        public int Col { get; set; }
        /// <summary>
        /// Public property: Row (row of the cell)
        /// </summary>
        public int Row { get; set; }
        /// <summary>
        /// Public property: Name (name of the cell)
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Public property: Colour (colour of the cell)
        /// </summary>
        public string Colour { get; set; }


        /****************************************************************************
        Method:     Cell() --- contructor method with inputs
        Purpose:    Creates a new cell instance
        Input:      int col    --- column of the cell
                    int row    --- row of the cell
                    string name   --- name of the cell
                    string colour --- colour of the cell
        Output:     Constructor method/no return type
        ****************************************************************************/
        /// <summary>
        /// Constructor method
        /// </summary>
        /// <param name="col">Column of the cell</param>
        /// <param name="row">Row of the cell</param>
        /// <param name="name">Name of the cell</param>
        /// <param name="colour">Colour of the cell</param>
        public Cell(int col, int row, string name, string colour)
        {
            Col = col;
            Row = row;
            Name = name;
            Colour = colour;
        }// end Cell() constructor


        /****************************************************************************
        Method:     ToString()
        Purpose:    Compiles a formatted string from the Cell instance data
        Input:      void
        Output:     Formatted string for display
        ****************************************************************************/
        /// <summary>
        /// Overridden ToString() method
        /// </summary>
        /// <returns>Formatted string for display</returns>
        public override string ToString()
        {
            string cellString = Name + "\t\t" + Row + "\t" + Col;

            return cellString;

        }// end ToString()


        /****************************************************************************
        Method:     ToCSVString()
        Purpose:    Compiles a string with appropriate instance data and formatting
                    to be written to an external classroom csv
        Input:      void
        Output:     CSV formatted string for writing to a classroom csv
        ****************************************************************************/
        /// <summary>
        /// ToCSVString() method
        /// </summary>
        /// <returns>CSV formatted string for writing to a classroom csv</returns>
        public string ToCSVString()
        {
            return Col + "," + Row + "," + Name + "," + Colour;

        } // end ToCSVString()


        /****************************************************************************
        Method:     CompareTo()
        Purpose:    Compares the business of the Recycler instance with the business of another
                    Used for sorting instances (with Sort() method)
                    Implemented method from IComparable interface
        Input:      Recycler object (other instance being compared)
        Output:     int
                    Returns 0 if both student names are equal
                    Returns -1 if this.Name is alphabetically less than other.Name
                    Returns 1 if this.Name is alphabetically greater than other.Name
        ****************************************************************************/
        /// <summary>
        /// Implemented CompareTo() method
        /// </summary>
        /// <param name="other">Cell object (other instance being compared)</param>
        /// <returns>Returns 0 if both student names are equal,
        ///          Returns -1 if this.Name is alphabetically less than other.Name,
        ///          Returns 1 if this.Name is alphabetically greater than other.Name</returns>
        public int CompareTo(Cell other)
        {
            return this.Name.CompareTo(other.Name);

        }// end CompareTo()
    }
}
