# wpf-samples

## Microsoft Windows Presentation Foundation (WPF) App with Microsoft Edge WebView2




Microsoft Windows Presentation Foundation (WPF) is a framework to build graphical interfaces / applications for Microsoft Windows Platform. 

With Microsoft Edge WebView2, we can bring the web capabilities to WPF applications and build a hybrid app.

This sample demonstrates integrating Dyte Meeting running on Microsoft Edge WebView2, inside a WPF application.


##Steps to build & run this application:

Minimum Requirements:
- Operating System: Windows 7 and above
- Runtime: .NET Framework 6.0
- Runtime: Microsoft Edge WebView 2
- For WPF App: Visual Studio 2022 [Community Edition will do]
- For Web App: Visual Studio Core or Visual Studio 2022 [Community Edition will do]

###Step 1: Clone the repository:

This repository has 2 projects:
- solution-webapp: A web app with Dyte Meeting components
- solution-wpfapp: A WPF app embedding webapp

###Step 2: Start Dyte Meeting:

Using Dyte REST APIs, create a meeting and add participant to it. More details available here:
Once you call these APIs, you'll have:

roomName (Example:
authToken (Example: 


###Step 3: Run Web App

Use Visual Studio Code with Live Server or Visual Studio and run the Web App. 

Format the URL like:

http://127.0.0.1:5500/index.html?roomName=[roomname]&authToken=[authtoken]

###Step 4: Run WPF App

Use Visual Studio to open WPF app. In that project edit `ExamWindow.xaml` with values for `host`, `url`, `roomName` and `authToken`. 

Run the WPF app while making sure that Web App is running. 

###Step 5: Start / Stop Recording

Use Dyte REST APIs to start/stop recording and observe the events passed from Web App to WPF app. 

![](/img/wpf-app-screenshot.png)

##Support
If you need any help with the sample, create an issue in this repository or reach out to us on: [https://community.dyte.io](https://community.dyte.io "Dyte Community")