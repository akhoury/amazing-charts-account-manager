
AMAZING CHARTS TEST APPLICATION

Account Manager v0.001 
 by Aziz Khoury 1/8/2012

-Program requires:
	.NET 4.0
	.Windows OS

-few notes:
	.For demo purposes, two files people.xml and people.csv were created in the bin/debug/ since the application requires local no-database storage. 
	        ;to demo just launch bin/debug/AccountManager.exe or import .sln to VS2010 and launch. 
    .Due to time contraints the following are still future work:
			;Source documentation perfection
			;Encrypting passwords so none would store in clear text
			;Implementing menu-bar and/or submenus, tooltips, keyboard shortcuts etc.
			;Open/Save xml/csv from/to directory option
			;Help documentation 


===============================Requirements=====================================
AMAZING CHARTS TEST APPLICATION

Applicants to the Amazing Charts development team are asked to provide a code sample so we can
get an idea how the applicant approaches a programming task. This test application allows for the
creation, editing, and deletion of user data. The user data will be stored in two different file formats.

Requirements

The solution must be a Windows desktop application.
The solution must be written in .NET.
The solution must demonstrate principles of object oriented design.
The solution must include an application setting that will toggle the user data persistent store
between an XML file and a CSV file.
a. Note, the contents of each file should be separate and distinct, so there is no requirement
to synchronize the data between the two files. e.g. if the user adds 2 users to the XML file
then toggles to the CSV file for the first time, there would be no entries to display for the
CSV file.
5. The solution must have a single “Account Management” form to create, edit, and delete user data.
a. The form must allow the user to explicitly save any changes to the user data.
b. The form must allow the user to toggle the XML/CSV application setting and refresh the
display to show the user data associated with the current setting.
i. If unsaved changes exist when the setting is toggled, the user must be given the
option to:
1. Save the changes and continue.
2. Continue without saving the changes.
3. Cancel the application setting change.
c. If there are unsaved changes when the user attempts to close the form, the user must be
give the option to:
1. Save the changes and close.
2. Close without saving the changes.
3. Cancel the close.
d. The form must have a dropdown list that displays all users in alphabetical order.
i. When a user is selected from the dropdown, the user’s info is displayed and can be
edited or deleted.
e. The form must have a new user option.
f. The form must allow the user to edit or enter a user name.
i. The user name must consist of letters and numbers only (no special characters).
ii. The user name must be between 4 and 10 characters long.
g. The form must allow the user to edit or enter a password.
i. The password must consist of letters and numbers only.
ii. The password must be between 8 and 20 characters long.
iii.The Password value must not be displayed to the user.
h. The form must have a read-only field to display the “account created” date.

Notes

The applicant is welcome to use this exercise to showcase their knowledge or expertise in .NET, design
patterns, or other areas of interest, but this is not necessary. We are simply looking for well written
code exhibiting object oriented programming.