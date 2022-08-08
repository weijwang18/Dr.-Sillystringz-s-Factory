# Dr. Sillystringz's Factory

#### By _**Winnie Wang**_  

#### _An MVC application to help Dr. Sillystringz keep track of their machine repairs._  

---

## Technologies Used

* _C#_
* _.NET_
* _HTML_
* _CSS_
* _SQL Workbench_
* _Entity Framework_
* _MVC_

---
## Description

_This is an MVC application that was built using C#. The purpose of this application is to help Dr. Sillystringz keep track of their machine repairs. When the application runs, the factory manager should be able to add a list of engineers, a list of machines, and specify which engineers are licensed to repair which machines. An engineer can be licensed to repair (belong to) many machines (such as the Drqmweaver, the Bubblewrappinator, and the Laughbox) and a machine can have many engineers licensed to repair it._

---
## Setup and Installation Requirements
**This Setup assumes you have GitBash and MySQL Workbench pre-installed.   
If needed, please navigate to these links:  
https://git-scm.com/download/  
Download Git and follow the setup wizard.  
https://dev.mysql.com/downloads/workbench/  
Download MySQL Workbench, follow the setup wizard & create a localhost server on port 3306**


*Note: Keep track of your username and password, this will be used in the connection link under,*  
"**SQL Workbench Configuration**" > "2. Insert the following code:"


<details>
<summary><strong>Initial Setup</strong></summary>
<ol>
<li>Copy the git repository url: https://github.com/weijwang18/Dr.-Sillystringz-s-Factory
<li>Open a terminal and navigate to your Desktop with <strong>cd</strong> command
<li>Run,   
<strong>$ git clone https://github.com/weijwang18/Dr.-Sillystringz-s-Factory</strong>
<li>In the terminal, navigate into the root directory of the cloned project folder "Dr.-Sillystringz-s-Factory".
<li>Navigate to the projects root directory, "Factory".
<li>Move onto "SQL Workbench Configuration" instructions below to build the necessary database.
<br>
</details>

<details>
<summary><strong>SQL Workbench Configuration</strong></summary>
<ol>
<li>Create an appsetting.json file in the "Factory" directory  
   <pre>Dr.-Sillystringz-s-Factory
   └── Factory
    └── appsetting.json</pre>
<li> Insert the following code: <br>

<pre>{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=winnie_wang;uid=[YOUR-USERNAME-HERE];pwd=[YOUR-PASSWORD-HERE];"
  }
}</pre>
<small>*Note: you must include your password in the code block section labeled "YOUR-PASSWORD-HERE".</small><br>
<small>**Note: you must include your username in the code block section labeled "YOUR-USERNAME-HERE".</small><br>
<small>***Note: if you plan to push this cloned project to a public-facing repository, remember to add the appsettings.json file to your .gitignore before doing so.</small>
<li>In root directory of project folder "Factory", run  
<strong>$ dotnet ef migrations add restoreDatabase</strong>
<li>Then run <strong>$ dotnet ef database update</strong>
<ol> 
  <li>Open SQL Workbench.
  <li>Navigate to "winnie_wang" schema.
  <li>Click the drop down, select "Tables" drop down.
  <li>Verify the tables.
  
</details>
<details>
<summary><strong>To Run</strong></summary>
Navigate to:  
   <pre>Dr.-Sillystringz-s-Factory
   └── <strong>Factory</strong></pre>
Run ```$ dotnet restore``` in the terminal.<br>
Run ```$ dotnet run``` in the terminal.
</details>
<br>
This program was built using *`Microsoft .NET SDK 5.0.401`*, and may not be compatible with other versions. Your milage may vary.

---

## License

MIT


Copyright (c) 8/2022 Winnie Wang
## Contact Information
_If you have any questions or concerns, please feel free to reach out to me [via email at: Winnie](mailto:weijwang18@gmail.com) or request to make a contribution. Thank you!_ 


**A Big Thanks To:**
**Garrett Hays @ https://github.com/GarrettHays**    
**Zachary Waggoner @ https://github.com/CyndaZ42**  
**for amazing README formatting and instructions!**