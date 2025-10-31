# Windows Service Manager (Client Application)

A lightweight and extensible Windows client application built with **C#** and **.NET**, designed to control and monitor Windows services, manage configuration options through a local SQLite database, and trigger automated REST API calls based on schedules.  
It serves as a companion tool for managing and interacting with the `RestClientService`, allowing full remote or local service control.

## Features

- **Start / Stop Service** — control your Windows service directly from the application.
- **Automated Scheduler** — periodically sends API requests to your REST service based on schedule parameters.
- **SQLite-Based Configuration** — all settings (host, schedule, etc.) are stored in an embedded `options.db` databases `OptionsTable` table.
- **Manual Options Editing** — open and modify `options.db` manually if the service becomes inaccessible.
- **Templates Management** — add, delete, view or edit the emails body from `Templates` table of `options.db`.

## Installation
### 1. Clone the repository
```bash
git clone https://github.com/<your-username>/<repository-name>.git
cd <repository-name>
```

### 2. Open the project

- Launch Visual Studio 2022 (or newer).

- Open the solution file:
  ClientApplication.sln

### 3. Restore dependencies
Visual Studio usually restores NuGet packages automatically.
If not, run manually:
```bash
dotnet restore
```
### 4. Build the project
```bash
dotnet build --configuration Release
```
Or just with Visual Studio's Build button
### 5. Run the application

You can:

Run it directly from Visual Studio (recommended for testing).
Important: Run as Administrator.

Or launch the compiled executable from:

/bin/Release/netX.X/publish/

### Additionally
This program requires: 

- windowsdesktop-runtime-9.0.9
- MicrosoftEdgeWebView2Runtime
- dotnet-runtime-9.0.9


## Usage guide
### Structure
Project consists of many forms, each responsible for different tasks with service.
After launching the Client Application, you’ll see functional tabs, described above:

Templates
Smtp Options
Service Management
Sending Test
Schedule


- **AllOptions form** — The main form, that contains all service options as tabs: Templates, SMTP Options, Service Managment, Sending Test and Schedule tabs. Some of the tabs contain forms as body. it contains 2 buttons: Service Name and Service Host, to connect to your service and to check if there is a local service on your computer.
- The tab Service Management contains 3 buttons, start-Starts local service, stop-Stops the local service, open local db-An emergancy way to open the options.db from selected place.
- Schedule tab contains 3 textboxes: Hour, Minute and Interval. It also contains a
save changes button, which saves the changes of schedule options to `Schedule` table from `options.db`.
- **SMTP Options form** — Contains a grid in which is shown `SMTPOptions` table from `options.db`. There are 2 buttons and 1 grid on the form: Edit and Refresh buttons and Options grid. by clicking Edit button a new EditOption form opens where you can edit the option's value and category. After the action you can refresh the grid if needed (after edit it does an automatic refresh).
It sends a request to the Rest Client Service and gets the options.
- **Templates Options form** — Contains a grid in which is shown `Templates` table from `options.db`. There are 5 buttons, 1 combobox and 1 grid on the form: add, edit, view, delete and refresh buttons, Templates grid and a Filter combobox.
Pressing Delete button will delete the selected template from the table, pressing Add button will opens a new window, AddTemplate form, where you can create a new template, pressing Edit button opens a new window, EditTemplate form, where you can edit the selected form
pressing View will open an EditForm in view mode (no way to change things in form) with selected template info, pressing refresh will refresh the info in grid. The Genders combobox is responsible of sorting data in Templates grid. It shows All and other genders that are in
grid. You can choose one from combobox to sort the grid by that gender.
- **Manual Send (Sending Test) form** — With this form, you can test-send an email to a test person, by filling in all the textboxes and comboboxes and pressing Send email button. There are 2 comboboxes, Gender and Template. To fill the comboboxes, press refresh button.
In this form you can also send emails with people info from Info Rest Serivece and with the options from `options.db`. The reqired fields to be filled are: receivers name, last name, email, gender and template, senders email, pwd, SMTP host and port.
- **EditOption form** — This form contains 3 textboxes and a button: Option Name textbox (read only), Option Value textbox, Option Category textbox and Update the option button. By clicking the button, the values update in `options.db` (if there are no changes, nothing will be updated). This form opens after clicking edit button in SMTP Options tab or in emergency db window. The update button sends a request to the Rest Client Service with a content, that contains the info from the window after pressing it.
- **EditTemplate form** — Opens when Edit button is clicked in Templates tab with info from selected row. It contains 1 textboxe: template name, 1 combobox: gender, 1 checkbox: is default for gender, 1 rich textbox: html body, 1 WebView2 for html body and an update button. If template is selected as default, you cant change the the values of gender and is default for gender (they become read only). The update button sends a request to the Rest Client Service with a content, that contains the info from the window after pressing it.
- **AddTemplate form** — Opens when Add button is clicked in Templates tab. It is similar to EditTemplate form with the difference being that everything is emplty and the button is now add the template. Add the template button sends a request to the Rest Client Service with a content, that contains the info from the window after pressing it, after which the new template will be added to `Templates` table. If the is def checkbox is checked, the previous default's Is def will set to be unchecked.

#### Databases and tables

In client app itself there are no databases. The only databases are the ones, that are used in Rest Client Service. The database and tables structure inside Rest Client Service:
```bash
options.db/
│
├── OptionsTable (OptionName Text Not Null unique | OptionValue Text Not Null | Category Text Not Null)
│
├── Schedule (Hour Integer Not Null | Minute Integer Not Null | IntervalSeconds Integer Not Null)
│
├── Templates (Id integer | Name Text Not Null | Body Text Not Null | Gender Body Text Not Null | IsDefault Integer Not Null Check("IsDefault" in (0,1)) )
```

## Typical Workflow 
1. Run the application as Administrator.
2. Make sure options.db exists and contains a valid RestClientHost (e.g., http://localhost:7038).
3. Set (if not already) a valid Service Name (not required, if connecting to the service from another computer) and Service Host to connect to the service.
   Note: If Service Name is incorrect or there is no such service, the Service Management tab won't open.
4. (Only if connected to local service) If the host is not available, or is incorrect, use the emergency db open button to fix the issue.
5. If the host or port changes, restart service (if it is local) and change the Service Host in Client Application.
6. By default, the schedule is 0 0 0, which means it wont work. After changing schedule make sure to restart the service for it to work. Note: interval in seconds can't be set less than 10 for safety measures.
   
## Possible/common issues and solutions
- Scheduler not running - Invalid hours or interval. Check values in Schedule table.
- (Emergency db open) No updates applied after edit - Incorrect dbPath or file locked. Make sure to launch the programm as admin and verify the dbpath.
- Service not responding - Invalid or busy port. Open local options.db and correct the RestClientHost and change the Service Host to the correct one.

## Author

**Areg Vardanyan**


