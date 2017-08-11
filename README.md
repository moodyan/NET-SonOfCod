# Son Of Cod Seafood

#### _App created for Epicodus Independent Project, ASP.NET - Week Two. Practice using ASP.NET MVC with Authentication and basic testing. August 11th, 2017_

#### By **Alyssa Moody**

## Description

_A web app that manages the marketing and newsletter sign up for Son of Cod Seafood (fictitious company)._

## Program Specifications

| Description  | Input Example | Output Example |
| ------------- | ------------- | ------------- |
| The program allows all users to view a landing page.  | Home  | "Welcome"  |
| The program allows all users to view a marketing page.  | /Marketing  | Information on Son of Cod  |
| The program allows users to sign up for the newsletter.  | /Newsletter  | --  |
| The program allows "admin" to visit an admin portal that contains the current mailing list.  | /Account  | --  |

_This website's style loosely mimics the styling of [Pacific Seafood](https://www.pacseafood.com/)._

## Setup/Installation Requirements

**Requirements**

If you do not have Visual Studio 2017, download [HERE](https://www.visualstudio.com/thank-you-downloading-visual-studio/?sku=Community&rel=15).

If you do not have SSMS, download [HERE](https://docs.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms).

**Cloning From GitHub:** Download or clone project repository onto desktop from GitHub.

Open the project in Visual Studio.

**Migrations**
1. In Solution Explorer, right-click the project and choose 'Open in File Explorer' from the context menu.
2. Enter "cmd" in the address bar and press Enter.
3. Enter the following command in the command window:
  - dotnet ef database update
4. Open cod_scripts.sql in SSMS and execute (this will add sample data).
5. Back in VS, click IIS Express at the top of the window. Project should open in a new window in your default browser.

## Screenshots


## Known Bugs

_No known bugs._

## Support and contact details

_If you run into any issues or have questions, ideas or concerns, please contact Alyssa Moody at alyssanicholemoody@gmail.com_

## Technologies Used

**Languages:** HTML, CSS, C#, ASP.NET

**IDE:** Visual Studio 2017

**Database Management:** MySQL (SSMS)

**Testing:** xUnit

### License

*MIT license Agreement*

Copyright (c) 2017 **_Alyssa Moody_*
