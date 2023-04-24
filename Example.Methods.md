# OPC UA Methods

- [GetAvailableSecondaryPrintheads](#GetAvailableSecondaryPrintheads)
- [StoreMessage](#StoreMessage)
- [GetEventsFile](#GetEventsFile)
- [SetConfiguration](#SetConfiguration)
- [UploadFile](#UploadFile)
- [DownloadFile](#DownloadFile)
- [EnableLocalNotification](#EnableLocalNotification)
- [GetPrimaryIdentifier](#GetPrimaryIdentifier)
- [GetPrinterConfiguration](#GetPrinterConfiguration)
- [StopPrinting](#StopPrinting)
- [GetProductDetectStatus](#GetProductDetectStatus)
- [PrintPreviewCurrentHash](#PrintPreviewCurrentHash)
- [PrintPreviewCurrentCompressed](#PrintPreviewCurrentCompressed)
- [GetDateTime](#GetDateTime)
- [GetUpdateFiles](#GetUpdateFiles)
- [GetWifiNetworkConfiguration](#GetWifiNetworkConfiguration)
- [GetFontFile](#GetFontFile)
- [DeleteMessageFolder](#DeleteMessageFolder)
- [PrintPreview](#PrintPreview)
- [GetCustomCodes](#GetCustomCodes)
- [SetNotificationURL](#SetNotificationURL)
- [PathRecallMessage](#PathRecallMessage)
- [GetAvailableWifiNetworks](#GetAvailableWifiNetworks)
- [ConnectToWifiNetwork](#ConnectToWifiNetwork)
- [PrintPreviewCurrent](#PrintPreviewCurrent)
- [CancelPrinting](#CancelPrinting)
- [SendFile](#SendFile)
- [SetCustomCodes](#SetCustomCodes)
- [PathPrintPreviewCompressed](#PathPrintPreviewCompressed)
- [RecallMessage](#RecallMessage)
- [CompareFile](#CompareFile)
- [SetDateTime](#SetDateTime)
- [CreateMessageFolder](#CreateMessageFolder)
- [GetDiagnostics](#GetDiagnostics)
- [GetMessageVariableData](#GetMessageVariableData)
- [PathStoreMessage](#PathStoreMessage)
- [SetMessageVariableData](#SetMessageVariableData)
- [PrintStoredMessage](#PrintStoredMessage)
- [GetPrintHeadConfiguration](#GetPrintHeadConfiguration)
- [DeleteFile](#DeleteFile)
- [PrintPrd](#PrintPrd)
- [SetEthernetNetworkConfiguration](#SetEthernetNetworkConfiguration)
- [GetEthernetNetworkConfiguration](#GetEthernetNetworkConfiguration)
- [ResumePrinting](#ResumePrinting)
- [ResetTotalCount](#ResetTotalCount)
- [SendEventsFile](#SendEventsFile)
- [RenamePrinter](#RenamePrinter)
- [SetWifiNetworkConfiguration](#SetWifiNetworkConfiguration)
- [GetConfiguration](#GetConfiguration)
- [PathGetMessageFolders](#PathGetMessageFolders)
- [PathPrintPreviewHash](#PathPrintPreviewHash)
- [GetAccessPassword](#GetAccessPassword)
- [SetPrintHeadConfiguration](#SetPrintHeadConfiguration)
- [DoUSBUnmount](#DoUSBUnmount)
- [GetStoredMessageList](#GetStoredMessageList)
- [DoFirmwareUpdate](#DoFirmwareUpdate)
- [SetMessageCount](#SetMessageCount)
- [PathPrintStoredMessage](#PathPrintStoredMessage)
- [GetFileHash](#GetFileHash)
- [GetStatusInformation](#GetStatusInformation)
- [PathGetStoredMessageList](#PathGetStoredMessageList)
- [IdentifyPrinter](#IdentifyPrinter)
- [GetBroadcastingSsid](#GetBroadcastingSsid)
- [GetFirmwareUpdateProgress](#GetFirmwareUpdateProgress)
- [GetFilesAndFolders](#GetFilesAndFolders)
- [PathPrintPreview](#PathPrintPreview)
- [SetAccessPassword](#SetAccessPassword)
- [CreateFolder](#CreateFolder)
- [GetFileByName](#GetFileByName)
- [GetPrintheadConsumeables](#GetPrintheadConsumeables)

# Methods

## <a id='GetAvailableSecondaryPrintheads'></a>GetAvailableSecondaryPrintheads
List of available clone printheads that are seen by primary printhead

### Input Arguments
| Name | Description | Type |
|------|-------------|------|

### Output Arguments
| Name | Description | Type |
|------|-------------|------|
| Available Clones | List of clone pr | s=String |
| Error | If fa | s=String |

---
## <a id='StoreMessage'></a>StoreMessage
Stores a message in prd format on controller

### Input Arguments
| Name | Description | Type |
|------|-------------|------|
| The message name | prd Name | s=String |
| The message to store | prd format | s=String |

### Output Arguments
| Name | Description | Type |
|------|-------------|------|
| Error | Error | s=String |

---
## <a id='GetEventsFile'></a>GetEventsFile
Get the events config file to control automated ACS

### Input Arguments
| Name | Description | Type |
|------|-------------|------|

### Output Arguments
| Name | Description | Type |
|------|-------------|------|
| FileContents | File content | s=String |
| Error | Error | s=String |

---
## <a id='SetConfiguration'></a>SetConfiguration
Command to set the printer configuration

### Input Arguments
| Name | Description | Type |
|------|-------------|------|
| Configuration | config to set | s=String |

### Output Arguments
| Name | Description | Type |
|------|-------------|------|
| Error | Error | s=String |

---
## <a id='UploadFile'></a>UploadFile
Uploads the file specified

### Input Arguments
| Name | Description | Type |
|------|-------------|------|
| Path | File Path | s=String |
| FileName | File Name | s=String |
| Data | File data | s=String |

### Output Arguments
| Name | Description | Type |
|------|-------------|------|
| ReturnCode | Return cod | s=UInt32 |

---
## <a id='DownloadFile'></a>DownloadFile
Downloads the file specified

### Input Arguments
| Name | Description | Type |
|------|-------------|------|
| Path | File Path | s=String |
| FileName | File Name | s=String |

### Output Arguments
| Name | Description | Type |
|------|-------------|------|
| ReturnCode | Return cod | s=UInt32 |
| Data | File | s=String |

---
## <a id='EnableLocalNotification'></a>EnableLocalNotification
Enable sending local notification on specified port

### Input Arguments
| Name | Description | Type |
|------|-------------|------|
| Enable | True or False | s=Boolean |
| Port | Local UDP port to listen on | s=UInt16 |

### Output Arguments
| Name | Description | Type |
|------|-------------|------|
| Error | Error | s=String |

---
## <a id='GetPrimaryIdentifier'></a>GetPrimaryIdentifier
Gets the identifier of the primary print head

### Input Arguments
| Name | Description | Type |
|------|-------------|------|

### Output Arguments
| Name | Description | Type |
|------|-------------|------|
| Error | Error | s=String |
| PrinterId | Identifie | s=String |

---
## <a id='GetPrinterConfiguration'></a>GetPrinterConfiguration
Gets printer configuration details

### Input Arguments
| Name | Description | Type |
|------|-------------|------|
| Task number | 1 or 2 | s=Int32 |

### Output Arguments
| Name | Description | Type |
|------|-------------|------|
| Result | Comman | s=String |
| Error | Error | s=String |
| Configurations | List of config | s=String |
| Hardware Version | Hardware Version | s=String |
| Software Version | Software version | s=String |
| Model | Model | s=String |
| Serial Number | Serial Number | s=String |

---
## <a id='StopPrinting'></a>StopPrinting
Commands the printer to pause printing

### Input Arguments
| Name | Description | Type |
|------|-------------|------|
| Task number | 1 or 2 | s=Int32 |

### Output Arguments
| Name | Description | Type |
|------|-------------|------|
| Error | Error | s=String |

---
## <a id='GetProductDetectStatus'></a>GetProductDetectStatus
Returns the current status of the product detect

### Input Arguments
| Name | Description | Type |
|------|-------------|------|

### Output Arguments
| Name | Description | Type |
|------|-------------|------|
| Product Detected | True indicates a | s=Boolean |

---
## <a id='PrintPreviewCurrentHash'></a>PrintPreviewCurrentHash
Gets current message preview's hash key

### Input Arguments
| Name | Description | Type |
|------|-------------|------|
| Task number | 1 or 2 | s=Int32 |

### Output Arguments
| Name | Description | Type |
|------|-------------|------|
| Error | Error | s=String |
| task name | string | s=String |
| hash key | string | s=String |

---
## <a id='PrintPreviewCurrentCompressed'></a>PrintPreviewCurrentCompressed
Gets current message preview as bitmaps

### Input Arguments
| Name | Description | Type |
|------|-------------|------|
| Task number | 1 or 2 | s=Int32 |

### Output Arguments
| Name | Description | Type |
|------|-------------|------|
| Error | Error | s=String |
| Decompressed size | Size of image dat | s=String |
| Image | Image | i=0 |

---
## <a id='GetDateTime'></a>GetDateTime
Gets Current system date time

### Input Arguments
| Name | Description | Type |
|------|-------------|------|

### Output Arguments
| Name | Description | Type |
|------|-------------|------|
| ReturnCode | Return cod | s=UInt32 |
| Current Date Time | Date time in form | s=String |

---
## <a id='GetUpdateFiles'></a>GetUpdateFiles
Returns a list of upgrade files on a USB drive

### Input Arguments
| Name | Description | Type |
|------|-------------|------|

### Output Arguments
| Name | Description | Type |
|------|-------------|------|
| ReturnCode | Return cod | s=UInt32 |
| Error | Error | s=String |
| Files | List  | s=String |

---
## <a id='GetWifiNetworkConfiguration'></a>GetWifiNetworkConfiguration
Gets network configuration information for wireless interface

### Input Arguments
| Name | Description | Type |
|------|-------------|------|

### Output Arguments
| Name | Description | Type |
|------|-------------|------|
| Current SSID | The SSID I a | s=String |
| MAC Address | My MAC Addr | s=String |
| DHCP On | Whether | s=Boolean |
| IP Address | My IP addr | s=String |
| Subnet Mask | My subnet m | s=String |
| Gateway | My gate | s=String |
| ReturnCode | Return cod | s=UInt32 |

---
## <a id='GetFontFile'></a>GetFontFile
Gets the file associated with the specified font

### Input Arguments
| Name | Description | Type |
|------|-------------|------|
| FontFamily | Font Family | s=String |
| FontStyle | Font Style | s=String |

### Output Arguments
| Name | Description | Type |
|------|-------------|------|
| FileName | File nam | s=String |
| Data | File | s=String |
| ReturnCode | Return cod | s=UInt32 |

---
## <a id='DeleteMessageFolder'></a>DeleteMessageFolder
Deletes a message folder

### Input Arguments
| Name | Description | Type |
|------|-------------|------|
| FolderName | Folder name to be deleted | s=String |

### Output Arguments
| Name | Description | Type |
|------|-------------|------|
| Error | Error | s=UInt32 |

---
## <a id='PrintPreview'></a>PrintPreview
Gets message preview as bitmaps

### Input Arguments
| Name | Description | Type |
|------|-------------|------|
| prd xml data | the prd data to preview | s=String |
| Task number | 1 or 2 | s=Int32 |

### Output Arguments
| Name | Description | Type |
|------|-------------|------|
| Error | Error | s=String |
| Preview image list | list of base64 enc | s=String |

---
## <a id='GetCustomCodes'></a>GetCustomCodes
Get the serialized shift code info from NextJet

### Input Arguments
| Name | Description | Type |
|------|-------------|------|

### Output Arguments
| Name | Description | Type |
|------|-------------|------|
| Data | Seri | s=String |
| ReturnCode | Return cod | s=UInt32 |

---
## <a id='SetNotificationURL'></a>SetNotificationURL
Receive notifications over UDP at this URL

### Input Arguments
| Name | Description | Type |
|------|-------------|------|
| URL | format must be udp://ipaddress:port | s=String |

### Output Arguments
| Name | Description | Type |
|------|-------------|------|
| Error | Error | s=String |

---
## <a id='PathRecallMessage'></a>PathRecallMessage
Returns the message stored in the path and filename

### Input Arguments
| Name | Description | Type |
|------|-------------|------|
| FolderName | Folder path | s=String |
| Filename | File name | s=String |

### Output Arguments
| Name | Description | Type |
|------|-------------|------|
| ReturnCode | Return cod | s=UInt32 |
| Msg | Mes | s=String |

---
## <a id='GetAvailableWifiNetworks'></a>GetAvailableWifiNetworks
Gets available WiFi networks

### Input Arguments
| Name | Description | Type |
|------|-------------|------|

### Output Arguments
| Name | Description | Type |
|------|-------------|------|
| Networks | New line | s=String |
| ReturnCode | Return cod | s=UInt32 |

---
## <a id='ConnectToWifiNetwork'></a>ConnectToWifiNetwork
Sets network configuration

### Input Arguments
| Name | Description | Type |
|------|-------------|------|
| SSID | The SSID to connect to | s=String |
| Password | Pre Shared Key (PSK) for the network | s=String |

### Output Arguments
| Name | Description | Type |
|------|-------------|------|
| ReturnCode | Return cod | s=UInt32 |

---
## <a id='PrintPreviewCurrent'></a>PrintPreviewCurrent
Gets current message preview as bitmaps

### Input Arguments
| Name | Description | Type |
|------|-------------|------|
| Task number | 1 or 2 | s=Int32 |

### Output Arguments
| Name | Description | Type |
|------|-------------|------|
| Error | Error | s=String |
| Preview image list | list of base64 enc | s=String |

---
## <a id='CancelPrinting'></a>CancelPrinting
Commands the printer to cancel printing

### Input Arguments
| Name | Description | Type |
|------|-------------|------|
| Task number | 1 or 2 | s=Int32 |

### Output Arguments
| Name | Description | Type |
|------|-------------|------|
| Error | Error | s=String |

---
## <a id='SendFile'></a>SendFile
Sends File

### Input Arguments
| Name | Description | Type |
|------|-------------|------|
| FileName | File Name | s=String |
| File | File | s=String |

### Output Arguments
| Name | Description | Type |
|------|-------------|------|
| Error | Error | s=String |

---
## <a id='SetCustomCodes'></a>SetCustomCodes
Set the shift code info

### Input Arguments
| Name | Description | Type |
|------|-------------|------|
| Data | Serialized shift code data from Next Jet | s=String |

### Output Arguments
| Name | Description | Type |
|------|-------------|------|
| ReturnCode | Return cod | s=UInt32 |

---
## <a id='PathPrintPreviewCompressed'></a>PathPrintPreviewCompressed
Gets message preview as bitmaps

### Input Arguments
| Name | Description | Type |
|------|-------------|------|
| FolderName | Folder name | s=String |
| Msg | Message | s=String |
| Task number | 1 or 2 | s=UInt32 |

### Output Arguments
| Name | Description | Type |
|------|-------------|------|
| ReturnCode | Return cod | s=UInt32 |
| Decompressed size | Size of image dat | s=String |
| Image | Image | i=0 |

---
## <a id='RecallMessage'></a>RecallMessage
Recall a message in prd format from controller

### Input Arguments
| Name | Description | Type |
|------|-------------|------|
| The message name | prd Name | s=String |

### Output Arguments
| Name | Description | Type |
|------|-------------|------|
| Error | Error | s=String |
| Recalled Message | prd Format | s=String |

---
## <a id='CompareFile'></a>CompareFile
Compares file name and md5 hash to determine if the file exist in the correct form

### Input Arguments
| Name | Description | Type |
|------|-------------|------|
| FileName | File Name | s=String |
| md5Hash | md5 hash of the file | s=String |

### Output Arguments
| Name | Description | Type |
|------|-------------|------|
| Error | Error | s=String |

---
## <a id='SetDateTime'></a>SetDateTime
Sets current system date time

### Input Arguments
| Name | Description | Type |
|------|-------------|------|
| Date Time | Date time in format yyyyMMdd hh:mm:ss always use 24 hour clock to transmit | s=String |
| Time Zone | Optional | s=String |

### Output Arguments
| Name | Description | Type |
|------|-------------|------|
| ReturnCode | Return cod | s=UInt32 |

---
## <a id='CreateMessageFolder'></a>CreateMessageFolder
Creates a folder to store messages

### Input Arguments
| Name | Description | Type |
|------|-------------|------|
| FolderName | Folder Name | s=String |

### Output Arguments
| Name | Description | Type |
|------|-------------|------|
| Error | Error | s=UInt32 |

---
## <a id='GetDiagnostics'></a>GetDiagnostics
Gets printer diagnostic information

### Input Arguments
| Name | Description | Type |
|------|-------------|------|
| Task number | 1 or 2 | s=Int32 |

### Output Arguments
| Name | Description | Type |
|------|-------------|------|
| Result | Comman | s=String |
| Error | Error | s=String |
| Diagnostics | List of dia | s=String |

---
## <a id='GetMessageVariableData'></a>GetMessageVariableData
Gets the data for the variable fields in the currently printing message.

### Input Arguments
| Name | Description | Type |
|------|-------------|------|
| Task Number | 1 or 2 | s=Int32 |

### Output Arguments
| Name | Description | Type |
|------|-------------|------|
| Error | Error | s=String |
| Message variable data list | XML document | s=String |

---
## <a id='PathStoreMessage'></a>PathStoreMessage
Stores a message in the folder pointed to by path

### Input Arguments
| Name | Description | Type |
|------|-------------|------|
| FolderName | Folder Name | s=String |
| Filename | Filename | s=String |
| Msg | Message | s=String |

### Output Arguments
| Name | Description | Type |
|------|-------------|------|
| ReturnCode | Return cod | s=UInt32 |

---
## <a id='SetMessageVariableData'></a>SetMessageVariableData
Sets the data for the variable fields in the currently printing message using the provided key/value pairs.

### Input Arguments
| Name | Description | Type |
|------|-------------|------|
| Task Number | 1 or 2 | s=Int32 |
| Variable Data | XML document | s=String |

### Output Arguments
| Name | Description | Type |
|------|-------------|------|
| Success/Fail | True, if the | s=Boolean |

---
## <a id='PrintStoredMessage'></a>PrintStoredMessage
Print the message with the given name

### Input Arguments
| Name | Description | Type |
|------|-------------|------|
| The message name | prd Name | s=String |

### Output Arguments
| Name | Description | Type |
|------|-------------|------|
| Error | Error | s=String |

---
## <a id='GetPrintHeadConfiguration'></a>GetPrintHeadConfiguration
Get the configuration of all the print heads on the system

### Input Arguments
| Name | Description | Type |
|------|-------------|------|

### Output Arguments
| Name | Description | Type |
|------|-------------|------|
| ReturnCode | Return cod | s=Int32 |
| ConfigurationData | Configuration dat | s=String |

---
## <a id='DeleteFile'></a>DeleteFile
Deletes the specified file

### Input Arguments
| Name | Description | Type |
|------|-------------|------|
| Path | File Path | s=String |
| FileName | File Name | s=String |

### Output Arguments
| Name | Description | Type |
|------|-------------|------|
| ReturnCode | Return cod | s=UInt32 |

---
## <a id='PrintPrd'></a>PrintPrd
Send a PRD to print

### Input Arguments
| Name | Description | Type |
|------|-------------|------|
| PRD xml | The PRD message | s=String |
| Task number | 1 or 2 | s=Int32 |

### Output Arguments
| Name | Description | Type |
|------|-------------|------|
| Error | Error | s=String |

---
## <a id='SetEthernetNetworkConfiguration'></a>SetEthernetNetworkConfiguration
Sets network configuration

### Input Arguments
| Name | Description | Type |
|------|-------------|------|
| MAC Address | My MAC Address | s=String |
| DHCP On | Whether or not to use DHCP to obtain my IP | s=Boolean |
| IP Address | My IP address on this network | s=String |
| Subnet Mask | My subnet mask for this network | s=String |
| Gateway | My gateway for this network | s=String |

### Output Arguments
| Name | Description | Type |
|------|-------------|------|
| ReturnCode | Return cod | s=UInt32 |

---
## <a id='GetEthernetNetworkConfiguration'></a>GetEthernetNetworkConfiguration
Gets network configuration information for wired interface

### Input Arguments
| Name | Description | Type |
|------|-------------|------|

### Output Arguments
| Name | Description | Type |
|------|-------------|------|
| MAC Address | My MAC Addr | s=String |
| DHCP On | Whether | s=Boolean |
| IP Address | My IP addr | s=String |
| Subnet Mask | My subnet m | s=String |
| Gateway | My gate | s=String |
| ReturnCode | Return cod | s=UInt32 |

---
## <a id='ResumePrinting'></a>ResumePrinting
Commands the printer to resume printing

### Input Arguments
| Name | Description | Type |
|------|-------------|------|
| Task number | 1 or 2 | s=Int32 |

### Output Arguments
| Name | Description | Type |
|------|-------------|------|
| Error | Error | s=String |

---
## <a id='ResetTotalCount'></a>ResetTotalCount
Reset total count to zero

### Input Arguments
| Name | Description | Type |
|------|-------------|------|

### Output Arguments
| Name | Description | Type |
|------|-------------|------|
| Error | Error | s=String |

---
## <a id='SendEventsFile'></a>SendEventsFile
Send the events config file to control automated ACS

### Input Arguments
| Name | Description | Type |
|------|-------------|------|
| FileContents | File | s=String |

### Output Arguments
| Name | Description | Type |
|------|-------------|------|
| Error | Error | s=String |

---
## <a id='RenamePrinter'></a>RenamePrinter
Modifies the SSID value used by printhead

### Input Arguments
| Name | Description | Type |
|------|-------------|------|
| Printer name | New SSID for the selected printhead | s=String |

### Output Arguments
| Name | Description | Type |
|------|-------------|------|
| Success | Did the | s=Boolean |
| Error | If fa | s=String |

---
## <a id='SetWifiNetworkConfiguration'></a>SetWifiNetworkConfiguration
Sets network configuration

### Input Arguments
| Name | Description | Type |
|------|-------------|------|
| Current SSID | The SSID I am currently connected to | s=String |
| MAC Address | My MAC Address | s=String |
| DHCP On | Whether or not to use DHCP to obtain my IP | s=Boolean |
| IP Address | My IP address on this network | s=String |
| Subnet Mask | My subnet mask for this network | s=String |
| Gateway | My gateway for this network | s=String |

### Output Arguments
| Name | Description | Type |
|------|-------------|------|
| ReturnCode | Return cod | s=UInt32 |

---
## <a id='GetConfiguration'></a>GetConfiguration
Gets printer configuration file

### Input Arguments
| Name | Description | Type |
|------|-------------|------|

### Output Arguments
| Name | Description | Type |
|------|-------------|------|
| Error | Error | s=String |
| Configuration | The printer c | s=String |

---
## <a id='PathGetMessageFolders'></a>PathGetMessageFolders
Return a list of message filenames store in path

### Input Arguments
| Name | Description | Type |
|------|-------------|------|

### Output Arguments
| Name | Description | Type |
|------|-------------|------|
| MsgList | Message | s=String |

---
## <a id='PathPrintPreviewHash'></a>PathPrintPreviewHash
Gets message preview as bitmaps

### Input Arguments
| Name | Description | Type |
|------|-------------|------|
| FolderName | Folder name | s=String |
| Msg | Message | s=String |
| Task number | 1 or 2 | s=UInt32 |

### Output Arguments
| Name | Description | Type |
|------|-------------|------|
| ReturnCode | Return cod | s=UInt32 |
| task name | string | s=String |
| hash key | string | s=String |

---
## <a id='GetAccessPassword'></a>GetAccessPassword
Gets the password for access point on the printhead

### Input Arguments
| Name | Description | Type |
|------|-------------|------|

### Output Arguments
| Name | Description | Type |
|------|-------------|------|
| Password | Password | s=String |

---
## <a id='SetPrintHeadConfiguration'></a>SetPrintHeadConfiguration
Set the configuration of all the print heads on the system

### Input Arguments
| Name | Description | Type |
|------|-------------|------|
| ConfigurationData | Configuration data | s=String |

### Output Arguments
| Name | Description | Type |
|------|-------------|------|
| ReturnCode | Return cod | s=Int32 |

---
## <a id='DoUSBUnmount'></a>DoUSBUnmount
Unmounts the USB drive on the printhead

### Input Arguments
| Name | Description | Type |
|------|-------------|------|

### Output Arguments
| Name | Description | Type |
|------|-------------|------|
| Success | True in | s=Boolean |

---
## <a id='GetStoredMessageList'></a>GetStoredMessageList
Gets a list of stored messages

### Input Arguments
| Name | Description | Type |
|------|-------------|------|

### Output Arguments
| Name | Description | Type |
|------|-------------|------|
| Error | Error | s=String |
| Message list | list of prds | s=String |

---
## <a id='DoFirmwareUpdate'></a>DoFirmwareUpdate
Updates the printhead firmware

### Input Arguments
| Name | Description | Type |
|------|-------------|------|
| Filename | Filename of upgrade file to be used | s=String |
| DoBackup | If a backup should be done before upgrade | s=Boolean |

### Output Arguments
| Name | Description | Type |
|------|-------------|------|
| Error | Error | s=UInt32 |

---
## <a id='SetMessageCount'></a>SetMessageCount
Set message count

### Input Arguments
| Name | Description | Type |
|------|-------------|------|
| New count | New count | s=UInt64 |

### Output Arguments
| Name | Description | Type |
|------|-------------|------|
| Error | Error | s=String |

---
## <a id='PathPrintStoredMessage'></a>PathPrintStoredMessage
Print the message stored in the path and filename

### Input Arguments
| Name | Description | Type |
|------|-------------|------|
| Task number | 1 or 2 | s=Int32 |
| FolderName | Folder name | s=String |
| Filename | File name | s=String |

### Output Arguments
| Name | Description | Type |
|------|-------------|------|
| ReturnCode | Return cod | s=UInt32 |

---
## <a id='GetFileHash'></a>GetFileHash
md5 hash of the specified file

### Input Arguments
| Name | Description | Type |
|------|-------------|------|
| FileName | File Name | s=String |

### Output Arguments
| Name | Description | Type |
|------|-------------|------|
| Error | Error | s=String |
| md5Hash | md5 has | s=String |

---
## <a id='GetStatusInformation'></a>GetStatusInformation
Gets printer status information

### Input Arguments
| Name | Description | Type |
|------|-------------|------|
| Task number | 1 or 2 | s=Int32 |

### Output Arguments
| Name | Description | Type |
|------|-------------|------|
| Error | Error | s=String |
| State | Curre | s=String |
| Message | Current | s=String |
| LineSpeed | Speed of  | s=Int32 |
| Count | Key:V | s=String |
| Consumable | Key:Value  | s=String |
| Errors | List o | s=String |
| Warnings | List of  | s=String |

---
## <a id='PathGetStoredMessageList'></a>PathGetStoredMessageList
Retrieves a list of messages stored in the folder in path

### Input Arguments
| Name | Description | Type |
|------|-------------|------|
| FolderName | Folder name | s=String |

### Output Arguments
| Name | Description | Type |
|------|-------------|------|
| ReturnCode | Return cod | s=UInt32 |
| MsgNameList | Message fil | s=String |

---
## <a id='IdentifyPrinter'></a>IdentifyPrinter
Toggle the specified printer's beacon to indicate which printer is specified.

### Input Arguments
| Name | Description | Type |
|------|-------------|------|
| PrinterId | Identification id of the printer to indicate.  Passing an empty string will clear. | s=String |

### Output Arguments
| Name | Description | Type |
|------|-------------|------|
| ReturnCode | Return cod | s=UInt32 |

---
## <a id='GetBroadcastingSsid'></a>GetBroadcastingSsid
Gets SSID broadcasting on Wlan1

### Input Arguments
| Name | Description | Type |
|------|-------------|------|

### Output Arguments
| Name | Description | Type |
|------|-------------|------|
| SSID | The  | s=String |
| ReturnCode | Return cod | s=UInt32 |

---
## <a id='GetFirmwareUpdateProgress'></a>GetFirmwareUpdateProgress
Returns the current state of the upgrade procedure

### Input Arguments
| Name | Description | Type |
|------|-------------|------|

### Output Arguments
| Name | Description | Type |
|------|-------------|------|
| State | Curre | s=String |

---
## <a id='GetFilesAndFolders'></a>GetFilesAndFolders
Gets the files and folders in xml format for the current path

### Input Arguments
| Name | Description | Type |
|------|-------------|------|
| Path | File Path | s=String |

### Output Arguments
| Name | Description | Type |
|------|-------------|------|
| ReturnCode | Return cod | s=UInt32 |
| FilesAndFolders | Returns files a | s=String |

---
## <a id='PathPrintPreview'></a>PathPrintPreview
Gets message preview as bitmaps

### Input Arguments
| Name | Description | Type |
|------|-------------|------|
| FolderName | Folder name | s=String |
| Msg | Message | s=String |
| Task number | 1 or 2 | s=UInt32 |

### Output Arguments
| Name | Description | Type |
|------|-------------|------|
| ReturnCode | Return cod | s=UInt32 |
| Preview image list | list of base64 enc | s=String |

---
## <a id='SetAccessPassword'></a>SetAccessPassword
Sets the password for access point on the printhead

### Input Arguments
| Name | Description | Type |
|------|-------------|------|
| Password | Password for access point | s=String |

### Output Arguments
| Name | Description | Type |
|------|-------------|------|
| Success | True in | s=Boolean |

---
## <a id='CreateFolder'></a>CreateFolder
Create new folder at path with name specified

### Input Arguments
| Name | Description | Type |
|------|-------------|------|
| Path | File Path | s=String |
| FolderName | Folder Name | s=String |

### Output Arguments
| Name | Description | Type |
|------|-------------|------|
| ReturnCode | Return cod | s=UInt32 |

---
## <a id='GetFileByName'></a>GetFileByName
Gets File by name including extension

### Input Arguments
| Name | Description | Type |
|------|-------------|------|
| FileName | File Name | s=String |

### Output Arguments
| Name | Description | Type |
|------|-------------|------|
| Error | Error | s=String |
| File | File | s=String |

---
## <a id='GetPrintheadConsumeables'></a>GetPrintheadConsumeables
Get the status of the printhead ink and waste container

### Input Arguments
| Name | Description | Type |
|------|-------------|------|

### Output Arguments
| Name | Description | Type |
|------|-------------|------|
| ReturnCode | Return cod | s=UInt32 |
| Data | Cons | s=String |

---
