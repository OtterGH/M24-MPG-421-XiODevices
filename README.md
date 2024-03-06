Follow the steps below to prepare for opening the solution.


1.	GOTO postman.com or OPEN Postman
2.	Add Workspace = XiO-API
	1.	Add Authorization
		1.	Select the Type dropdown to "API Key"
		2.	Fill in the Key: Key = "XiO-subscription-key"
		3.	Fill in the Value: Value = "[ get this value from the XiO admin or Account Settings]"
		4.	Add Variable
			1.	Name Variable = "accountid"
			2.	Initial Value = "[get this value from the XiO admin or Account Settings ]"
		5.	Add Request
			1.	Name the Request "Account-Groups"
			2.	Paste this into the URL https://api.crestron.io/api/v1/group/accountid/{accountid}/groups
   			3.	Save
   			4.	Replace {accountid} with ({accountid}}
			5.	Save and Send
			6.	Locate Your Room and Copy the “id” value
3.	Locate Your Room and Copy the “id” value – if you have not
4.	GOTO XiO-API >> Variables
5.	Add Variable
	1.	Name Variable = "groupid"
	2.	Fill the Value by pasting the “id” value you copied
6.	Add Request
	1.	Name the Request "Group-Devices"
	2.	Paste this into the URL https://api.crestron.io/api/v1/group/accountid/{accountid}/groupid/{groupid}/devices
 	3.	Save
	4.	Replace {accountid} with {{accountid}} variable
	5.	Replace {{groupid}} with {{groupid}} variable
	6.	Save and Send
	7.	Select ALL in the return body window
7.	New Tab then GOTO https://app.quicktype.io/
	1.	Paste the Body from the Group-Device request into JSON field
	2.	Change Name to "Device"
 	3.	Select "C#" as the Language
	4.	Set Generateed namespace to "XiODevices"
 	5.	Select Attributes Only	
	6.	Click Copy Code
	7.	OPEN SOLUTION XiODevices.sn (https://github.com/OtterGH/M24-MPG-421-XiODevices/)
		1.	VS2022/2019 >> New >> File >> C# Class
		2.	Name the class "Device.cs"
		3.	Cntl + A >> delete/backspace
		4.	Paste
		5.	Change “public partial class...” to ”public class...”
  		6.	Move Usings out of namespace to the top of the file and Save
TIME TO CODE
