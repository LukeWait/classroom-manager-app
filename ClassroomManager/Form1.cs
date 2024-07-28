/**************************************************************************************
File name: Form1.cs
Purpose:   1. Create GUI From application
           2. Provide user-interaction (buttons, textboxes, menuitems)
           3. Read classroom.csv data from external file (when user selects File - Open)
              User prompted to select filepath
           4. Display classroom data in text boxes and data grid after read
           5. Change student names in data grid
           6. Remove all student names from data grid with Clear button
           7. Save cell and classroom data to opened external file (File - Save/Save Changes button)
           8. Save cell and classroom data to new external file (File Save As)
              User prompted to select filepath
           9. Sort all student names and display as student list pop up with Sort button
           10. Search (by student name) for student location in data grid using binary search
               and display student list pop up with student highlighted with Find button
           11. Save to Random Access File with Save RAF button
           12. Exit the application with Exit button or File - Close
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
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ClassroomManager
{

    public partial class Form1 : Form
    { 
        // public constants
        /// <summary>
        /// Constant representing total rows in dataGridView
        /// </summary>
        public const int TOTAL_ROWS = 19;
        /// <summary>
        /// Constant representing total columns in dataGridView
        /// </summary>
        public const int TOTAL_COLS = 10;
        // cellList of cell data stored in classroom csv
        private List<Cell> cellList;
        // nameList of student names stored in classroom csv
        private List<Cell> nameList;
        // file path of currently open csv file
        private string currentFilePath;


        /****************************************************************************
        Method:     Form1()
        Purpose:    Constructs GUI components
                    Initialises private data
        Input:      void
        Output:     Constructor method/no return value
        ****************************************************************************/
        /// <summary>
        /// Form1() method
        /// </summary>
        public Form1()
        {
            // Visual Studio GUI setup
            InitializeComponent();

            // instantiate the private variables
            cellList = new List<Cell>();
            nameList = new List<Cell>();


            /************************DATAGRIDVIEW**************************************/
            // construct the dataGrid rows          
            dataGridView.Rows.Add(TOTAL_ROWS - 1);
            // set appropriate row header width
            dataGridView.RowHeadersWidth = 50;
            // set up row header numbers stating with 0
            for (int count = 0; count < dataGridView.Rows.Count; count++)
            {
                dataGridView.Rows[count].HeaderCell.Value = string.Format((count).ToString(), "0");
            }
            // set up font style and size for the data grid view
            dataGridView.DefaultCellStyle.Font = new Font("Arial", 10);

        }// end constructor method




        /************************METHODS*******************************************/

        /************************MANIPULATING DATA*********************************/

        /****************************************************************************
        Method:     ReadCSVData()
        Purpose:    Reads classroom csv
                    Adds second column of first 4 rows to classDetails array
                    Creates instance of Cell class for every line after row 4, 
                    and adds instance to cellList
        Input:      void
        Output:     void
        ****************************************************************************/
        /// <summary>
        /// ReadCSVData() method
        /// </summary>
        public void ReadCSVData()
        {
            try
            {
                // if file exists
                if (File.Exists(currentFilePath))
                {
                    // Read file line by line using StreamReader
                    using (StreamReader file = new StreamReader(currentFilePath))
                    {
                        string line;
                        // lineCount to process first four lines in csv
                        int lineCount = 0;

                        while ((line = file.ReadLine()) != null)
                        {

                            // first four lines of csv stored in classDetails array
                            lineCount++;
                            if (lineCount < 5)
                            {
                                // split the line into a string array
                                string[] classData = line.Split(',');
                                // add to relevant text box based on lineCount
                                switch (lineCount)
                                {
                                    case 1:
                                        teacherTextBox.Text = classData[1];
                                        break;
                                    case 2:
                                        classTextBox.Text = classData[1];
                                        break;
                                    case 3:
                                        roomTextBox.Text = classData[1];
                                        break;
                                    case 4:
                                        dateTextBox.Text = classData[1];
                                        break;
                                }
                                // return to start of while loop
                                continue;
                            }

                            // split the line into a string array
                            string[] lineArray = line.Split(',');
                            // assign array values to string vars
                            int col = Int32.Parse(lineArray[0]);
                            int row = Int32.Parse(lineArray[1]);
                            string name = lineArray[2];
                            string colour = "NA";
                            if (name.Equals("BKGRND FILL"))
                            {
                                colour = lineArray[3];
                            }
                            // create Cell instance
                            Cell cell = new Cell(col, row, name, colour);
                            // add instance to cellList
                            cellList.Add(cell);

                        }
                        // close the reader
                        file.Close();                      

                    }// end using StreamReader file
                }
                // display in pop-up that file does not exist
                else
                {
                    MessageBox.Show("ERROR: No external file exists for: " + currentFilePath, "ERROR!");
                }
            }
            // display exceptions as pop-up messages
            catch (IOException ioe)
            {
                MessageBox.Show("ERROR: Problem in reading the external file: " + currentFilePath + "\r\n"
                    + ioe.Message, "ERROR!");
            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR: Problem with external file: " + currentFilePath + "\r\n"
                    + e.Message, "ERROR!");
            }

        }// end ReadCSVData()


        /****************************************************************************
        Method:     DisplayDataGrid()
        Purpose:    Displays cellList data in data grid
        Input:      void
        Output:     void
        ****************************************************************************/
        /// <summary>
        /// DisplayDataGrid() method
        /// </summary>
        public void DisplayDataGrid()
        {
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            style.BackColor = Color.BurlyWood;
            style.ForeColor = Color.Black;

            // go through every instance of cell in cellList
            for (int i = 0; i < cellList.Count; i++)
            {
                // if name is BKGRND FILL, set colour
                if (cellList[i].Name.Equals("BKGRND FILL"))
                {      
                    // code to read in backcolor from csv
                    // style.BackColor = System.Drawing.Color.FromName(cellList[i].Colour);

                    dataGridView.Rows[cellList[i].Row].Cells[cellList[i].Col].Style = style;
                }
                // otherwise display name
                else
                {
                    dataGridView.Rows[cellList[i].Row].Cells[cellList[i].Col].Value = cellList[i].Name;
                }
            }

        }// end DisplayDataGrid()


        /****************************************************************************
        Method:     UpdateLists()
        Purpose:    Clears the cellList and nameList
                    Removes background colour from highlighted student cell
                    Re-populates Lists from dataGridView
        Input:      void
        Output:     void
        ****************************************************************************/
        /// <summary>
        /// UpdateLists() method
        /// </summary>
        public void UpdateLists()
        {
            // clear the nameList and cellList
            cellList.Clear();
            nameList.Clear();

            // loop through the entire dataGridView to get all relevant data
            for (int row = 0; row < TOTAL_ROWS; row++)
            {
                for (int col = 0; col < TOTAL_COLS; col++)
                {
                    // if user has changed the value of Front Desk, revert back
                    if (row == 0 && col == 4)
                    {
                        dataGridView.Rows[row].Cells[col].Value = "Front Desk";
                    }

                    // if the background is highlighted, change back to empty
                    if (dataGridView.Rows[row].Cells[col].Style.BackColor == Color.LightCoral)
                    {
                        dataGridView.Rows[row].Cells[col].Style.BackColor = Color.Empty;
                    }

                    // if the contents of the dataGridView cell is not empty or null
                    if (!String.IsNullOrEmpty((string)dataGridView.Rows[row].Cells[col].Value))
                    {
                        // create a new cell instance, add to the string builder and cellList
                        Cell cell = new Cell(col, row, (string)dataGridView.Rows[row].Cells[col].Value, "NA");
                        cellList.Add(cell);

                        // if contents of the dataGridView cell is not "Front Desk"
                        if (!dataGridView.Rows[row].Cells[col].Value.Equals("Front Desk"))
                        {
                            // add to the nameList
                            nameList.Add(cell);
                        }
                    // if the dataGridView has a colour assigned (is a desk)
                    }
                    else if (dataGridView.Rows[row].Cells[col].Style.BackColor != Color.Empty)
                    {
                        // convert the background color to a string
                        string background = dataGridView.Rows[row].Cells[col].Style.BackColor.ToString();
                        int startIndex = background.IndexOf("[") + 1;
                        int lengthOf = (background.Length - 1) - startIndex;

                        // create a new cell instance, add to the string builder and cellList
                        Cell cell = new Cell(col, row, "BKGRND FILL", background.Substring(startIndex, lengthOf));
                        cellList.Add(cell);
                    }
                }
            }

        }// end UpdateLists()


        /****************************************************************************
        Method:     ClearData()
        Purpose:    Removes all but the background fill and front desk cells from
                    the dataGridView
                    Clears out the nameList and cellList
        Input:      void
        Output:     void
        ****************************************************************************/
        /// <summary>
        /// ClearData() method
        /// </summary>
        public void ClearData()
        {
            // clear out the nameList and cellList
            nameList.Clear();
            cellList.Clear();

            // loop through the entire dataGridView
            for (int row = 0; row < TOTAL_ROWS; row++)
            {
                for (int col = 0; col < TOTAL_COLS; col++)
                {
                    // if user has changed the value of Front Desk, revert back
                    if (row == 0 && col == 4)
                    {
                        dataGridView.Rows[row].Cells[col].Value = "Front Desk";
                    }

                    // if the contents of the dataGridView cell is not empty or null
                    // and doesn't contain "Front Desk"
                    if (!String.IsNullOrEmpty((string)dataGridView.Rows[row].Cells[col].Value) &&
                        !dataGridView.Rows[row].Cells[col].Value.Equals("Front Desk"))
                    {
                        // remove from the dataGridView
                        dataGridView.Rows[row].Cells[col].Value = "";

                        // remove highlighted student background colour
                        dataGridView.Rows[row].Cells[col].Style.BackColor = Color.Empty;
                    }
                }
            }
            
        }// end clearNames()


        /************************SEARCHING AND SORTING*****************************/

        /****************************************************************************
        Method:     DisplayStudentList()
        Purpose:    Displays nameList in pop-up with row and col data
        Input:      void
        Output:     void
        ****************************************************************************/
        /// <summary>
        /// DisplayStudentList() method
        /// </summary>
        public void DisplayStudentList()
        {
            // construct string to display information in pop-up
            string studentList = "Student\t\tRow\tCol\n" +
                                    "--------------------------------------------\n";

            // go through each name in the nameList
            for (int i = 0; i < nameList.Count; i++)
            {
                // add name row and col data to the display string
                studentList += nameList[i].ToString() + "\n";
            }

            // display studentList in pop-up
            MessageBox.Show(studentList, "Student List");

        }// end DisplayStudentList()


        /****************************************************************************
        Method:     DisplayStudentList()
        Purpose:    Displays nameList in pop-up with row and col data
                    Highlights student based on index passed in from binary search
        Input:      string student (name of student searched by user)
                    int index (found index returned from binary search)
        Output:     void
        ****************************************************************************/
        /// <summary>
        /// parameterised DisplayStudentList()
        /// </summary>
        /// <param name="student">Name of student searched by user</param>
        /// <param name="index">found index returned from binary search</param>
        public void DisplayStudentList(string student, int index)
        {
            // contruct string to display information in pop-up
            string studentList = "Student\t\tRow\tCol\n" +
                                    "--------------------------------------------\n";

            // go through each name in the nameList
            for (int i = 0; i < nameList.Count; i++)
            {
                studentList += nameList[i].ToString();

                // if nameList index matches index passed in from binary search
                if (i == index)
                {
                    studentList += "\t<- FOUND";

                    // prevent changing background color of a desk
                    if (dataGridView.Rows[nameList[i].Row].Cells[nameList[i].Col].Style.BackColor != Color.BurlyWood)
                    {
                        // highlight student in data grid
                        DataGridViewCellStyle style = new DataGridViewCellStyle();
                        style.BackColor = Color.LightCoral;
                        dataGridView.Rows[nameList[i].Row].Cells[nameList[i].Col].Style = style;
                    }
                }
                studentList += "\n";
            }

            // display studentList in pop-up with highlighted student
            MessageBox.Show(studentList, "Student List - Search: " + student);

        }// end DisplayStudentList()


        /****************************************************************************
        Method:     BinarySearch()
        Purpose:    Overridden BinarySearch() method       
        Input:      void
        Output:     void
        ****************************************************************************/
        /// <summary>
        /// BinarySearch() method
        /// </summary>
        /// <param name="studentName">Student to compare</param>
        /// <returns>Index of found student</returns>
        public int BinarySearch(string studentName)
        {
            int foundIndex = -1;
            int firstIndex = 0;
            int lastIndex = nameList.Count - 1;

            while (firstIndex <= lastIndex)
            {
                int midIndex = (firstIndex + lastIndex) / 2;
                string studentToCompare = nameList[midIndex].Name;

                if (studentToCompare.CompareTo(studentName) == 0)
                {
                    foundIndex = midIndex;
                    break;
                }
                else if (studentToCompare.CompareTo(studentName) > 0)
                {
                    lastIndex = midIndex - 1;
                }
                else
                {
                    firstIndex = midIndex + 1;
                }
            }

            return foundIndex;

        }// end BinarySearch


        /************************SAVING TO EXTERNAL FILE***************************/

        /****************************************************************************
        Method:     IsSaveValid()
        Purpose:    Performs validation checks on classroom details textboxes
                    If validation passes, updates classDetails array
        Input:      void
        Output:     bool (must pass all validation checks to be true)
        ****************************************************************************/
        /// <summary>
        /// IsSaveValid() method
        /// </summary>
        /// <returns>bool indicating whether all validation checks have passed</returns>
        public bool IsSaveValid()
        {
            // return validate, changes to false is any checks fail
            bool saveValidity = true;
            // string for accumulated error msg
            string errorMessage = "ERROR(S) encountered\n";

            // check if filepath exists
            if (String.IsNullOrEmpty(currentFilePath))
            {
                errorMessage += "No data loaded\n";
                saveValidity = false;
            }
            else
            {
                // check teacher
                if (String.IsNullOrEmpty(teacherTextBox.Text))
                {
                    errorMessage += "Teacher is required\n";
                    saveValidity = false;
                }
                // check class
                if (String.IsNullOrEmpty(classTextBox.Text))
                {
                    errorMessage += "Class is required\n";
                    saveValidity = false;
                }
                // check room
                if (String.IsNullOrEmpty(roomTextBox.Text))
                {
                    errorMessage += "Room is required\n";
                    saveValidity = false;
                }
                // check date
                if (String.IsNullOrEmpty(dateTextBox.Text))
                {
                    errorMessage += "Date is required\n";
                    saveValidity = false;
                }
            }

            // display error message if errors encountered
            if (saveValidity == false)
            {
                MessageBox.Show(errorMessage, "ERRORS!");
            }

            // return false if any errors encountered
            return saveValidity;

        }// end IsSaveValid()


        /****************************************************************************
        Method:     SaveToExternalFile()
        Purpose:    Constructs string to write with GetFileContent()
                    Writes the string to external file        
        Input:      void
        Output:     void
        ****************************************************************************/
        /// <summary>
        /// SaveToExternalFile() method
        /// </summary>
        public void SaveToExternalFile()
        {
            // retrieve formatted string for writing to external file
            string fileContent = GetFileContent();

            try
            {
                File.WriteAllText(currentFilePath, fileContent);
                MessageBox.Show("Class data saved to " + currentFilePath, "FILE SAVE SUCCESSFUL!");
            }
            catch (Exception exc)
            {
                MessageBox.Show("Could not save data to " + currentFilePath, "FILE SAVE FAILED!");
                Console.WriteLine(exc.StackTrace);
            }

        }// end SaveToExternalFile()
        
        
        /****************************************************************************
        Method:     GetFileContent()
        Purpose:    Builds string from classDetails and cell data
        Input:      void
        Output:     fileContent string for writing all data to external file
        ****************************************************************************/
        /// <summary>
        /// GetFileContent() method
        /// </summary>
        /// <returns>fileContent string for writing all data to external file</returns>
        public string GetFileContent()
        {
            // update the Lists
            UpdateLists();

            StringBuilder sb = new StringBuilder();
            // add classroom textboxes data to string builder
            sb.AppendLine("Teacher:," + teacherTextBox.Text);
            sb.AppendLine("Class:," + classTextBox.Text);
            sb.AppendLine("Room:," + roomTextBox.Text);
            sb.AppendLine("Date:," + dateTextBox.Text);

            for (int i = 0; i < cellList.Count; i++)
            {
                sb.AppendLine(cellList[i].ToCSVString());
            }

            // convert string builder contents to string to return
            string fileContent = sb.ToString();

            return fileContent;

        }// end GetFileContent()   


        /****************************************************************************
        Method:     ExitForm()
        Purpose:    Exits the form application
        Input:      void
        Output:     void
        ****************************************************************************/
        /// <summary>
        /// ExitForm() method
        /// </summary>
        public void ExitForm()
        {
            // exit the application
            if (System.Windows.Forms.Application.MessageLoop)
            {
                // WinForms app
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                // Console app
                System.Environment.Exit(1);
            }

        }// end ExitForm()



        /************************EVENT HANDLERS************************************/

        /************************BUTTONS*******************************************/

        /****************************************************************************
        Method:     clearButton_Click() event handler
        Purpose:    Calls the ClearData() method to remove all student names
                    from the dataGridView and clear out the Lists
        Input:      object sender (the button instance)
                    EventArgs e (event generated data)
        Output:     void
        ****************************************************************************/
        private void clearButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(currentFilePath))
            {
                ClearData();
            }

        }// end clearButton event


        /****************************************************************************
        Method:     saveChangesButton_Click() event handler
        Purpose:    Calls IsSaveValid() to validate fields before continuing
                    Saves changes made to csv (overwrites) at currentFilePath by
                    calling SaveToExternalFile()
        Input:      object sender (the button instance)
                    EventArgs e (event generated data)
        Output:     void
        ****************************************************************************/
        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            if (IsSaveValid())
            {
                SaveToExternalFile();
            }

        }// end saveChangesButton event


        /****************************************************************************
        Method:     sortButton_Click() event handler
        Purpose:    Checks for students in nameList
                    Calls UpdateLists() to refresh Lists from dataGridView
                    Sorts the nameList
                    Displays student list by calling DisplayStudentList()
        Input:      object sender (the button instance)
                    EventArgs e (event generated data)
        Output:     void
        ****************************************************************************/
        private void sortButton_Click(object sender, EventArgs e)
        {
            // call method to update the nameList from dataGridView and sort
            UpdateLists();

            // sort the nameList
            nameList.Sort();

            if (nameList.Count > 0)
            {
                // display student list in pop up
                DisplayStudentList();
            }
            else
            {
                MessageBox.Show("No students in memory!", "Student List");
            }

        }// end sortButton event


        /****************************************************************************
        Method:     findButton_Click() event handler
        Purpose:    Checks that student name has been input
                    Calls UpdateLists() to refresh Lists from dataGridView
                    Sorts the nameList
                    Displays highlighted student in student list pop-up and dataGridView
                    by calling parameterised DisplayStudentList()
        Input:      object sender (the button instance)
                    EventArgs e (event generated data)
        Output:     void
        ****************************************************************************/
        private void findButton_Click(object sender, EventArgs e)
        {
            // string of the search item (student name)
            string studentToSearch = searchTextBox.Text;

            // check if the search text box is not empty
            if (String.IsNullOrEmpty(studentToSearch))
            {
                MessageBox.Show("Student name is required in the search field", "ERROR!");
                return;
            }
            else
            {
                // call method to update the nameList from dataGridView and sort
                UpdateLists();

                // sort the nameList
                nameList.Sort();

                if (nameList.Count > 0)
                {
                    // use BinarySearch to return index value if record exists
                    int foundIndex = BinarySearch(studentToSearch);

                    if (foundIndex >= 0)
                    {
                        // display student list in pop up with highlighted student
                        // also highlight student in dataGridView
                        DisplayStudentList(studentToSearch, foundIndex);
                    }
                    else
                    {
                        MessageBox.Show(studentToSearch + " NOT found!", "NOT FOUND");
                    }
                }
                else
                {
                    MessageBox.Show("No students in memory!", "Student List");
                }
            }

        }// end findButton event


        /****************************************************************************
        Method:     saveRAFButton_Click() event handler
        Purpose:    RAF (random access file) writing to external binary file
                    you need string fileName and string dataToWrite assigned variables
        Input:      object sender (the button instance)
                    EventArgs e (event generated data)
        Output:     void
        ****************************************************************************/
        private void saveRAFButton_Click(object sender, EventArgs e)
        {
            string fileName = "RandomAccessFile.dat";

            try
            {
                // FileStream object 
                // sets up file stream with target file name usually in .bin or .dat format
                // FileMode.Append means putting the stream in append mode
                // to write content which is added to any pre-existing content)
                // FileMode.Create means over-writing the existing content 
                // in the binary data file
                FileStream fstream = new FileStream(fileName, FileMode.Create, FileAccess.Write);

                // create a binary writer object
                BinaryWriter bwStream = new BinaryWriter(fstream);
                // set file position where to write data
                //fstream.Position = pos * size;
                // write data
                bwStream.Write(GetFileContent());
                // close objects
                bwStream.Close();
                fstream.Close();
                MessageBox.Show("Data successfully written to random access file " + fileName, "SUCCESS - Random Access File written!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: Data NOT written to random access file " + fileName, "ERROR - Problem in writing to random access file");
                Console.WriteLine(ex.StackTrace);
            }

        }// end saveRAFButton event


        /****************************************************************************
        Method:     exitButton_Click() event handler
        Purpose:    Exits the application by calling ExitForm()
        Input:      object sender (the button instance)
                    EventArgs e (event generated data)
        Output:     void
        ****************************************************************************/
        private void exitButton_Click(object sender, EventArgs e)
        {
            ExitForm();

        }// end exitButton event


        /************************MENU ITEMS****************************************/

        /****************************************************************************
        Method:     openToolStripMenuItem_Click() event handler
        Purpose:    Opens explorer window for user to navigate to desired file
                    When a file is opened, sets the file path to currentFilePath
                    Clears out the Lists and dataGridView with ClearData()
                    Reads in the csv data with ReadCSVData()
                    Displays read in class details with DisplayClassDetails()
                    Displays read in cell data with DisplayDataGrid()
        Input:      object sender (the button instance)
                    EventArgs e (event generated data)
        Output:     void
        ****************************************************************************/
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";
            // filters for file types that can be opened by application
            openFileDialog.Filter = "All files(*.*) | *.*| txt files(*.txt)| *.txt| " +
                                    "csv files(*.csv)| *.csv| dat files(*.dat)| *.dat";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                currentFilePath = openFileDialog.FileName;

                // clear the Lists and dataGridView
                ClearData();

                // external file operations
                ReadCSVData();

                // display cellList in data grid
                DisplayDataGrid();
            }
      
        }// end openMenuItem event


        /****************************************************************************
        Method:     saveToolStripMenuItem_Click() event handler
        Purpose:    Calls IsSaveValid() to validate fields before continuing
                    Saves changes made to csv (overwrites) at currentFilePath by
                    calling SaveToExternalFile()
        Input:      object sender (the button instance)
                    EventArgs e (event generated data)
        Output:     void
        ****************************************************************************/
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IsSaveValid())
            {
                SaveToExternalFile();
            }

        }// end saveMenuItem event


        /****************************************************************************
        Method:     saveAsToolStripMenuItem_Click() event handler
        Purpose:    Calls IsSaveValid() to validate fields before continuing
                    Opens explorer window for user to navigate to desired filepath
                    Takes user input and sets as currentFilePath
                    Calls SaveToExternalFile() to save to new external file
        Input:      object sender (the button instance)
                    EventArgs e (event generated data)
        Output:     void
        ****************************************************************************/
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IsSaveValid())
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                // Simplify object initialization
                saveFileDialog.InitialDirectory = "c:\\";
                saveFileDialog.Filter = "All files (*.*)|*.*| txt files (*.txt)|*.txt";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the path of specified file
                    currentFilePath = saveFileDialog.FileName;

                    SaveToExternalFile();
                }
            }

        }// end saveAsMenuItem event


        /****************************************************************************
        Method:     closeToolStripMenuItem_Click() event handler
        Purpose:    Exits the application by calling ExitForm()
        Input:      object sender (the button instance)
                    EventArgs e (event generated data)
        Output:     void
        ****************************************************************************/
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExitForm();

        }// end closeMenuItem event

    }// end Form1()
}