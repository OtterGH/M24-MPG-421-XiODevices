GOTO postman.com or OPEN Postman
	Add Workspace = XiO-API
	Add Authorization
		Type = API Key
		Key = XiO-subscription-key
			Value = [ get this value from the XiO admin or Account Settings]
	Add Variable
		Variable = accountid
			Initial Value = [get this value from the XiO admin or Account Settings ]
	Add Request
		Name = Account-Groups
		URL =  copy from https://sdkcon78221.crestron.com/sdk/Crestron_XiO_Cloud_SDK/Content/Topics/API-Reference.htm#AccountGroups
			Replace {accountid} with ({accountid}} variable
	Save and Send
	Locate Your Room and Copy the “id” value
	Locate Your Room and Copy the “id” value – if you have not
	GOTO XiO-API >> Variables
		Add Variable
		Variable = groupid
			Initial Value = paste “id” value you copied
	Add Request
		Name = Group-Devices
		URL =  copy from https://sdkcon78221.crestron.com/sdk/Crestron_XiO_Cloud_SDK/Content/Topics/API-Reference.htm#GroupDevices
	Replace {accountid} with {{accountid}} variable
	Replace {groupid} with {{groupid}} variable
	Save and Send
	Select ALL in the return body window

New Tab then GOTO https://json2csharp.com/
	Paste the Body from the Group-Device request
	Select Use Pascal Case
	Select Add JsonProperty
	Click Convert
	Click Copy To Clipboard
	Make a Device.cs file
		VSCode >> new Text File
		Select Language >> C#
	Add “namespace Blank” and {}
	Paste between {}
	Change “public class Root” to ”public class Device”
	Save as Device.cs
	Remember where you saved it
![image](https://github.com/OtterGH/M24-MPG-421-XiODevices/assets/156679703/1d278855-d43c-45ca-a992-93b8de5c098e)
