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
	4.	Replace {groupid} with {{groupid}} variable
	5.	Save and Send
	6.	Select ALL in the return body window
7.	New Tab then GOTO https://json2csharp.com/
	1.	Paste the Body from the Group-Device request
	2.	Select Use Pascal Case
	3.	Select Add JsonProperty
	4.	Click Convert
	5.	Click Copy To Clipboard
	8.	Make a Device.cs file
		1.	VSCode >> new Text File
		2.	Select Language >> C#
		3.	Add “namespace Blank” and {}
		4.	Paste between {}
		5.	Change “public class Root” to ”public class Device”
	6.	Save as Device.cs
		1.	Remember where you saved it
