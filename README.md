# Outlook-Add-In-TaskPane-WebBrowser
This is an Outlook Add-in that will open a task pane and display a webpage in the Taskpane. You will have to change the URL in the class ThisAddIn

 
This was mainly developed using the Ribbon Visual Designer and tools in Visual Studio. I created a custom task pane and added a User Control per the documentation here : https://docs.microsoft.com/en-us/visualstudio/vsto/walkthrough-synchronizing-a-custom-task-pane-with-a-ribbon-button?view=vs-2017

I changed the RibbonType in the Ribbon to Outlook Explorer, since I wanted to see it in the main outlook display.

And I also added the web browser via the Visual Designer toolbox in the User Control Task Pane. 

You will need to change the labels/names in the ribbon, user control, button and in the customtaskpane.add function in the ThisAddIn Class to whatever fits your requirements.

That being said, please don't try modifying the code for the visual items. Utilize the Visual Designer to change the values otherwise there may be some issues deploying the Add-In.

If you have any problems with this example, feel free to open up an issue against this GitHub and I'll reach out to respond as quickly as possible. 

Note: This is not a Microsoft Supported Github Repository. 
