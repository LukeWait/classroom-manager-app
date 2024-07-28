# Classroom Manager App
## Description
A Windows Forms application for managing classroom data with a focus on dataGridView manipulation.

<p align="center">
  <img src="https://github.com/LukeWait/classroom-manager-app/raw/main/ClassroomManager/images/classroom-manager-screenshot.png" alt="App Screenshot" width="600">
</p>

## Table of Contents
- [Installation](#installation)
- [Usage](#usage)
- [Development](#development)
- [License](#license)
- [Acknowledgments](#acknowledgments)
- [Source Code](#source-code)
- [Dependencies](#dependencies)

## Installation
This app is designed for Windows only. It leverages the .NET 5 framework, which ensures modern, efficient, and secure runtime behavior. Requirements include:
- **Executable:** The .NET 5 runtime must be installed on the user's system.
- **From Source:** Development tools including the .NET 5 SDK and Visual Studio 2019 (v16.8+) or later versions are necessary.

### Executable
1. Download the latest release from the [releases page](https://github.com/LukeWait/classroom-manager-app/releases).
2. Extract the contents to a desired location.
3. Navigate to the `bin` directory.
4. Run the `ClassroomManager.exe` file.

### From Source
To install and run the application from source:
1. Clone the repository:
    ```sh
    git clone https://github.com/LukeWait/classroom-manager-app.git
    cd classroom-manager-app
    ```
2. Open the solution file `ClassroomManager.sln` in Visual Studio.
3. Restore NuGet packages if prompted.
4. Build or run the solution using Visual Studio.

## Usage
1. Launch the application by running the `ClassroomManager.exe` or from source.
2. Open a valid CSV using the `File` menu (refer to the example CSV file `classroom_data_template.csv` for the expected format when loading data into the dataGridView.)
3. Use the GUI to manipulate the CSV file using the dataGridView interface.

### Application Functions
- **Load Data**: Load classroom data from CSV files into a dataGridView.
- **Edit Data**: Use the dataGridView interface to add, edit, or delete data.
  - Update Teacher, Class, Room, and Date fields.
  - Add/remove students manually.
  - Clear all student names.
  - Sort alphabetically and display a list of student names.
  - Find and highlight a student using an input field.
- **Save Data**: Save the modified data back to CSV files.
  - Save changes/save as a new file.
  - Export as a binary file using random access file (RAF) techniques.

## Development
This project was developed using Visual Studio and utilizes Windows Forms. For the best experience with Windows Forms projects that involve extensive use of the Form Designer, it is recommended to use Visual Studio as it will be the most reliable and feature-complete IDE option.
If you are exploring alternatives and willing to handle some design tasks manually or switch between IDEs, JetBrains Rider on Windows could be a viable option, but it might not offer the same level of designer support as Visual Studio.

### Project Structure
```sh
classroom-manager-app/
├── ClassroomManager/
│   ├── images/                             # GUI design elements
│   ├── Properties/                         # Project properties
│   ├── Cell.cs                             # Class representing a classroom/dataGridView cell 
│   ├── ClassroomManager.csproj             # Project file
│   ├── ClassroomManager.xml                # XML documentation for classes and methods
│   ├── Form1.cs                            # Main form code
│   ├── Form1.Designer.cs                   # Main form designer code
│   ├── Form1.resx                          # Main form resources
│   └── Program.cs                          # Main program entry point
├── classroom_data_template.csv             # Example CSV file used to load into dataGridView
└── ClassroomManager.sln                    # Visual Studio Solution file
```

### Data Storage
The application manages data by accessing a properly formatted CSV file, such as `classroom_data_template.csv`. The first four rows must contain the headings and relevant data for Teacher, Class, Room, and Date. Subsequent rows represent individual cells in the dataGridView, with columns structured as follows:


<table>
  <tr>
    <th style="border-right:1px solid black">Column 1</th>
    <th style="border-right:1px solid black">Column 2</th>
    <th style="border-right:1px solid black">Column 3</th>
    <th>Column 4</th>
  </tr>
  <tr>
    <td style="border-right:1px solid black">Teacher:</td>
    <td style="border-right:1px solid black">[Relevant Teacher Name]</td>
    <td style="border-right:1px solid black"></td>
    <td></td>
  </tr>
  <tr>
    <td style="border-right:1px solid black">Class:</td>
    <td style="border-right:1px solid black">[Relevant Class Name]</td>
    <td style="border-right:1px solid black"></td>
    <td></td>
  </tr>
  <tr>
    <td style="border-right:1px solid black">Room:</td>
    <td style="border-right:1px solid black">[Relevant Room Number]</td>
    <td style="border-right:1px solid black"></td>
    <td></td>
  </tr>
  <tr>
    <td style="border-right:1px solid black">Date:</td>
    <td style="border-right:1px solid black">[Relevant Date]</td>
    <td style="border-right:1px solid black"></td>
    <td></td>
  </tr>
  <tr>
    <td style="border-right:1px solid black">Column coordinate of the cell</td>
    <td style="border-right:1px solid black">Row coordinate of the cell</td>
    <td style="border-right:1px solid black">Cell content (e.g., student name<br> or `BKGRND FILL` for a<br> background-filled cell)</td>
    <td>Cell color (applicable only if<br> `BKGRND FILL` is specified<br> in column 3)</td>
  </tr>
</table>

### Creating New Releases
- **Build the Application**: Use Visual Studio to compile and package the application into an executable (.exe) file. Ensure that all dependencies and necessary files are included in the build process.
  - Open the solution file (`ClassroomManager.sln`) in Visual Studio.
  - Restore any NuGet packages if prompted.
  - Build the solution by selecting `Build` > `Build Solution` from the menu.
  - Locate the compiled `.exe` file in the `bin/Release` or `bin/Debug` directory, depending on your build configuration.

- **Include CSV File**: Ensure that the `classroom_data_template.csv` file is included with the release. This file serves as a template for users to format their classroom data correctly.


## License
This project is licensed under the MIT License. See the LICENSE file for details.

## Acknowledgments
This project was developed as part of an assignment at TAFE Queensland for subject ICTPRG443.

Project requirements and initial GUI design/codebase provided by Hans Telford.

## Source Code
The source code for this project can be found in the GitHub repository: [https://github.com/LukeWait/classroom-manager-app](https://www.github.com/LukeWait/classroom-manager-app).

## Dependencies
- Windows 10 or later
- [.NET 5.0](https://dotnet.microsoft.com/download/dotnet/5.0)
- [Visual Studio 2019 (v16.8+)](https://visualstudio.microsoft.com/vs/) or [Visual Studio 2022](https://visualstudio.microsoft.com/vs/)
