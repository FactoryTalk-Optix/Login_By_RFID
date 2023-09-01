# Login_By_RFID
How to login via pcProx RFID reader (or any keyboard emulation hardware)

## Workflow
1. If user has no password (blank field), if the code matches any user, login is performed automatically
2. If user is configured with a password (not blank field), a DialogBox is triggered to insert the proper password

## Known issues
1. No async login is possible, user must select the TextBox before scanning the tag
