Follow the steps below to prepare for opening the solution.


1.	GOTO postman.com or OPEN Postman
2.	Add Workspace = XiO-API
	1.	Add Authorization
		1.	Type = API Key
		2.	Key = XiO-subscription-key
		3.	Value = [ get this value from the XiO admin or Account Settings]
		4.	Add Variable
			1.	Variable = accountid
			2.	Initial Value = [get this value from the XiO admin or Account Settings ]
		5.	Add Request
			1.	Name = Account-Groups
			2.	URL =  copy from https://sdkcon78221.crestron.com/sdk/Crestron_XiO_Cloud_SDK/Content/Topics/API-Reference.htm#AccountGroups
			3.	Replace {accountid} with ({accountid}} variable
			4.	Save and Send
			6.	Locate Your Room and Copy the “id” value
3.	Locate Your Room and Copy the “id” value – if you have not
4.	GOTO XiO-API >> Variables
5.	Add Variable
	1.	Variable = groupid
	2.	Initial Value = paste “id” value you copied
6.	Add Request
	1.	Name = Group-Devices
	2.	URL =  copy from https://sdkcon78221.crestron.com/sdk/Crestron_XiO_Cloud_SDK/Content/Topics/API-Reference.htm#GroupDevices
	3.	Replace {accountid} with {{accountid}} variable
	4.	Replace {{groupid}} with {{groupid}} variable
	5.	Save and Send
	6.	Select ALL in the return body window
7.	New Tab then GOTO https://app.quicktype.io/
	1.	Paste the Body from the Group-Device request into JSON field
	2.	Change Name to "Device"
	3.	Set Generateed namespace to "XiODevice"
	4.	Click Copy Code
	5.	OPEN SOLUTION XiODevices.sn (https://github.com/OtterGH/M24-MPG-421-XiODevices/)
		1.	VS2022/2019 >> New >> File >> C# Class
		2.	Set the Class Name to "Device"
		3.	Cntl + A >> delete/backspace
		4.	Paste
		5.	Change “public partial class...” to ”public class...”
  		6.	Move Usings out of namespace and Save
