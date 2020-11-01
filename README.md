# Geldautomaat - school project

This is a **school project** for senior years. written in C# winforms.

## Setup

What it takes to run this project.

### Setup database
Import the sql file to your database manager.

Fill in your database cridentials [here](https://github.com/RheimerVanDijk/Geldautomaat/blob/9f493e12253937aa931380b547e10f66069a9947/GeldautomaatClassLibrary/Database.cs#L16).

### Run the application

Open one of the folders ([Geldautomaat](https://github.com/RheimerVanDijk/Geldautomaat/tree/master/Geldautomaat), [GeldautomaatAdminPanel](https://github.com/RheimerVanDijk/Geldautomaat/tree/master/GeldautomaatAdminPanel)) and open the .sln file with your c# winforms editor

Or run the project as shown above and open the compiled .exe file (**projectFolder**/bin/debug)

## INPORTANT INTO
#### Roles:
* role 0: normal user
* role 1: admin

#### Account information:
**Application automatically generates a pincode you can change this in the database**

There no way at this point in time to view the pincode to login with a user of a admin account. 

go to the database add a users and convert a pincode [here](https://md5decrypt.net/en/Sha256/).

You can decrypt the pincode at the above povided website to login with a user or a admin account.

#### Login cridentials:
* User: account number and pincode
* Admin: email and pincode
