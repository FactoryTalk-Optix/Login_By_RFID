# Login_By_RFID
How to log in via pcProx RFID reader (or any keyboard emulation hardware)

## Workflow
1. If the user has no password (blank field), if the code matches any user, login is performed automatically
2. If the user is configured with a password (not blank field), a DialogBox is triggered to insert the proper password

## Known issues
1. No async login is possible, the user must select the TextBox before scanning the tag

### Disclaimer

Rockwell Automation maintains these repositories as a convenience to you and other users. Although Rockwell Automation reserves the right at any time and for any reason to refuse access to edit or remove content from this Repository, you acknowledge and agree to accept sole responsibility and liability for any Repository content posted, transmitted, downloaded, or used by you. Rockwell Automation has no obligation to monitor or update Repository content

The examples provided are to be used as a reference for building your own application and should not be used in production as-is. It is recommended to adapt the example for the purpose, observing the highest safety standards.
